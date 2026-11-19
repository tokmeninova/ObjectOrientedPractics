using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит сведения о заказе покупателя, товарах, адресе доставки
    /// и последовательности изменений его статуса.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Хранит историю статусов: каждой дате и времени соответствует
        /// статус, который был установлен в этот момент.
        /// </summary>
        private Dictionary<DateTime, OrderStatus> _statusHistory =
            new Dictionary<DateTime, OrderStatus>();

        /// <summary>
        /// Хранит идентификатор, который получит следующий созданный заказ.
        /// </summary>
        private static int _nextId = 1;

        /// <summary>
        /// Хранит ссылки на товары, включённые в заказ.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Хранит текущее значение статуса заказа.
        /// </summary>
        private OrderStatus _status;

        /// <summary>
        /// Показывает, выполняется ли восстановление объекта из JSON.
        /// При загрузке дополнительные записи в историю не создаются.
        /// </summary>
        private bool _isDeserializing;

        /// <summary>
        /// Возвращает уникальный идентификатор заказа.
        /// Значение назначается при создании или восстанавливается из JSON.
        /// </summary>
        [JsonProperty]
        public int Id { get; private set; }

        /// <summary>
        /// Возвращает дату и время создания заказа.
        /// При восстановлении определяется по ранней записи истории.
        /// </summary>
        [JsonProperty]
        public DateTime Created { get; private set; }

        /// <summary>
        /// Возвращает и задаёт адрес доставки заказа.
        /// </summary>
        public Address DeliveryAddress { get; set; }

        /// <summary>
        /// Перенумеровывает заказы последовательно с 1.
        /// </summary>
        /// <param name="customers">Список покупателей.</param>
        public static void RenumberOrders(
            IEnumerable<Customer> customers)
        {
            int nextId = 1;

            foreach (Customer customer in customers)
            {
                foreach (Order order in customer.Orders)
                {
                    order.Id = nextId;
                    nextId++;
                }
            }

            // Следующий заказ получит свободный ID.
            _nextId = nextId;
        }


        /// <summary>
        /// Возвращает и задаёт текущий статус заказа.
        /// Изменение значения вне загрузки из JSON добавляется в историю.
        /// </summary>
        public OrderStatus Status
        {
            get
            {
                return _status;
            }
            set
            {
                // Не сохраняем повторно тот же статус.
                // Не создаём лишнюю запись, если статус фактически не меняется
                // и история уже содержит хотя бы одно событие.
                if (_status == value &&
                    _statusHistory.Count > 0)
                {
                    return;
                }

                // Сохраняем новое состояние независимо от режима загрузки.
                _status = value;

                // При загрузке история восстановится из JSON.
                // Во время десериализации не дублируем события истории.
                if (!_isDeserializing)
                {
                    AddStatusChange(value, DateTime.Now);
                }
            }
        }

        /// <summary>
        /// Возвращает историю изменения статусов заказа.
        /// При десериализации JSON существующий словарь заменяется загруженным.
        /// </summary>
        [JsonProperty(
            ObjectCreationHandling =
                ObjectCreationHandling.Replace)]
        public Dictionary<DateTime, OrderStatus> StatusHistory
        {
            get
            {
                return _statusHistory;
            }
            private set
            {
                // Если в JSON нет истории, оставляем рабочий пустой словарь.
                _statusHistory = value ??
                    new Dictionary<DateTime, OrderStatus>();
            }
        }

        /// <summary>
        /// Возвращает дату и время последнего изменения статуса.
        /// Если история не содержит более поздних дат, возвращает Created.
        /// </summary>
        [JsonIgnore]
        public DateTime LastStatusChangeTime
        {
            get
            {
                // Начинаем поиск с даты создания как начальной границы.
                DateTime lastTime = Created;

                // В словаре нет гарантированного порядка по дате.
                // Поэтому обходим все временные метки истории.
                foreach (DateTime time in _statusHistory.Keys)
                {
                    if (time > lastTime)
                    {
                        lastTime = time;
                    }
                }

                return lastTime;
            }
        }

        /// <summary>
        /// Возвращает и задаёт список товаров, включённых в заказ.
        /// Список содержит ссылки на объекты Item и может включать повторы.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                // Сохраняем переданный список, не создавая его копию.
                _items = value;
            }
        }

        /// <summary>
        /// Возвращает общую стоимость товаров заказа.
        /// Стоимость рассчитывается по текущим значениям Item.Cost.
        /// </summary>
        public double Amount
        {
            get
            {
                // Отсутствие товаров означает нулевую стоимость.
                if (_items == null || _items.Count == 0)
                {
                    return 0.0;
                }

                // Накапливаем итог без изменения самих элементов заказа.
                double total = 0.0;

                // Каждый элемент списка учитывается отдельно.
                // Повторяющиеся товары также входят в сумму.
                foreach (Item item in _items)
                {
                    total += item.Cost;
                }

                return total;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Order"/>
        /// с новым идентификатором и начальным статусом New.
        /// </summary>
        public Order()
        {
            // Используем общий счётчик для последовательной выдачи ID.
            // После присваивания счётчик автоматически увеличивается.
            Id = _nextId++;

            // Первая запись истории — New.
            // Установка свойства Status добавляет первую запись в историю.
            Status = OrderStatus.New;

            // Дата создания определяется по первой записи.
            // Первое изменение статуса произошло в момент создания заказа.
            Created = LastStatusChangeTime;
        }

        /// <summary>
        /// Добавляет запись о смене статуса в историю заказа.
        /// При совпадении меток времени увеличивает значение на один тик.
        /// </summary>
        /// <param name="status">Новый статус.</param>
        /// <param name="time">Время изменения.</param>
        private void AddStatusChange(
            OrderStatus status,
            DateTime time)
        {
            // Ключи словаря должны быть уникальными.
            // Dictionary<DateTime, OrderStatus> не допускает одинаковых ключей.
            // Сдвигаем совпадающее время на минимальный шаг DateTime.
            while (_statusHistory.ContainsKey(time))
            {
                time = time.AddTicks(1);
            }

            // Добавляем новое событие после обеспечения уникальности времени.
            _statusHistory.Add(time, status);
        }

        /// <summary>
        /// Подготавливает заказ к десериализации: включает режим загрузки
        /// и очищает историю для её восстановления из JSON.
        /// </summary>
        /// <param name="context">Контекст загрузки.</param>
        [OnDeserializing]
        internal void OnDeserializing(StreamingContext context)
        {
            // Пока объект загружается, сеттер Status не должен записывать
            // изменения, которых не было в исходном JSON.
            _isDeserializing = true;
            // Убираем историю, созданную конструктором, перед загрузкой данных.
            _statusHistory.Clear();
        }

        /// <summary>
        /// Восстанавливает согласованность даты создания, истории статусов
        /// и счётчика идентификаторов после десериализации JSON.
        /// </summary>
        /// <param name="context">Контекст загрузки.</param>
        [OnDeserialized]
        internal void OnDeserialized(StreamingContext context)
        {
            // Возвращаем обычный режим работы после завершения загрузки.
            _isDeserializing = false;

            // Старый JSON может не содержать историю статусов.
            // В таком случае формируем хотя бы одну исходную запись.
            if (_statusHistory.Count == 0)
            {
                // Используем сохранённую дату создания, если она есть.
                DateTime time = Created;

                // Для заказов без даты используем текущее локальное время.
                if (time == default)
                {
                    time = DateTime.Now;
                }

                AddStatusChange(_status, time);
            }

            // Находим первую и последнюю записи истории.
            // Начальные крайние значения позволяют найти минимум и максимум
            // без предположений о порядке элементов словаря.
            DateTime firstTime = DateTime.MaxValue;
            DateTime lastTime = DateTime.MinValue;

            // По ранней записи определяем Created, а по последней — Status.
            foreach (var entry in _statusHistory)
            {
                if (entry.Key < firstTime)
                {
                    firstTime = entry.Key;
                }

                if (entry.Key > lastTime)
                {
                    lastTime = entry.Key;
                    // Последний по времени статус становится текущим.
                    _status = entry.Value;
                }
            }

            Created = firstTime;

            // Учитываем восстановленный ID.
            // Следующий новый заказ не должен повторить ID загруженного.
            if (Id >= _nextId)
            {
                // checked сообщает о переполнении int вместо тихого сбоя.
                _nextId = checked(Id + 1);
            }
        }
    }
}

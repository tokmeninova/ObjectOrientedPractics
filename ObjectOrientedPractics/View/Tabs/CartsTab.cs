using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Предоставляет интерфейс для управления корзиной выбранного покупателя.
    /// Отображает товары магазина, покупателей и состав выбранной корзины.
    /// Позволяет добавлять, удалять товары и оформлять заказ.
    /// Списки передаются из общего хранилища и используются без копирования.
    /// </summary>
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Список товаров магазина, полученный из Store.
        /// Хранит ссылку на ту же коллекцию, которая используется на вкладке Items.
        /// При отсутствии переданных данных содержит пустой список.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Список покупателей магазина, полученный из Store.
        /// Используется для заполнения выпадающего списка Customer.
        /// При отсутствии переданных данных содержит пустой список.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Возвращает и задаёт выбранного покупателя.
        /// Если покупатель не выбран, значение равно null.
        /// Указывает, чья именно корзина отображается справа.
        /// </summary>
        private Customer? CurrentCustomer { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="CartsTab"/>.
        /// Инициализирует элементы интерфейса и подключает обработчики событий.
        /// Сами списки товаров и покупателей передаются позже из главной формы.
        /// </summary>
        public CartsTab()
        {
            // Создаём элементы управления, описанные в CartsTab.Designer.cs.
            // В частности, здесь появляются ListBox, ComboBox, кнопки и надписи.
            InitializeComponent();

            // Подписываемся на изменение выбранного покупателя.
            // Сначала отписываем тот же обработчик, если он уже подключён в Designer.
            // Это предотвращает его повторное выполнение при одном выборе.
            customersComboBox.SelectedIndexChanged -= customersComboBox_SelectedIndexChanged;
            customersComboBox.SelectedIndexChanged += customersComboBox_SelectedIndexChanged;

            // Подключаем действие добавления выбранного товара в корзину.
            addToCartButton.Click -= addToCartButton_Click;
            addToCartButton.Click += addToCartButton_Click;

            // Подключаем удаление одного выбранного товара из корзины.
            removeItemButton.Click -= removeItemButton_Click;
            removeItemButton.Click += removeItemButton_Click;

            // Подключаем очистку корзины с запросом подтверждения.
            clearCartButton.Click -= clearCartButton_Click;
            clearCartButton.Click += clearCartButton_Click;

            // Подключаем оформление заказа из текущей корзины.
            createOrderButton.Click -= createOrderButton_Click;
            createOrderButton.Click += createOrderButton_Click;

            // Позволяем спискам менять высоту плавно при изменении размеров окна.
            // Если IntegralHeight = true, высота может округляться по числу строк.
            itemsListBox.IntegralHeight = false;
            cartListBox.IntegralHeight = false;
        }

        /// <summary>
        /// Возвращает и задаёт список товаров магазина без создания его копии.
        /// При изменении списка обновляет отображаемые товары.
        /// Присвоение нового списка не заменяет его копией: изменения видны
        /// другим вкладкам, работающим с той же коллекцией.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set
            {
                // Сохраняем общую ссылку; при null создаём безопасный пустой список.
                _items = value ?? new List<Item>();
                // Обновляем внешний список сразу после получения новых данных.
                UpdateItemsList();
            }
        }

        /// <summary>
        /// Возвращает и задаёт список покупателей магазина без создания его копии.
        /// При изменении списка обновляет отображаемых покупателей.
        /// Свойство получает ту же коллекцию, которая хранится в Store.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                // Получаем список покупателей или заменяем null пустой коллекцией.
                _customers = value ?? new List<Customer>();
                // Обновляем варианты выбора в ComboBox.
                UpdateCustomersList();
            }
        }

        /// <summary>
        /// Обновляет списки товаров и покупателей, а также корзину выбранного покупателя.
        /// Вызывается при возвращении на вкладку, когда данные могли измениться
        /// на вкладках Items или Customers. Не создаёт новые товары и корзины.
        /// </summary>
        public void RefreshData()
        {
            // Считываем актуальное содержимое общей коллекции товаров.
            UpdateItemsList();

            // Считываем актуальных покупателей; метод пытается сохранить выбор.
            UpdateCustomersList();

            // Согласовываем внутреннее свойство с реальным выбором ComboBox.
            // Если покупатель удалён, SelectedItem будет null.
            CurrentCustomer = customersComboBox.SelectedItem as Customer;

            // После синхронизации выбора обновляем корзину и сумму на экране.
            UpdateCartList();
        }

        /// <summary>
        /// Обновляет список товаров, по возможности сохраняя текущий выбор.
        /// Использует BeginUpdate и EndUpdate, чтобы избежать лишних перерисовок
        /// при заполнении ListBox большим количеством товаров.
        /// </summary>
        private void UpdateItemsList()
        {
            // Запоминаем объект товара до очистки элементов интерфейса.
            Item? selectedItem = itemsListBox.SelectedItem as Item;

            // Временно приостанавливаем перерисовку списка.
            itemsListBox.BeginUpdate();
            try
            {
                // Удаляем только отображаемые строки ListBox, не товары из Store.
                itemsListBox.Items.Clear();

                // В списке показываем имя товара, а не имя его класса.
                itemsListBox.DisplayMember = nameof(Item.Name);

                // Размещаем те же объекты Item, которые находятся в общей коллекции.
                foreach (Item item in _items)
                {
                    itemsListBox.Items.Add(item);
                }

                // Возвращаем выделение только тогда, когда объект ещё существует.
                // После удаления товара на другой вкладке выбирать будет нечего.
                if (selectedItem != null && _items.Contains(selectedItem))
                {
                    itemsListBox.SelectedItem = selectedItem;
                }
            }
            finally
            {
                // Возобновляем отрисовку даже при возникновении исключения.
                itemsListBox.EndUpdate();
            }
        }

        /// <summary>
        /// Обновляет выпадающий список покупателей, по возможности сохраняя выбор.
        /// При удалении выбранного покупателя сбрасывает выбор в ComboBox.
        /// Изменение выбора также может вызвать обновление корзины через событие.
        /// </summary>
        private void UpdateCustomersList()
        {
            // Запоминаем текущего покупателя до обновления списка вариантов.
            Customer? selectedCustomer = customersComboBox.SelectedItem as Customer;

            // Предотвращаем мерцание при массовом заполнении ComboBox.
            customersComboBox.BeginUpdate();
            try
            {
                // Удаляем пункты интерфейса; сами покупатели в Store не удаляются.
                customersComboBox.Items.Clear();

                // Отображаем полное имя покупателя, сохраняя сам объект в Items.
                customersComboBox.DisplayMember = "Fullname";

                // Добавляем всех покупателей из общей коллекции приложения.
                foreach (Customer customer in _customers)
                {
                    customersComboBox.Items.Add(customer);
                }

                // Восстанавливаем выбор, если покупатель всё ещё существует.
                if (selectedCustomer != null && _customers.Contains(selectedCustomer))
                {
                    customersComboBox.SelectedItem = selectedCustomer;
                }
                else
                {
                    // -1 означает отсутствие выбора в ComboBox.
                    customersComboBox.SelectedIndex = -1;
                }
            }
            finally
            {
                // Гарантированно разрешаем перерисовку списка покупателей.
                customersComboBox.EndUpdate();
            }
        }

        /// <summary>
        /// Обновляет текущего покупателя и отображаемую корзину при изменении выбора.
        /// Смена покупателя должна переключать именно его корзину, а не общую.
        /// </summary>
        /// <param name="sender">Источник события изменения выбора.</param>
        /// <param name="e">Данные события.</param>
        private void customersComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            // Преобразуем выбранный объект ComboBox к типу Customer.
            // Если выбор отсутствует, здесь будет null.
            CurrentCustomer = customersComboBox.SelectedItem as Customer;

            // Показываем корзину только что выбранного покупателя и её сумму.
            UpdateCartList();
        }

        /// <summary>
        /// Обновляет список товаров корзины и отображаемую общую стоимость.
        /// Если покупатель не выбран, список остаётся пустым, а сумма равна нулю.
        /// </summary>
        private void UpdateCartList()
        {
            // Приостанавливаем перерисовку правого списка на время обновления.
            cartListBox.BeginUpdate();
            try
            {
                // Очищаем только элементы интерфейса, не содержимое корзины.
                cartListBox.Items.Clear();
                cartListBox.DisplayMember = nameof(Item.Name);

                // Добавляем товары только при наличии выбранного покупателя.
                // Предполагается, что Cart уже инициализирован в Customer.
                if (CurrentCustomer != null && CurrentCustomer.Cart.Items != null)
                {
                    // К каждому покупателю привязана собственная корзина Cart.
                    foreach (Item item in CurrentCustomer.Cart.Items)
                    {
                        cartListBox.Items.Add(item);
                    }
                }
            }
            finally
            {
                // Гарантированно возобновляем перерисовку корзины.
                cartListBox.EndUpdate();
            }

            // Сумма должна соответствовать текущему содержимому корзины.
            UpdateAmount();
        }

        /// <summary>
        /// Выводит общую стоимость корзины выбранного покупателя.
        /// Если покупатель не выбран, выводит нулевую стоимость.
        /// Отображает значение в формате с двумя знаками после запятой.
        /// </summary>
        private void UpdateAmount()
        {
            // Получаем рассчитанную стоимость из Cart, не суммируя товары вручную.
            // Оператор ?? подставляет 0, если покупатель не выбран.
            double amount = CurrentCustomer?.Cart.Amount ?? 0.0;

            // N2 оставляет две десятичные цифры и использует текущую культуру ОС.
            amountValueLabel.Text = amount.ToString("N2");
        }

        /// <summary>
        /// Добавляет выбранный товар в корзину текущего покупателя.
        /// Не изменяет каталог товаров магазина. Один товар можно добавить
        /// несколько раз, если это разрешено моделью корзины.
        /// </summary>
        /// <param name="sender">Источник события нажатия кнопки.</param>
        /// <param name="e">Данные события.</param>
        private void addToCartButton_Click(object? sender, EventArgs e)
        {
            // Сначала проверяем, кому должна принадлежать корзина.
            if (CurrentCustomer == null)
            {
                MessageBox.Show("Выберите покупателя.");
                return;
            }

            // Получаем из списка объект Item, выбранный пользователем.
            Item? selectedItem = itemsListBox.SelectedItem as Item;

            // Нельзя добавлять товар, если в списке ничего не выделено.
            if (selectedItem == null)
            {
                MessageBox.Show("Выберите товар.");
                return;
            }

            // Изменяем настоящую коллекцию товаров корзины покупателя.
            CurrentCustomer.Cart.Items.Add(selectedItem);

            // Обновляем список справа и значение Amount.
            UpdateCartList();
        }

        /// <summary>
        /// Удаляет один выбранный товар из корзины текущего покупателя.
        /// Остальные товары корзины и каталог магазина не затрагиваются.
        /// </summary>
        /// <param name="sender">Источник события нажатия кнопки.</param>
        /// <param name="e">Данные события.</param>
        private void removeItemButton_Click(object? sender, EventArgs e)
        {
            // Операция недоступна без выбранного покупателя.
            if (CurrentCustomer == null)
            {
                MessageBox.Show("Выберите покупателя.");
                return;
            }

            // Выделение ищем в правом списке, то есть в текущей корзине.
            Item? selectedItem = cartListBox.SelectedItem as Item;

            // Без выделения неизвестно, какой товар нужно удалить.
            if (selectedItem == null)
            {
                MessageBox.Show("Выберите товар для удаления.");
                return;
            }

            // Удаляем одно вхождение выбранного объекта из корзины.
            CurrentCustomer.Cart.Items.Remove(selectedItem);

            // Показываем изменившийся список и пересчитанную стоимость.
            UpdateCartList();
        }

        /// <summary>
        /// Очищает корзину текущего покупателя после подтверждения действия.
        /// При отказе пользователя содержимое корзины остаётся неизменным.
        /// </summary>
        /// <param name="sender">Источник события нажатия кнопки.</param>
        /// <param name="e">Данные события.</param>
        private void clearCartButton_Click(object? sender, EventArgs e)
        {
            // Не допускаем очистку корзины без выбранного покупателя.
            if (CurrentCustomer == null)
            {
                MessageBox.Show("Выберите покупателя.");
                return;
            }

            // Пустую корзину повторно очищать не требуется.
            if (CurrentCustomer.Cart.Items.Count == 0)
            {
                MessageBox.Show("Корзина уже пустая.");
                return;
            }

            // Действие удаляет сразу все товары, поэтому просим подтверждение.
            DialogResult result = MessageBox.Show(
                "Вы действительно хотите очистить корзину?",
                "Очистка корзины",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // При выборе No или закрытии окна ничего не удаляем.
            if (result != DialogResult.Yes)
            {
                return;
            }

            // Удаляем товары из модели корзины, а не только с экрана.
            CurrentCustomer.Cart.Items.Clear();

            // После очистки сумма должна стать равной нулю.
            UpdateCartList();
        }

        /// <summary>
        /// Создаёт заказ из товаров корзины, сохраняет его у покупателя и очищает корзину.
        /// Новый заказ содержит собственный список товаров; это позволяет
        /// сохранить его состав после очистки корзины покупателя.
        /// </summary>
        /// <param name="sender">Источник события нажатия кнопки.</param>
        /// <param name="e">Данные события.</param>
        private void createOrderButton_Click(object? sender, EventArgs e)
        {
            // Каждый заказ должен принадлежать определённому покупателю.
            if (CurrentCustomer == null)
            {
                MessageBox.Show("Выберите покупателя.");
                return;
            }

            // Не создаём заказ, в котором нет ни одного товара.
            if (CurrentCustomer.Cart.Items == null || CurrentCustomer.Cart.Items.Count == 0)
            {
                MessageBox.Show("Корзина пуста.");
                return;
            }

            // Создаём отдельный объект заказа на основе текущего состояния корзины.
            Order order = new Order
            {
                // Берём адрес доставки из данных выбранного покупателя.
                DeliveryAddress = CurrentCustomer.Address,

                // Новый заказ получает начальный статус New.
                Status = OrderStatus.New,

                // Копируем структуру списка, чтобы очистка Cart не очистила Order.
                // Это поверхностная копия: объекты Item остаются общими.
                Items = new List<Item>(CurrentCustomer.Cart.Items)
            };

            // Сохраняем заказ в истории заказов именно этого покупателя.
            CurrentCustomer.Orders.Add(order);

            // После оформления заказа корзина покупателя должна стать пустой.
            CurrentCustomer.Cart.Items.Clear();

            // Обновляем правый список товаров и сумму в интерфейсе.
            UpdateCartList();

            // Показываем пользователю номер созданного заказа.
            MessageBox.Show(
                $"Заказ №{order.Id} успешно создан!",
                "Создание заказа",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        /// <summary>
        /// Вызывается при загрузке вкладки. Обработчик сохранён для Designer.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void CartsTab_Load(object? sender, EventArgs e) { }
        /// <summary>
        /// Реагирует на нажатие надписи Items. Дополнительных действий нет.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void itemsLabel_Click(object? sender, EventArgs e) { }
        /// <summary>
        /// Вызывается при перерисовке панели. Собственная отрисовка не используется.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void panel1_Paint(object? sender, PaintEventArgs e) { }
        /// <summary>
        /// Вызывается при выборе элемента корзины. Логика выбора не требуется.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void cartListBox_SelectedIndexChanged(object? sender, EventArgs e) { }
        /// <summary>
        /// Вызывается при перерисовке таблицы компоновки. Не изменяет внешний вид.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void tableLayoutPanel1_Paint(object? sender, PaintEventArgs e) { }
        /// <summary>
        /// Вызывается при перерисовке элемента. Дополнительная отрисовка не требуется.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void CategoryCombo_Paint(object? sender, PaintEventArgs e) { }

        /// <summary>
        /// Вызывается при нажатии надписи Cart. Действия не предусмотрены.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void NameLabel_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Вызывается при нажатии Amount. Сумма меняется через UpdateAmount.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void amountLabel_Click(object sender, EventArgs e)
        {
        }
    }
}

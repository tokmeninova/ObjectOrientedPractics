
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services; 
using ObjectOrientedPractics.View.Controls; 


namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Управляет покупателями магазина.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Максимальная длина имени.
        /// </summary>
        private const int MaxFullnameLength = 200;

        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();
        /// <summary>
        /// Список товаров магазина.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Перенумеровывает покупателей с 1.
        /// </summary>
        private void RenumberCustomers()
        {
            // Проходим по всем покупателям.
            for (int i = 0; i < _customers.Count; i++)
            {
                // Присваиваем ID по порядку.
                _customers[i].SetId(i + 1);
            }

            // Получаем индекс выбранного покупателя.
            int selectedIndex = СustomersListBox.SelectedIndex;

            // Проверяем допустимость индекса.
            if (selectedIndex >= 0 &&
                selectedIndex < _customers.Count)
            {
                // Показываем новый ID.
                IdTextBox.Text =
                    _customers[selectedIndex].Id.ToString();
            }
        }

        /// <summary>
        /// Возвращает или задаёт список покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get
            {
                // Возвращаем список.
                return _customers;
            }
            set
            {
                // Присваиваем список с проверкой на null.
                _customers = value ??
                    throw new ArgumentNullException(nameof(value));

                // Перенумеровываем покупателей.
                RenumberCustomers();

                // Очищаем список на форме.
                СustomersListBox.Items.Clear();

                // Перебираем покупателей.
                foreach (Customer customer in _customers)
                {
                    // Добавляем покупателя в ListBox.
                    СustomersListBox.Items.Add(customer);
                }

                // Очищаем поля формы.
                ResetForm();
            }
        }
        /// <summary>
        /// Возвращает или задаёт список товаров.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value ??
                    throw new ArgumentNullException(nameof(value));
            }
        }

        /// <summary>
        /// Создаёт вкладку покупателей.
        /// </summary>
        public CustomersTab()
        {
            // Создаём элементы интерфейса.
            InitializeComponent();
            GenerateOrdersButton.Click += GenerateOrdersButton_Click;

            // Запрещаем редактировать ID.
            IdTextBox.ReadOnly = true;

            // Восстанавливаем цвета.
            ResetColors();

            // Подключаем кнопку Add.
            LeftButton.Click += AddCustomerButton_Click;

            // Подключаем кнопку Remove.
            RightButton.Click += RemoveCustomerButton_Click;

            // Подключаем обработчик выбора покупателя.
            СustomersListBox.SelectedIndexChanged +=
                CustomersListBox_SelectedIndexChanged;

            // Подключаем обработчик клавиатуры.
            СustomersListBox.KeyDown +=
                CustomersListBox_KeyDown;


        }

        /// <summary>
        /// Добавляет или изменяет покупателя.
        /// </summary>
        private void AddCustomerButton_Click(
            object? sender, EventArgs e)
        {
            // Проверяем имя и адрес.
            if (!TryReadCustomer(
                out string fullname,
                out Address address))
            {
                // Прерываем при ошибке.
                return;
            }

            try
            {
                // Получаем выбранный индекс.
                int index = СustomersListBox.SelectedIndex;

                // Если покупатель не выбран.
                if (index == -1)
                {
                    // Создаём покупателя.
                    Customer customer = new Customer(
                        fullname, address);

                    // Добавляем в коллекцию.
                    _customers.Add(customer);

                    // Добавляем в ListBox.
                    СustomersListBox.Items.Add(customer);

                    // Обновляем идентификаторы.
                    RenumberCustomers();
                }
                else
                {
                    // Получаем выбранного покупателя.
                    Customer customer = _customers[index];

                    // Изменяем имя.
                    customer.Fullname = fullname;

                    // Изменяем адрес.
                    customer.Address = address;

                    // Обновляем отображение.
                    СustomersListBox.Items[index] = customer;
                }

                // Очищаем поля формы.
                ResetForm();
            }
            catch (ArgumentException ex)
            {
                // Показываем ошибку данных.
                ShowError(ex.Message);
            }
        }

        /// <summary>
        /// Удаляет выбранного покупателя.
        /// </summary>
        private void RemoveCustomerButton_Click(
            object? sender, EventArgs e)
        {
            // Получаем индекс выбранного покупателя.
            int index = СustomersListBox.SelectedIndex;

            // Проверяем наличие выбора.
            if (index == -1)
            {
                // Показываем сообщение.
                ShowError("Сначала выберите покупателя!");

                // Прерываем удаление.
                return;
            }

            // Удаляем объект из коллекции.
            _customers.RemoveAt(index);

            // Удаляем элемент из ListBox.
            СustomersListBox.Items.RemoveAt(index);

            // Обновляем ID оставшихся покупателей.
            RenumberCustomers();

            // Очищаем поля.
            ResetForm();
        }

        /// <summary>
        /// Генерирует случайного покупателя.
        /// </summary>
        private void GenerateCustomerButton_Click_1(
            object? sender, EventArgs e)
        {
            // Создаём случайного покупателя.
            Customer customer =
                CustomerFactory.CreateRandomCustomer();

            // Добавляем объект в коллекцию.
            _customers.Add(customer);

            // Отображаем покупателя в ListBox.
            СustomersListBox.Items.Add(customer);

            // Перенумеровываем покупателей.
            RenumberCustomers();

            // Очищаем форму.
            ResetForm();
        }

        /// <summary>
        /// Генерирует случайные заказы покупателей.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void GenerateOrdersButton_Click(
            object? sender, EventArgs e)
        {
            if (_customers.Count == 0)
            {
                MessageBox.Show("Нет покупателей.");
                return;
            }

            if (_items.Count == 0)
            {
                MessageBox.Show("Нет товаров.");
                return;
            }

            int createdCount = 0;

            // Создаём заказы для всех покупателей.
            foreach (Customer customer in _customers)
            {
                int ordersCount = Random.Shared.Next(1, 4);

                for (int i = 0; i < ordersCount; i++)
                {
                    Address address = customer.Address;

                    // Создаём заказ с адресом доставки.
                    Order order = new Order
                    {
                        DeliveryAddress = new Address(
                            address.Index,
                            address.Country,
                            address.City,
                            address.Street,
                            address.Building,
                            address.Apartment)
                    };

                    // Добавляем случайные товары.
                    int itemsCount = Random.Shared.Next(1, 6);

                    for (int j = 0; j < itemsCount; j++)
                    {
                        int index = Random.Shared.Next(_items.Count);
                        order.Items.Add(_items[index]);
                    }

                    customer.Orders.Add(order);
                    createdCount++;
                }
            }

            MessageBox.Show(
                $"Создано заказов: {createdCount}",
                "Генерация заказов",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }


        /// <summary>
        /// Отображает выбранного покупателя.
        /// </summary>
        private void CustomersListBox_SelectedIndexChanged(
            object? sender, EventArgs e)
        {
            // Получаем индекс выбранного элемента.
            int index = СustomersListBox.SelectedIndex;

            // Проверяем наличие выбора.
            if (index == -1)
            {
                // Прерываем обработчик.
                return;
            }

            // Получаем выбранного покупателя.
            Customer customer = _customers[index];

            // Показываем ID.
            IdTextBox.Text = customer.Id.ToString();

            // Показываем полное имя.
            CostTextBox.Text = customer.Fullname;

            // Получаем адрес покупателя.
            Address source = customer.Address;

            // Проверяем наличие заполненного индекса.
            if (source.Index == 0)
            {
                // Устанавливаем пустой адрес.
                addressControl1.Address = new Address();
            }
            else
            {
                // Создаём копию адреса.
                addressControl1.Address = new Address(
                    source.Index,
                    source.Country,
                    source.City,
                    source.Street,
                    source.Building,
                    source.Apartment);
            }
        }

        /// <summary>
        /// Проверяет имя и адрес покупателя.
        /// </summary>
        /// <param name="fullname">Полное имя.</param>
        /// <param name="address">Адрес доставки.</param>
        /// <returns>True, если данные корректны.</returns>
        private bool TryReadCustomer(
            out string fullname,
            out Address address)
        {
            // Получаем имя без лишних пробелов.
            fullname = CostTextBox.Text.Trim();

            // Инициализируем выходной параметр.
            address = null!;

            // Проверяем, заполнено ли имя.
            if (string.IsNullOrWhiteSpace(fullname))
            {
                // Сообщаем об отсутствии имени.
                return ShowInputError(
                    "Введите Full Name!",
                    CostTextBox);
            }

            // Проверяем максимальную длину имени.
            if (fullname.Length > MaxFullnameLength)
            {
                // Сообщаем о превышении длины.
                return ShowInputError(
                    "Full Name не должен превышать 200 символов!",
                    CostTextBox);
            }

            try
            {
                // Получаем проверенный адрес.
                address = addressControl1.Address;

                // Данные корректны.
                return true;
            }
            catch (InvalidOperationException ex)
            {
                // Показываем ошибку адреса.
                ShowError(ex.Message);

                // Возвращаем отрицательный результат.
                return false;
            }
        }

        /// <summary>
        /// Очищает форму покупателя.
        /// </summary>
        private void ResetForm()
        {
            // Снимаем выделение в списке.
            СustomersListBox.ClearSelected();

            // Очищаем поле ID.
            IdTextBox.Clear();

            // Очищаем поле имени.
            CostTextBox.Clear();

            // Создаём пустой адрес.
            addressControl1.Address = new Address();

            // Восстанавливаем стандартные цвета.
            ResetColors();

            // Устанавливаем фокус на поле имени.
            CostTextBox.Focus();
        }

        /// <summary>
        /// Восстанавливает цвета полей.
        /// </summary>
        private void ResetColors()
        {
            // Цвет списка покупателей.
            СustomersListBox.BackColor =
                SystemColors.Window;

            // Цвет поля имени.
            CostTextBox.BackColor =
                SystemColors.Window;
        }

        /// <summary>
        /// Очищает форму при нажатии Escape.
        /// </summary>
        private void CustomersListBox_KeyDown(
            object? sender, KeyEventArgs e)
        {
            // Проверяем нажатую клавишу.
            if (e.KeyCode != Keys.Escape)
            {
                // Пропускаем другие клавиши.
                return;
            }

            // Очищаем форму.
            ResetForm();

            // Помечаем событие обработанным.
            e.Handled = true;

            // Отключаем стандартную обработку клавиши.
            e.SuppressKeyPress = true;
        }

        /// <summary>
        /// Показывает ошибку и устанавливает фокус.
        /// </summary>
        /// <param name="message">Текст ошибки.</param>
        /// <param name="control">Поле ввода.</param>
        /// <returns>Всегда false.</returns>
        private static bool ShowInputError(
            string message, Control control)
        {
            // Показываем сообщение.
            ShowError(message);

            // Устанавливаем фокус на поле.
            control.Focus();

            // Возвращаем false.
            return false;
        }


        /// <summary>
        /// Показывает сообщение об ошибке.
        /// </summary>
        /// <param name="message">Текст ошибки.</param>
        private static void ShowError(string message)
        {

            MessageBox.Show(
                message,
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }


        /// <summary>
        /// Обрабатывает нажатие на подпись имени.
        /// </summary>
        private void NameLabel_Click(
            object? sender, EventArgs e)
        {

        }

        /// <summary>
        /// Обрабатывает нажатие на подпись.
        /// </summary>
        private void label2_Click_1(
            object? sender, EventArgs e)
        {

        }

        /// <summary>
        /// Обрабатывает изменение текстового поля.
        /// </summary>
        private void NameTextBox_TextChanged(
            object? sender, EventArgs e)
        {

        }

        /// <summary>
        /// Обрабатывает загрузку AddressControl.
        /// </summary>
        private void addressControl2_Load(
            object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Обрабатывает загрузку AddressControl.
        /// </summary>
        private void addressControl2_Load_1(
            object sender, EventArgs e)
        {

        }

        private void LeftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addressControl1_Load(object sender, EventArgs e)
        {

        }
    }
}

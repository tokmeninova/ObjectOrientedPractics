using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Предоставляет пользовательский интерфейс для работы
    /// со списком покупателей.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> Customers = new List<Customer>();

        /// <summary>
        /// Создаёт экземпляр класса <see cref="CustomersTab"/>.
        /// </summary>
        public CustomersTab()
        {
            // Инициализируем элементы пользовательского интерфейса.
            InitializeComponent();

            // Запрещаем пользователю изменять идентификатор вручную.
            IdTextBox.ReadOnly = true;

            // Подключаем обработчик добавления покупателя.
            LeftButton.Click += AddCustomerButton_Click;

            // Подключаем обработчик удаления покупателя.
            RightButton.Click += RemoveCustomerButton_Click;

            // Подключаем обработчик выбора покупателя из списка.
            СustomersListBox.SelectedIndexChanged +=
                CustomersListBox_SelectedIndexChanged;
        }

        /// <summary>
        /// Добавляет нового покупателя в список.
        /// </summary>
        /// <param name="sender">
        /// Объект, вызвавший событие.
        /// </param>
        /// <param name="e">
        /// Аргументы события.
        /// </param>
        private void AddCustomerButton_Click(
            object sender,
            EventArgs e)
        {
            // Получаем полное имя покупателя из текстового поля.
            string fullname = CostTextBox.Text;

            // Получаем адрес покупателя из текстового поля.
            string address = NameTextBox.Text;

            // Проверяем, что полное имя не является пустым.
            if (string.IsNullOrWhiteSpace(fullname))
            {
                MessageBox.Show("Введите Full Name.");
                return;
            }

            // Создаём нового покупателя с указанными именем и адресом.
            var customer = new Customer(fullname, address);

            // Добавляем покупателя в список покупателей.
            Customers.Add(customer);

            // Добавляем покупателя в элемент ListBox.
            СustomersListBox.Items.Add(customer);

            // Выбираем добавленного покупателя в ListBox.
            СustomersListBox.SelectedIndex =
                СustomersListBox.Items.Count - 1;
        }

        /// <summary>
        /// Удаляет выбранного покупателя из списка.
        /// </summary>
        /// <param name="sender">
        /// Объект, вызвавший событие.
        /// </param>
        /// <param name="e">
        /// Аргументы события.
        /// </param>
        private void RemoveCustomerButton_Click(
            object sender,
            EventArgs e)
        {
            // Получаем индекс выбранного покупателя.
            int selectedIndex =
                СustomersListBox.SelectedIndex;

            // Проверяем, выбран ли покупатель.
            if (selectedIndex == -1)
            {
                MessageBox.Show(
                    "Сначала выберите покупателя.");

                return;
            }

            // Удаляем покупателя из списка покупателей.
            Customers.RemoveAt(selectedIndex);

            // Удаляем покупателя из элемента ListBox.
            СustomersListBox.Items.RemoveAt(
                selectedIndex);

            // Очищаем информацию об удалённом покупателе.
            IdTextBox.Clear();
            CostTextBox.Clear();
            NameTextBox.Clear();
        }

        /// <summary>
        /// Создаёт случайного покупателя и добавляет его в список.
        /// </summary>
        /// <param name="sender">
        /// Объект, вызвавший событие.
        /// </param>
        /// <param name="e">
        /// Аргументы события.
        /// </param>
        private void GenerateCustomerButton_Click_1(
            object sender,
            EventArgs e)
        {
            // Создаём случайного покупателя с помощью CustomerFactory.
            var customer =
                CustomerFactory.CreateRandomCustomer();

            // Добавляем покупателя в список покупателей.
            Customers.Add(customer);

            // Добавляем покупателя в элемент ListBox.
            СustomersListBox.Items.Add(customer);

            // Выбираем созданного покупателя в ListBox.
            СustomersListBox.SelectedIndex =
                СustomersListBox.Items.Count - 1;
        }

        /// <summary>
        /// Отображает данные выбранного покупателя.
        /// </summary>
        /// <param name="sender">
        /// Объект, вызвавший событие.
        /// </param>
        /// <param name="e">
        /// Аргументы события.
        /// </param>
        private void CustomersListBox_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            // Получаем индекс выбранного покупателя.
            int selectedIndex =
                СustomersListBox.SelectedIndex;

            // Если покупатель не выбран, прекращаем выполнение метода.
            if (selectedIndex == -1)
            {
                return;
            }

            // Получаем выбранного покупателя из списка.
            Customer customer =
                Customers[selectedIndex];

            // Отображаем идентификатор покупателя.
            IdTextBox.Text =
                customer.Id.ToString();

            // Отображаем полное имя покупателя.
            CostTextBox.Text =
                customer.Fullname;

            // Отображаем адрес покупателя.
            NameTextBox.Text =
                customer.Address;
        }

        /// <summary>
        /// Обрабатывает нажатие на метку адреса.
        /// </summary>
        /// <param name="sender">
        /// Объект, вызвавший событие.
        /// </param>
        /// <param name="e">
        /// Аргументы события.
        /// </param>
        private void NameLabel_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Обрабатывает нажатие на метку панели.
        /// </summary>
        /// <param name="sender">
        /// Объект, вызвавший событие.
        /// </param>
        /// <param name="e">
        /// Аргументы события.
        /// </param>
        private void label2_Click_1(object sender, EventArgs e)
        {
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Управление покупателями:
    /// добавление, редактирование, удаление и генерация.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Максимальная длина полного имени покупателя.
        /// </summary>
        private const int MaxFullnameLength = 200;

        /// <summary>
        /// Список покупателей.
        /// </summary>
        private readonly List<Customer> _customers =
            new List<Customer>();
        /// <summary>
        /// Элемент управления адресом доставки.
        /// </summary>
        private readonly AddressControl addressControl1;

        /// <summary>
        /// Создаёт вкладку управления покупателями.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent(); 

            addressControl1 = addressControl2;

            IdTextBox.ReadOnly = true;
            ResetColors();

            LeftButton.Click += AddCustomerButton_Click;
            RightButton.Click += RemoveCustomerButton_Click;

            СustomersListBox.SelectedIndexChanged +=
                CustomersListBox_SelectedIndexChanged;

            СustomersListBox.KeyDown +=
                CustomersListBox_KeyDown;

            // Кнопка Generate уже подключена в Designer.
        }

        /// <summary>
        /// Добавляет нового покупателя
        /// или изменяет выбранного.
        /// </summary>
        private void AddCustomerButton_Click(
            object? sender, EventArgs e)
        {
            if (!TryReadCustomer(
                out string fullname,
                out Address address))
            {
                return;
            }

            try
            {
                int index = СustomersListBox.SelectedIndex;

                if (index == -1)
                {
                    // Создаём нового покупателя.
                    Customer customer = new Customer(
                        fullname, address);

                    _customers.Add(customer);
                    СustomersListBox.Items.Add(customer);
                }
                else
                {
                    // Изменяем существующего покупателя.
                    Customer customer = _customers[index];

                    customer.Fullname = fullname;
                    customer.Address = address;

                    // Обновляем отображение имени.
                    СustomersListBox.Items[index] = customer;
                }

                ResetForm();
            }
            catch (ArgumentException ex)
            {
                ShowError(ex.Message);
            }
        }

        /// <summary>
        /// Удаляет выбранного покупателя.
        /// </summary>
        private void RemoveCustomerButton_Click(
            object? sender, EventArgs e)
        {
            int index = СustomersListBox.SelectedIndex;

            if (index == -1)
            {
                ShowError("Сначала выберите покупателя!");
                return;
            }

            _customers.RemoveAt(index);
            СustomersListBox.Items.RemoveAt(index);

            ResetForm();
        }

        /// <summary>
        /// Генерирует случайного покупателя.
        /// </summary>
        private void GenerateCustomerButton_Click_1(
            object? sender, EventArgs e)
        {
            Customer customer =
                CustomerFactory.CreateRandomCustomer();

            _customers.Add(customer);
            СustomersListBox.Items.Add(customer);

            ResetForm();
        }

        /// <summary>
        /// Отображает данные выбранного покупателя.
        /// </summary>
        private void CustomersListBox_SelectedIndexChanged(
            object? sender, EventArgs e)
        {
            int index = СustomersListBox.SelectedIndex;

            if (index == -1)
            {
                return;
            }

            Customer customer = _customers[index];

            IdTextBox.Text = customer.Id.ToString();
            CostTextBox.Text = customer.Fullname;

            // Копируем адрес, чтобы изменения до Add
            // не затрагивали исходного покупателя.
            Address source = customer.Address;

            if (source.Index == 0)
            {
                addressControl1.Address = new Address();
            }
            else
            {
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
        /// Проверяет имя и получает адрес покупателя.
        /// </summary>
        /// <param name="fullname">Полное имя.</param>
        /// <param name="address">Проверенный адрес.</param>
        /// <returns>
        /// True, если все данные корректны.
        /// </returns>
        private bool TryReadCustomer(
            out string fullname,
            out Address address)
        {
            fullname = CostTextBox.Text.Trim();
            address = null!;

            if (string.IsNullOrWhiteSpace(fullname))
            {
                return ShowInputError(
                    "Введите Full Name!",
                    CostTextBox);
            }

            if (fullname.Length > MaxFullnameLength)
            {
                return ShowInputError(
                    "Full Name не должен превышать 200 символов!",
                    CostTextBox);
            }

            try
            {
                // Получаем проверенный адрес из элемента.
                address = addressControl1.Address;
                return true;
            }
            catch (InvalidOperationException ex)
            {
                ShowError(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Очищает форму для нового покупателя.
        /// </summary>
        private void ResetForm()
        {
            СustomersListBox.ClearSelected();

            IdTextBox.Clear();
            CostTextBox.Clear();

            // Сбрасываем адрес.
            addressControl1.Address = new Address();

            ResetColors();
            CostTextBox.Focus();
        }

        /// <summary>
        /// Восстанавливает стандартные цвета.
        /// </summary>
        private void ResetColors()
        {
            СustomersListBox.BackColor =
                SystemColors.Window;

            CostTextBox.BackColor =
                SystemColors.Window;
        }

        /// <summary>
        /// Очищает форму при нажатии Escape.
        /// </summary>
        private void CustomersListBox_KeyDown(
            object? sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Escape)
            {
                return;
            }

            ResetForm();

            e.Handled = true;
            e.SuppressKeyPress = true;
        }

        /// <summary>
        /// Показывает ошибку и устанавливает фокус.
        /// </summary>
        private static bool ShowInputError(
            string message, Control control)
        {
            ShowError(message);
            control.Focus();
            return false;
        }

        /// <summary>
        /// Показывает сообщение об ошибке.
        /// </summary>
        private static void ShowError(string message)
        {
            MessageBox.Show(
                message,
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        // Оставляем обработчики, если они
        // подключены в CustomersTab.Designer.cs.

        private void NameLabel_Click(
            object? sender, EventArgs e)
        {
        }

        private void label2_Click_1(
            object? sender, EventArgs e)
        {
        }

        private void NameTextBox_TextChanged(
            object? sender, EventArgs e)
        {
        }

        private void addressControl2_Load(object sender, EventArgs e)
        {

        }

        private void addressControl2_Load_1(object sender, EventArgs e)
        {

        }
    }
}

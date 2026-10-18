using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Управление покупателями: добавление, редактирование, удаление и генерация.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        private const int MaxFullnameLength = 200;
        private const int MaxAddressLength = 500;

        private readonly List<Customer> _customers = new List<Customer>();

        public CustomersTab()
        {
            InitializeComponent();

            IdTextBox.ReadOnly = true;
            ResetColors();

            LeftButton.Click += AddCustomerButton_Click;
            RightButton.Click += RemoveCustomerButton_Click;
            СustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            СustomersListBox.KeyDown += CustomersListBox_KeyDown;

            // Кнопка генерации подключена в CustomersTab.Designer.cs.
        }

        /// <summary>
        /// Добавляет покупателя, если ничего не выбрано, или изменяет выбранного.
        /// </summary>
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            if (!TryReadCustomer(out string fullname, out string address))
                return;

            try
            {
                int index = СustomersListBox.SelectedIndex;

                if (index == -1)
                {
                    Customer customer = new Customer(fullname, address);
                    _customers.Add(customer);
                    СustomersListBox.Items.Add(customer);
                }
                else
                {
                    // Изменяем существующий объект, не создавая его копию.
                    Customer customer = _customers[index];
                    customer.Fullname = fullname;
                    customer.Address = address;
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
        private void RemoveCustomerButton_Click(object sender, EventArgs e)
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
        /// Генерирует покупателя и сразу добавляет его в список.
        /// </summary>
        private void GenerateCustomerButton_Click_1(object sender, EventArgs e)
        {
            Customer customer = CustomerFactory.CreateRandomCustomer();
            _customers.Add(customer);
            СustomersListBox.Items.Add(customer);
            ResetForm();
        }

        /// <summary>
        /// Отображает данные выбранного покупателя в текстовых полях.
        /// </summary>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = СustomersListBox.SelectedIndex;
            if (index == -1)
                return;

            Customer customer = _customers[index];
            IdTextBox.Text = customer.Id.ToString();
            CostTextBox.Text = customer.Fullname;
            NameTextBox.Text = customer.Address;
        }

        /// <summary>
        /// Проверяет данные и сообщает об ошибках без окрашивания полей.
        /// CostTextBox — Full Name; NameTextBox — Address.
        /// </summary>
        private bool TryReadCustomer(out string fullname, out string address)
        {
            fullname = CostTextBox.Text.Trim();
            address = NameTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(fullname))
                return ShowInputError("Введите Full Name!", CostTextBox);

            if (fullname.Length > MaxFullnameLength)
                return ShowInputError("Full Name не должен превышать 200 символов!", CostTextBox);

            if (address.Length > MaxAddressLength)
                return ShowInputError("Address не должен превышать 500 символов!", NameTextBox);

            return true;
        }

        /// <summary>
        /// Очищает форму для ввода нового покупателя.
        /// </summary>
        private void ResetForm()
        {
            СustomersListBox.ClearSelected();

            IdTextBox.Clear();
            CostTextBox.Clear();
            NameTextBox.Clear();

            ResetColors();
            CostTextBox.Focus();
        }

        private void ResetColors()
        {
            СustomersListBox.BackColor = SystemColors.Window;
            CostTextBox.BackColor = SystemColors.Window;
            NameTextBox.BackColor = SystemColors.Window;
        }

        /// <summary>
        /// Escape снимает выделение и очищает форму.
        /// </summary>
        private void CustomersListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Escape)
                return;

            ResetForm();
            e.Handled = true;
            e.SuppressKeyPress = true;
        }

        private static bool ShowInputError(string message, Control control)
        {
            ShowError(message);
            control.Focus();
            return false;
        }

        private static void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Обработчики используются в Designer.
        private void NameLabel_Click(object sender, EventArgs e) { }
        private void label2_Click_1(object sender, EventArgs e) { }
        private void NameTextBox_TextChanged(object sender, EventArgs e) { }
    }
}

using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View
{
    /// <summary>
    /// Отображает данные выбранного заказа.
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// Выбранный заказ.
        /// </summary>
        private Order? _selectedOrder;

        /// <summary>
        /// Флаг обновления интерфейса.
        /// </summary>
        private bool _isUpdatingDetails;

        /// <summary>
        /// Возникает при изменении статуса заказа.
        /// </summary>
        public event EventHandler? StatusChanged;

        /// <summary>
        /// Возвращает или задаёт выбранный заказ.
        /// </summary>
        public Order? SelectedOrder
        {
            get
            {
                return _selectedOrder;
            }
            set
            {
                _selectedOrder = value;
                UpdateDetails();
            }
        }

        /// <summary>
        /// Создаёт элемент управления заказом.
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();

            // Запрещаем редактирование полей.
            idTextBox.ReadOnly = true;
            createdTextBox.ReadOnly = true;
            orderItemsDataGridView.ReadOnly = true;

            // Добавляем статусы заказа.
            statusComboBox.Items.Clear();

            foreach (OrderStatus status in Enum.GetValues<OrderStatus>())
            {
                statusComboBox.Items.Add(status);
            }

            statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusComboBox.Enabled = false;


            // Подключаем событие изменения статуса.
            statusComboBox.SelectedIndexChanged +=
                StatusComboBox_SelectedIndexChanged;


            // Показываем адрес только для чтения.
            SetAddressReadOnly(deliveryAddressControl);
            deliveryAddressControl.Visible = false;
        }

        /// <summary>
        /// Запрещает редактирование адреса.
        /// </summary>
        /// <param name="parent">Родительский элемент.</param>
        private void SetAddressReadOnly(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.ReadOnly = true;
                    textBox.TabStop = false;
                }

                if (control.HasChildren)
                {
                    SetAddressReadOnly(control);
                }
            }
        }

        /// <summary>
        /// Показывает сведения о выбранном заказе.
        /// </summary>
        private void UpdateDetails()
        {
            _isUpdatingDetails = true;

            try
            {
                // Очищаем предыдущие сведения.
                idTextBox.Clear();
                createdTextBox.Clear();
                statusComboBox.SelectedIndex = -1;
                statusComboBox.Enabled = false;
                deliveryAddressControl.Visible = false;
                orderItemsDataGridView.Rows.Clear();
                amountValueLabel.Text = "0,00";

                if (_selectedOrder == null)
                {
                    return;
                }

                Order order = _selectedOrder;

                // Показываем ID, дату и статус.
                idTextBox.Text = order.Id.ToString();
                createdTextBox.Text =
                    order.Created.ToString("dd.MM.yyyy HH:mm");
                statusComboBox.SelectedItem = order.Status;
                statusComboBox.Enabled = true;

                // Показываем адрес доставки.
                deliveryAddressControl.Address = order.DeliveryAddress;
                deliveryAddressControl.Visible = true;

                // Подсчитываем количество одинаковых товаров.
                Dictionary<Item, int> quantities =
                    new Dictionary<Item, int>();

                foreach (Item item in order.Items)
                {
                    if (quantities.ContainsKey(item))
                    {
                        quantities[item]++;
                    }
                    else
                    {
                        quantities.Add(item, 1);
                    }
                }

                // Заполняем таблицу товаров.
                foreach (var entry in quantities)
                {
                    Item item = entry.Key;
                    int quantity = entry.Value;

                    orderItemsDataGridView.Rows.Add(
                        item.Name,
                        quantity,
                        item.Cost.ToString("N2"),
                        (item.Cost * quantity).ToString("N2")
                    );
                }

                amountValueLabel.Text = order.Amount.ToString("N2");
                orderItemsDataGridView.ClearSelection();
            }
            finally
            {
                _isUpdatingDetails = false;
            }
        }

        /// <summary>
        /// Изменяет статус заказа.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void StatusComboBox_SelectedIndexChanged(
            object? sender, EventArgs e)
        {
            if (_isUpdatingDetails || _selectedOrder == null)
            {
                return;
            }

            if (statusComboBox.SelectedItem is OrderStatus status)
            {
                _selectedOrder.Status = status;
                StatusChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}

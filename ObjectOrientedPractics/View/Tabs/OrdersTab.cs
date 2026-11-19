
using ObjectOrientedPractics.Model;
using System.Collections.Generic;
namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Список покупателей магазина.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();
        /// <summary>
        /// Общий список заказов всех покупателей.
        /// </summary>
        private List<Order> _orders = new List<Order>();

        /// <summary>
        /// Предотвращает обработку событий
        /// во время программного обновления интерфейса.
        /// </summary>

        private bool _isUpdatingDetails;

        /// <summary>
        /// Поле поиска заказов, создаваемое без изменения Designer.
        /// </summary>
        private TextBox _findTextBox = null!;

        /// <summary>
        /// Индекс столбца текущей сортировки.
        /// </summary>
        private int _sortColumnIndex = -1;

        /// <summary>
        /// Порядок сортировки: по возрастанию или убыванию.
        /// </summary>
        private bool _sortAscending = true;

        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value ??
                    throw new ArgumentNullException(nameof(value));

                UpdateOrders();
            }
        }



        /// <summary>
        /// Собирает все заказы покупателей
        /// и отображает их в таблице.
        /// </summary>
        private void UpdateOrders()

        {
            Order.RenumberOrders(_customers);
            _isUpdatingDetails = true;

            try
            {
                // Очищаем старые данные.
                _orders.Clear();
                ordersDataGridView.Rows.Clear();

                // Получаем строку поиска один раз.
                string query = _findTextBox.Text.Trim();

                foreach (Customer customer in _customers)
                {
                    foreach (Order order in customer.Orders)
                    {
                        string address =
                            order.DeliveryAddress?.ToString() ?? "";

                        // Ищем по покупателю, адресу или статусу.
                        bool matches =
                            string.IsNullOrEmpty(query) ||
                            (customer.Fullname?.Contains(
                                query, StringComparison.OrdinalIgnoreCase)
                                == true) ||
                            address.Contains(
                                query, StringComparison.OrdinalIgnoreCase) ||
                            order.Status.ToString().Contains(
                                query, StringComparison.OrdinalIgnoreCase);

                        if (!matches)
                        {
                            continue;
                        }

                        _orders.Add(order);

                        int index = ordersDataGridView.Rows.Add(
                            order.Id,
                            order.LastStatusChangeTime.ToString(
                                "dd.MM.yyyy HH:mm"),
                            customer.Fullname,
                            address,
                            order.Amount.ToString("N2"),
                            order.Status.ToString());

                        // Связываем строку с настоящим заказом.
                        ordersDataGridView.Rows[index].Tag = order;
                    }
                }

                ordersDataGridView.ClearSelection();
            }
            finally
            {
                _isUpdatingDetails = false;
            }

            // Сохраняем сортировку после обновления поиска.
            if (_sortColumnIndex >= 0)
            {
                SortOrders();
            }
            else
            {
                ClearOrderDetails();
            }
        }

        /// <summary>
        /// Обновляет данные вкладки заказов.
        /// </summary>
        public void RefreshData()
        {
            // Обновляем список всех заказов
            // и строки таблицы.
            UpdateOrders();
        }

        public OrdersTab()
        {
            InitializeComponent();

            // Создаём нижнюю строку поиска без изменения Designer.
            InitializeFindControls();

            // Показываем стоимость, чтобы сортировать по заголовку.
            amountColumn.Visible = true;
            amountColumn.MinimumWidth = 65;
            amountColumn.FillWeight = 25F;

            // Управляем сортировкой самостоятельно.
            idColumn.SortMode =
                DataGridViewColumnSortMode.Programmatic;
            amountColumn.SortMode =
                DataGridViewColumnSortMode.Programmatic;

            ordersDataGridView.ColumnHeaderMouseClick -=
                OrdersDataGridView_ColumnHeaderMouseClick;
            ordersDataGridView.ColumnHeaderMouseClick +=
                OrdersDataGridView_ColumnHeaderMouseClick;

            _findTextBox.TextChanged -= FindTextBox_TextChanged;
            _findTextBox.TextChanged += FindTextBox_TextChanged;

            // Запрещаем редактировать данные заказа.
            idTextBox.ReadOnly = true;
            createdTextBox.ReadOnly = true;
            orderItemsDataGridView.ReadOnly = true;

            // Заполняем список возможных статусов.
            statusComboBox.Items.Clear();

            foreach (OrderStatus status in Enum.GetValues<OrderStatus>())
            {
                statusComboBox.Items.Add(status);
            }

            // Пока заказ не выбран, статус менять нельзя.
            statusComboBox.Enabled = false;

            // Подключаем обработчики событий.
            ordersDataGridView.SelectionChanged +=
                OrdersDataGridView_SelectionChanged;

            statusComboBox.SelectedIndexChanged +=
                StatusComboBox_SelectedIndexChanged;

            // Поля адреса доступны только для чтения.
            SetAddressReadOnly(deliveryAddressControl);

            // Пока заказ не выбран, адрес скрыт.
            deliveryAddressControl.Visible = false;

        }

        /// <summary>
        /// Добавляет поле поиска под таблицей заказов.
        /// </summary>
        private void InitializeFindControls()
        {
            // Добавляем строку в уже существующую левую таблицу.
            leftTableLayoutPanel.RowCount = 3;

            if (leftTableLayoutPanel.RowStyles.Count < 3)
            {
                leftTableLayoutPanel.RowStyles.Add(
                    new RowStyle(SizeType.Absolute, 44F));
            }

            TableLayoutPanel searchPanel = new TableLayoutPanel();
            searchPanel.ColumnCount = 2;
            searchPanel.ColumnStyles.Add(
                new ColumnStyle(SizeType.Absolute, 55F));
            searchPanel.ColumnStyles.Add(
                new ColumnStyle(SizeType.Percent, 100F));
            searchPanel.RowCount = 1;
            searchPanel.RowStyles.Add(
                new RowStyle(SizeType.Percent, 100F));
            searchPanel.Dock = DockStyle.Fill;
            searchPanel.Margin = new Padding(0, 5, 3, 0);
            searchPanel.Name = "searchPanel";

            Label findLabel = new Label();
            findLabel.AutoSize = true;
            findLabel.Dock = DockStyle.Fill;
            findLabel.Text = "Find:";
            findLabel.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;

            _findTextBox = new TextBox();
            _findTextBox.Dock = DockStyle.Fill;
            _findTextBox.Name = "findTextBox";
            _findTextBox.Margin = new Padding(0, 3, 0, 3);

            searchPanel.Controls.Add(findLabel, 0, 0);
            searchPanel.Controls.Add(_findTextBox, 1, 0);
            leftTableLayoutPanel.Controls.Add(searchPanel, 0, 2);
        }

        /// <summary>
        /// Обновляет таблицу при изменении текста поиска.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void FindTextBox_TextChanged(
            object? sender, EventArgs e)
        {
            UpdateOrders();
        }


        /// <summary>
        /// Сортирует заказы при нажатии на заголовок столбца.
        /// </summary>
        private void OrdersDataGridView_ColumnHeaderMouseClick(
            object? sender, DataGridViewCellMouseEventArgs e)
        {
            // Сортируем только по ID или стоимости.
            if (e.ColumnIndex != idColumn.Index &&
                e.ColumnIndex != amountColumn.Index)
            {
                return;
            }

            // Повторное нажатие меняет направление сортировки.
            if (_sortColumnIndex == e.ColumnIndex)
            {
                _sortAscending = !_sortAscending;
            }
            else
            {
                _sortColumnIndex = e.ColumnIndex;
                _sortAscending = true;
            }

            SortOrders();
        }

        /// <summary>
        /// Сортирует строки по настоящим значениям заказа.
        /// </summary>
        private void SortOrders()
        {
            if (_sortColumnIndex < 0 ||
                ordersDataGridView.Rows.Count == 0)
            {
                ClearOrderDetails();
                return;
            }

            // Запоминаем выбранный заказ перед сортировкой.
            Order? selectedOrder = null;

            if (ordersDataGridView.SelectedRows.Count > 0)
            {
                selectedOrder =
                    ordersDataGridView.SelectedRows[0].Tag as Order;
            }

            _isUpdatingDetails = true;

            try
            {
                bool byAmount =
                    _sortColumnIndex == amountColumn.Index;

                ordersDataGridView.Sort(
                    new OrderRowComparer(byAmount, _sortAscending));

                // Показываем стрелку у нужного заголовка.
                idColumn.HeaderCell.SortGlyphDirection =
                    SortOrder.None;
                amountColumn.HeaderCell.SortGlyphDirection =
                    SortOrder.None;

                DataGridViewColumn column =
                    ordersDataGridView.Columns[_sortColumnIndex];

                column.HeaderCell.SortGlyphDirection =
                    _sortAscending
                        ? SortOrder.Ascending
                        : SortOrder.Descending;

                // Восстанавливаем выбор того же объекта заказа.
                ordersDataGridView.ClearSelection();

                if (selectedOrder != null)
                {
                    foreach (DataGridViewRow row
                             in ordersDataGridView.Rows)
                    {
                        if (ReferenceEquals(row.Tag, selectedOrder))
                        {
                            row.Selected = true;
                            break;
                        }
                    }
                }
            }
            finally
            {
                _isUpdatingDetails = false;
            }

            if (ordersDataGridView.SelectedRows.Count > 0 &&
                ordersDataGridView.SelectedRows[0].Tag is Order order)
            {
                ShowOrderDetails(order);
            }
            else
            {
                ClearOrderDetails();
            }
        }

        /// <summary>
        /// Сравнивает строки таблицы по ID или стоимости заказа.
        /// </summary>
        private sealed class OrderRowComparer :
            System.Collections.IComparer
        {
            /// <summary>
            /// Нужно ли сравнивать стоимость вместо ID.
            /// </summary>
            private readonly bool _byAmount;

            /// <summary>
            /// Порядок сортировки.
            /// </summary>
            private readonly bool _ascending;

            /// <summary>
            /// Создаёт сравниватель строк.
            /// </summary>
            public OrderRowComparer(bool byAmount, bool ascending)
            {
                _byAmount = byAmount;
                _ascending = ascending;
            }

            /// <summary>
            /// Сравнивает два заказа по выбранному критерию.
            /// </summary>
            public int Compare(object? x, object? y)
            {
                if (x is not DataGridViewRow leftRow ||
                    y is not DataGridViewRow rightRow ||
                    leftRow.Tag is not Order leftOrder ||
                    rightRow.Tag is not Order rightOrder)
                {
                    return 0;
                }

                int result;

                if (_byAmount)
                {
                    result =
                        leftOrder.Amount.CompareTo(rightOrder.Amount);
                }
                else
                {
                    result =
                        leftOrder.Id.CompareTo(rightOrder.Id);
                }

                if (!_ascending)
                {
                    result = -result;
                }

                return result;
            }
        }

        /// <summary>
        /// Запрещает редактирование полей адреса.
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

                // Проверяем вложенные элементы.
                if (control.HasChildren)
                {
                    SetAddressReadOnly(control);
                }
            }
        }

        /// <summary>
        /// Обрабатывает выбор заказа в таблице.
        /// </summary>
        private void OrdersDataGridView_SelectionChanged(
            object? sender, EventArgs e)
        {
            if (_isUpdatingDetails)
            {
                return;
            }

            if (ordersDataGridView.SelectedRows.Count == 0)
            {
                ClearOrderDetails();
                return;
            }

            // Берём объект из Tag, а не по индексу строки.
            DataGridViewRow row = ordersDataGridView.SelectedRows[0];

            if (row.Tag is Order order)
            {
                ShowOrderDetails(order);
            }
            else
            {
                ClearOrderDetails();
            }
        }

        /// <summary>
        /// Отображает данные выбранного заказа.
        /// </summary>
        /// <param name="order">Выбранный заказ.</param>
        private void ShowOrderDetails(Order order)
        {
            _isUpdatingDetails = true;

            try
            {
                // Отображаем номер заказа.
                idTextBox.Text = order.Id.ToString();

                // Отображаем дату создания.
                createdTextBox.Text =
                    order.LastStatusChangeTime.ToString("dd.MM.yyyy HH:mm");

                // Отображаем текущий статус.
                statusComboBox.SelectedItem = order.Status;
                statusComboBox.Enabled = true;

                // Отображаем адрес доставки.
                deliveryAddressControl.Address =
                    order.DeliveryAddress;

                deliveryAddressControl.Visible = true;

                // Очищаем предыдущие товары.
                orderItemsDataGridView.Rows.Clear();

                // Подсчитываем количество каждого товара.
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

                // Отображаем итоговую стоимость.
                amountValueLabel.Text =
                    order.Amount.ToString("N2");

                orderItemsDataGridView.ClearSelection();
            }
            finally
            {
                _isUpdatingDetails = false;
            }
        }

        /// <summary>
        /// Изменяет статус выбранного заказа.
        /// </summary>
        private void StatusComboBox_SelectedIndexChanged(
            object? sender, EventArgs e)
        {
            if (_isUpdatingDetails ||
                ordersDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow row = ordersDataGridView.SelectedRows[0];

            if (row.Tag is not Order order ||
                statusComboBox.SelectedItem is not OrderStatus status)
            {
                return;
            }

            order.Status = status;

            // Обновляем отображаемые статус и время.
            row.Cells[statusColumn.Index].Value = status.ToString();
            row.Cells[createdColumn.Index].Value =
                order.LastStatusChangeTime.ToString("dd.MM.yyyy HH:mm");

            createdTextBox.Text =
                order.LastStatusChangeTime.ToString("dd.MM.yyyy HH:mm");

            // После смены статуса заказ может перестать
            // соответствовать текущему поиску.
            if (!string.IsNullOrWhiteSpace(_findTextBox.Text))
            {
                UpdateOrders();
            }
        }

        /// <summary>
        /// Очищает информацию о выбранном заказе.
        /// </summary>
        private void ClearOrderDetails()
        {
            _isUpdatingDetails = true;

            try
            {
                idTextBox.Clear();
                createdTextBox.Clear();

                statusComboBox.SelectedIndex = -1;
                statusComboBox.Enabled = false;

                deliveryAddressControl.Visible = false;

                orderItemsDataGridView.Rows.Clear();
                amountValueLabel.Text = "0,00";
            }
            finally
            {
                _isUpdatingDetails = false;
            }
        }
        private void OrdersTab_Load(object sender, EventArgs e)
        {

        }

        private void ordersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deliveryAddressControl_Load(object sender, EventArgs e)
        {

        }
    }
}

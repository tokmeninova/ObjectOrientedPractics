namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора.
        /// </summary>
        private void InitializeComponent()
        {
            mainTableLayoutPanel = new TableLayoutPanel();
            leftPanel = new Panel();
            leftTableLayoutPanel = new TableLayoutPanel();
            findPanel = new TableLayoutPanel();
            findLabel = new Label();
            findTextBox = new TextBox();
            ordersLabel = new Label();
            ordersDataGridView = new DataGridView();
            rightPanel = new Panel();
            rightTableLayoutPanel = new TableLayoutPanel();
            selectedOrderLabel = new Label();
            orderDetailsPanel = new Panel();
            idLabel = new Label();
            idTextBox = new TextBox();
            createdLabel = new Label();
            createdTextBox = new TextBox();
            statusLabel = new Label();
            statusComboBox = new ComboBox();
            deliveryAddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            orderItemsLabel = new Label();
            orderItemsDataGridView = new DataGridView();
            itemNameColumn = new DataGridViewTextBoxColumn();
            itemQuantityColumn = new DataGridViewTextBoxColumn();
            itemPriceColumn = new DataGridViewTextBoxColumn();
            itemAmountColumn = new DataGridViewTextBoxColumn();
            totalTableLayoutPanel = new TableLayoutPanel();
            amountTitleLabel = new Label();
            amountValueLabel = new Label();
            idColumn = new DataGridViewTextBoxColumn();
            createdColumn = new DataGridViewTextBoxColumn();
            customerColumn = new DataGridViewTextBoxColumn();
            addressColumn = new DataGridViewTextBoxColumn();
            amountColumn = new DataGridViewTextBoxColumn();
            statusColumn = new DataGridViewTextBoxColumn();
            mainTableLayoutPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            leftTableLayoutPanel.SuspendLayout();
            findPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).BeginInit();
            rightPanel.SuspendLayout();
            rightTableLayoutPanel.SuspendLayout();
            orderDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderItemsDataGridView).BeginInit();
            totalTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.ColumnCount = 2;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47F));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53F));
            mainTableLayoutPanel.Controls.Add(leftPanel, 0, 0);
            mainTableLayoutPanel.Controls.Add(rightPanel, 1, 0);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(0, 0);
            mainTableLayoutPanel.Margin = new Padding(0);
            mainTableLayoutPanel.MinimumSize = new Size(780, 510);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.Padding = new Padding(10);
            mainTableLayoutPanel.RowCount = 1;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.Size = new Size(940, 620);
            mainTableLayoutPanel.TabIndex = 0;
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(leftTableLayoutPanel);
            leftPanel.Dock = DockStyle.Fill;
            leftPanel.Location = new Point(10, 10);
            leftPanel.Margin = new Padding(0, 0, 8, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(424, 600);
            leftPanel.TabIndex = 0;
            // 
            // leftTableLayoutPanel
            // 
            leftTableLayoutPanel.ColumnCount = 1;
            leftTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            leftTableLayoutPanel.Controls.Add(ordersLabel, 0, 0);
            leftTableLayoutPanel.Controls.Add(ordersDataGridView, 0, 1);
            leftTableLayoutPanel.Controls.Add(findPanel, 0, 2);
            leftTableLayoutPanel.Dock = DockStyle.Fill;
            leftTableLayoutPanel.Location = new Point(0, 0);
            leftTableLayoutPanel.Name = "leftTableLayoutPanel";
            leftTableLayoutPanel.RowCount = 3;
            leftTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            leftTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            leftTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            leftTableLayoutPanel.Size = new Size(424, 600);
            leftTableLayoutPanel.TabIndex = 0;
            // 
            // findPanel
            // 
            findPanel.ColumnCount = 2;
            findPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            findPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            findPanel.Controls.Add(findLabel, 0, 0);
            findPanel.Controls.Add(findTextBox, 1, 0);
            findPanel.Dock = DockStyle.Fill;
            findPanel.Margin = new Padding(0, 5, 3, 0);
            findPanel.Name = "findPanel";
            findPanel.RowCount = 1;
            findPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            findPanel.TabIndex = 1;
            // 
            // findLabel
            // 
            findLabel.AutoSize = true;
            findLabel.Dock = DockStyle.Fill;
            findLabel.Name = "findLabel";
            findLabel.Text = "Find:";
            findLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // findTextBox
            // 
            findTextBox.Dock = DockStyle.Top;
            findTextBox.Margin = new Padding(0, 3, 0, 3);
            findTextBox.Name = "findTextBox";
            findTextBox.TabIndex = 0;
            // 
            // ordersLabel
            // 
            ordersLabel.AutoSize = true;
            ordersLabel.Dock = DockStyle.Fill;
            ordersLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ordersLabel.Location = new Point(3, 0);
            ordersLabel.Name = "ordersLabel";
            ordersLabel.Size = new Size(418, 32);
            ordersLabel.TabIndex = 0;
            ordersLabel.Text = "Orders";
            ordersLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ordersDataGridView
            // 
            ordersDataGridView.AllowUserToAddRows = false;
            ordersDataGridView.AllowUserToDeleteRows = false;
            ordersDataGridView.AllowUserToResizeRows = false;
            ordersDataGridView.AllowUserToOrderColumns = false;
            ordersDataGridView.AllowUserToResizeColumns = false;
            ordersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ordersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersDataGridView.Columns.AddRange(new DataGridViewColumn[] { idColumn, createdColumn, customerColumn, addressColumn, amountColumn, statusColumn });
            ordersDataGridView.Dock = DockStyle.Fill;
            ordersDataGridView.Location = new Point(0, 32);
            ordersDataGridView.Margin = new Padding(0, 0, 3, 0);
            ordersDataGridView.MultiSelect = false;
            ordersDataGridView.Name = "ordersDataGridView";
            ordersDataGridView.ReadOnly = true;
            idColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            createdColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            customerColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            addressColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            amountColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            statusColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            ordersDataGridView.RowHeadersVisible = false;
            ordersDataGridView.RowHeadersWidth = 51;
            ordersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ordersDataGridView.Size = new Size(421, 568);
            ordersDataGridView.TabIndex = 0;
            ordersDataGridView.CellContentClick += ordersDataGridView_CellContentClick;
            // 
            // rightPanel
            // 
            rightPanel.AutoScroll = true;
            rightPanel.Controls.Add(rightTableLayoutPanel);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(450, 10);
            rightPanel.Margin = new Padding(8, 0, 0, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(480, 600);
            rightPanel.TabIndex = 1;
            // 
            // rightTableLayoutPanel
            // 
            rightTableLayoutPanel.ColumnCount = 1;
            rightTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            rightTableLayoutPanel.Controls.Add(selectedOrderLabel, 0, 0);
            rightTableLayoutPanel.Controls.Add(orderDetailsPanel, 0, 1);
            rightTableLayoutPanel.Controls.Add(deliveryAddressControl, 0, 2);
            rightTableLayoutPanel.Controls.Add(orderItemsLabel, 0, 3);
            rightTableLayoutPanel.Controls.Add(orderItemsDataGridView, 0, 4);
            rightTableLayoutPanel.Controls.Add(totalTableLayoutPanel, 0, 5);
            rightTableLayoutPanel.Dock = DockStyle.Fill;
            rightTableLayoutPanel.Location = new Point(0, 0);
            rightTableLayoutPanel.MinimumSize = new Size(370, 480);
            rightTableLayoutPanel.Name = "rightTableLayoutPanel";
            rightTableLayoutPanel.RowCount = 6;
            rightTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            rightTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 108F));
            rightTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 190F));
            rightTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            rightTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            rightTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            rightTableLayoutPanel.Size = new Size(480, 600);
            rightTableLayoutPanel.TabIndex = 0;
            // 
            // selectedOrderLabel
            // 
            selectedOrderLabel.AutoSize = true;
            selectedOrderLabel.Dock = DockStyle.Fill;
            selectedOrderLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            selectedOrderLabel.Location = new Point(3, 0);
            selectedOrderLabel.Name = "selectedOrderLabel";
            selectedOrderLabel.Size = new Size(474, 34);
            selectedOrderLabel.TabIndex = 0;
            selectedOrderLabel.Text = "Selected Order";
            selectedOrderLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // orderDetailsPanel
            // 
            orderDetailsPanel.Controls.Add(idLabel);
            orderDetailsPanel.Controls.Add(idTextBox);
            orderDetailsPanel.Controls.Add(createdLabel);
            orderDetailsPanel.Controls.Add(createdTextBox);
            orderDetailsPanel.Controls.Add(statusLabel);
            orderDetailsPanel.Controls.Add(statusComboBox);
            orderDetailsPanel.Dock = DockStyle.Fill;
            orderDetailsPanel.Location = new Point(0, 34);
            orderDetailsPanel.Margin = new Padding(0);
            orderDetailsPanel.Name = "orderDetailsPanel";
            orderDetailsPanel.Size = new Size(480, 108);
            orderDetailsPanel.TabIndex = 1;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(3, 7);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(27, 20);
            idLabel.TabIndex = 0;
            idLabel.Text = "ID:";
            idLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(84, 3);
            idTextBox.Margin = new Padding(3, 3, 0, 3);
            idTextBox.MaximumSize = new Size(220, 28);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(208, 27);
            idTextBox.TabIndex = 0;
            // 
            // createdLabel
            // 
            createdLabel.AutoSize = true;
            createdLabel.Location = new Point(3, 43);
            createdLabel.Name = "createdLabel";
            createdLabel.Size = new Size(64, 20);
            createdLabel.TabIndex = 1;
            createdLabel.Text = "Created:";
            createdLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // createdTextBox
            // 
            createdTextBox.Location = new Point(84, 39);
            createdTextBox.Margin = new Padding(3, 3, 0, 3);
            createdTextBox.MaximumSize = new Size(220, 28);
            createdTextBox.Name = "createdTextBox";
            createdTextBox.ReadOnly = true;
            createdTextBox.Size = new Size(208, 27);
            createdTextBox.TabIndex = 1;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(3, 79);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(52, 20);
            statusLabel.TabIndex = 2;
            statusLabel.Text = "Status:";
            statusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // statusComboBox
            // 
            statusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusComboBox.Location = new Point(84, 75);
            statusComboBox.Margin = new Padding(3, 3, 0, 3);
            statusComboBox.MaximumSize = new Size(220, 0);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(208, 28);
            statusComboBox.TabIndex = 2;
            // 
            // deliveryAddressControl
            // 
            deliveryAddressControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            deliveryAddressControl.Location = new Point(0, 142);
            deliveryAddressControl.Margin = new Padding(0);
            deliveryAddressControl.MaximumSize = new Size(550, 190);
            deliveryAddressControl.MinimumSize = new Size(350, 183);
            deliveryAddressControl.Name = "deliveryAddressControl";
            deliveryAddressControl.Size = new Size(480, 190);
            deliveryAddressControl.TabIndex = 2;
            deliveryAddressControl.Load += deliveryAddressControl_Load;
            // 
            // orderItemsLabel
            // 
            orderItemsLabel.AutoSize = true;
            orderItemsLabel.Dock = DockStyle.Fill;
            orderItemsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            orderItemsLabel.Location = new Point(3, 332);
            orderItemsLabel.Name = "orderItemsLabel";
            orderItemsLabel.Size = new Size(474, 27);
            orderItemsLabel.TabIndex = 3;
            orderItemsLabel.Text = "Order Items";
            orderItemsLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // orderItemsDataGridView
            // 
            orderItemsDataGridView.AllowUserToAddRows = false;
            orderItemsDataGridView.AllowUserToDeleteRows = false;
            orderItemsDataGridView.AllowUserToResizeRows = false;
            orderItemsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            orderItemsDataGridView.BackgroundColor = SystemColors.Window;
            orderItemsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderItemsDataGridView.Columns.AddRange(new DataGridViewColumn[] { itemNameColumn, itemQuantityColumn, itemPriceColumn, itemAmountColumn });
            orderItemsDataGridView.Dock = DockStyle.Fill;
            orderItemsDataGridView.Location = new Point(3, 359);
            orderItemsDataGridView.Margin = new Padding(3, 0, 3, 0);
            orderItemsDataGridView.MultiSelect = false;
            orderItemsDataGridView.Name = "orderItemsDataGridView";
            orderItemsDataGridView.ReadOnly = true;
            orderItemsDataGridView.RowHeadersVisible = false;
            orderItemsDataGridView.RowHeadersWidth = 51;
            orderItemsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            orderItemsDataGridView.Size = new Size(474, 193);
            orderItemsDataGridView.TabIndex = 3;
            // 
            // itemNameColumn
            // 
            itemNameColumn.FillWeight = 43F;
            itemNameColumn.HeaderText = "Item";
            itemNameColumn.MinimumWidth = 6;
            itemNameColumn.Name = "itemNameColumn";
            itemNameColumn.ReadOnly = true;
            // 
            // itemQuantityColumn
            // 
            itemQuantityColumn.FillWeight = 18F;
            itemQuantityColumn.HeaderText = "Qty";
            itemQuantityColumn.MinimumWidth = 45;
            itemQuantityColumn.Name = "itemQuantityColumn";
            itemQuantityColumn.ReadOnly = true;
            // 
            // itemPriceColumn
            // 
            itemPriceColumn.FillWeight = 20F;
            itemPriceColumn.HeaderText = "Price";
            itemPriceColumn.MinimumWidth = 57;
            itemPriceColumn.Name = "itemPriceColumn";
            itemPriceColumn.ReadOnly = true;
            // 
            // itemAmountColumn
            // 
            itemAmountColumn.FillWeight = 19F;
            itemAmountColumn.HeaderText = "Total";
            itemAmountColumn.MinimumWidth = 60;
            itemAmountColumn.Name = "itemAmountColumn";
            itemAmountColumn.ReadOnly = true;
            // 
            // totalTableLayoutPanel
            // 
            totalTableLayoutPanel.ColumnCount = 1;
            totalTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            totalTableLayoutPanel.Controls.Add(amountTitleLabel, 0, 0);
            totalTableLayoutPanel.Controls.Add(amountValueLabel, 0, 1);
            totalTableLayoutPanel.Dock = DockStyle.Fill;
            totalTableLayoutPanel.Location = new Point(3, 555);
            totalTableLayoutPanel.Name = "totalTableLayoutPanel";
            totalTableLayoutPanel.RowCount = 2;
            totalTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            totalTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            totalTableLayoutPanel.Size = new Size(474, 42);
            totalTableLayoutPanel.TabIndex = 4;
            // 
            // amountTitleLabel
            // 
            amountTitleLabel.AutoSize = true;
            amountTitleLabel.Dock = DockStyle.Fill;
            amountTitleLabel.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            amountTitleLabel.Location = new Point(0, 0);
            amountTitleLabel.Margin = new Padding(0);
            amountTitleLabel.Name = "amountTitleLabel";
            amountTitleLabel.Size = new Size(474, 18);
            amountTitleLabel.TabIndex = 0;
            amountTitleLabel.Text = "Amount:";
            amountTitleLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // amountValueLabel
            // 
            amountValueLabel.AutoSize = true;
            amountValueLabel.Dock = DockStyle.Fill;
            amountValueLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 204);
            amountValueLabel.Location = new Point(0, 18);
            amountValueLabel.Margin = new Padding(0);
            amountValueLabel.Name = "amountValueLabel";
            amountValueLabel.Size = new Size(474, 24);
            amountValueLabel.TabIndex = 1;
            amountValueLabel.Text = "0,00";
            amountValueLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // idColumn
            // 
            idColumn.FillWeight = 14F;
            idColumn.HeaderText = "Id";
            idColumn.MinimumWidth = 38;
            idColumn.Name = "idColumn";
            idColumn.ReadOnly = true;
            // 
            // createdColumn
            // 
            createdColumn.FillWeight = 25F;
            createdColumn.HeaderText = "Created";
            createdColumn.MinimumWidth = 70;
            createdColumn.Name = "createdColumn";
            createdColumn.ReadOnly = true;
            // 
            // customerColumn
            // 
            customerColumn.FillWeight = 35F;
            customerColumn.HeaderText = "Customer Full Name";
            customerColumn.MinimumWidth = 90;
            customerColumn.Name = "customerColumn";
            customerColumn.ReadOnly = true;
            // 
            // addressColumn
            // 
            addressColumn.HeaderText = "Delivery Address";
            addressColumn.MinimumWidth = 6;
            addressColumn.Name = "addressColumn";
            addressColumn.ReadOnly = true;
            addressColumn.Visible = false;
            // 
            // amountColumn
            // 
            amountColumn.HeaderText = "Amount";
            amountColumn.MinimumWidth = 6;
            amountColumn.Name = "amountColumn";
            amountColumn.ReadOnly = true;
            amountColumn.Visible = false;
            // 
            // statusColumn
            // 
            statusColumn.FillWeight = 26F;
            statusColumn.HeaderText = "Order Status";
            statusColumn.MinimumWidth = 84;
            statusColumn.Name = "statusColumn";
            statusColumn.ReadOnly = true;
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(mainTableLayoutPanel);
            Name = "OrdersTab";
            Size = new Size(940, 620);
            Load += OrdersTab_Load;
            mainTableLayoutPanel.ResumeLayout(false);
            leftPanel.ResumeLayout(false);
            findPanel.ResumeLayout(false);
            findPanel.PerformLayout();
            leftTableLayoutPanel.ResumeLayout(false);
            leftTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).EndInit();
            rightPanel.ResumeLayout(false);
            rightTableLayoutPanel.ResumeLayout(false);
            rightTableLayoutPanel.PerformLayout();
            orderDetailsPanel.ResumeLayout(false);
            orderDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderItemsDataGridView).EndInit();
            totalTableLayoutPanel.ResumeLayout(false);
            totalTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTableLayoutPanel;
        private Panel leftPanel;
        private TableLayoutPanel leftTableLayoutPanel;
        private TableLayoutPanel findPanel;
        private Label findLabel;
        private TextBox findTextBox;
        private DataGridView ordersDataGridView;
        private Label ordersLabel;
        private Panel rightPanel;
        private TableLayoutPanel rightTableLayoutPanel;
        private Panel orderDetailsPanel;
        private Label selectedOrderLabel;
        private Label idLabel;
        private TextBox idTextBox;
        private Label createdLabel;
        private TextBox createdTextBox;
        private Label statusLabel;
        private ComboBox statusComboBox;
        private Controls.AddressControl deliveryAddressControl;
        private Label orderItemsLabel;
        private DataGridView orderItemsDataGridView;
        private DataGridViewTextBoxColumn itemNameColumn;
        private DataGridViewTextBoxColumn itemQuantityColumn;
        private DataGridViewTextBoxColumn itemPriceColumn;
        private DataGridViewTextBoxColumn itemAmountColumn;
        private TableLayoutPanel totalTableLayoutPanel;
        private Label amountTitleLabel;
        private Label amountValueLabel;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn createdColumn;
        private DataGridViewTextBoxColumn customerColumn;
        private DataGridViewTextBoxColumn addressColumn;
        private DataGridViewTextBoxColumn amountColumn;
        private DataGridViewTextBoxColumn statusColumn;
    }
}
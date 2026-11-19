using System.Xml.Linq;

namespace ObjectOrientedPractics.View
{
    partial class OrderControl
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            amountValueLabel = new Label();
            totalTableLayoutPanel = new TableLayoutPanel();
            amountTitleLabel = new Label();
            itemAmountColumn = new DataGridViewTextBoxColumn();
            itemPriceColumn = new DataGridViewTextBoxColumn();
            itemQuantityColumn = new DataGridViewTextBoxColumn();
            itemNameColumn = new DataGridViewTextBoxColumn();
            deliveryAddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            orderItemsLabel = new Label();
            orderItemsDataGridView = new DataGridView();
            selectedOrderLabel = new Label();
            orderDetailsPanel = new Panel();
            idLabel = new Label();
            idTextBox = new TextBox();
            createdLabel = new Label();
            createdTextBox = new TextBox();
            statusLabel = new Label();
            statusComboBox = new ComboBox();
            rightTableLayoutPanel = new TableLayoutPanel();
            totalTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderItemsDataGridView).BeginInit();
            orderDetailsPanel.SuspendLayout();
            rightTableLayoutPanel.SuspendLayout();
            SuspendLayout();
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
            // totalTableLayoutPanel
            // 
            totalTableLayoutPanel.ColumnCount = 1;
            totalTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            totalTableLayoutPanel.Controls.Add(amountTitleLabel, 0, 0);
            totalTableLayoutPanel.Controls.Add(amountValueLabel, 0, 1);
            totalTableLayoutPanel.Dock = DockStyle.Fill;
            totalTableLayoutPanel.Location = new Point(3, 585);
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
            // itemAmountColumn
            // 
            itemAmountColumn.FillWeight = 19F;
            itemAmountColumn.HeaderText = "Total";
            itemAmountColumn.MinimumWidth = 60;
            itemAmountColumn.Name = "itemAmountColumn";
            itemAmountColumn.ReadOnly = true;
            // 
            // itemPriceColumn
            // 
            itemPriceColumn.FillWeight = 20F;
            itemPriceColumn.HeaderText = "Price";
            itemPriceColumn.MinimumWidth = 57;
            itemPriceColumn.Name = "itemPriceColumn";
            itemPriceColumn.ReadOnly = true;
            // 
            // itemQuantityColumn
            // 
            itemQuantityColumn.FillWeight = 18F;
            itemQuantityColumn.HeaderText = "Qty";
            itemQuantityColumn.MinimumWidth = 45;
            itemQuantityColumn.Name = "itemQuantityColumn";
            itemQuantityColumn.ReadOnly = true;
            // 
            // itemNameColumn
            // 
            itemNameColumn.FillWeight = 43F;
            itemNameColumn.HeaderText = "Item";
            itemNameColumn.MinimumWidth = 6;
            itemNameColumn.Name = "itemNameColumn";
            itemNameColumn.ReadOnly = true;
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
            orderItemsDataGridView.Size = new Size(474, 223);
            orderItemsDataGridView.TabIndex = 3;
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
            rightTableLayoutPanel.Size = new Size(480, 630);
            rightTableLayoutPanel.TabIndex = 0;
            // 
            // OrderControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(rightTableLayoutPanel);
            Name = "OrderControl";
            Size = new Size(480, 630);
            totalTableLayoutPanel.ResumeLayout(false);
            totalTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)orderItemsDataGridView).EndInit();
            orderDetailsPanel.ResumeLayout(false);
            orderDetailsPanel.PerformLayout();
            rightTableLayoutPanel.ResumeLayout(false);
            rightTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label amountValueLabel;
        private TableLayoutPanel totalTableLayoutPanel;
        private Label amountTitleLabel;
        private DataGridViewTextBoxColumn itemAmountColumn;
        private DataGridViewTextBoxColumn itemPriceColumn;
        private DataGridViewTextBoxColumn itemQuantityColumn;
        private DataGridViewTextBoxColumn itemNameColumn;
        private Controls.AddressControl deliveryAddressControl;
        private Label orderItemsLabel;
        private DataGridView orderItemsDataGridView;
        private Label selectedOrderLabel;
        private Panel orderDetailsPanel;
        private Label idLabel;
        private TextBox idTextBox;
        private Label createdLabel;
        private TextBox createdTextBox;
        private Label statusLabel;
        private ComboBox statusComboBox;
        private TableLayoutPanel rightTableLayoutPanel;
    }
}

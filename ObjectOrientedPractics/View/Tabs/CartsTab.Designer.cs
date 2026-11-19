namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освобождает используемые ресурсы.
        /// </summary>
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
        /// Инициализирует интерфейс вкладки корзины.
        /// </summary>
        private void InitializeComponent()
        {
            TabTableLayout = new TableLayoutPanel();
            leftpanel = new Panel();
            leftLayoutPanel = new TableLayoutPanel();
            itemsLabel = new Label();
            itemsListBox = new ListBox();
            addToCartButton = new Button();
            rightPanel = new Panel();
            cartContentPanel = new Panel();
            customerLabel = new Label();
            customersComboBox = new ComboBox();
            cartLabel = new Label();
            cartListBox = new ListBox();
            amountLayoutPanel = new TableLayoutPanel();
            amountLabel = new Label();
            amountValueLabel = new Label();
            buttonsLayoutPanel = new TableLayoutPanel();
            createOrderButton = new Button();
            removeItemButton = new Button();
            clearCartButton = new Button();
            TabTableLayout.SuspendLayout();
            leftpanel.SuspendLayout();
            leftLayoutPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            cartContentPanel.SuspendLayout();
            amountLayoutPanel.SuspendLayout();
            buttonsLayoutPanel.SuspendLayout();
            SuspendLayout();
            //
            // TabTableLayout — основная сетка (левая 40%, правая 60%)
            //
            TabTableLayout.ColumnCount = 2;
            TabTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            TabTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            TabTableLayout.Controls.Add(leftpanel, 0, 0);
            TabTableLayout.Controls.Add(rightPanel, 1, 0);
            TabTableLayout.Dock = DockStyle.Fill;
            TabTableLayout.Location = new Point(0, 0);
            TabTableLayout.Margin = new Padding(0);
            TabTableLayout.Name = "TabTableLayout";
            TabTableLayout.Padding = new Padding(8);
            TabTableLayout.RowCount = 1;
            TabTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TabTableLayout.Size = new Size(842, 636);
            TabTableLayout.TabIndex = 0;
            //
            // leftpanel
            //
            leftpanel.BackColor = Color.White;
            leftpanel.Controls.Add(leftLayoutPanel);
            leftpanel.Dock = DockStyle.Fill;
            leftpanel.Margin = new Padding(0, 0, 5, 0);
            leftpanel.Name = "leftpanel";
            leftpanel.TabIndex = 0;
            //
            // leftLayoutPanel — заголовок, растягиваемый список, кнопка внизу
            //
            leftLayoutPanel.ColumnCount = 1;
            leftLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            leftLayoutPanel.Controls.Add(itemsLabel, 0, 0);
            leftLayoutPanel.Controls.Add(itemsListBox, 0, 1);
            leftLayoutPanel.Controls.Add(addToCartButton, 0, 2);
            leftLayoutPanel.Dock = DockStyle.Fill;
            leftLayoutPanel.Margin = new Padding(0);
            leftLayoutPanel.Name = "leftLayoutPanel";
            leftLayoutPanel.Padding = new Padding(5);
            leftLayoutPanel.RowCount = 3;
            leftLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            leftLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            leftLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            leftLayoutPanel.TabIndex = 0;
            //
            // itemsLabel
            //
            itemsLabel.Anchor = AnchorStyles.Left;
            itemsLabel.AutoSize = true;
            itemsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            itemsLabel.Margin = new Padding(3, 0, 3, 0);
            itemsLabel.Name = "itemsLabel";
            itemsLabel.TabIndex = 0;
            itemsLabel.Text = "Items";
            //
            // itemsListBox
            //
            itemsListBox.Dock = DockStyle.Fill;
            itemsListBox.FormattingEnabled = true;
            itemsListBox.IntegralHeight = false;
            itemsListBox.Margin = new Padding(3, 0, 3, 5);
            itemsListBox.Name = "itemsListBox";
            itemsListBox.TabIndex = 1;
            //
            // addToCartButton
            //
            addToCartButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addToCartButton.AutoSize = false;
            addToCartButton.Margin = new Padding(3, 3, 3, 5);
            addToCartButton.Name = "addToCartButton";
            addToCartButton.Size = new Size(110, 35);
            addToCartButton.TabIndex = 2;
            addToCartButton.Text = "Add To Cart";
            addToCartButton.UseVisualStyleBackColor = true;
            //
            // rightPanel
            //
            rightPanel.BackColor = Color.White;
            rightPanel.AutoScroll = true;
            rightPanel.AutoScrollMinSize = new Size(385, 405);
            rightPanel.Controls.Add(cartContentPanel);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Margin = new Padding(5, 0, 0, 0);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(489, 620);
            rightPanel.TabIndex = 1;
            //
            // cartContentPanel — общая ширина Customer, Cart, суммы и кнопок.
            // Предел 800 px как в блоке Name на ItemsTab.
            // По высоте этот блок занимает только верхнюю часть правой области.
            //
            cartContentPanel.BackColor = Color.White;
            cartContentPanel.Controls.Add(buttonsLayoutPanel);
            cartContentPanel.Controls.Add(amountLayoutPanel);
            cartContentPanel.Controls.Add(cartListBox);
            cartContentPanel.Controls.Add(cartLabel);
            cartContentPanel.Controls.Add(customersComboBox);
            cartContentPanel.Controls.Add(customerLabel);
            cartContentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cartContentPanel.Location = new Point(12, 0);
            cartContentPanel.MaximumSize = new Size(800, 400);
            cartContentPanel.Name = "cartContentPanel";
            cartContentPanel.Size = new Size(458, 400);
            cartContentPanel.TabIndex = 0;
            //
            // customerLabel
            //
            customerLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            customerLabel.Location = new Point(0, 18);
            customerLabel.AutoSize = true;
            customerLabel.Margin = new Padding(3, 0, 2, 0);
            customerLabel.Name = "customerLabel";
            customerLabel.TabIndex = 0;
            customerLabel.Text = "Customer:";
            //
            // customersComboBox
            //
            customersComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            customersComboBox.Location = new Point(88, 12);
            customersComboBox.Size = new Size(370, 28);
            customersComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            customersComboBox.FormattingEnabled = true;
            customersComboBox.Margin = new Padding(0, 4, 3, 4);
            customersComboBox.Name = "customersComboBox";
            customersComboBox.TabIndex = 1;
            //
            // cartLabel
            //
            cartLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            cartLabel.Location = new Point(0, 56);
            cartLabel.AutoSize = true;
            cartLabel.Margin = new Padding(3, 0, 3, 0);
            cartLabel.Name = "cartLabel";
            cartLabel.TabIndex = 2;
            cartLabel.Text = "Cart:";
            //
            // cartListBox
            //
            cartListBox.BorderStyle = BorderStyle.FixedSingle;
            cartListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cartListBox.Location = new Point(0, 82);
            cartListBox.Size = new Size(458, 180);
            cartListBox.Visible = true;
            cartListBox.IntegralHeight = false;
            cartListBox.Margin = new Padding(3, 0, 3, 4);
            cartListBox.Name = "cartListBox";
            cartListBox.TabIndex = 3;
            //
            // amountLayoutPanel
            //
            amountLayoutPanel.ColumnCount = 1;
            amountLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            amountLayoutPanel.Controls.Add(amountLabel, 0, 0);
            amountLayoutPanel.Controls.Add(amountValueLabel, 0, 1);
            amountLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            amountLayoutPanel.Location = new Point(0, 264);
            amountLayoutPanel.Size = new Size(458, 58);
            amountLayoutPanel.Margin = new Padding(0);
            amountLayoutPanel.Name = "amountLayoutPanel";
            amountLayoutPanel.RowCount = 2;
            amountLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            amountLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            amountLayoutPanel.TabIndex = 4;
            //
            // amountLabel
            //
            amountLabel.Anchor = AnchorStyles.Right;
            amountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            amountLabel.AutoSize = false;
            amountLabel.Margin = new Padding(0, 0, 3, 0);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(125, 24);
            amountLabel.TabIndex = 0;
            amountLabel.Text = "Amount:";
            amountLabel.TextAlign = ContentAlignment.MiddleRight;
            //
            // amountValueLabel
            //
            amountValueLabel.Anchor = AnchorStyles.Right;
            amountValueLabel.AutoSize = false;
            amountValueLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            amountValueLabel.Margin = new Padding(0, 0, 3, 0);
            amountValueLabel.Name = "amountValueLabel";
            amountValueLabel.Size = new Size(125, 24);
            amountValueLabel.TabIndex = 1;
            amountValueLabel.Text = "0,00";
            amountValueLabel.TextAlign = ContentAlignment.MiddleRight;
            //
            // buttonsLayoutPanel
            //
            buttonsLayoutPanel.ColumnCount = 4;
            buttonsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 118F));
            buttonsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            buttonsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 118F));
            buttonsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 118F));
            buttonsLayoutPanel.Controls.Add(createOrderButton, 0, 0);
            buttonsLayoutPanel.Controls.Add(removeItemButton, 2, 0);
            buttonsLayoutPanel.Controls.Add(clearCartButton, 3, 0);
            buttonsLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonsLayoutPanel.Location = new Point(0, 329);
            buttonsLayoutPanel.Size = new Size(458, 52);
            buttonsLayoutPanel.Margin = new Padding(0);
            buttonsLayoutPanel.Name = "buttonsLayoutPanel";
            buttonsLayoutPanel.RowCount = 1;
            buttonsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            buttonsLayoutPanel.TabIndex = 5;
            //
            // createOrderButton
            //
            createOrderButton.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            createOrderButton.Margin = new Padding(3, 5, 3, 4);
            createOrderButton.Name = "createOrderButton";
            createOrderButton.Size = new Size(110, 35);
            createOrderButton.TabIndex = 0;
            createOrderButton.Text = "Create Order";
            createOrderButton.UseVisualStyleBackColor = true;
            //
            // removeItemButton
            //
            removeItemButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            removeItemButton.Margin = new Padding(3, 5, 3, 4);
            removeItemButton.Name = "removeItemButton";
            removeItemButton.Size = new Size(110, 35);
            removeItemButton.TabIndex = 1;
            removeItemButton.Text = "Remove Item";
            removeItemButton.UseVisualStyleBackColor = true;
            //
            // clearCartButton
            //
            clearCartButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            clearCartButton.Margin = new Padding(3, 5, 3, 4);
            clearCartButton.Name = "clearCartButton";
            clearCartButton.Size = new Size(110, 35);
            clearCartButton.TabIndex = 2;
            clearCartButton.Text = "Clear Cart";
            clearCartButton.UseVisualStyleBackColor = true;
            //
            // CartsTab
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TabTableLayout);
            Name = "CartsTab";
            Size = new Size(842, 636);
            Load += CartsTab_Load;
            buttonsLayoutPanel.ResumeLayout(false);
            amountLayoutPanel.ResumeLayout(false);
            cartContentPanel.ResumeLayout(false);
            cartContentPanel.PerformLayout();
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            leftLayoutPanel.ResumeLayout(false);
            leftLayoutPanel.PerformLayout();
            leftpanel.ResumeLayout(false);
            TabTableLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel TabTableLayout;
        private Panel leftpanel;
        private TableLayoutPanel leftLayoutPanel;
        private Label itemsLabel;
        private ListBox itemsListBox;
        private Button addToCartButton;
        private Panel rightPanel;
        private Panel cartContentPanel;
        private Label customerLabel;
        private ComboBox customersComboBox;
        private Label cartLabel;
        private ListBox cartListBox;
        private TableLayoutPanel amountLayoutPanel;
        private Label amountLabel;
        private Label amountValueLabel;
        private TableLayoutPanel buttonsLayoutPanel;
        private Button createOrderButton;
        private Button removeItemButton;
        private Button clearCartButton;
    }
}

namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            CustomersLabel = new Label();
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            button2 = new Button();
            LeftPanel = new Panel();
            TabTableLayout = new TableLayoutPanel();
            GenerateCustomerButton = new Button();
            LeftButton = new Button();
            RightButton = new Button();
            СustomersListBox = new ListBox();
            NameTextBox = new TextBox();
            CostLabel = new Label();
            IdLabel = new Label();
            IdTextBox = new TextBox();
            SelectedItemTabel = new Label();
            CostTextBox = new TextBox();
            TableLayout = new TableLayoutPanel();
            RightPanel = new Panel();
            SelectedCustomerPanel = new Panel();
            PanelLabel = new Label();
            NameLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            LeftPanel.SuspendLayout();
            TabTableLayout.SuspendLayout();
            TableLayout.SuspendLayout();
            RightPanel.SuspendLayout();
            SelectedCustomerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CustomersLabel
            // 
            CustomersLabel.AutoSize = true;
            CustomersLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CustomersLabel.Location = new Point(3, 11);
            CustomersLabel.Name = "CustomersLabel";
            CustomersLabel.Size = new Size(84, 20);
            CustomersLabel.TabIndex = 0;
            CustomersLabel.Text = "Сustomers";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(141, 50);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Location = new Point(3, 1101);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(443, 56);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.Transparent;
            button2.Location = new Point(150, 3);
            button2.Name = "button2";
            button2.Size = new Size(141, 50);
            button2.TabIndex = 1;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = false;
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = Color.White;
            LeftPanel.Controls.Add(TabTableLayout);
            LeftPanel.Controls.Add(tableLayoutPanel1);
            LeftPanel.Controls.Add(СustomersListBox);
            LeftPanel.Controls.Add(CustomersLabel);
            LeftPanel.Dock = DockStyle.Fill;
            LeftPanel.Location = new Point(3, 3);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(336, 666);
            LeftPanel.TabIndex = 2;
            // 
            // TabTableLayout
            // 
            TabTableLayout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabTableLayout.ColumnCount = 3;
            TabTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            TabTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            TabTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            TabTableLayout.Controls.Add(GenerateCustomerButton, 2, 0);
            TabTableLayout.Controls.Add(LeftButton, 0, 0);
            TabTableLayout.Controls.Add(RightButton, 1, 0);
            TabTableLayout.Location = new Point(6, 604);
            TabTableLayout.Name = "TabTableLayout";
            TabTableLayout.RowCount = 1;
            TabTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TabTableLayout.Size = new Size(318, 56);
            TabTableLayout.TabIndex = 10;
            // 
            // GenerateCustomerButton
            // 
            GenerateCustomerButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GenerateCustomerButton.Location = new Point(215, 3);
            GenerateCustomerButton.Name = "GenerateCustomerButton";
            GenerateCustomerButton.Size = new Size(100, 50);
            GenerateCustomerButton.TabIndex = 3;
            GenerateCustomerButton.Text = "Generate a customer";
            GenerateCustomerButton.UseVisualStyleBackColor = true;
            GenerateCustomerButton.Click += GenerateCustomerButton_Click_1;
            // 
            // LeftButton
            // 
            LeftButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LeftButton.BackColor = Color.Transparent;
            LeftButton.ForeColor = SystemColors.ControlText;
            LeftButton.Location = new Point(3, 3);
            LeftButton.Name = "LeftButton";
            LeftButton.Size = new Size(100, 50);
            LeftButton.TabIndex = 0;
            LeftButton.Text = "Add";
            LeftButton.UseVisualStyleBackColor = false;
            // 
            // RightButton
            // 
            RightButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RightButton.BackColor = Color.Transparent;
            RightButton.Location = new Point(109, 3);
            RightButton.Name = "RightButton";
            RightButton.Size = new Size(100, 50);
            RightButton.TabIndex = 1;
            RightButton.Text = "Remove";
            RightButton.UseVisualStyleBackColor = false;
            // 
            // СustomersListBox
            // 
            СustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            СustomersListBox.FormattingEnabled = true;
            СustomersListBox.IntegralHeight = false;
            СustomersListBox.Location = new Point(6, 37);
            СustomersListBox.Name = "СustomersListBox";
            СustomersListBox.Size = new Size(318, 564);
            СustomersListBox.TabIndex = 1;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.BorderStyle = BorderStyle.FixedSingle;
            NameTextBox.Location = new Point(84, 112);
            NameTextBox.MaximumSize = new Size(800, 98);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(425, 98);
            NameTextBox.TabIndex = 6;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(3, 81);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(79, 20);
            CostLabel.TabIndex = 4;
            CostLabel.Text = "Full Name:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(3, 48);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(27, 20);
            IdLabel.TabIndex = 3;
            IdLabel.Text = "ID:";
            // 
            // IdTextBox
            // 
            IdTextBox.BorderStyle = BorderStyle.FixedSingle;
            IdTextBox.Location = new Point(84, 46);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(186, 27);
            IdTextBox.TabIndex = 1;
            // 
            // SelectedItemTabel
            // 
            SelectedItemTabel.AutoSize = true;
            SelectedItemTabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedItemTabel.Location = new Point(3, 11);
            SelectedItemTabel.Name = "SelectedItemTabel";
            SelectedItemTabel.Size = new Size(139, 20);
            SelectedItemTabel.TabIndex = 0;
            SelectedItemTabel.Text = "Selected Customer";
            // 
            // CostTextBox
            // 
            CostTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CostTextBox.BorderStyle = BorderStyle.FixedSingle;
            CostTextBox.Location = new Point(84, 79);
            CostTextBox.MaximumSize = new Size(800, 27);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(425, 27);
            CostTextBox.TabIndex = 2;
            // 
            // TableLayout
            // 
            TableLayout.BackColor = Color.Transparent;
            TableLayout.ColumnCount = 2;
            TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.875F));
            TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.125F));
            TableLayout.Controls.Add(RightPanel, 1, 0);
            TableLayout.Controls.Add(LeftPanel, 0, 0);
            TableLayout.Dock = DockStyle.Fill;
            TableLayout.Location = new Point(0, 0);
            TableLayout.Name = "TableLayout";
            TableLayout.RowCount = 1;
            TableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayout.Size = new Size(860, 672);
            TableLayout.TabIndex = 1;
            // 
            // RightPanel
            // 
            RightPanel.BackColor = Color.White;
            RightPanel.Controls.Add(SelectedCustomerPanel);
            RightPanel.Controls.Add(NameTextBox);
            RightPanel.Controls.Add(NameLabel);
            RightPanel.Controls.Add(CostLabel);
            RightPanel.Controls.Add(IdLabel);
            RightPanel.Controls.Add(CostTextBox);
            RightPanel.Controls.Add(IdTextBox);
            RightPanel.Controls.Add(SelectedItemTabel);
            RightPanel.Dock = DockStyle.Fill;
            RightPanel.Location = new Point(345, 3);
            RightPanel.Name = "RightPanel";
            RightPanel.Size = new Size(512, 666);
            RightPanel.TabIndex = 1;
            // 
            // SelectedCustomerPanel
            // 
            SelectedCustomerPanel.Controls.Add(PanelLabel);
            SelectedCustomerPanel.Location = new Point(3, 216);
            SelectedCustomerPanel.Name = "SelectedCustomerPanel";
            SelectedCustomerPanel.Size = new Size(506, 444);
            SelectedCustomerPanel.TabIndex = 8;
            // 
            // PanelLabel
            // 
            PanelLabel.AutoSize = true;
            PanelLabel.Location = new Point(215, 202);
            PanelLabel.Name = "PanelLabel";
            PanelLabel.Size = new Size(52, 20);
            PanelLabel.TabIndex = 0;
            PanelLabel.Text = "Panel2";
            PanelLabel.Click += label2_Click_1;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(3, 114);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(65, 20);
            NameLabel.TabIndex = 5;
            NameLabel.Text = "Address:";
            NameLabel.Click += NameLabel_Click;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableLayout);
            Name = "CustomersTab";
            Size = new Size(860, 672);
            tableLayoutPanel1.ResumeLayout(false);
            LeftPanel.ResumeLayout(false);
            LeftPanel.PerformLayout();
            TabTableLayout.ResumeLayout(false);
            TableLayout.ResumeLayout(false);
            RightPanel.ResumeLayout(false);
            RightPanel.PerformLayout();
            SelectedCustomerPanel.ResumeLayout(false);
            SelectedCustomerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label CustomersLabel;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button2;
        private Panel LeftPanel;
        private ListBox СustomersListBox;
        private TextBox NameTextBox;
        private Label CostLabel;
        private Label IdLabel;
        private TextBox IdTextBox;
        private Label SelectedItemTabel;
        private TextBox CostTextBox;
        private TableLayoutPanel TableLayout;
        private Panel RightPanel;
        private TableLayoutPanel TabTableLayout;
        private Button LeftButton;
        private Button RightButton;
        private Panel SelectedCustomerPanel;
        private Label PanelLabel;
        private Button GenerateCustomerButton;
        private Label NameLabel;
    }
}

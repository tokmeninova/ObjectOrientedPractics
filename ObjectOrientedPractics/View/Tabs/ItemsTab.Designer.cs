namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsListBox
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
            TabTableLayout = new TableLayoutPanel();
            RightPanel = new Panel();
            DescriptionTextBox = new TextBox();
            DescriptionLabel = new Label();
            NameTextBox = new TextBox();
            NameLabel = new Label();
            CostLabel = new Label();
            IdLabel = new Label();
            CostTextBox = new TextBox();
            IdTextBox = new TextBox();
            SelectedItemTabel = new Label();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            GenerateItemButton = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            TabTableLayout.SuspendLayout();
            RightPanel.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // TabTableLayout
            // 
            TabTableLayout.BackColor = Color.Transparent;
            TabTableLayout.ColumnCount = 2;
            TabTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.875F));
            TabTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.125F));
            TabTableLayout.Controls.Add(RightPanel, 1, 0);
            TabTableLayout.Controls.Add(panel1, 0, 0);
            TabTableLayout.Dock = DockStyle.Fill;
            TabTableLayout.Location = new Point(0, 0);
            TabTableLayout.Name = "TabTableLayout";
            TabTableLayout.RowCount = 1;
            TabTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TabTableLayout.Size = new Size(800, 600);
            TabTableLayout.TabIndex = 0;
            // 
            // RightPanel
            // 
            RightPanel.BackColor = Color.White;
            RightPanel.Controls.Add(DescriptionTextBox);
            RightPanel.Controls.Add(DescriptionLabel);
            RightPanel.Controls.Add(NameTextBox);
            RightPanel.Controls.Add(NameLabel);
            RightPanel.Controls.Add(CostLabel);
            RightPanel.Controls.Add(IdLabel);
            RightPanel.Controls.Add(CostTextBox);
            RightPanel.Controls.Add(IdTextBox);
            RightPanel.Controls.Add(SelectedItemTabel);
            RightPanel.Dock = DockStyle.Fill;
            RightPanel.Location = new Point(322, 3);
            RightPanel.Name = "RightPanel";
            RightPanel.Size = new Size(475, 594);
            RightPanel.TabIndex = 1;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionTextBox.BorderStyle = BorderStyle.FixedSingle;
            DescriptionTextBox.Location = new Point(13, 278);
            DescriptionTextBox.MaximumSize = new Size(800, 164);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(459, 164);
            DescriptionTextBox.TabIndex = 8;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(13, 255);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(88, 20);
            DescriptionLabel.TabIndex = 7;
            DescriptionLabel.Text = "Description:";
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.BorderStyle = BorderStyle.FixedSingle;
            NameTextBox.Location = new Point(13, 135);
            NameTextBox.MaximumSize = new Size(800, 98);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(459, 98);
            NameTextBox.TabIndex = 6;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(13, 112);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(52, 20);
            NameLabel.TabIndex = 5;
            NameLabel.Text = "Name:";
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(13, 73);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(41, 20);
            CostLabel.TabIndex = 4;
            CostLabel.Text = "Cost:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(13, 37);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(27, 20);
            IdLabel.TabIndex = 3;
            IdLabel.Text = "ID:";
            IdLabel.Click += IdLabel_Click;
            // 
            // CostTextBox
            // 
            CostTextBox.BorderStyle = BorderStyle.FixedSingle;
            CostTextBox.Location = new Point(85, 70);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(151, 27);
            CostTextBox.TabIndex = 2;
            // 
            // IdTextBox
            // 
            IdTextBox.BorderStyle = BorderStyle.FixedSingle;
            IdTextBox.Location = new Point(85, 34);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(151, 27);
            IdTextBox.TabIndex = 1;
            // 
            // SelectedItemTabel
            // 
            SelectedItemTabel.AutoSize = true;
            SelectedItemTabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedItemTabel.Location = new Point(13, 11);
            SelectedItemTabel.Name = "SelectedItemTabel";
            SelectedItemTabel.Size = new Size(104, 20);
            SelectedItemTabel.TabIndex = 0;
            SelectedItemTabel.Text = "Selected Item";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 594);
            panel1.TabIndex = 2;
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
            tableLayoutPanel1.Controls.Add(GenerateItemButton, 2, 0);
            tableLayoutPanel1.Location = new Point(3, 535);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(307, 56);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(96, 50);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.Transparent;
            button2.Location = new Point(105, 3);
            button2.Name = "button2";
            button2.Size = new Size(96, 50);
            button2.TabIndex = 1;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = false;
            // 
            // GenerateItemButton
            // 
            GenerateItemButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GenerateItemButton.Location = new Point(207, 3);
            GenerateItemButton.Name = "GenerateItemButton";
            GenerateItemButton.Size = new Size(97, 50);
            GenerateItemButton.TabIndex = 2;
            GenerateItemButton.Text = "Generate a product";
            GenerateItemButton.UseVisualStyleBackColor = true;
            GenerateItemButton.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.IntegralHeight = false;
            listBox1.Location = new Point(3, 37);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(307, 492);
            listBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Items";
            // 
            // ItemsListBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TabTableLayout);
            Name = "ItemsListBox";
            Size = new Size(800, 600);
            TabTableLayout.ResumeLayout(false);
            RightPanel.ResumeLayout(false);
            RightPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TabTableLayout;
        private Panel RightPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
        private TextBox DescriptionTextBox;
        private Label DescriptionLabel;
        private TextBox NameTextBox;
        private Label NameLabel;
        private Label CostLabel;
        private Label IdLabel;
        private TextBox CostTextBox;
        private TextBox IdTextBox;
        private Label SelectedItemTabel;
        private Panel panel1;
        private ListBox listBox1;
        private Label label1;
        private Button GenerateItemButton;
    }
}

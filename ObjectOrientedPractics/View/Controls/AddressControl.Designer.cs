namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            DeliveryAddressLabel = new Label();
            IndexLabel = new Label();
            IndexTextBox = new TextBox();
            CountryLabel = new Label();
            CountryTextBox = new TextBox();
            CityLabel = new Label();
            CityTextBox = new TextBox();
            StreetLabel = new Label();
            StreetTextBox = new TextBox();
            BuildingLabel = new Label();
            BuildingTextBox = new TextBox();
            ApartmentLabel = new Label();
            ApartmentTextBox = new TextBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(470, 200);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 86F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 97F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(DeliveryAddressLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(IndexLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(IndexTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(CountryLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(CountryTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(CityLabel, 2, 2);
            tableLayoutPanel1.Controls.Add(CityTextBox, 3, 2);
            tableLayoutPanel1.Controls.Add(StreetLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(StreetTextBox, 1, 3);
            tableLayoutPanel1.Controls.Add(BuildingLabel, 0, 4);
            tableLayoutPanel1.Controls.Add(BuildingTextBox, 1, 4);
            tableLayoutPanel1.Controls.Add(ApartmentLabel, 2, 4);
            tableLayoutPanel1.Controls.Add(ApartmentTextBox, 3, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.MinimumSize = new Size(350, 183);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(7, 2, 0, 0);
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(470, 200);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // DeliveryAddressLabel
            // 
            DeliveryAddressLabel.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(DeliveryAddressLabel, 4);
            DeliveryAddressLabel.Dock = DockStyle.Fill;
            DeliveryAddressLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DeliveryAddressLabel.Location = new Point(10, 2);
            DeliveryAddressLabel.Name = "DeliveryAddressLabel";
            DeliveryAddressLabel.Size = new Size(457, 38);
            DeliveryAddressLabel.TabIndex = 0;
            DeliveryAddressLabel.Text = "Delivery Address";
            DeliveryAddressLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // IndexLabel
            // 
            IndexLabel.AutoSize = true;
            IndexLabel.Dock = DockStyle.Fill;
            IndexLabel.Location = new Point(10, 40);
            IndexLabel.Name = "IndexLabel";
            IndexLabel.Size = new Size(80, 36);
            IndexLabel.TabIndex = 1;
            IndexLabel.Text = "Post Index:";
            IndexLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // IndexTextBox
            // 
            IndexTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            IndexTextBox.BorderStyle = BorderStyle.FixedSingle;
            IndexTextBox.Location = new Point(96, 44);
            IndexTextBox.Margin = new Padding(3, 3, 6, 3);
            IndexTextBox.MaximumSize = new Size(125, 28);
            IndexTextBox.Name = "IndexTextBox";
            IndexTextBox.Size = new Size(125, 27);
            IndexTextBox.TabIndex = 0;
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Dock = DockStyle.Fill;
            CountryLabel.Location = new Point(10, 76);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(80, 36);
            CountryLabel.TabIndex = 2;
            CountryLabel.Text = "Country:";
            CountryLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CountryTextBox
            // 
            CountryTextBox.BorderStyle = BorderStyle.FixedSingle;
            CountryTextBox.Dock = DockStyle.Fill;
            CountryTextBox.Location = new Point(96, 80);
            CountryTextBox.Margin = new Padding(3, 4, 8, 5);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(129, 27);
            CountryTextBox.TabIndex = 1;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Dock = DockStyle.Fill;
            CityLabel.Location = new Point(236, 76);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(91, 36);
            CityLabel.TabIndex = 3;
            CityLabel.Text = "City:";
            CityLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CityTextBox
            // 
            CityTextBox.BorderStyle = BorderStyle.FixedSingle;
            CityTextBox.Dock = DockStyle.Fill;
            CityTextBox.Location = new Point(333, 80);
            CityTextBox.Margin = new Padding(3, 4, 0, 5);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(137, 27);
            CityTextBox.TabIndex = 2;
            // 
            // StreetLabel
            // 
            StreetLabel.AutoSize = true;
            StreetLabel.Dock = DockStyle.Fill;
            StreetLabel.Location = new Point(10, 112);
            StreetLabel.Name = "StreetLabel";
            StreetLabel.Size = new Size(80, 36);
            StreetLabel.TabIndex = 4;
            StreetLabel.Text = "Street:";
            StreetLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // StreetTextBox
            // 
            StreetTextBox.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanel1.SetColumnSpan(StreetTextBox, 3);
            StreetTextBox.Dock = DockStyle.Fill;
            StreetTextBox.Location = new Point(96, 116);
            StreetTextBox.Margin = new Padding(3, 4, 0, 5);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(374, 27);
            StreetTextBox.TabIndex = 3;
            // 
            // BuildingLabel
            // 
            BuildingLabel.AutoSize = true;
            BuildingLabel.Dock = DockStyle.Fill;
            BuildingLabel.Location = new Point(10, 148);
            BuildingLabel.Name = "BuildingLabel";
            BuildingLabel.Size = new Size(80, 36);
            BuildingLabel.TabIndex = 5;
            BuildingLabel.Text = "Building:";
            BuildingLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BuildingTextBox
            // 
            BuildingTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BuildingTextBox.BorderStyle = BorderStyle.FixedSingle;
            BuildingTextBox.Location = new Point(96, 152);
            BuildingTextBox.Margin = new Padding(3, 3, 8, 3);
            BuildingTextBox.MaximumSize = new Size(125, 28);
            BuildingTextBox.Name = "BuildingTextBox";
            BuildingTextBox.Size = new Size(125, 27);
            BuildingTextBox.TabIndex = 4;
            // 
            // ApartmentLabel
            // 
            ApartmentLabel.AutoSize = true;
            ApartmentLabel.Dock = DockStyle.Fill;
            ApartmentLabel.Location = new Point(236, 148);
            ApartmentLabel.Name = "ApartmentLabel";
            ApartmentLabel.Size = new Size(91, 36);
            ApartmentLabel.TabIndex = 6;
            ApartmentLabel.Text = "Apartment:";
            ApartmentLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ApartmentTextBox
            // 
            ApartmentTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ApartmentTextBox.BorderStyle = BorderStyle.FixedSingle;
            ApartmentTextBox.Location = new Point(333, 152);
            ApartmentTextBox.Margin = new Padding(3, 3, 0, 3);
            ApartmentTextBox.Name = "ApartmentTextBox";
            ApartmentTextBox.Size = new Size(137, 27);
            ApartmentTextBox.TabIndex = 5;
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            MinimumSize = new Size(0, 183);
            Name = "AddressControl";
            Size = new Size(470, 200);
            Load += AddressControl_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TextBox BuildingTextBox;
        private TextBox CityTextBox;
        private TextBox ApartmentTextBox;
        private TextBox CountryTextBox;
        private Label ApartmentLabel;
        private TextBox StreetTextBox;
        private TextBox IndexTextBox;
        private Label DeliveryAddressLabel;
        private Label StreetLabel;
        private Label IndexLabel;
        private Label BuildingLabel;
        private Label CountryLabel;
        private Label CityLabel;
    }
}

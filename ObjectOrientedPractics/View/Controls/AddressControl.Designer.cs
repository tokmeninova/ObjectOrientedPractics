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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            DeliveryAddressLabel = new Label();
            ApartmentTextBox = new TextBox();
            BuildingLabel = new Label();
            StreetLabel = new Label();
            CountryLabel = new Label();
            CityLabel = new Label();
            IndexLabel = new Label();
            StreetTextBox = new TextBox();
            BuildingTextBox = new TextBox();
            CityTextBox = new TextBox();
            ApartmentLabel = new Label();
            IndexTextBox = new TextBox();
            CountryTextBox = new TextBox();
            SuspendLayout();
            // 
            // DeliveryAddressLabel
            // 
            DeliveryAddressLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeliveryAddressLabel.AutoSize = true;
            DeliveryAddressLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DeliveryAddressLabel.Location = new Point(20, 20);
            DeliveryAddressLabel.Name = "DeliveryAddressLabel";
            DeliveryAddressLabel.Size = new Size(128, 20);
            DeliveryAddressLabel.TabIndex = 6;
            DeliveryAddressLabel.Text = "Delivery Address";
            // 
            // ApartmentTextBox
            // 
            ApartmentTextBox.BorderStyle = BorderStyle.FixedSingle;
            ApartmentTextBox.Location = new Point(335, 177);
            ApartmentTextBox.Name = "ApartmentTextBox";
            ApartmentTextBox.Size = new Size(105, 27);
            ApartmentTextBox.TabIndex = 8;
            ApartmentTextBox.TextChanged += ApartmentTextBox_TextChanged;
            // 
            // BuildingLabel
            // 
            BuildingLabel.AutoSize = true;
            BuildingLabel.Location = new Point(20, 178);
            BuildingLabel.Name = "BuildingLabel";
            BuildingLabel.Size = new Size(67, 20);
            BuildingLabel.TabIndex = 4;
            BuildingLabel.Text = "Building:";
            // 
            // StreetLabel
            // 
            StreetLabel.AutoSize = true;
            StreetLabel.Location = new Point(20, 139);
            StreetLabel.Name = "StreetLabel";
            StreetLabel.Size = new Size(51, 20);
            StreetLabel.TabIndex = 3;
            StreetLabel.Text = "Street:";
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Location = new Point(20, 99);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(63, 20);
            CountryLabel.TabIndex = 1;
            CountryLabel.Text = "Country:";
            CountryLabel.Click += CountryLabel_Click;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(307, 99);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(37, 20);
            CityLabel.TabIndex = 2;
            CityLabel.Text = "City:";
            // 
            // IndexLabel
            // 
            IndexLabel.AutoSize = true;
            IndexLabel.Location = new Point(20, 59);
            IndexLabel.Name = "IndexLabel";
            IndexLabel.Size = new Size(79, 20);
            IndexLabel.TabIndex = 0;
            IndexLabel.Text = "Post Index:";
            IndexLabel.Click += IndexLabel_Click;
            // 
            // StreetTextBox
            // 
            StreetTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StreetTextBox.BorderStyle = BorderStyle.FixedSingle;
            StreetTextBox.Location = new Point(105, 137);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(435, 27);
            StreetTextBox.TabIndex = 10;
            // 
            // BuildingTextBox
            // 
            BuildingTextBox.BorderStyle = BorderStyle.FixedSingle;
            BuildingTextBox.Location = new Point(105, 177);
            BuildingTextBox.Name = "BuildingTextBox";
            BuildingTextBox.Size = new Size(115, 27);
            BuildingTextBox.TabIndex = 12;
            // 
            // CityTextBox
            // 
            CityTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CityTextBox.BorderStyle = BorderStyle.FixedSingle;
            CityTextBox.Location = new Point(350, 97);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(190, 27);
            CityTextBox.TabIndex = 9;
            // 
            // ApartmentLabel
            // 
            ApartmentLabel.AutoSize = true;
            ApartmentLabel.Location = new Point(246, 179);
            ApartmentLabel.Name = "ApartmentLabel";
            ApartmentLabel.Size = new Size(83, 20);
            ApartmentLabel.TabIndex = 5;
            ApartmentLabel.Text = "Apartment:";
            // 
            // IndexTextBox
            // 
            IndexTextBox.BorderStyle = BorderStyle.FixedSingle;
            IndexTextBox.Location = new Point(105, 57);
            IndexTextBox.Name = "IndexTextBox";
            IndexTextBox.Size = new Size(115, 27);
            IndexTextBox.TabIndex = 7;
            IndexTextBox.TextChanged += IndexTextBox_TextChanged;
            // 
            // CountryTextBox
            // 
            CountryTextBox.BorderStyle = BorderStyle.FixedSingle;
            CountryTextBox.Location = new Point(105, 97);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(190, 27);
            CountryTextBox.TabIndex = 14;
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BuildingTextBox);
            Controls.Add(CityTextBox);
            Controls.Add(ApartmentTextBox);
            Controls.Add(CountryTextBox);
            Controls.Add(ApartmentLabel);
            Controls.Add(StreetTextBox);
            Controls.Add(IndexTextBox);
            Controls.Add(DeliveryAddressLabel);
            Controls.Add(StreetLabel);
            Controls.Add(IndexLabel);
            Controls.Add(BuildingLabel);
            Controls.Add(CountryLabel);
            Controls.Add(CityLabel);
            Name = "AddressControl";
            Size = new Size(743, 355);
            Load += AddressControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label DeliveryAddressLabel;
        private TextBox ApartmentTextBox;
        private Label BuildingLabel;
        private Label StreetLabel;
        private Label CountryLabel;
        private Label CityLabel;
        private Label IndexLabel;
        private TextBox StreetTextBox;
        private TextBox BuildingTextBox;
        private TextBox CityTextBox;
        private Label ApartmentLabel;
        private TextBox IndexTextBox;
        private TextBox CountryTextBox;
    }
}

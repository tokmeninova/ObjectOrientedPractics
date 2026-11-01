using System.ComponentModel;
using ObjectOrientedPractics.Model;



namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Элемент управления для работы с адресом доставки.
    /// </summary>
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Объект адреса доставки.
        /// </summary>
        private Address _address = new Address();
        /// <summary>
        /// Указывает, выполняется ли программное обновление полей.
        /// </summary>
        private bool _isUpdating;
        /// <summary>
        /// Показывает подсказки об ошибках ввода адреса.
        /// </summary>
        private readonly ToolTip _errorToolTip = new ToolTip();

        /// <summary>
        /// Возвращает или задаёт объект адреса.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(
            DesignerSerializationVisibility.Hidden)]
        public Address Address
        {


            get
            {
                // Во время работы конструктора Visual Studio
                // не запускаем проверку пользовательского ввода.
                if (LicenseManager.UsageMode ==
                    LicenseUsageMode.Designtime)
                {
                    return _address;
                }

                // Проверяем все поля перед возвратом адреса.
                if (!ValidateAddress())
                {
                    throw new InvalidOperationException(
                        "Адрес содержит некорректные данные.");
                }

                // Создаём адрес из актуальных значений.
                int index = int.Parse(IndexTextBox.Text.Trim());

                _address = new Address(
                    index,
                    CountryTextBox.Text.Trim(),
                    CityTextBox.Text.Trim(),
                    StreetTextBox.Text.Trim(),
                    BuildingTextBox.Text.Trim(),
                    ApartmentTextBox.Text.Trim());

                return _address;
            }

            set
            {
                _address = value ?? new Address();

                _isUpdating = true;

                try
                {
                    IndexTextBox.Text = _address.Index == 0
                        ? string.Empty
                        : _address.Index.ToString();

                    CountryTextBox.Text = _address.Country;
                    CityTextBox.Text = _address.City;
                    StreetTextBox.Text = _address.Street;
                    BuildingTextBox.Text = _address.Building;
                    ApartmentTextBox.Text = _address.Apartment;
                }

                finally
                {
                    _isUpdating = false;
                }

                // Очищаем подсветку после загрузки адреса.
                foreach (TextBox textBox in new[]
                {
                IndexTextBox,
                CountryTextBox,
                CityTextBox,
                StreetTextBox,
                BuildingTextBox,
                ApartmentTextBox
                })
                {
                    textBox.BackColor = SystemColors.Window;
                    _errorToolTip.SetToolTip(textBox, string.Empty);
                }

            }
        }




        public AddressControl()
        {
            InitializeComponent();
            IndexTextBox.BackColor = SystemColors.Window;

            IndexTextBox.TextChanged += AddressTextBox_TextChanged;
            CountryTextBox.TextChanged += AddressTextBox_TextChanged;
            CityTextBox.TextChanged += AddressTextBox_TextChanged;
            StreetTextBox.TextChanged += AddressTextBox_TextChanged;
            BuildingTextBox.TextChanged += AddressTextBox_TextChanged;
            ApartmentTextBox.TextChanged += AddressTextBox_TextChanged;
        }

        /// <summary>
        /// Обновляет данные адреса при изменении текстовых полей.
        /// </summary>
        private void AddressTextBox_TextChanged(object? sender, EventArgs e)
        {
            if (_isUpdating)
            {
                return;
            }
            if (sender is TextBox textBox)
            {
                ValidateField(textBox);
            }
            if (sender == IndexTextBox)
            {
                if (int.TryParse(IndexTextBox.Text, out int index)
                    && index >= 100000 && index <= 999999)
                {
                    _address.Index = index;
                }
            }
            else if (sender == CountryTextBox)
            {
                if (CountryTextBox.Text.Length <= 50)
                {
                    _address.Country = CountryTextBox.Text;
                }
            }
            else if (sender == CityTextBox)
            {
                if (CityTextBox.Text.Length <= 50)
                {
                    _address.City = CityTextBox.Text;
                }
            }
            else if (sender == StreetTextBox)
            {
                if (StreetTextBox.Text.Length <= 100)
                {
                    _address.Street = StreetTextBox.Text;
                }
            }
            else if (sender == BuildingTextBox)
            {
                if (BuildingTextBox.Text.Length <= 10)
                {
                    _address.Building = BuildingTextBox.Text;
                }
            }
            else if (sender == ApartmentTextBox)
            {
                if (ApartmentTextBox.Text.Length <= 10)
                {
                    _address.Apartment = ApartmentTextBox.Text;
                }

            }

        }
        /// <summary>
        /// Проверяет текстовое поле адреса
        /// и отображает ошибку при необходимости.
        /// </summary>
        /// <param name="textBox">Проверяемое поле.</param>
        /// <returns>True, если значение корректно.</returns>
        private bool ValidateField(TextBox textBox)
        {
            string value = textBox.Text.Trim();
            string error = string.Empty;

            if (textBox == IndexTextBox)
            {
                if (!int.TryParse(value, out int index)
                    || index < 100000 || index > 999999)
                {
                    error = "Индекс должен содержать 6 цифр.";
                }
            }
            else if (textBox == CountryTextBox ||
                     textBox == CityTextBox)
            {
                if (value.Length > 50)
                {
                    error = "Не более 50 символов.";
                }
            }
            else if (textBox == StreetTextBox)
            {
                if (value.Length > 100)
                {
                    error = "Не более 100 символов.";
                }
            }
            else if (textBox == BuildingTextBox ||
                     textBox == ApartmentTextBox)
            {
                if (value.Length > 10)
                {
                    error = "Не более 10 символов.";
                }
            }

            if (!string.IsNullOrEmpty(error))
            {
                textBox.BackColor = Color.LightCoral;
                _errorToolTip.SetToolTip(textBox, error);
                return false;
            }

            textBox.BackColor = SystemColors.Window;
            _errorToolTip.SetToolTip(textBox, string.Empty);

            return true;
        }

        /// <summary>
        /// Проверяет корректность всех полей адреса.
        /// </summary>
        /// <returns>
        /// True, если все поля заполнены корректно.
        /// </returns>
        private bool ValidateAddress()
        {
            bool isValid = true;

            isValid = ValidateField(IndexTextBox) & isValid;
            isValid = ValidateField(CountryTextBox) & isValid;
            isValid = ValidateField(CityTextBox) & isValid;
            isValid = ValidateField(StreetTextBox) & isValid;
            isValid = ValidateField(BuildingTextBox) & isValid;
            isValid = ValidateField(ApartmentTextBox) & isValid;

            return isValid;
        }

        private void AddressControl_Load(object sender, EventArgs e)
        {

        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IndexLabel_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CountryLabel_Click(object sender, EventArgs e)
        {

        }

        private void IndexTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


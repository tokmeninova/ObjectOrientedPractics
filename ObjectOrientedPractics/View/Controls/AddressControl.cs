
using System.ComponentModel;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Управляет вводом адреса доставки.
    /// </summary>
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Текущий адрес.
        /// </summary>
        private Address _address = new Address();

        /// <summary>
        /// Флаг обновления полей.
        /// </summary>
        private bool _isUpdating;

        /// <summary>
        /// Подсказки об ошибках.
        /// </summary>
        private readonly ToolTip _errorToolTip = new ToolTip();

        /// <summary>
        /// Возвращает или задаёт адрес.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(
            DesignerSerializationVisibility.Hidden)]
        public Address Address
        {
            get
            {
                // Пропускаем проверку в Designer.
                if (LicenseManager.UsageMode ==
                    LicenseUsageMode.Designtime)
                {
                    return _address;
                }

                // Проверяем введённые данные.
                if (!ValidateAddress())
                {
                    throw new InvalidOperationException(
                        "Адрес содержит некорректные данные.");
                }

                // Получаем почтовый индекс.
                int index = int.Parse(IndexTextBox.Text.Trim());

                // Создаём адрес из полей.
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
                // Устанавливаем адрес.
                _address = value ?? new Address();

                // Блокируем обработчики изменений.
                _isUpdating = true;

                try
                {
                    // Заполняем текстовые поля.
                    if (_address.Index == 0)
                    {
                        IndexTextBox.Text = string.Empty;
                    }
                    else
                    {
                        IndexTextBox.Text = _address.Index.ToString();
                    }


                    CountryTextBox.Text = _address.Country;
                    CityTextBox.Text = _address.City;
                    StreetTextBox.Text = _address.Street;
                    BuildingTextBox.Text = _address.Building;
                    ApartmentTextBox.Text = _address.Apartment;
                }
                finally
                {
                    // Возобновляем обработку изменений.
                    _isUpdating = false;
                }

                // Сбрасываем подсветку ошибок.
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
                    _errorToolTip.SetToolTip(
                        textBox, string.Empty);
                }
            }
        }

        /// <summary>
        /// Создаёт элемент управления адресом.
        /// </summary>
        public AddressControl()
        {
            // Инициализируем элементы.
            InitializeComponent();

            IndexTextBox.BackColor = SystemColors.Window;

            // Подключаем обработчики изменений.
            IndexTextBox.TextChanged += AddressTextBox_TextChanged;
            CountryTextBox.TextChanged += AddressTextBox_TextChanged;
            CityTextBox.TextChanged += AddressTextBox_TextChanged;
            StreetTextBox.TextChanged += AddressTextBox_TextChanged;
            BuildingTextBox.TextChanged += AddressTextBox_TextChanged;
            ApartmentTextBox.TextChanged += AddressTextBox_TextChanged;
        }

        /// <summary>
        /// Обновляет адрес при изменении полей.
        /// </summary>
        private void AddressTextBox_TextChanged(
            object? sender, EventArgs e)
        {
            // Пропускаем программное обновление.
            if (_isUpdating)
            {
                return;
            }

            // Проверяем изменённое поле.
            if (sender is TextBox textBox)
            {
                ValidateField(textBox);
            }

            // Обновляем почтовый индекс.
            if (sender == IndexTextBox)
            {
                if (int.TryParse(IndexTextBox.Text, out int index)
                    && index >= 100000 && index <= 999999)
                {
                    _address.Index = index;
                }
            }

            // Обновляем страну.
            else if (sender == CountryTextBox)
            {
                if (CountryTextBox.Text.Length <= 50)
                {
                    _address.Country = CountryTextBox.Text;
                }
            }

            // Обновляем город.
            else if (sender == CityTextBox)
            {
                if (CityTextBox.Text.Length <= 50)
                {
                    _address.City = CityTextBox.Text;
                }
            }

            // Обновляем улицу.
            else if (sender == StreetTextBox)
            {
                if (StreetTextBox.Text.Length <= 100)
                {
                    _address.Street = StreetTextBox.Text;
                }
            }

            // Обновляем номер дома.
            else if (sender == BuildingTextBox)
            {
                if (BuildingTextBox.Text.Length <= 10)
                {
                    _address.Building = BuildingTextBox.Text;
                }
            }

            // Обновляем номер квартиры.
            else if (sender == ApartmentTextBox)
            {
                if (ApartmentTextBox.Text.Length <= 10)
                {
                    _address.Apartment = ApartmentTextBox.Text;
                }
            }
        }

        /// <summary>
        /// Проверяет значение текстового поля.
        /// </summary>
        /// <param name="textBox">Проверяемое поле.</param>
        /// <returns>True, если значение корректно.</returns>
        private bool ValidateField(TextBox textBox)
        {
            // Получаем значение поля.
            string value = textBox.Text.Trim();
            string error = string.Empty;

            // Проверяем почтовый индекс.
            if (textBox == IndexTextBox)
            {
                if (!int.TryParse(value, out int index)
                    || index < 100000 || index > 999999)
                {
                    error = "Индекс должен содержать 6 цифр.";
                }
            }

            // Проверяем страну и город.
            else if (textBox == CountryTextBox ||
                     textBox == CityTextBox)
            {
                if (value.Length > 50)
                {
                    error = "Не более 50 символов.";
                }
            }

            // Проверяем улицу.
            else if (textBox == StreetTextBox)
            {
                if (value.Length > 100)
                {
                    error = "Не более 100 символов.";
                }
            }

            // Проверяем дом и квартиру.
            else if (textBox == BuildingTextBox ||
                     textBox == ApartmentTextBox)
            {
                if (value.Length > 10)
                {
                    error = "Не более 10 символов.";
                }
            }

            // Подсвечиваем ошибку.
            if (!string.IsNullOrEmpty(error))
            {
                textBox.BackColor = Color.LightCoral;
                _errorToolTip.SetToolTip(textBox, error);
                return false;
            }

            // Убираем подсветку ошибки.
            textBox.BackColor = SystemColors.Window;
            _errorToolTip.SetToolTip(textBox, string.Empty);

            return true;
        }

        /// <summary>
        /// Проверяет все поля адреса.
        /// </summary>
        /// <returns>True, если значения корректны.</returns>
        private bool ValidateAddress()
        {
            bool isValid = true;

            // Проверяем каждое поле.
            isValid = ValidateField(IndexTextBox) & isValid;
            isValid = ValidateField(CountryTextBox) & isValid;
            isValid = ValidateField(CityTextBox) & isValid;
            isValid = ValidateField(StreetTextBox) & isValid;
            isValid = ValidateField(BuildingTextBox) & isValid;
            isValid = ValidateField(ApartmentTextBox) & isValid;

            return isValid;
        }

        /// <summary>
        /// Обработчик загрузки элемента.
        /// </summary>
        private void AddressControl_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Обработчик изменения страны.
        /// </summary>
        private void CountryTextBox_TextChanged(
            object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Обработчик нажатия на подпись индекса.
        /// </summary>
        private void IndexLabel_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Обработчик отрисовки панели.
        /// </summary>
        private void tableLayoutPanel1_Paint(
            object sender, PaintEventArgs e)
        {
        }

        /// <summary>
        /// Обработчик изменения квартиры.
        /// </summary>
        private void ApartmentTextBox_TextChanged(
            object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Обработчик нажатия на подпись страны.
        /// </summary>
        private void CountryLabel_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Обработчик изменения индекса.
        /// </summary>
        private void IndexTextBox_TextChanged(
            object sender, EventArgs e)
        {
        }
    }
}

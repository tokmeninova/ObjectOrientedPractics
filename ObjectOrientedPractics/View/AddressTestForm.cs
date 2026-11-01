
using System;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View
{
    /// <summary>
    /// Временная форма для проверки AddressControl.
    /// </summary>
    public partial class AddressTestForm : Form
    {
        /// <summary>
        /// Создаёт тестовую форму.
        /// </summary>
        public AddressTestForm()
        {
            InitializeComponent();

            LoadAddressButton.Click += LoadAddressButton_Click;
            CheckAddressButton.Click += CheckAddressButton_Click;
        }

        /// <summary>
        /// Загружает тестовый адрес.
        /// </summary>
        private void LoadAddressButton_Click(
            object? sender, EventArgs e)
        {
            var address = new Address(
                634050,
                "Russia",
                "Tomsk",
                "Lenina",
                "36",
                "15");

            addressControl1.Address = address;
        }

        /// <summary>
        /// Проверяет введённый адрес.
        /// </summary>
        private void CheckAddressButton_Click(
            object? sender, EventArgs e)
        {
            try
            {
                Address address = addressControl1.Address;

                MessageBox.Show(
                    $"Индекс: {address.Index}\n" +
                    $"Страна: {address.Country}\n" +
                    $"Город: {address.City}\n" +
                    $"Улица: {address.Street}\n" +
                    $"Дом: {address.Building}\n" +
                    $"Квартира: {address.Apartment}",
                    "Адрес корректен");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Ошибка адреса",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}

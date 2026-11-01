using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Главная форма приложения.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Хранит все товары и покупателей приложения.
        /// </summary>
        private readonly Store _store = new Store();

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainForm"/>.
        /// </summary>

        public MainForm()
        {
            InitializeComponent();

            // Передаём список товаров во вкладку Items.
            itemsListBox1.Items = _store.Items;

            // Передаём список покупателей во вкладку Customers.
            customersTab1.Customers = _store.Customers;
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            ProjectSerializer.Save("project.json", _store.Items, _store.Customers);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            ProjectSerializer.Load("project.json", out var items, out var customers);
            // Обновляем коллекции магазина.
            _store.Items = items ?? new List<Item>();
            _store.Customers = customers ?? new List<Customer>();

            // Передаём загруженные списки вкладкам.
            itemsListBox1.Items = _store.Items;
            customersTab1.Customers = _store.Customers;
        }
    }
}
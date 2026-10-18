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
        /// Список товаров.
        /// </summary>
        private List<Item> itemsList = new List<Item>();

        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> customersList = new List<Customer>();

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ProjectSerializer.Save("project.json", itemsList, customersList);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            ProjectSerializer.Load("project.json", out var items, out var customers);
            itemsList = items;
            customersList = customers;
        }
    }
}
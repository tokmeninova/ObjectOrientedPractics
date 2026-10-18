using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Пользовательский элемент управления для работы со списком товаров.
    /// </summary>
    public partial class ItemsListBox : UserControl
    {
        /// <summary>
        /// Список, в котором хранятся все созданные товары.
        /// </summary>
        private List<Item> Items = new List<Item>();

        /// <summary>
        /// Конструктор пользовательского элемента ItemsListBox.
        /// </summary>
        public ItemsListBox()
        {
            // Создаёт и инициализирует все элементы интерфейса.
            InitializeComponent();

            // Запрещаем пользователю изменять ID товара вручную.
            IdTextBox.ReadOnly = true;

            // Подключаем обработчик нажатия кнопки Add.
            button1.Click += AddItemButton_Click;

            // Подключаем обработчик нажатия кнопки Remove.
            button2.Click += RemoveItemButton_Click;

            // Подключаем событие выбора товара из списка.
            listBox1.SelectedIndexChanged +=  ItemsListBox_SelectedIndexChanged;
        }

        /// <summary>
        /// Добавляет новый товар на основе данных,
        /// введённых пользователем.
        /// </summary>
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            // Получаем название товара из TextBox.
            string name = NameTextBox.Text;

            // Получаем описание товара из TextBox.
            string info = DescriptionTextBox.Text;

            // Проверяем, было ли введено название товара.
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Введите Name.");
                return;
            }

            // Пытаемся преобразовать введённую стоимость
            // из строки в число типа double.
            if (!double.TryParse(CostTextBox.Text, out double cost))
            {
                MessageBox.Show("Введите правильную стоимость.");
                return;
            }

            try
            {
                // Создаём новый объект Item.
                // Конструктор получает название, описание и стоимость.
                var item = new Item(
                    name,
                    info,
                    cost);

                // Добавляем созданный товар в список Items.
                Items.Add(item);

                // Добавляем товар в визуальный ListBox.
                listBox1.Items.Add(item);

                // Автоматически выбираем только что
                // добавленный товар.
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            }
            catch (ArgumentException exception)
            {
                // Если данные не проходят валидацию,
                // показываем пользователю сообщение об ошибке.
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// Удаляет выбранный товар.
        /// </summary>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            // Получаем индекс выбранного товара.
            int selectedIndex = listBox1.SelectedIndex;

            // Если ничего не выбрано,
            // SelectedIndex будет равен -1.
            if (selectedIndex == -1)
            {
                MessageBox.Show( "Сначала выберите товар.");

                return;
            }

            // Удаляем товар из списка объектов Items.
            Items.RemoveAt(selectedIndex);

            // Удаляем тот же товар из визуального ListBox.
            listBox1.Items.RemoveAt(selectedIndex);

            // После удаления очищаем поля справа.
            IdTextBox.Clear();
            CostTextBox.Clear();
            NameTextBox.Clear();
            DescriptionTextBox.Clear();
        }

        /// <summary>
        /// Генерирует случайный товар.
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            // Фабрика создаёт случайный объект Item.
            var item = ItemFactory.CreateRandomItem();

            // Добавляем товар в список объектов.
            Items.Add(item);

            // Добавляем товар в визуальный ListBox.
            listBox1.Items.Add(item);

            // Автоматически выбираем созданный товар.
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        /// <summary>
        /// Показывает информацию о выбранном товаре.
        /// </summary>
        private void ItemsListBox_SelectedIndexChanged( object sender,EventArgs e)
        {
            // Получаем индекс выбранного элемента.
            int selectedIndex = listBox1.SelectedIndex;

            // Если товар не выбран, ничего не делаем.
            if (selectedIndex == -1)
            {
                return;
            }

            // Получаем объект Item по его индексу.
            Item item = Items[selectedIndex];

            // Показываем ID товара.
            IdTextBox.Text = item.Id.ToString();

            // Показываем стоимость товара.
            CostTextBox.Text = item.Cost.ToString();

            // Показываем название товара.
            NameTextBox.Text = item.Name;

            // Показываем описание товара.
            DescriptionTextBox.Text = item.Info;
        }

        /// <summary>
        /// Обработчик нажатия на надпись ID.
        /// </summary>
        private void IdLabel_Click(object sender, EventArgs e)
        {
        }
    }
}
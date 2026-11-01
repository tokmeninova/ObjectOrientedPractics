using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Управление товарами: добавление, редактирование, удаление и генерация.
    /// </summary>
    public partial class ItemsListBox : UserControl
    {
        private const int MaxNameLength = 200;
        private const int MaxDescriptionLength = 1000;
        private const double MaxCost = 100000;

        /// <summary>
        /// Коллекция товаров, отображаемых на вкладке.
        /// </summary>
        private List<Item> _items = new List<Item>();


        /// <summary>
        /// Возвращает или задаёт список товаров.
        /// При изменении списка обновляет отображение.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                // Запрещаем передачу null.
                _items = value ?? throw new ArgumentNullException(
                    nameof(value));

                // Очищаем визуальный список.
                listBox1.Items.Clear();

                // Отображаем товары из новой коллекции.
                foreach (Item item in _items)
                {
                    listBox1.Items.Add(item);
                }

                // Очищаем поля редактирования.
                ResetForm();
            }
        }



        public ItemsListBox()
        {
            InitializeComponent();

            IdTextBox.ReadOnly = true;
            ResetColors();

            // Заполняем выпадающий список категориями товаров.
            CategoryComboBox.DataSource =
                Enum.GetValues(typeof(Category));

            // Пользователь может только выбрать категорию.
            CategoryComboBox.DropDownStyle =
                ComboBoxStyle.DropDownList;

            button1.Click += AddItemButton_Click;
            button2.Click += RemoveItemButton_Click;

            listBox1.SelectedIndexChanged +=
                ItemsListBox_SelectedIndexChanged;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
        }



        /// <summary>
        /// Изменяет категорию выбранного товара.
        /// </summary>
        private void CategoryComboBox_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;

            if (index == -1)
                return;

            Item item = _items[index];

            if (CategoryComboBox.SelectedItem is Category category)
            {
                item.Category = category;
            }
        }



        /// <summary>
        /// Добавляет товар, если ничего не выбрано,
        /// или изменяет существующий товар.
        /// </summary>
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if (!TryReadItem(out string name,
                out string description, out double cost))
                return;

            try
            {
                int index = listBox1.SelectedIndex;

                // Получаем выбранную категорию.
                Category category =
                    (Category)CategoryComboBox.SelectedItem;

                if (index == -1)
                {
                    // Создаём товар с четырьмя аргументами.
                    Item item = new Item(
                        name,
                        description,
                        cost,
                        category);

                    _items.Add(item);
                    listBox1.Items.Add(item);
                }
                else
                {
                    // Изменяем выбранный товар.
                    Item item = _items[index];

                    item.Name = name;
                    item.Info = description;
                    item.Cost = cost;
                    item.Category = category;

                    listBox1.Items[index] = item;
                }

                ResetForm();
            }
            catch (ArgumentException ex)
            {
                ShowError(ex.Message);
            }
        }


        /// <summary>
        /// Удаляет выбранный товар.
        /// </summary>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;

            if (index == -1)
            {
                ShowError("Сначала выберите товар!");
                return;
            }

            _items.RemoveAt(index);
            listBox1.Items.RemoveAt(index);
            ResetForm();
        }

        /// <summary>
        /// Генерирует товар и сразу добавляет его в список.
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            Item item = ItemFactory.CreateRandomItem();
            _items.Add(item);
            listBox1.Items.Add(item);
            ResetForm();
        }

        /// <summary>
        /// Отображает данные выбранного товара.
        /// </summary>
        private void ItemsListBox_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;

            if (index == -1)
                return;

            Item item = _items[index];

            IdTextBox.Text = item.Id.ToString();
            NameTextBox.Text = item.Name;
            CostTextBox.Text = item.Cost.ToString();
            DescriptionTextBox.Text = item.Info;

            // Показываем категорию выбранного товара.
            CategoryComboBox.SelectedItem = item.Category;
        }



        /// <summary>
        /// Проверяет данные и сообщает об ошибках без окрашивания полей.
        /// </summary>
        private bool TryReadItem(out string name, out string description, out double cost)
        {
            name = NameTextBox.Text.Trim();
            description = DescriptionTextBox.Text.Trim();
            cost = 0;

            if (string.IsNullOrWhiteSpace(name))
                return ShowInputError("Введите название товара!", NameTextBox);

            if (name.Length > MaxNameLength)
                return ShowInputError("Название не должно превышать 200 символов!", NameTextBox);

            if (description.Length > MaxDescriptionLength)
                return ShowInputError("Описание не должно превышать 1000 символов!", DescriptionTextBox);

            if (!double.TryParse(CostTextBox.Text, out cost)
                || double.IsNaN(cost) || double.IsInfinity(cost))
            {
                return ShowInputError("Введите корректную цену!", CostTextBox);
            }

            if (cost < 0)
                return ShowInputError("Цена не может быть отрицательной!", CostTextBox);

            if (cost > MaxCost)
                return ShowInputError("Цена не должна превышать 100 000!", CostTextBox);

            return true;
        }

        /// <summary>
        /// Очищает форму для ввода нового товара.
        /// </summary>
        private void ResetForm()
        {
            listBox1.ClearSelected();

            IdTextBox.Clear();
            NameTextBox.Clear();
            CostTextBox.Clear();
            DescriptionTextBox.Clear();

            ResetColors();
            NameTextBox.Focus();
        }

        private void ResetColors()
        {
            listBox1.BackColor = SystemColors.Window;
            NameTextBox.BackColor = SystemColors.Window;
            CostTextBox.BackColor = SystemColors.Window;
            DescriptionTextBox.BackColor = SystemColors.Window;
        }

        private static bool ShowInputError(string message, Control control)
        {
            ShowError(message);
            control.Focus();
            return false;
        }

        private static void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Обработчик используется в Designer.
        private void IdLabel_Click(object sender, EventArgs e) { }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

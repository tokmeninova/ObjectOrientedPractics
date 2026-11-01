
using ObjectOrientedPractics.Model; 
using ObjectOrientedPractics.Services; 

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Управляет товарами магазина.
    /// </summary>
    public partial class ItemsListBox : UserControl
    {
        /// <summary>
        /// Максимальная длина названия.
        /// </summary>
        private const int MaxNameLength = 200;

        /// <summary>
        /// Максимальная длина описания.
        /// </summary>
        private const int MaxDescriptionLength = 1000;

        /// <summary>
        /// Максимальная цена товара.
        /// </summary>
        private const double MaxCost = 100000;

        /// <summary>
        /// Коллекция товаров.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Возвращает или задаёт список товаров.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                // Возвращаем текущий список товаров.
                return _items;
            }
            set
            {
                // Присваиваем список с проверкой на null.
                _items = value ?? throw new ArgumentNullException(
                    nameof(value));

                // Очищаем ListBox.
                listBox1.Items.Clear();

                // Перебираем все товары.
                foreach (Item item in _items)
                {
                    // Добавляем товар в ListBox.
                    listBox1.Items.Add(item);
                }
                RenumberItems();

                // Очищаем поля формы.
                ResetForm();
            }
        }

        /// <summary>
        /// Создаёт вкладку товаров.
        /// </summary>
        public ItemsListBox()
        {
            // Создаём элементы интерфейса.
            InitializeComponent();

            // Запрещаем редактировать ID.
            IdTextBox.ReadOnly = true;

            // Восстанавливаем цвета.
            ResetColors();

            // Заполняем список значениями Category.
            CategoryComboBox.DataSource =
                Enum.GetValues(typeof(Category));

            // Разрешаем только выбор категории.
            CategoryComboBox.DropDownStyle =
                ComboBoxStyle.DropDownList;

            // Подключаем кнопку Add.
            button1.Click += AddItemButton_Click;

            // Подключаем кнопку Remove.
            button2.Click += RemoveItemButton_Click;

            // Подключаем обработчик выбора товара.
            listBox1.SelectedIndexChanged +=
                ItemsListBox_SelectedIndexChanged;

            // Подключаем обработчик выбора категории.
            CategoryComboBox.SelectedIndexChanged +=
                CategoryComboBox_SelectedIndexChanged;

            
        }

        /// <summary>
        /// Изменяет категорию выбранного товара.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CategoryComboBox_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            // Получаем индекс выбранного товара.
            int index = listBox1.SelectedIndex;

            // Проверяем допустимость индекса.
            if (index < 0 || index >= _items.Count)
                return;

            // Проверяем тип выбранной категории.
            if (CategoryComboBox.SelectedItem is Category category)
            {
                // Присваиваем категорию товару.
                _items[index].Category = category;
            }
        }

        /// <summary>
        /// Добавляет или редактирует товар.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void AddItemButton_Click(
            object sender, EventArgs e)
        {
            // Проверяем название, описание и цену.
            if (!TryReadItem(
                out string name,
                out string description,
                out double cost))
                return;

            // Проверяем выбор категории.
            if (CategoryComboBox.SelectedItem is not Category category)
            {
                // Показываем ошибку.
                ShowError("Выберите категорию товара!");

                // Прерываем выполнение.
                return;
            }

            try
            {
                // Получаем индекс выбранного товара.
                int index = listBox1.SelectedIndex;

                // Если товар не выбран, создаём новый.
                if (index == -1)
                {
                    // Создаём объект товара.
                    Item item = new Item(
                        name,
                        description,
                        cost,
                        category);

                    // Добавляем товар в коллекцию.
                    _items.Add(item);

                    // Добавляем товар в ListBox.
                    listBox1.Items.Add(item);
                    RenumberItems();
                }
                else
                {
                    // Получаем выбранный товар.
                    Item item = _items[index];

                    // Изменяем название.
                    item.Name = name;

                    // Изменяем описание.
                    item.Info = description;

                    // Изменяем цену.
                    item.Cost = cost;

                    // Изменяем категорию.
                    item.Category = category;

                    // Обновляем элемент списка.
                    listBox1.Items[index] = item;
                }

                // Очищаем форму.
                ResetForm();
            }
            catch (ArgumentException ex)
            {
                // Показываем сообщение об ошибке.
                ShowError(ex.Message);
            }
        }


        /// <summary>
        /// Удаляет товар и обновляет ID.
        /// </summary>
        private void RemoveItemButton_Click(
            object sender, EventArgs e)
        {
            // Получаем индекс выбранного товара.
            int index = listBox1.SelectedIndex;

            if (index == -1)
            {
                ShowError("Сначала выберите товар!");
                return;
            }

            // Удаляем товар из коллекции.
            _items.RemoveAt(index);

            // Удаляем товар из ListBox.
            listBox1.Items.RemoveAt(index);

            // Перенумеровываем товары.
            RenumberItems();

            // Очищаем поля.
            ResetForm();
        }



        /// <summary>
        /// Генерирует случайный товар.
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            // Создаём случайный товар.
            Item item = ItemFactory.CreateRandomItem();

            // Добавляем товар.
            _items.Add(item);
            listBox1.Items.Add(item);

            // Обновляем ID.
            RenumberItems();

            // Очищаем форму.
            ResetForm();
        }


        /// <summary>
        /// Отображает выбранный товар.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ItemsListBox_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            // Получаем индекс выбранного товара.
            int index = listBox1.SelectedIndex;

            // Проверяем допустимость индекса.
            if (index < 0 || index >= _items.Count)
                return;

            // Получаем объект товара.
            Item item = _items[index];

            // Отображаем идентификатор.
            IdTextBox.Text = item.Id.ToString();

            // Отображаем название.
            NameTextBox.Text = item.Name;

            // Отображаем цену.
            CostTextBox.Text = item.Cost.ToString();

            // Отображаем описание.
            DescriptionTextBox.Text = item.Info;

            // Отображаем категорию.
            CategoryComboBox.SelectedItem = item.Category;
        }

        /// <summary>
        /// Проверяет введённые данные товара.
        /// </summary>
        /// <param name="name">Название товара.</param>
        /// <param name="description">Описание товара.</param>
        /// <param name="cost">Цена товара.</param>
        /// <returns>True, если данные корректны.</returns>
        private bool TryReadItem(
            out string name,
            out string description,
            out double cost)
        {
            // Получаем название без крайних пробелов.
            name = NameTextBox.Text.Trim();

            // Получаем описание без крайних пробелов.
            description = DescriptionTextBox.Text.Trim();

            // Устанавливаем начальную цену.
            cost = 0;

            // Проверяем наличие названия.
            if (string.IsNullOrWhiteSpace(name))
                return ShowInputError(
                    "Введите название товара!",
                    NameTextBox);

            // Проверяем длину названия.
            if (name.Length > MaxNameLength)
                return ShowInputError(
                    "Название не должно превышать 200 символов!",
                    NameTextBox);

            // Проверяем длину описания.
            if (description.Length > MaxDescriptionLength)
                return ShowInputError(
                    "Описание не должно превышать 1000 символов!",
                    DescriptionTextBox);

            // Проверяем число и исключаем NaN/Infinity.
            if (!double.TryParse(CostTextBox.Text, out cost)
                || double.IsNaN(cost)
                || double.IsInfinity(cost))
            {
                // Показываем ошибку цены.
                return ShowInputError(
                    "Введите корректную цену!",
                    CostTextBox);
            }

            // Проверяем отрицательную цену.
            if (cost < 0)
                return ShowInputError(
                    "Цена не может быть отрицательной!",
                    CostTextBox);

            // Проверяем верхний предел цены.
            if (cost > MaxCost)
                return ShowInputError(
                    "Цена не должна превышать 100 000!",
                    CostTextBox);

            // Все проверки пройдены.
            return true;
        }



        /// <summary>
        /// Перенумеровывает товары начиная с 1.
        /// </summary>
        private void RenumberItems()
        {
            // Обновляем ID всех товаров.
            for (int i = 0; i < _items.Count; i++)
            {
                _items[i].SetId(i + 1);
            }

            // Получаем выбранный товар.
            int selectedIndex = listBox1.SelectedIndex;

            // Обновляем его ID на форме.
            if (selectedIndex >= 0 &&
                selectedIndex < _items.Count)
            {
                IdTextBox.Text =
                    _items[selectedIndex].Id.ToString();
            }
        }


        /// <summary>
        /// Очищает поля товара.
        /// </summary>
        private void ResetForm()
        {
            // Снимаем выделение товара.
            listBox1.ClearSelected();

            // Очищаем поле ID.
            IdTextBox.Clear();

            // Очищаем название.
            NameTextBox.Clear();

            // Очищаем цену.
            CostTextBox.Clear();

            // Очищаем описание.
            DescriptionTextBox.Clear();

            // Восстанавливаем цвета.
            ResetColors();

            // Устанавливаем фокус на название.
            NameTextBox.Focus();
        }

        /// <summary>
        /// Восстанавливает цвета элементов.
        /// </summary>
        private void ResetColors()
        {
            // Цвет списка товаров.
            listBox1.BackColor = SystemColors.Window;

            // Цвет поля названия.
            NameTextBox.BackColor = SystemColors.Window;

            // Цвет поля цены.
            CostTextBox.BackColor = SystemColors.Window;

            // Цвет поля описания.
            DescriptionTextBox.BackColor = SystemColors.Window;
        }

        /// <summary>
        /// Показывает ошибку и устанавливает фокус.
        /// </summary>
        /// <param name="message">Текст ошибки.</param>
        /// <param name="control">Поле с ошибкой.</param>
        /// <returns>Всегда false.</returns>
        private static bool ShowInputError(
            string message,
            Control control)
        {
            // Показываем сообщение.
            ShowError(message);

            // Устанавливаем фокус на поле.
            control.Focus();

            // Возвращаем результат проверки.
            return false;
        }

        /// <summary>
        /// Показывает сообщение об ошибке.
        /// </summary>
        /// <param name="message">Текст ошибки.</param>
        private static void ShowError(string message)
        {
            // Открываем окно сообщения.
            MessageBox.Show(
                message,                
                "Ошибка",              
                MessageBoxButtons.OK,   
                MessageBoxIcon.Error); 
        }
    }
}

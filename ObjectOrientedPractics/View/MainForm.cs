
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Главное окно приложения.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Общий экземпляр магазина для всех вкладок.
        /// </summary>
        private readonly Store _store = new Store();

        /// <summary>
        /// Разрешает сохранение данных.
        /// </summary>
        private bool _canSave = true;

        /// <summary>
        /// Возвращает путь к файлу сохранения.
        /// </summary>
        private string GetSavePath()
        {
            string folder = Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.MyDocuments),
                "ObjectOrientedPractics");

            Directory.CreateDirectory(folder);

            return Path.Combine(folder, "project.json");
        }

        /// <summary>
        /// Создаёт главное окно приложения.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            // Передаём общие списки вкладкам.
            itemsListBox1.Items = _store.Items;

            customersTab1.Customers = _store.Customers;
            customersTab1.Items = _store.Items;

            cartsTab1.Items = _store.Items;
            cartsTab1.Customers = _store.Customers;

            ordersTab1.Customers = _store.Customers;

            // Подключаем обновление вкладок.
            if (tabPage3.Parent is TabControl tabs)
            {
                tabs.SelectedIndexChanged -=
                    tabControl1_SelectedIndexChanged;

                tabs.SelectedIndexChanged +=
                    tabControl1_SelectedIndexChanged;
            }

            cartsTab1.RefreshData();

            // Загружаем ранее сохранённые данные.
            LoadData();

            // Подключаем сохранение при закрытии.
            FormClosing -= MainForm_FormClosing;
            FormClosing += MainForm_FormClosing;
        }


        /// <summary>
        /// Автоматически сохраняет данные магазина в JSON.
        /// </summary>
        private void SaveData()
        {
            if (!_canSave)
            {
                return;
            }

            try
            {
                // Получаем путь к файлу.
                string path = GetSavePath();
                Order.RenumberOrders(_store.Customers);

                // Сохраняем товары и покупателей.
                ProjectSerializer.Save(
                    path,
                    _store.Items,
                    _store.Customers);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ошибка сохранения:\n" + ex.Message);
            }
        }
        

        /// <summary>
        /// Загружает данные магазина из JSON.
        /// </summary>
        private void LoadData()
        {
            try
            {
                // Используем тот же путь, что и при сохранении.
                string path = GetSavePath();

                // Проверяем существование файла.
                if (!File.Exists(path))
                {
                    return;
                }

                // Загружаем данные.
                ProjectSerializer.Load(
                    path, out var items, out var customers);

                // Обновляем данные магазина.
                _store.Items = items ?? new List<Item>();
                _store.Customers = customers ??
                    new List<Customer>();

                // Передаём новые списки вкладкам.
                itemsListBox1.Items = _store.Items;

                customersTab1.Items = _store.Items;
                customersTab1.Customers = _store.Customers;

                cartsTab1.Items = _store.Items;
                cartsTab1.Customers = _store.Customers;

                ordersTab1.Customers = _store.Customers;

                // Обновляем отображение.
                cartsTab1.RefreshData();
                ordersTab1.RefreshData();

                _canSave = true;
            }
            catch (Exception ex)
            {
                // Не перезаписываем повреждённый
                // или не прочитанный файл пустыми данными.
                _canSave = false;

                MessageBox.Show(
                    "Ошибка загрузки:\n" + ex.Message);
            }
        }

        /// <summary>
        /// Сохраняет данные при закрытии программы.
        /// </summary>
        private void MainForm_FormClosing(
            object? sender, FormClosingEventArgs e)
        {
            SaveData();
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки Save.
        /// </summary>
        private void SaveButton_Click(
            object? sender, EventArgs e)
        {
            SaveData();
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки Load.
        /// </summary>
        private void LoadButton_Click(
            object? sender, EventArgs e)
        {
            LoadData();
        }

        /// <summary>
        /// Обновляет данные при переключении вкладок.
        /// </summary>
        private void tabControl1_SelectedIndexChanged(
            object? sender, EventArgs e)
        {
            if (sender is not TabControl tabs)
            {
                return;
            }

            // Обновляем вкладку корзины.
            if (tabs.SelectedTab == tabPage3)
            {
                cartsTab1.RefreshData();
            }

            // Обновляем вкладку заказов.
            if (tabs.SelectedTab == tabPage4)
            {
                ordersTab1.RefreshData();
            }
        }

        // Обработчики, используемые конструктором формы.
        private void cartsTab_Load(
            object? sender, EventArgs e)
        {
        }

        private void cartsTabPage_SelectedIndexChanged(
            object? sender, EventArgs e)
        {
        }

        private void itemsListBox1_Load(
            object sender, EventArgs e)
        {
        }
    }
}

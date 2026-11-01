
using ObjectOrientedPractics.Model;
using Newtonsoft.Json;


namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Сохраняет и загружает данные проекта.
    /// </summary>
    public static class ProjectSerializer
    {
        /// <summary>
        /// Хранит данные для сериализации.
        /// </summary>
        private class ProjectData
        {
            /// <summary>
            /// Список товаров.
            /// </summary>
            public List<Item> Items { get; set; } = new List<Item>();

            /// <summary>
            /// Список покупателей.
            /// </summary>
            public List<Customer> Customers { get; set; } =
                new List<Customer>();
        }

        /// <summary>
        /// Сохраняет данные в JSON-файл.
        /// </summary>
        /// <param name="path">Путь к файлу.</param>
        /// <param name="items">Список товаров.</param>
        /// <param name="customers">Список покупателей.</param>
        public static void Save(
            string path,
            List<Item> items,
            List<Customer> customers)
        {
            // Проверяем списки на null.
            ArgumentNullException.ThrowIfNull(items);
            ArgumentNullException.ThrowIfNull(customers);

            // Собираем данные проекта.
            ProjectData data = new ProjectData
            {
                Items = items,
                Customers = customers
            };

            // Преобразуем данные в JSON.
            string json = JsonConvert.SerializeObject(
                data,
                Formatting.Indented);

            // Записываем JSON в файл.
            File.WriteAllText(path, json);
        }

        /// <summary>
        /// Загружает данные из JSON-файла.
        /// </summary>
        /// <param name="path">Путь к файлу.</param>
        /// <param name="items">Загруженные товары.</param>
        /// <param name="customers">Загруженные покупатели.</param>
        public static void Load(
            string path,
            out List<Item> items,
            out List<Customer> customers)
        {
            // Проверяем наличие файла.
            if (!File.Exists(path))
            {
                throw new FileNotFoundException(
                    "Файл сохранения не найден.",
                    path);
            }

            // Читаем файл.
            string json = File.ReadAllText(path);

            // Восстанавливаем данные из JSON.
            ProjectData data =
                JsonConvert.DeserializeObject<ProjectData>(json)
                ?? throw new InvalidDataException(
                    "Файл не содержит корректных данных проекта.");

            // Получаем списки товаров и покупателей.
            items = data.Items ?? new List<Item>();
            customers = data.Customers ?? new List<Customer>();
        }
    }
}

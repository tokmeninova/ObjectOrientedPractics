
using ObjectOrientedPractics.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Сохраняет и загружает данные проекта.
    /// </summary>
    public static class ProjectSerializer
    {
        /// <summary>
        /// Настройки сериализации.
        /// </summary>
        private static readonly JsonSerializerSettings _settings =
            new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                PreserveReferencesHandling =
                    PreserveReferencesHandling.Objects
            };

        /// <summary>
        /// Хранит данные магазина.
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
        /// Сохраняет данные магазина в файл.
        /// </summary>
        /// <param name="path">Путь к файлу.</param>
        /// <param name="items">Список товаров.</param>
        /// <param name="customers">Список покупателей.</param>
        public static void Save(
            string path,
            List<Item> items,
            List<Customer> customers)
        {
            // Подготавливаем данные.
            ProjectData data = new ProjectData
            {
                Items = items,
                Customers = customers
            };

            // Сериализуем с сохранением ссылок.
            string json =
                JsonConvert.SerializeObject(data, _settings);

            // Сохраняем JSON в файл.
            File.WriteAllText(path, json);
        }

        /// <summary>
        /// Загружает данные магазина из файла.
        /// </summary>
        /// <param name="path">Путь к файлу.</param>
        /// <param name="items">Загруженные товары.</param>
        /// <param name="customers">Загруженные покупатели.</param>
        public static void Load(
            string path,
            out List<Item> items,
            out List<Customer> customers)
        {
            // Читаем сохранённые данные.
            string json = File.ReadAllText(path);

            // Восстанавливаем объекты и ссылки.
            ProjectData data =
                JsonConvert.DeserializeObject<ProjectData>(
                    json, _settings)
                ?? throw new InvalidDataException(
                    "Не удалось загрузить данные магазина.");

            // Возвращаем списки.
            items = data.Items ?? new List<Item>();
            customers = data.Customers ?? new List<Customer>();
        }
    }
}

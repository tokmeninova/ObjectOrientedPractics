
using ObjectOrientedPractics.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет методы сохранения и загрузки данных проекта.
    /// </summary>
    public static class ProjectSerializer
    {
        /// <summary>
        /// Хранит списки товаров и покупателей для сериализации.
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
        /// Сохраняет товары и покупателей в JSON-файл.
        /// </summary>
        /// <param name="path">Путь к файлу.</param>
        /// <param name="items">Список товаров.</param>
        /// <param name="customers">Список покупателей.</param>
        public static void Save(
            string path,
            List<Item> items,
            List<Customer> customers)
        {
            ArgumentNullException.ThrowIfNull(items);
            ArgumentNullException.ThrowIfNull(customers);

            ProjectData data = new ProjectData
            {
                Items = items,
                Customers = customers
            };

            string json = JsonConvert.SerializeObject(
                data,
                Formatting.Indented);

            File.WriteAllText(path, json);
        }

        /// <summary>
        /// Загружает товары и покупателей из JSON-файла.
        /// </summary>
        /// <param name="path">Путь к файлу.</param>
        /// <param name="items">Загруженные товары.</param>
        /// <param name="customers">Загруженные покупатели.</param>
        public static void Load(
            string path,
            out List<Item> items,
            out List<Customer> customers)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException(
                    "Файл сохранения не найден.",
                    path);
            }

            string json = File.ReadAllText(path);

            ProjectData data =
                JsonConvert.DeserializeObject<ProjectData>(json)
                ?? throw new InvalidDataException(
                    "Файл не содержит корректных данных проекта.");

            items = data.Items ?? new List<Item>();
            customers = data.Customers ?? new List<Customer>();
        }
    }
}

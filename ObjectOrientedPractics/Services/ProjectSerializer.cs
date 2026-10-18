using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace ObjectOrientedPractics.Services;

/// <summary>
/// Предоставляет методы для сохранения и загрузки данных проекта.
/// </summary>
public static class ProjectSerializer
{
    /// <summary>
    /// Хранит списки товаров и покупателей для сериализации.
    /// </summary>
    private class ProjectData
    {
        /// <summary>
        /// Возвращает и задаёт список товаров.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Возвращает и задаёт список покупателей.
        /// </summary>
        public List<Customer> Customers { get; set; }
    }

    /// <summary>
    /// Сохраняет данные проекта в файл.
    /// </summary>
    /// <param name="path">Путь к файлу для сохранения.</param>
    /// <param name="items">Список товаров.</param>
    /// <param name="customers">Список покупателей.</param>
    public static void Save(string path, List<Item> items, List<Customer> customers)
    {
        var data = new ProjectData { Items = items, Customers = customers };
        var json = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented);
        File.WriteAllText(path, json);
    }

    /// <summary>
    /// Загружает данные проекта из файла.
    /// </summary>
    /// <param name="path">Путь к файлу для загрузки.</param>
    /// <param name="items">Список товаров.</param>
    /// <param name="customers">Список покупателей.</param>
    public static void Load(string path, out List<Item> items, out List<Customer> customers)
    {
        var json = File.ReadAllText(path);
        var data = JsonConvert.DeserializeObject<ProjectData>(json);
        items = data.Items;
        customers = data.Customers;
    }
}
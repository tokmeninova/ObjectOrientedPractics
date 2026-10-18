using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services;

/// <summary>
/// Предоставляет методы для создания случайных товаров.
/// </summary>
public static class ItemFactory
{
    /// <summary>
    /// Массив возможных названий товаров.
    /// </summary>
    private static readonly string[] Names =
    {
        "Ноутбук ASUS VivoBook",
        "Смартфон Xiaomi Redmi Note",
        "Наушники Sony WH-1000XM5",
        "Клавиатура Logitech MX Keys",
        "Мышь Razer DeathAdder",
        "Монитор Dell UltraSharp",
        "Планшет Samsung Galaxy Tab",
        "Внешний диск WD Elements",
        "Флешка SanDisk Ultra",
        "Веб-камера Logitech C920",
        "Принтер HP LaserJet",
        "Колонка JBL Charge 5"
    };

    /// <summary>
    /// Массив возможных описаний товаров.
    /// </summary>
    private static readonly string[] Infos =
    {
        "Гарантия 12 месяцев, доставка в течение 3 дней.",
        "Новинка сезона, в наличии на складе.",
        "Официальная гарантия производителя.",
        "Товар представлен в нескольких цветах.",
        "Подходит для дома и офиса.",
        "Рекомендуется проверить комплектацию при получении."
    };

    /// <summary>
    /// Генератор случайных чисел.
    /// </summary>
    private static readonly Random _random = new Random();

    /// <summary>
    /// Создаёт случайный товар.
    /// </summary>
    /// <returns>Возвращает объект <see cref="Item"/> со случайными данными.</returns>
    public static Item CreateRandomItem()
    {
        var name = Names[_random.Next(Names.Length)];
        var info = Infos[_random.Next(Infos.Length)];
        var cost = Math.Round(_random.NextDouble() * 100000, 2);

        return new Item(name, info, cost);
    }
}
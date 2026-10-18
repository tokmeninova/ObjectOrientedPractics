using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services;

/// <summary>
/// Предоставляет методы для создания случайных покупателей.
/// </summary>
public static class CustomerFactory
{
    /// <summary>
    /// Массив возможных полных имён покупателей.
    /// </summary>
    private static readonly string[] FullNames =
    {
        "Иванов Иван Иванович",
        "Петрова Анна Сергеевна",
        "Сидоров Алексей Викторович",
        "Кузнецова Мария Дмитриевна",
        "Смирнов Дмитрий Олегович",
        "Попова Екатерина Андреевна",
        "Васильев Никита Павлович",
        "Новикова Ольга Игоревна"
    };

    /// <summary>
    /// Массив возможных адресов покупателей.
    /// </summary>
    private static readonly string[] Addresses =
    {
        "г. Томск, ул. Ленина, д. 12, кв. 45",
        "г. Томск, пр. Кирова, д. 34, кв. 7",
        "г. Новосибирск, ул. Гагарина, д. 5, кв. 101",
        "г. Москва, ул. Тверская, д. 8, кв. 22",
        "г. Санкт-Петербург, Невский пр., д. 100, кв. 15",
        "г. Томск, ул. Советская, д. 20, кв. 3"
    };

    /// <summary>
    /// Генератор случайных чисел.
    /// </summary>
    private static readonly Random _random = new Random();

    /// <summary>
    /// Создаёт случайного покупателя.
    /// </summary>
    /// <returns>Возвращает объект <see cref="Customer"/> со случайными данными.</returns>
    public static Customer CreateRandomCustomer()
    {
        var fullname = FullNames[_random.Next(FullNames.Length)];
        var address = Addresses[_random.Next(Addresses.Length)];

        return new Customer(fullname, address);
    }
}

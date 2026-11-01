
using ObjectOrientedPractics.Model;
using System;

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
    private static readonly Address[] Addresses =
    {
        new Address(
            634050, "Россия", "Томск",
            "Ленина", "12", "45"),

        new Address(
            634034, "Россия", "Томск",
            "Кирова", "34", "7"),

        new Address(
            630099, "Россия", "Новосибирск",
            "Гагарина", "5", "101"),

        new Address(
            125009, "Россия", "Москва",
            "Тверская", "8", "22"),

        new Address(
            191025, "Россия", "Санкт-Петербург",
            "Невский проспект", "100", "15"),

        new Address(
            634041, "Россия", "Томск",
            "Советская", "20", "3")
    };

    /// <summary>
    /// Генератор случайных чисел.
    /// </summary>
    private static readonly Random _random = new Random();

    /// <summary>
    /// Создаёт случайного покупателя.
    /// </summary>
    /// <returns>
    /// Объект Customer со случайным именем и адресом.
    /// </returns>
    public static Customer CreateRandomCustomer()
    {
        string fullname =
            FullNames[_random.Next(FullNames.Length)];

        Address selectedAddress =
            Addresses[_random.Next(Addresses.Length)];

        // Создаём отдельный объект адреса
        // для каждого нового покупателя.
        Address address = new Address(
            selectedAddress.Index,
            selectedAddress.Country,
            selectedAddress.City,
            selectedAddress.Street,
            selectedAddress.Building,
            selectedAddress.Apartment);

        return new Customer(fullname, address);
    }
}

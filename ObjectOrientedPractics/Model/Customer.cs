using ObjectOrientedPractics.Services;
using Newtonsoft.Json;
using System.Collections.Generic;
namespace ObjectOrientedPractics.Model;

/// <summary>
/// Хранит данные о покупателе: уникальный идентификатор, полное имя и адрес.
/// </summary>
public class Customer
{
    /// <summary>
    /// Уникальный идентификатор покупателя.
    /// </summary>
    private int _id;

    /// <summary>
    /// Полное имя покупателя.
    /// </summary>
    private string _fullname;

    /// <summary>
    /// Адрес доставки покупателя.
    /// </summary>
    private Address _address;

    /// <summary>
    /// Корзина покупателя.
    /// </summary>
    private Cart? _cart = new Cart();

    /// <summary>
    /// Список заказов покупателя.
    /// </summary>
    private List<Order>? _orders = new List<Order>();

    /// <summary>
    /// Возвращает уникальный идентификатор покупателя.
    /// </summary>
    public int Id
    {
        get
        {
            return _id;
        }
    }

    /// <summary>
    /// Изменяет идентификатор покупателя
    /// при перенумерации списка.
    /// </summary>
    /// <param name="id">Новый идентификатор.</param>
    internal void SetId(int id)
    {
        if (id <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(id));
        }

        _id = id;
    }

    /// <summary>
    /// Возвращает и задаёт полное имя покупателя. Должно быть не длиннее 200 символов.
    /// </summary>
    public string Fullname
    {
        get
        {
            return _fullname;
        }
        set
        {
            ValueValidator.AssertStringOnLength(value, 200, nameof(Fullname));
            _fullname = value;
        }
    }

    /// <summary>
    /// Возвращает и задаёт адрес доставки покупателя.
    /// </summary>
    public Address Address
    {
        get
        {
            return _address;
        }
        set
        {
            _address = value ?? throw new ArgumentNullException(
                nameof(Address),
                "Адрес покупателя не может быть null.");
        }
    }

    /// <summary>
    /// Возвращает корзину покупателя.
    /// </summary>
    public Cart Cart
    {
        get
        {
            _cart ??= new Cart();
            return _cart;
        }
    }

    /// <summary>
    /// Возвращает список заказов покупателя.
    /// </summary>
    public List<Order> Orders
    {
        get
        {
            _orders ??= new List<Order>();
            return _orders;
        }
    }

    /// <summary>
    /// Создаёт покупателя с пустым адресом.
    /// </summary>
    public Customer()
    {
        _id = IdGenerator.GetNextId();
        _address = new Address();
        _cart = new Cart();
        _orders = new List<Order>();
    }

    /// <summary>
    /// Создаёт покупателя с указанным именем и адресом.
    /// </summary>
    /// <param name="fullname">Полное имя покупателя.</param>
    /// <param name="address">Адрес доставки покупателя.</param>
    public Customer(string fullname, Address address)
    {
        _id = IdGenerator.GetNextId();
        Fullname = fullname;
        Address = address;
    }

    /// <summary>
    /// Восстанавливает покупателя с сохранённым идентификатором.
    /// Используется при десериализации JSON.
    /// </summary>
    /// <param name="id">Сохранённый идентификатор.</param>
    /// <param name="fullname">Полное имя покупателя.</param>
    /// <param name="address">Адрес доставки.</param>
    [JsonConstructor]
    public Customer(int id, string fullname, Address address)
    {
        if (id <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(id));
        }

        _id = id;
        Fullname = fullname;
        Address = address;

        IdGenerator.RegisterExistingId(id);
    }

    public override string ToString()
    {
        return Fullname;
    }
}

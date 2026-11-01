using ObjectOrientedPractics.Services;
using Newtonsoft.Json;

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
    /// Возвращает уникальный идентификатор покупателя.
    /// </summary>
    public int Id { get { return _id; } }

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
    /// Создаёт покупателя с пустым адресом.
    /// </summary>
    public Customer()
    {
        _id = IdGenerator.GetNextId();
        _address = new Address();
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

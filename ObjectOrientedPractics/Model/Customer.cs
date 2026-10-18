using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjectOrientedPractics.Model;

/// <summary>
/// Хранит данные о покупателе: уникальный идентификатор, полное имя и адрес.
/// </summary>
public class Customer
{
    /// <summary>
    /// Уникальный идентификатор покупателя.
    /// </summary>
    private readonly int _id;

    /// <summary>
    /// Полное имя покупателя.
    /// </summary>
    private string _fullname;

    /// <summary>
    /// Адрес покупателя.
    /// </summary>
    private string _address;

    /// <summary>
    /// Возвращает уникальный идентификатор покупателя.
    /// </summary>
    public int Id { get { return _id; } }

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
    /// Возвращает и задаёт адрес покупателя. Должен быть не длиннее 500 символов.
    /// </summary>
    public string Address
    {
        get
        {
            return _address;
        }
        set
        {
            ValueValidator.AssertStringOnLength(value, 500, nameof(Address));
            _address = value;
        }
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Customer"/>.
    /// </summary>
    public Customer()
    {
        _id = IdGenerator.GetNextId();
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Customer"/>.
    /// </summary>
    /// <param name="fullname">Полное имя покупателя. Должно быть не длиннее 200 символов.</param>
    /// <param name="address">Адрес покупателя. Должен быть не длиннее 500 символов.</param>
    public Customer(string fullname, string address)
    {
        Fullname = fullname;
        Address = address;
        _id = IdGenerator.GetNextId();
    }
    public override string ToString()
    {
        return Fullname;
    }
}

using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model;

/// <summary>
/// Хранит данные о товаре: уникальный идентификатор, название, описание и стоимость.
/// </summary>
public class Item
{
    /// <summary>
    /// Уникальный идентификатор товара.
    /// </summary>
    private readonly int _id;

    /// <summary>
    /// Название товара.
    /// </summary>
    private string _name;

    /// <summary>
    /// Описание товара.
    /// </summary>
    private string _info;

    /// <summary>
    /// Стоимость товара.
    /// </summary>
    private double _cost;

    /// <summary>
    /// Возвращает уникальный идентификатор товара.
    /// </summary>
    public int Id { get { return _id; } }

    /// <summary>
    /// Возвращает и задаёт название товара. Должно быть не длиннее 200 символов.
    /// </summary>
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
            _name = value;
        }
    }

    /// <summary>
    /// Возвращает и задаёт описание товара. Должно быть не длиннее 1000 символов.
    /// </summary>
    public string Info
    {
        get { return _info; }
        set
        {
            ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
            _info = value;
        }
    }

    /// <summary>
    /// Возвращает и задаёт стоимость товара. Должна быть в диапазоне от 0 до 100 000.
    /// </summary>
    public double Cost
    {
        get
        {
            return _cost;
        }
        set
        {
            if (value < 0 || value > 100000)
            {
                throw new ArgumentException("Cost must be in range[0, 100 000]");
            }

            _cost = value;
        }
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Item"/>.
    /// </summary>
    public Item()
    {
        _id = IdGenerator.GetNextId();
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Item"/>.
    /// </summary>
    /// <param name="name">Название товара. Должно быть не длиннее 200 символов.</param>
    /// <param name="info">Описание товара. Должно быть не длиннее 1000 символов.</param>
    /// <param name="cost">Стоимость товара. Должна быть в диапазоне от 0 до 100 000.</param>
    public Item(string name, string info, double cost)
    {
        Name = name;
        Info = info;
        Cost = cost;
        _id = IdGenerator.GetNextId();

    }
    public override string ToString()
    {
        return Name;
    }
}

using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model;

/// <summary>
/// Хранит данные о товаре.
/// </summary>
public class Item
{
    /// <summary>
    /// Идентификатор товара.
    /// </summary>
    private int _id;

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
    /// Возвращает ID товара.
    /// </summary>
    public int Id
    {
        get
        {
            return _id;
        }
    }

    /// <summary>
    /// Изменяет ID товара.
    /// </summary>
    /// <param name="id">Новый ID.</param>
    internal void SetId(int id)
    {
        if (id <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(id));
        }

        _id = id;
    }

    /// <summary>
    /// Категория товара.
    /// </summary>
    public Category Category { get; set; }

    /// <summary>
    /// Название товара до 200 символов.
    /// </summary>
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            ValueValidator.AssertStringOnLength(
                value, 200, nameof(Name));

            _name = value;
        }
    }

    /// <summary>
    /// Описание товара до 1000 символов.
    /// </summary>
    public string Info
    {
        get
        {
            return _info;
        }
        set
        {
            ValueValidator.AssertStringOnLength(
                value, 1000, nameof(Info));

            _info = value;
        }
    }

    /// <summary>
    /// Стоимость товара от 0 до 100000.
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
                throw new ArgumentException(
                    "Cost must be in range[0, 100 000]");
            }

            _cost = value;
        }
    }

    /// <summary>
    /// Создаёт товар с новым ID.
    /// </summary>
    public Item()
    {
        _id = IdGenerator.GetNextId();
    }

    /// <summary>
    /// Создаёт товар с указанными данными.
    /// </summary>
    /// <param name="name">Название.</param>
    /// <param name="info">Описание.</param>
    /// <param name="cost">Стоимость.</param>
    /// <param name="category">Категория.</param>
    public Item(
        string name,
        string info,
        double cost,
        Category category)
    {
        Name = name;
        Info = info;
        Cost = cost;
        Category = category;

        _id = IdGenerator.GetNextId();
    }

    /// <summary>
    /// Возвращает название товара.
    /// </summary>
    /// <returns>Название товара.</returns>
    public override string ToString()
    {
        return Name;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services;

/// <summary>
/// Предоставляет методы для генерации уникальных идентификаторов.
/// </summary>
public static class IdGenerator
{
    /// <summary>
    /// Текущий идентификатор.
    /// </summary>
    private static int _id = 1;

    /// <summary>
    /// Возвращает следующий уникальный идентификатор.
    /// </summary>
    /// <returns>Возвращает целочисленный идентификатор.</returns>
    public static int GetNextId()
    {
        return _id++;
    }
    /// <summary>
    /// Учитывает ранее сохранённый идентификатор.
    /// </summary>
    /// <param name="id">Идентификатор загруженного объекта.</param>
    public static void RegisterExistingId(int id)
    {
        if (id <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(id));
        }

        if (id >= _id)
        {
            _id = checked(id + 1);
        }
    }
}
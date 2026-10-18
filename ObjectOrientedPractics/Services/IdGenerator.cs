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
}
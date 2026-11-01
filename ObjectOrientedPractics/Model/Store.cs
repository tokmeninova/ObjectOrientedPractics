
using System;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит коллекции товаров и покупателей магазина.
    /// </summary>
    public class Store
    {
        /// <summary>
        /// Список товаров магазина.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Список покупателей магазина.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Возвращает или задаёт список товаров.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value ?? throw new ArgumentNullException(
                    nameof(value));
            }
        }

        /// <summary>
        /// Возвращает или задаёт список покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value ?? throw new ArgumentNullException(
                    nameof(value));
            }
        }

        /// <summary>
        /// Создаёт магазин с пустыми списками
        /// товаров и покупателей.
        /// </summary>
        public Store()
        {
            _items = new List<Item>();
            _customers = new List<Customer>();
        }
    }
}

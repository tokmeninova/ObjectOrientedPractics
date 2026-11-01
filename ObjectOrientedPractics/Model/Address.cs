using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет адрес доставки покупателя.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна или регион.
        /// </summary>
        private string _country;

        /// <summary>
        /// Город или населённый пункт.
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица.
        /// </summary>
        private string _street;

        /// <summary>
        /// Номер дома.
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры или помещения.
        /// </summary>
        private string _apartment;
  
    /// <summary>
    /// Почтовый индекс. Шестизначное число.
    /// </summary>
    public int Index
        {
            get 
            {
                return _index; 
            }
            set
            {
                if (value < 100000 || value > 999999)
                {
                    throw new ArgumentException(
                        "Почтовый индекс должен содержать 6 цифр.");
                }

                _index = value;
            }
        }

        /// <summary>
        /// Страна или регион. Не более 50 символов.
        /// </summary>
        public string Country
        {
            get
            {
                return _country; 
            }
            set
            {
                ValueValidator.AssertStringOnLength(
                    value, 50, nameof(Country));

                _country = value;
            }
        }

        /// <summary>
        /// Город. Не более 50 символов.
        /// </summary>
        public string City
        {
            get 
            {
                return _city; 
            }
            set
            {
                ValueValidator.AssertStringOnLength(
                    value, 50, nameof(City));

                _city = value;
            }
        }

        /// <summary>
        /// Улица. Не более 100 символов.
        /// </summary>
        public string Street
        {
            get 
            { 
                return _street;
            }
            set
            {
                ValueValidator.AssertStringOnLength(
                    value, 100, nameof(Street));

                _street = value;
            }
        }

        /// <summary>
        /// Номер дома. Не более 10 символов.
        /// </summary>
        public string Building
        {
            get 
            { 
                return _building;
            }
            set
            {
                ValueValidator.AssertStringOnLength(
                    value, 10, nameof(Building));

                _building = value;
            }
        }

        /// <summary>
        /// Номер квартиры. Не более 10 символов.
        /// </summary>
        public string Apartment
        {
            get 
            { 
                return _apartment;
            }
            set
            {
                ValueValidator.AssertStringOnLength(
                    value, 10, nameof(Apartment));

                _apartment = value;
            }
        }


        /// <summary>
        /// Создаёт пустой адрес.
        /// </summary>
        public Address()
        {
            _index = 0;
            _country = string.Empty;
            _city = string.Empty;
            _street = string.Empty;
            _building = string.Empty;
            _apartment = string.Empty;
        }

        /// <summary>
        /// Создаёт адрес с указанными данными.
        /// </summary>
        /// <param name="index">Почтовый индекс.</param>
        /// <param name="country">Страна.</param>
        /// <param name="city">Город.</param>
        /// <param name="street">Улица.</param>
        /// <param name="building">Номер дома.</param>
        /// <param name="apartment">Номер квартиры.</param>
        public Address(
            int index,
            string country,
            string city,
            string street,
            string building,
            string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }


    }
}

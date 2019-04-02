using System;
using System.Collections.Generic;

namespace Barbershop
{

    /// <sumary>
    /// Клиенты
    /// </sumary>
    public class Client
    {
        /// <summary>
        /// ФИО
        /// </summary>
        public string ClientName { get; set; }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime Birthday { get; set; }
        /// <summary>
        /// Фотография клиента
        /// </summary>
        public byte[] Photo { get; set; }
        /// <summary>
        /// Номер телефона
        /// </summary>
        public string PhoneNumber { get; set; }
    }
    /// <sumary>
    /// Запись к барберу
    /// </sumary>
    public class Appointment
    {
        /// <summary>
        /// Дата посещения
        /// </summary>
        public DateTime VisitDate { get; set; }
        /// <summary>
        /// Описание услуги
        /// </summary>
        public List<TypeService> Service { get; set; }
        /// <summary>
        /// Данные клиента
        /// </summary>
        public Client ClientData { get; set; }
        /// <summary>
        /// Сотрудники
        /// </summary>
        public class Workers
        {
            /// <summary>
            /// Индивидуальный номер
            /// </summary>
            public int IndividualNumber { get; set; }
            /// <summary>
            /// ФИО
            /// </summary>
            public string WorkerName { get; set; }
            /// <summary>
            /// Должность
            /// </summary>
            public string Position { get; set; }
            /// <summary>
            /// Дата приема на работу
            /// </summary>
            public DateTime StartDate { get; set; }
            /// <summary>
            /// Адрес
            /// </summary>
            public string Address { get; set; }
            /// <summary>
            /// Фотография барбера
            /// </summary>
            public byte[] Photo { get; set; }
        }
        /// <summary>
        /// Прайс лист
        /// </summary>
        public class PriceList
        {
            /// <summary>
            /// Тип услуги
            /// </summary>
            public List<TypeService> TypeService { get; set; }
            /// <summary>
            /// Парикмахер
            /// </summary>
            public string Barber { get; set; }
            /// <summary>
            /// Цена услуги
            /// </summary>
            public double Price { get; set; }
        }
    }
    /// <summary>
    /// Тип услуги
    /// </summary>
    public enum TypeService
    {
        /// <summary>
        /// Мужская стрижка 
        /// </summary>
        MenHaircut,
        /// <summary>
        /// Стрижка машинкой
        /// </summary>
        HaircutMachine,
        /// <summary>
        /// Моделирование бороды
        /// </summary>
        BeardStyling,
        /// <summary>
        /// Коррекция бороды
        /// </summary>
        BeardСorrection,
        /// <summary>
        /// Укладка волос
        /// </summary>
        HairStyling,
        /// <summary>
        /// Камуфляж седины
        /// </summary>
        GreyCamouflage,
        /// <summary>
        /// Премиум бритье
        /// </summary>
        PremiumShave,
    }
}
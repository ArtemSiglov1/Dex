using Domen.Vlaueobj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domen.Entities
{
    /// <summary>
    /// класс описывающий персону наследуемый от базового класса всех сущностей
    /// </summary>
    public class Person : BaseEntity
    {
        /// <summary>
        /// конструктор с параметрами 
        /// </summary>
        /// <param name="fullName">полное имя</param>
        /// <param name="phoneNumber">номер телефона</param>
        /// <param name="telegram">юз телеграмм</param>
        public Person(FullName fullName,string phoneNumber,string telegram)
        {
            FullName = ValidateFullName(fullName);
            PhoneNumber = IsValidPhoneNumber(phoneNumber);
            Telegram = ValidateTelegram(telegram);
        }
        /// <summary>
        /// сущность полного имени
        /// </summary>
        public FullName FullName { get; set; }
        /// <summary>
        /// свойство даты рождения
        /// </summary>
        public DateTime BirthDay { get; set; }
        /// <summary>
        /// свойство возраста
        /// </summary>
        public int Age => DateTime.Now.Year - BirthDay.Year<150? DateTime.Now.Year - BirthDay.Year : throw new ArgumentException("Возраст не может превышать 150 лет.");

        /// <summary>
        /// свойство номера телефона
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// свойство юз телеграмма
        /// </summary>
        public string Telegram{get; set;}
        /// <summary>
        ///метод проверки полного имени 
        /// </summary>
        /// <param name="fullName">сущность полного имени</param>
        /// <returns>полное имя</returns>
        /// <exception cref="ArgumentException">
        /// Имя и фамилия не могут быть пустыми
        /// отчество не может быть пустым
        /// буквы только русской расскладки
        /// </exception>
        private FullName ValidateFullName(FullName fullName)
        {
            if (string.IsNullOrEmpty(fullName.FirstName) ||
                string.IsNullOrEmpty(fullName.LastName))
            {
                throw new ArgumentException("Имя и фамилия не могут быть пустыми");
            }
            
            if(fullName.MiddleName is not null)
            {
                if(fullName.MiddleName == string.Empty)
                {
                    throw new ArgumentException("отчество не может быть пустым");
                }
            }
             foreach(char c in fullName.FirstName+fullName.LastName+fullName.MiddleName)
             {
                if (c >= 'A' && c <= 'Z'|| c >= 'a' && c <= 'z')
                {
                    throw new ArgumentException("буквы только русской расскладки");
                    
                }
            }
            return fullName;

        }
        /// <summary>
        /// метод проверки номера телефона 
        /// </summary>
        /// <param name="phoneNumber">номер телефона</param>
        /// <returns>номер телефона</returns>
        /// <exception cref="ArgumentException">
        /// Номер телефона должен начинаться с '+37377' и содержать одну цифру от 4 до 9, а затем любые 5 цифр.
        /// </exception>
        private string IsValidPhoneNumber(string phoneNumber)
        {
            if(phoneNumber == null || !Regex.IsMatch(phoneNumber, @"^(\+37377)[4-9]\d{5}$"))
            {
                throw new ArgumentException("Номер телефона должен начинаться с '+37377' и содержать одну цифру от 4 до 9, а затем любые 5 цифр.");
            }
            return phoneNumber;
        }
        /// <summary>
        /// метод для проверки юз телеграмма
        /// </summary>
        /// <param name="telegram">юз телеграмм</param>
        /// <returns>юз телеграмм</returns>
        /// <exception cref="ArgumentException">
        /// Значение должно начинаться с символа '@'.
        /// </exception>
        private string ValidateTelegram(string telegram)
        {
            if (telegram == null || !telegram.StartsWith("@"))
            {
                throw new ArgumentException("Значение должно начинаться с символа '@'.");
            }
            return telegram;
        }
    }
}

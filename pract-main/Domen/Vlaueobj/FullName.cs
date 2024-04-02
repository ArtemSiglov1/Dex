using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen.Vlaueobj
{
    /// <summary>
    /// класс описывающий полное имя наследуемый от базавого класса для значимых объектов
    /// </summary>
    public class FullName : BaseValueObj
    {
        /// <summary>
        /// конструктор с параметрами 
        /// </summary>
        /// <param name="firstName">фамилия</param>
        /// <param name="lastName">имя</param>
        /// <param name="middleName">отчество</param>
        public FullName(string firstName, string lastName, string middleName)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
        }
        /// <summary>
        /// фамилия
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// имя
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Может быть отчеством
        /// </summary>
        public string? MiddleName { get; set; } = null;
    }
}

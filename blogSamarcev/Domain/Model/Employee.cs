using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blogSamarcev.Domain.Model.Common;

namespace blogSamarcev.Domain.Model
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class Employee : Entity
    {
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия пользователя
        /// </summary>
        public string SurName { get; set; }

        /// <summary>
        /// Адрес проживания пользователя
        /// </summary>
        public string Adress { get; set; }  


        public string FullName
        {
            get => FirstName + " " + SurName;
        }
    }
}

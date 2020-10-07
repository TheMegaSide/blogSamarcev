﻿using blogSamarcev.Domain.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogSamarcev.Domain
{/// <summary>
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
        public string Surname { get; set; }
        /// <summary>
        /// Адрес проживания пользователя
        /// </summary>
        public string Adress { get; set; }

        /// <summary>
        /// Возвращает полное имя пользователя
        /// </summary>
        public string FullName
        {
            get => FirstName + " " + Surname;
        }

    }
}

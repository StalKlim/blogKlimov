﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blogKlimov.Domain.Model.Common;

namespace blogKlimov.Domain.Model
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
        public string Surname { get; set; }

        /// <summary>
        /// Адрес проживания пользователя
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Возвращает полное имя пользователя
        /// </summary>
        public string FullName
        {
            get => FirstName + " " + Surname;
        }
    }
}
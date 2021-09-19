using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    /// <summary>
    /// 
    /// </summary>
    class Person
    {
        string name;
        string surname;
        DateTime birthday;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nameValue"></param>
        /// <param name="surnameValue"></param>
        /// <param name="birthdayValue"></param>
        public Person(string nameValue, string surnameValue, DateTime birthdayValue)
        {
            name = nameValue;
            surname = surnameValue;
            birthday = birthdayValue;
        }
        /// <summary>
        /// 
        /// </summary>
        public Person() : this("Obama", "Ivanovich", new DateTime(2000, 1, 1))
        {
        }
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Year
        {
            get
            {
                return Birthday.Year;
            }
            set
            {
                Birthday = new DateTime(value, Birthday.Month, Birthday.Day);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name + " " + Surname + " " + Birthday.ToShortDateString();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual string ToShortString()
        {
            return Name + " " + Surname;
        }

    }
}

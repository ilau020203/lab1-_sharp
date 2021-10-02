using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    /// <summary>
    /// Class for containing single person data.
    /// </summary>
    class Person
    {
        string name;
        string surname;
        DateTime birthday;
        /// <summary>
        /// Constructor with all necessary data, to represent a person.
        /// </summary>
        /// <param name="name">Person's Name.</param>
        /// <param name="surname">Person's Surname/</param>
        /// <param name="birthday">Person's Nirthday/</param>
        public Person(string nameValue, string surnameValue, DateTime birthdayValue)
        {
            name = nameValue;
            surname = surnameValue;
            birthday = birthdayValue;
        }
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Person() : this("Obama", "Ivanovich", new DateTime(2000, 1, 1))
        {
        }
        /// <summary>
        /// Representation of Person's Name.
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
        /// Representation of Person's Surname.
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
        /// Representation of Person's birth Year.
        /// </summary>
        /// <value>Changes Person's birth year, bul leaves all other data untouched.</value>
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
        /// Representation of Person's birth Year.
        /// </summary>
        /// <value>Changes Person's birth year, bul leaves all other data untouched.</value>
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
        /// Single line representation of person
        /// /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name + " " + Surname + " " + Birthday.ToShortDateString();
        }
        /// <summary>
        /// Single line representation of person< with no birthday.
        /// </summary>
        /// <returns></returns>
        /// <returns></returns>
        public virtual string ToShortString()
        {
            return Name + " " + Surname;
        }

    }
}

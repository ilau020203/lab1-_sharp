using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    /// <summary>
    /// 
    /// </summary>
    class Article
    {
        Person person;
        string title;
        double rating;
        public double Rating
        {
            get
            {
                return rating;
            }
            set
            {
                rating = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public Person Person
        {
            get
            {
                return person;
            }
            set
            {
                person = value;
            }
        }
        /// <summary>
        /// full construcrtor 
        /// </summary>
        /// <param name="nameValue"></param>
        /// <param name="surnameValue"></param>
        /// <param name="birthdayValue"></param>
        /// <param name="titleValue"></param>
        /// <param name="ratingValue"></param>
        public Article(string nameValue, string surnameValue, DateTime birthdayValue, string titleValue, double ratingValue)
        {
            person = new Person(nameValue, surnameValue, birthdayValue);
            title = titleValue;
            rating = ratingValue;
        }
        /// <summary>
        /// full construcrtor by full
        /// </summary>
        /// <param name="personValue"></param>
        /// <param name="titleValue"></param>
        /// <param name="ratingValue"></param>
        public Article(Person personValue, string titleValue, double ratingValue)
        {
            person = personValue;
            title = titleValue;
            rating = ratingValue;
        }
        /// <summary>
        /// default construcrtor
        /// </summary>
        public Article() : this(new Person(), "article title", 0) { }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return person.ToString() + " " + title + " rating:" + rating;
        }
    }
}

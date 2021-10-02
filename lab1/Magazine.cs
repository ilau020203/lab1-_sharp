using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace lab1
{
    /// <summary>
    /// Class for containing all Magazine metadata, including editors and articles.
    /// </summary>
    class Magazine
    {
        string title;
        DateTime createdDate;
        int circulation;
        Article[] articles;
        public Frequency Frequency { get; set; }//property
        /// <summary>
        /// full construcrtor
        /// </summary>
        /// <param name="titleValue"></param>
        /// <param name="frequencyValue"></param>
        /// <param name="createdDateValue"></param>
        /// <param name="circulationValue"></param>
        public Magazine(string titleValue, Frequency frequencyValue, DateTime createdDateValue,int circulationValue)
        {
            title = titleValue;
            Frequency = frequencyValue;
            createdDate = createdDateValue;
            circulation = circulationValue;
            articles = new Article[0];
        }

        /// <summary>
        /// default construcrtor
        /// </summary>
        public Magazine():this("title",Frequency.Weekly,new DateTime(),0)
        { }
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
        ///          /// </summary>
        public DateTime CreatedDate
        {
            get
            {
                return createdDate;
            }
            set
            {
                createdDate = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public Article[] Articles
        {
            get
            {
                return articles;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException();
                foreach(Article article in value)
                {
                    if (article == null)
                        throw new ArgumentNullException();
                }
                articles = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Circulation
        {
            get
            {
                return circulation;
            }
            set
            {
                circulation = value;
            }
        }

       /// <summary>
       /// 
       /// </summary>
        public double Rating
        {
            get
            {
                if (articles.Length == 0)
                    return 0;
                double sum = 0;
                foreach(Article item in articles)
                {
                    sum += item.Rating;
                }
                return sum / articles.Length;
            }
        }
        /// <summary>
        /// add new article
        /// </summary>
        /// <param name="list">new article</param>
        public void AddArticles(params Article[] list)
        {
            articles=articles.Concat(list).ToArray();
        }

        /// <summary>
        /// return true if Freqency equal
        /// </summary>
        /// <param name="frequencyValue"></param>
        /// <returns></returns>
        public bool this[Frequency frequencyValue] => frequencyValue == Frequency;
        /// <summary>
        /// to string with arcticlle
        /// </summary>
        /// <returns> sting wtih full parametr with article</returns>
        public override string ToString() => title +
            " " + Frequency.ToString() + " " + createdDate.ToShortDateString()
            + " circulation:" + circulation + " Rating:" + Rating + Environment.NewLine +
           String.Join<Article>(Environment.NewLine, articles);
        /// <summary>
        ///return data without aticle
        /// </summary>
        /// <returns>return data without</returns>
        public virtual string ToShortString() => title +
            " " + Frequency.ToString() + " " + createdDate.ToShortDateString()
            + " circulation:" + circulation + " Rating:" + Rating + Environment.NewLine;
    }
}

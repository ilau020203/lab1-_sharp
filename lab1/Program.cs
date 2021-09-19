using System;
using System.Diagnostics;
using System.Linq;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Magazine magazine = new Magazine();
            Console.WriteLine(magazine.ToShortString());
            //2
            Console.WriteLine(magazine[Frequency.Monthly]);
            Console.WriteLine(magazine[Frequency.Weekly]);
            Console.WriteLine(magazine[Frequency.Yearly]);
            //3
            magazine.Circulation = 123;
            magazine.CreatedDate = DateTime.Now;
            magazine.Title = "new title";
            Article[] articles = new Article[1];
            articles[0] = new Article();
            magazine.Articles = articles;
            Console.WriteLine(magazine.ToString());
            Console.WriteLine(Environment.NewLine);
            //4
            magazine.AddArticles(new Article(), new Article("aasf","asdfas",new DateTime(),"titile",9), new Article(), new Article());
            Console.WriteLine(magazine.ToString());
            
            //5
            Console.WriteLine("separator:\',\', \' \', \';\'");
            int[] sizeOfArray = Console.ReadLine().Split(',', ' ', ';').Select((value) => int.Parse(value)).ToArray();

            Article[] articles1 = new Article[sizeOfArray[0] * sizeOfArray[1]];
            for (int i = 0; i < articles1.Length; i++)
            {
                articles1[i] = new Article();
            }

            Article[,] articles2 = new Article[sizeOfArray[0] ,sizeOfArray[1]];
            for (int i = 0; i < sizeOfArray[0]; i++)
            {
                for(int j =0;j< sizeOfArray[1]; j++)
                {
                    articles2[i,j] = new Article();
                }
            }

            Article[][] articles3 = new Article[sizeOfArray[0]][];
            for (int i = 0; i < sizeOfArray[0]; i++)
            {
                articles3[i] = new Article[sizeOfArray[1]];
                for (int j = 0; j < sizeOfArray[1]; j++)
                {
                    articles3[i][j] = new Article();
                }
            }
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < articles1.Length; i++)
            {
                articles1[i].Rating = 124;
            }
            stopWatch.Stop();
            Console.WriteLine("one demensional"+stopWatch.Elapsed.TotalMilliseconds.ToString());
            stopWatch.Restart();
            for (int i = 0; i < sizeOfArray[0]; i++)
            {
                for (int j = 0; j < sizeOfArray[1]; j++)
                {
                    articles2[i, j].Rating=124;
                }
            }
            stopWatch.Stop();
            Console.WriteLine("one demensional rectangal" + stopWatch.Elapsed.TotalMilliseconds.ToString());
            stopWatch.Restart();
            for (int i = 0; i < sizeOfArray[0]; i++)
            {
                for (int j = 0; j < sizeOfArray[1]; j++)
                {
                    articles3[i][j].Rating = 124;
                }
            }
            stopWatch.Stop();
            Console.WriteLine("one demensional steped" + stopWatch.Elapsed.TotalMilliseconds.ToString());
        }
    }
}

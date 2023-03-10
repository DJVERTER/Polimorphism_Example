namespace Polimorphism_Example
{
    internal class Program
    {
        public class News
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public DateTime Created { get; set; } = DateTime.Now;
            public string GetHappyNews()
            {
                string happyNews = "Happy! " + Description;
                return happyNews;
            }
        }

        public class SuperNews : News
        {
            public string SuperMethod()
            {
                string happyNews = "Super! " + Description;
                return happyNews;
            }
        }
        static void Main(string[] args)
        {
            News newsObject = new News();
            newsObject.Description = "First News";
            Console.WriteLine(newsObject.Description);
            Console.WriteLine(newsObject.GetHappyNews());
            Console.WriteLine(newsObject.Created);

            Console.WriteLine("------------------------");

            SuperNews newsSuper = new SuperNews();
            newsSuper.Description = "First super news";
            Console.WriteLine(newsSuper.Description);
            Console.WriteLine(newsSuper.GetHappyNews());
            Console.WriteLine(newsSuper.SuperMethod());
            Console.WriteLine(newsSuper.Created);


            Console.ReadLine();
        }
    }
}
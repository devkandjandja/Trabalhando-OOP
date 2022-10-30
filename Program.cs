using System.Linq;
using StackFul.ContentContext;

namespace StackFul
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "Orientacao-Objeto"));
            articles.Add(new Article("Artigo sobre C#", "CSharp"));
            articles.Add(new Article("Artigo sobre Dotnet", "DotNet"));
            // foreach (var article in articles)
            // {
            //     Console.WriteLine(article.Id);
            //     Console.WriteLine(article.Title);
            //     Console.WriteLine(article.Url);
            // }
            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OPP", "fundamentos");
            var courseCSharp = new Course("Fundamentos C#", "dominando c#");
            var courseAspNet = new Course("Fundamentos Asp.Net", "dominando Asp.Net");
            courses.Add(courseOOP);
            courses.Add(courseCSharp);
            courses.Add(courseAspNet);

            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .Net", "especialista-dotnet");
            var careerItem2 = new CareerItem(2, "Aprenda OOP", "", null);
            var careerItem = new CareerItem(1, "comece por aqui", "", courseCSharp);
            var careerItem3 = new CareerItem(3, "Aprenda Aspnet", "", courseAspNet);
            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem);
            careerDotnet.Items.Add(careerItem3);
            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Oder))
                {
                    Console.WriteLine($"{item.Oder} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Lever);

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
            }
        }
    }
}
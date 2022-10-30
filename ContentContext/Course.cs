using StackFul.ContentContext.Enums;

namespace StackFul.ContentContext
{
    public class Course : Content
    {
        public Course(string title, string url)
        : base(title, url)
        {
            Modules = new List<Module>();
        }
        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }// Devemos depender sempre da abstração nunca da implementação 
        public int DurationInMinutes { get; set; }
        public EContextLevel Lever { get; set; }
        //sempre que se trabalhar com objeto dentro de objeto seja uma lista ou um objeto somente deve-se inicializar dentro do construtor.
    }
}
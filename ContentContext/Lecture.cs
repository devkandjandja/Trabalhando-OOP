using StackFul.ContentContext;
using StackFul.ContentContext.Enums;
using StackFul.SharedContext;

namespace StackuFul.ContentContext
{
    public class Lecture : Base
    {
        public string Order { get; set; }
        public string Title { get; set; }
        public int DuratioInMinutes { get; set; }
        public EContextLevel Level { get; set; }
    }
}
using StackFul.NotificationContext;
using StackFul.SharedContext;

namespace StackFul.ContentContext
{
    public class CareerItem : Base
    {
        public CareerItem(int oder, string title, string description, Course course)
        {
            if (course == null)
                AddNotification(new Notification("Course", "Curso iválido"));
            Oder = oder;
            Title = title;
            Description = description;
            Course = course;
        }

        public int Oder { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}
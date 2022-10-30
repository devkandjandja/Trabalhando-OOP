using StackFul.NotificationContext;

namespace StackFul.SharedContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid(); // Indica o SPOF - ponto unico de falha
        }
        public Guid Id { get; set; }
    }
}
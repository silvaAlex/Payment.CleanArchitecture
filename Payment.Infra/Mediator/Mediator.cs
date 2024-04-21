using Payment.Application.Mediator;

namespace Payment.Infra.Mediator
{
    public class Mediator : IMediator
    {
        private readonly IList<(string EventName, Action<object> callback)> _observers;

        public Mediator()
        {
            _observers = new List<(string EventName, Action<object> callback)>();   
        }

        public void Create(string eventName, Action<object> callback)
        {
            _observers.Add((eventName, callback));
        }

        public async Task Publish(string eventName, object data)
        {
            foreach (var (EventName, callback) in _observers)
            {
                if(EventName.Equals(eventName, StringComparison.InvariantCultureIgnoreCase))
                {
                    await Task.Run(() => callback(data));
                }
            }
        }
    }
}

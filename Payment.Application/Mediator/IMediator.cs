namespace Payment.Application.Mediator
{
    public interface IMediator
    {
        void Create(string eventName, Action<object> callback);
        Task Publish(string eventName, object data);
    }
}

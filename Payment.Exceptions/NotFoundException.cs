namespace Payment.Exceptions
{
    public class NotFoundException : PaymentException
    {
        public NotFoundException(string message) : base(message) { }
        
    }
}

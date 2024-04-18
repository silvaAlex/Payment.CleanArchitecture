namespace Payment.Exceptions
{
    public class PaymentException : SystemException
    {
        public PaymentException(string message) : base(message) { }
       
    }
}

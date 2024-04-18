namespace Payment.Exceptions
{
    public class ErrorOnValidationException : PaymentException
    {
        public ErrorOnValidationException(string message) : base(message) { }
       
    }
}

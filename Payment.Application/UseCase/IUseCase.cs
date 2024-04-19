namespace Payment.Application.UseCase
{
    public interface IUseCase<TInput, TOutput>
    {
        Task<TOutput> Execute(TInput input);
    }
}

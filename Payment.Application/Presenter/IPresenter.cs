namespace Payment.Application.Presenter
{
    public interface IPresenter<TInput, TOutput>
    {
        TOutput Presenter(IList<TInput> input);
    }
}

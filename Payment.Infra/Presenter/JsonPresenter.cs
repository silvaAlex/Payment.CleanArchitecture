using Payment.Application.Communication.Response;
using Payment.Application.Presenter;

namespace Payment.Infra.Presenter
{
    public class JsonPresenter : IPresenter<ResponseInvoice, IList<ResponseInvoice>>
    {
        public IList<ResponseInvoice> Presenter(IList<ResponseInvoice> input)
        {
           return input;
        }
    }
}

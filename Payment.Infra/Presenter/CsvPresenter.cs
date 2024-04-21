using Payment.Application.Communication.Response;
using Payment.Application.Presenter;
using System.Linq;
using System.Text;

namespace Payment.Infra.Presenter
{
    public class CsvPresenter : IPresenter<ResponseInvoice, string>
    {
        public string Presenter(IList<ResponseInvoice> input)
        {
            var csv = new StringBuilder();
            List<object[]> lines = (from line in input
                            select new object[]
                            {
                                line.Date.ToString("yyyy-MM-dd"),
                                line.Amount
                            })
                          .ToList();
   
            lines.ForEach(line => csv.AppendLine(string.Join(";", line)));

            return csv.ToString();
        }
    }
}

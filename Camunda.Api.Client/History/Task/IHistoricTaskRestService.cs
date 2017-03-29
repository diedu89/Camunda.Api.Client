using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    interface IHistoricTaskRestService
    {
        [Get("/history/task/{id}")]
        Task<HistoricTask> Get(string id);

        [Post("/history/task")]
        Task<List<HistoricTask>> GetList([Body] HistoricTaskQuery query, int? firstResult, int? maxResults);

        [Post("/history/task/count")]
        Task<CountResult> GetListCount([Body] HistoricTaskQuery query);
    }
}

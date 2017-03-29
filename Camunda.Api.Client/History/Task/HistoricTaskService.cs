using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    public class HistoricTaskService
    {
        private IHistoricTaskRestService _api;

        internal HistoricTaskService(IHistoricTaskRestService api)
        {
            _api = api;
        }

        public QueryResource<HistoricTaskQuery, HistoricTask> Query(HistoricTaskQuery query = null) =>
            new QueryResource<HistoricTaskQuery, HistoricTask>(_api, query);

        /// <param name="taskId">The id of the historic task to be retrieved.</param>
        public HistoricTaskResource this[string taskId] => new HistoricTaskResource(_api, taskId);
    }
}

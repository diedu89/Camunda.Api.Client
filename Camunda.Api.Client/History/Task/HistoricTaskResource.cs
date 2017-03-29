using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    public class HistoricTaskResource
    {
        private IHistoricTaskRestService _api;
        private string _taskId;

        internal HistoricTaskResource(IHistoricTaskRestService api, string taskId)
        {
            _api = api;
            _taskId = taskId;
        }

        /// <summary>
        /// Retrieves a historic task by id, according to the <see cref="HistoricTask"/> interface in the engine.
        /// </summary>
        public Task<HistoricTask> Get() => _api.Get(_taskId);
    }
}

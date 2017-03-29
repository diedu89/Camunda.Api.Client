using System;

namespace Camunda.Api.Client.History
{
    public class HistoricTask
    {
        /// <summary>
        /// The task id
        /// </summary>
        public string Id;
        /// <summary>
        /// The key of the process definition the task belongs to.
        /// </summary>
        public string ProcessDefinitionKey;
        /// <summary>
        /// The id of the process definition the task belongs to.
        /// </summary>
        public string ProcessDefinitionId;
        /// <summary>
        /// The id of the process instance the task belongs to.
        /// </summary>
        public string ProcessInstanceId;
        /// <summary>
        /// The id of the execution the task belongs to.
        /// </summary>
        public string ExecutionId;
        /// <summary>
        /// The key of the case definition the task belongs to.
        /// </summary>
        public string CaseDefinitionKey;
        /// <summary>
        /// The id of the case definition the task belongs to.
        /// </summary>
        public string CaseDefinitionId;
        /// <summary>
        /// The id of the case instance the task belongs to.
        /// </summary>
        public string CaseInstanceId;
        /// <summary>
        /// The id of the case execution the task belongs to.
        /// </summary>
        public string CaseExecutionId;
        /// <summary>
        /// The id of the activity that this object is an instance of.
        /// </summary>
        public string ActivityInstanceId;
        /// <summary>
        /// The task name.
        /// </summary>
        public string Name;
        /// <summary>
        /// The task's description.
        /// </summary>
        public string Description;
        /// <summary>
        /// The task's delete reason.
        /// </summary>
        public string DeleteReason;
        /// <summary>
        /// The owner's id.
        /// </summary>
        public string Owner;
        /// <summary>
        /// The assignee's id.
        /// </summary>
        public string Assignee;
        /// <summary>
        /// The time the task was started.
        /// </summary>
        public DateTime StartTime;
        /// <summary>
        /// The time the task ended.
        /// </summary>
        public DateTime EndTime;
        /// <summary>
        /// The time the task took to finish (in milliseconds).
        /// </summary>
        public long Duration;
        /// <summary>
        /// The task's key.
        /// </summary>
        public string TaskDefinitionKey;
        /// <summary>
        /// The task's priority.
        /// </summary>
        public long Priority;
        /// <summary>
        /// The task's due date.
        /// </summary>
        public DateTime Due;
        /// <summary>
        /// The id of the parent task, if this task is a subtask.
        /// </summary>
        public string ParentTaskId;
        /// <summary>
        /// The follow-up date for the task.
        /// </summary>
        public DateTime FollowUp;
        /// <summary>
        /// The tenant id of the task instance.
        /// </summary>
        public string TenantId;

        public override string ToString() => Id;
    }
}
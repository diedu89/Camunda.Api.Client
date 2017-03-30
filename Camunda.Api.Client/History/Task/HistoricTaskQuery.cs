using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Camunda.Api.Client.History
{
    public class HistoricTaskQuery
    {
        /// <summary>
        /// Filter by task id.
        /// </summary>
        public string TaskId;
        /// <summary>
        /// Filter by parent task id.
        /// </summary>
        public string TaskParentTaskId;
        /// <summary>
        /// Filter by process instance id.
        /// </summary>
        public string ProcessInstanceId;
        /// <summary>
        /// Filter by the id of the execution that executed the task.
        /// </summary>
        public string ExecutionId;
        /// <summary>
        /// Filter by process definition id.
        /// </summary>
        public string ProcessDefinitionId;
        /// <summary>
        /// Restrict to tasks that belong to a process definition with the given key.
        /// </summary>
        public string ProcessDefinitionKey;
        /// <summary>
        /// Restrict to tasks that belong to a process definition with the given name.
        /// </summary>
        public string ProcessDefinitionName;
        /// <summary>
        /// Filter by case instance id.
        /// </summary>
        public string CaseInstanceId;
        /// <summary>
        /// Filter by the id of the case execution that executed the task.
        /// </summary>
        public string CaseExecutionId;
        /// <summary>
        /// Filter by case definition id.
        /// </summary>
        public string CaseDefinitionId;
        /// <summary>
        /// Restrict to tasks that belong to a case definition with the given key.
        /// </summary>
        public string CaseDefinitionKey;
        /// <summary>
        /// Restrict to tasks that belong to a case definition with the given name.
        /// </summary>
        public string CaseDefinitionName;
        /// <summary>
        /// Filter by a list of activity instance ids. A task must have one of the given tenant ids. Must be an array of Strings.
        /// </summary>
        [JsonProperty("activityInstanceIdIn")]
        public List<string> ActivityInstanceIds;
        /// <summary>
        /// Restrict to tasks that have the given name.
        /// </summary>
        public string TaskName;
        /// <summary>
        /// Restrict to tasks that have a name with the given parameter value as substring.
        /// </summary>
        public string TaskNameLike;
        /// <summary>
        /// Restrict to tasks that have the given description.
        /// </summary>
        public string TaskDescription;
        /// <summary>
        /// Restrict to tasks that have a description that has the parameter value as a substring.
        /// </summary>
        public string TaskDescriptionLike;
        /// <summary>
        /// Restrict to tasks that have the given key.
        /// </summary>
        public string TaskDefinitionKey;
        /// <summary>
        /// Filter by a list of task definition keys. A task must have one of the given definition keys. Must be an array of Strings.
        /// </summary>
        [JsonProperty("taskDefinitionKeyIn")]
        public List<string> TaskDefinitionKeys;
        /// <summary>
        /// Restrict to tasks that have the given delete reason.
        /// </summary>
        public string TaskDeleteReason;
        /// <summary>
        /// Restrict to tasks that have a delete reason that has the parameter value as a substring.
        /// </summary>
        public string TaskDeleteReasonLike;
        /// <summary>
        /// Restrict to tasks that the given user is assigned to.
        /// </summary>
        public string TaskAssignee;
        /// <summary>
        /// Restrict to tasks that are assigned to users with the parameter value as a substring.
        /// </summary>
        public string taskAssigneeLike;
        /// <summary>
        /// Restrict to tasks that the given user owns.
        /// </summary>
        public string TaskOwner;
        /// <summary>
        /// Restrict to tasks that are owned by users with the parameter value as a substring.
        /// </summary>
        public string TaskOwnerLike;
        /// <summary>
        /// Restrict to tasks that have the given priority.
        /// </summary>
        public long? TaskPriority;
        /// <summary>
        /// If set to true, restricts the query to all tasks that are assigned.
        /// </summary>
        public bool? Assigned;
        /// <summary>
        /// If set to true, restricts the query to all tasks that are unassigned.
        /// </summary>
        public bool? Unassigned;
        /// <summary>
        /// Only include finished tasks.
        /// </summary>
        public bool? Finished;
        /// <summary>
        /// Only include unfinished tasks.
        /// </summary>
        public bool? Unfinished;
        /// <summary>
        /// Only include tasks of finished processes.
        /// </summary>
        public bool? ProcessFinished;
        /// <summary>
        /// Only include tasks of unfinished processes. 
        /// </summary>
        public bool? ProcessUnfinished;
        /// <summary>
        /// Restrict to tasks that are due on the given date. The date must have the format yyyy-MM-dd'T'HH:mm:ss, e.g., 2013-01-23T14:42:45.
        /// </summary>
        public DateTime? DueDate;
        /// <summary>
        /// Restrict to tasks that are due before the given date. The date must have the format yyyy-MM-dd'T'HH:mm:ss, e.g., 2013-01-23T14:42:45.
        /// </summary>
        public DateTime? TaskDueDateBefore;
        /// <summary>
        /// Restrict to tasks that are due after the given date. The date must have the format yyyy-MM-dd'T'HH:mm:ss, e.g., 2013-01-23T14:42:45.
        /// </summary>
        public DateTime? TaskDueDateAfter;
        /// <summary>
        /// Restrict to tasks that have a followUp date on the given date. The date must have the format yyyy-MM-dd'T'HH:mm:ss, e.g., 2013-01-23T14:42:45.
        /// </summary>
        public DateTime? TaskFollowUpDate;
        /// <summary>
        /// Restrict to tasks that have a followUp date before the given date. The date must have the format yyyy-MM-dd'T'HH:mm:ss, e.g., 2013-01-23T14:42:45.
        /// </summary>
        public DateTime? TaskFollowUpDateBefore;
        /// <summary>
        /// Restrict to tasks that have a followUp date after the given date. The date must have the format yyyy-MM-dd'T'HH:mm:ss, e.g., 2013-01-23T14:42:45.
        /// </summary>
        public DateTime? TaskFollowUpDateAfter;
        /// <summary>
        /// Filter by a list of tenant ids. A task instance must have one of the given tenant ids. Must be an array of Strings.
        /// </summary>
        [JsonProperty("tenantIdIn")]
        public List<string> TenantIds;
        /// <summary>
        /// Array to only include tasks that have variables with certain values. 
        /// </summary>
        public List<VariableQueryParameter> TaskVariables = new List<VariableQueryParameter>();
        /// <summary>
        /// Array to only include tasks that belong to a process instance with variables with certain values.
        /// </summary>
        public List<VariableQueryParameter> ProcessVariables = new List<VariableQueryParameter>();
        /// <summary>
        /// Restrict to tasks with a historic identity link to the given user.
        /// </summary>
        public string TaskInvolvedUser;
        /// <summary>
        /// Restrict to tasks with a historic identity link to the given group.
        /// </summary>
        public string TaskInvolvedGroup;
        /// <summary>
        /// Restrict to tasks with a historic identity link to the given candidate user.
        /// </summary>
        public string TaskHadCandidateUser;
        /// <summary>
        /// Restrict to tasks with a historic identity link to the given candidate group.
        /// </summary>
        public string TaskHadCandidateGroup;
        /// <summary>
        /// Only include tasks which have a candidate group.
        /// </summary>
        public bool? WithCandidateGroups;
        /// <summary>
        /// Only include tasks which have no candidate group.
        /// </summary>
        public bool? WithoutCandidateGroups;
    }
}
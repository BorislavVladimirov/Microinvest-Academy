using System;
using System.Collections.Generic;
using System.Text;
using TeskAndEmployee.Common;

namespace TeskAndEmployee.Models
{
    public class AllWork
    {
        #region Declarations
        private List<Task> tasks;
        #endregion

        #region Initializations
        public AllWork()
        {
            FreePlacesForTasks = GlobalConstants.InitialTasksCount;
        }

        #endregion

        #region Properties

        public List<Task> Tasks { get; } = new List<Task>();

        public int FreePlacesForTasks { get; private set; }

        public int CurrentUnassignedTask { get; private set; }

        #endregion

        #region Methods
        public void AddTask(Task task)
        {
            if (FreePlacesForTasks == 0)
            {
                throw new ArgumentException(GlobalConstants.NotEnoghtFreeSpaceForNewTask);
            }

            CurrentUnassignedTask = GlobalConstants.InitialIndex;

            this.Tasks.Add(task);
            FreePlacesForTasks--;
        }

        public Task GetNextTask()
        {
            if (this.Tasks.Count == 0)
            {
                throw new ArgumentException(GlobalConstants.TaskNotAvailable);
            }

            FreePlacesForTasks++;

            Task tempTask = Tasks[CurrentUnassignedTask];

            this.Tasks.RemoveAt(0);

            return tempTask;
        }
        #endregion
    }
}

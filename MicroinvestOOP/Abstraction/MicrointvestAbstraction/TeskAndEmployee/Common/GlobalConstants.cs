using System;
using System.Collections.Generic;
using System.Text;

namespace TeskAndEmployee.Common
{
    public static class GlobalConstants
    {
        public const string InvalidName = "Name should not be null or empty!";

        public const string InvalidWorkingHours = "Working hours must be greater or egual to 0 and less or equal to 8!";

        public const string InvalidLeftHours = "Hours left must be positive number!";

        public const string NotEnoughWorkingHours = "To be able to do work, working hours must be greater than 0!";

        public const string TaskNotAvailable = "No task available!";

        public const string NotEnoghtFreeSpaceForNewTask = "There are no free spaces for new tasks!";

        public const string NewWorkDayHasStarted = "Working hours are set to 8. New work day started for";

        public const string HoursLeft = "Working hours left:";

        public const string SetHourseLeft = "Working hours set to:";

        public const string AllWorkSetSuccessfully = "All work set seccessfully.";

        public const string CurrentTaskSetSuccessfuly = "Current task is set seccessfully.";

        public const string WorkingOnPreviousTask = "Working on previuos task!!!";

        public const string AllTasksDone = "All tasks are successfully done!";

        public const string DaysElapsed = "Days elapsed:";

        public const string RemainingTasks = "Remaining tasks:";

        public const string RemainingTaskHours = "Remaining tasks hours:";

        public const string TaskName = "Task name:";

        public const string GetName = "Name:";

        public const int InitialTasksCount = 10;

        public const int InitialWorkingHours = 8;

        public const int InitialIndex = 0;
    }
}

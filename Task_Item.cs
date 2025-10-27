using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNEMENT_2
{
    internal class Task_Item
    {
        // Private fields - demonstrates encapsulation
        private int taskId;
        private string title;
        private string description;
        private DateTime dueDate;
        private bool isCompleted;

        // Public Properties - PascalCase naming convention

        /// <summary>
        /// Gets or sets the unique Task ID
        /// </summary>
        public int TaskId
        {
            get { return taskId; }
            set { taskId = value; }
        }

        /// <summary>
        /// Gets or sets the Title of the task
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        /// <summary>
        /// Gets or sets the Description of the task
        /// </summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        /// <summary>
        /// Gets or sets the Due Date of the task
        /// </summary>
        public DateTime DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }


        public bool IsCompleted
        {
            get { return isCompleted; }  // Returns the FIELD (lowercase)
            set { isCompleted = value; }  // Sets the FIELD (lowercase)
        }

        // Constructors

        public Task_Item()
        {
            taskId = 0;
            title = string.Empty;
            description = string.Empty;
            dueDate = DateTime.Now;
            isCompleted = false;
        }

        public Task_Item(int id, string taskTitle, string taskDescription, DateTime taskDueDate)
        {
            taskId = id;
            title = taskTitle;
            description = taskDescription;
            dueDate = taskDueDate;
            isCompleted = false;
        }



    }
}

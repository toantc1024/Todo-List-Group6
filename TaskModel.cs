using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace todolist
{
    internal class TaskModel
    {
        private int id;
        private string StartTime;
        private string EndTime;
        private string Description;
        private string Priority;
        private bool isChecked;

        public TaskModel()
        {
            this.id =0;
            this.StartTime = string.Empty;
            this.EndTime = string.Empty;
            this.Description = string.Empty;
            this.Priority = string.Empty;
            this.isChecked = false;
        }

        public TaskModel(int id,string StartTime, string EndTime,string Description, string Priority, bool isChecked)
        {
            this.id = id;
            this.StartTime = StartTime;
            this.EndTime = EndTime;
            this.Description = Description;
            this.Priority = Priority;
            this.isChecked = isChecked;
        }

 

    }
}

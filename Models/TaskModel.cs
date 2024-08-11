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
        private String title;
        private String startTime;
        private String endTime;
        private String description;
        private String priority;

        
        public TaskModel(String title, String startTime, String endTime, String description, String priority)
        {
            this.title = title;
            this.startTime = startTime;
            this.endTime = endTime;
            this.description = description;
            this.priority = priority;
        }

        public String getTitle()
        {
            return title;
        }

        public void setTitle(String title)
        {
            this.title = title;
        }



    }
}

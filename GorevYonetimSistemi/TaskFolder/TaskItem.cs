using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorevYonetimSistemi.TaskFolder
{
    public class TaskItem
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public bool isCompleted { get; set; }

        public TaskItem(int Id,string Name,string Description) 
        {
            id=Id;
            name = Name;
            description = Description;
            isCompleted = false;
        }

        public void tamamlandimi() 
        {
            isCompleted = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedule.ViewModels
{
    public class TasksViewModel
    {
        public string Title { get; set; }
        public TimeSpan Time { get; set; }
        public string Color { get; set; }
        public string IconHTML { get; set; }
    }
}

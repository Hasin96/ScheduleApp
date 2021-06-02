using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedule.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateAndTime { get; set; }
        public int ColorId { get; set; }
        public int IconId { get; set;}
        
        public TaskColor Color { get; set; }
        public TaskFontAwesomeIcon Icon { get; set; }

    }
}

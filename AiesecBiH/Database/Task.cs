using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Database
{
    public class Task:BaseEntity
    {
        public enum PriorityType
        {
            Small,
            Medium,
            High,
            Urgent
        }
        
        public string Name { get; set; }
        public string Description { get; set; }
        public  PriorityType Priority { get; set; }
        public DateTime Deadline { get; set; }
    }
}

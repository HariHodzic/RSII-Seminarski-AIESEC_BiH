using System;

namespace AiesecBiH.Model.Insert
{
    public class Task
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

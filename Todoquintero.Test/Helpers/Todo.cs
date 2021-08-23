using System;

namespace Todoquintero.Test.Helpers
{
    public class Todo
    {
        public DateTime CreatedTime { get; internal set; }
        public bool IsCompleted { get; internal set; }
        public string TaskDescription { get; internal set; }
    }
}
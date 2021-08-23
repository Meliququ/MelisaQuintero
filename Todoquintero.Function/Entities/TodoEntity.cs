using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Text;

namespace Todoquintero.Function.Entities
{
  public  class TodoEntity : TableEntity
    {
        public DateTime createdtime { get; set; }
        public string TaskDescription { get; set; }

        public bool Iscompleted { get; set; }
        public bool IsCompleted { get; set; }
    }
}

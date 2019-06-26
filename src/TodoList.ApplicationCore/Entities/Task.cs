using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TodoList.ApplicationCore.Entities
{
    public class Task : Entity
    {
        public Task(string description, bool iscomplete)
        {
            Id = Guid.NewGuid();
            Description = description;
            IsComplete = iscomplete;
        }

        //public int TaskId { get; set; }

        public string Description { get; private set; }
        public bool IsComplete { get; private set; }
        public Guid? CategoryId { get; private set; }

        public virtual Category Category { get; private set; }

    }
}

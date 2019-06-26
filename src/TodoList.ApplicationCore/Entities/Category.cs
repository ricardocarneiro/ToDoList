using System;
using System.Collections.Generic;
using System.Text;

namespace TodoList.ApplicationCore.Entities
{
    public class Category : Entity
    {
        public Category(Guid id)
        {
            Id = id;
        }

        public string Name { get; private set; }

    }
}

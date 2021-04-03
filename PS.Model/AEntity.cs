using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Model
{
    public abstract class AEntity<TPrimaryKey>
    {
        public virtual TPrimaryKey Id { get; set; }
        public virtual bool IsActive { get; set; }

    }
}

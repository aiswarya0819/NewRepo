using System;
using System.Collections.Generic;

namespace App.DAL.Models
{
    public partial class Allocation
    {
        public long Id { get; set; }
        public string EmployeeId { get; set; } = null!;
        public long TeamId { get; set; }
        public long ProjectId { get; set; }
        public int Role { get; set; }
        public double HoursPerDay { get; set; }

        public virtual Resource Employee { get; set; } = null!;
        public virtual Project Project { get; set; } = null!;
        public virtual Team Team { get; set; } = null!;
    }
}

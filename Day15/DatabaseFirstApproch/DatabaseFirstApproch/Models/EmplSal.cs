using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseFirstApproch.Models
{
    public partial class EmplSal
    {
        public int? Empid { get; set; }
        public string SalId { get; set; }
        public DateTime? SalDate { get; set; }
        public double? TotalSal { get; set; }

        public virtual TblEmpl Emp { get; set; }
        public virtual TblSalary Sal { get; set; }
    }
}

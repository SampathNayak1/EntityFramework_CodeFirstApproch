using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityFramework_CodeFirstApproch.Models
{
    public class Employee
    {
        [Key]
        public int Eno { get; set; }
        public string Ename { get; set; }
        public string Job {  get; set; }
        public decimal Sal { get; set; }  
        public int Deptno { get; set; }
    }
}
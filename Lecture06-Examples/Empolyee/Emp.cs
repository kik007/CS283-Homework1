using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empolyee
{
    public class Emp
    {
        public static int maxempid;
        private int empid;
        private int baseSalary;
        private int benfit;

        public Emp()
        {
            this.empid = ++Emp.maxempid;
        }

        public int BaseSalary
        {
            get => baseSalary;
            set => baseSalary = value < 0 ? 0 : value;
        }

        public int Benfit
        {
            get => benfit;
            set => benfit = value < 0 ? 0 : value;
        }

        public int Salary
        {
            get
            {
                return this.BaseSalary + this.Benfit;
            }
        }

        public int Empid { get => empid; }

        //public static int maxempid;
        //private int empid;//員工編號
        //private float baseSalary;//基本工資
        //public float Salary;//獎金
        //private float benefit;//實際薪資

        //public Emp()
        //{
        //    this.empid = ++Emp.maxempid;
        //}

        //public float BaseSalary
        //{
        //    get { return this.baseSalary; }
        //    set
        //    {
        //        if (value <= 0.0f)
        //            this.baseSalary = 0.0f;
        //        else
        //            this.baseSalary = value;
        //    }
        //}

        //public float Benefit { get => benefit; }
        //public int Empid { get => empid; }
    }
}
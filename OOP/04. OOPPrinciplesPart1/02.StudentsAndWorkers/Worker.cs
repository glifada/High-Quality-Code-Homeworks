using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentsAndWorkers
{
    class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary 
        {
            get { return this.weekSalary; }
            set 
            {
                if (value < 0 )
                {
                    throw new ArgumentOutOfRangeException("The salary can not be negative value!");
                }
                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 0 || value > 20)
                {
                    throw new ArgumentOutOfRangeException("The work hours is invalid value!");
                }
                this.workHoursPerDay = value;
            }
        }

        public double MoneyPerHour()
        {
            double moneyPerHour = this.WeekSalary / (5 * this.WorkHoursPerDay);
            return moneyPerHour;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, money {2:F2}", this.FirstName, this.LastName, this.MoneyPerHour());
        }
    }
}

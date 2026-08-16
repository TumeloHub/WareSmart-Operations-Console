using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareSmart_Operations_Console
{
    public abstract class Warehousetask
    {
        public int TaskID { get; set; }
        public int Workload { get; set; }
        public int OrderAge { get; set; }
        public int ResourceScarcity { get; set; }
        public int OperationalRisk { get; set; }

        public Warehousetask(
            int taskID,
            int workload,
            int orderage,
            int resourcescarcity,
            int operationalrisk)
        {
            TaskID = taskID;
            Workload = workload;
            OrderAge = orderage;
            ResourceScarcity = resourcescarcity;
            OperationalRisk = operationalrisk;
        }

        public abstract double CalculatePriority();
    }
}

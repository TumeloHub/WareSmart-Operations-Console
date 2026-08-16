using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareSmart_Operations_Console
{
    public class RestockingTask:Warehousetask
    {
        public RestockingTask(
            int taskID,
            int workload,
            int orderage,
            int resourcescarcity,
            int operationalrisk)
            : base(taskID, workload, orderage, resourcescarcity, operationalrisk)
        {
        }

        public override double CalculatePriority()
        {
            return Workload + OrderAge + ResourceScarcity + OperationalRisk;
        }
    }

}

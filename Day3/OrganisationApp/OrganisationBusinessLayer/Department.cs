using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganisationBusinessLayer
{
    public class Department
    {
        public int deptNumber;
        public bool isProducing;
        public float produce;

        public Department(int deptNumber, bool isProducing, float produce)
        {
            this.deptNumber = deptNumber;
            this.produce = produce;
            this.isProducing = isProducing;
        }

        public float GetIncentive(float multiplefactor)
        {
            float incentive = 0;

            if (isProducing)
            {
                incentive = produce * multiplefactor;    
            }

            return incentive;
        }

    }
}

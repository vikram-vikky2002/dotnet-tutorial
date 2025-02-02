using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareHospitalBusinessLayer
{
    public class LabTestRepository
    {
        public double[] labTestCharge;
        public string[] labTestId;

        public LabTestRepository()
        {
            labTestCharge = new double[4];
            labTestId = new string[4];
            labTestId[0] = "L1";
            labTestCharge[0] = 500;
            labTestId[1] = "L2";
            labTestCharge[1] = 200;
            labTestId[2] = "L3";
            labTestCharge[2] = 700;
            labTestId[3] = "L4";
            labTestCharge[3] = 900;
        }

        public double GetCharge(string labId)
        {
            for (int i = 0; i < labTestCharge.Length; i++)
            {
                if (labTestId[i] == labId)
                {
                    return labTestCharge[i];
                }
            }
            return 0;
        }
    }
}

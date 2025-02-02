namespace CareHospitalBusinessLayer
{
    public class Patient
    {
        public string[] labTestId;
        public int patientId;
        public String patientName;

        public Patient(string[] labTestId, int patientId, string patientName)
        {
            this.labTestId = labTestId;
            this.patientId = patientId;
            this.patientName = patientName;
        }

        public double CalculateCharge()
        {
            LabTestRepository labTestRepository = new LabTestRepository();
            double totalAmount = 0;

            for (int i = 0; i < labTestId.Length; i++)
            {
                totalAmount += labTestRepository.GetCharge(labTestId[i]);
            }

            return totalAmount;
        }
    }
}

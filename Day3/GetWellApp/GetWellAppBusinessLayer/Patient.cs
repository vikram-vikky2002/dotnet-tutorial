namespace GetWellAppBusinessLayer
{
    public class Patient
    {
        
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Name { get; set; }
        public int PatientId { get; set; }
        public string PhoneNumber { get; set; }

        public Patient(int patientId, string name, int age, string gender, string phoneNumber)
        {
            Age = age;
            Gender = gender;
            Name = name;
            PatientId = patientId;
            PhoneNumber = phoneNumber;
        }

        public string DisplayPatientInfo()
        {
            string details = PatientId + " " + Name + " " + Age + " " + Gender + " " + PhoneNumber;
            return details;
        }
    }
}

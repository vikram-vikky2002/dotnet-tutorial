namespace ClassLibrary
{
    public class Patient
    {
        public string name;
        public int PatientId { get; private set; }
        public int age;
        public string disease;

        public static int totalPatients;

        static Patient()
        {
            totalPatients = 200;
        }

        public Patient(string name, int age, string disease)
        {
            this.name = name;
            this.age = age;
            this.disease = disease;
            PatientId = ++totalPatients;
        }

        public void DisplayPatientInfo()
        {
            Console.WriteLine("\nPatient Details :");
            Console.WriteLine("ID : " + PatientId);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Disease : " + disease);
        }

    }
}

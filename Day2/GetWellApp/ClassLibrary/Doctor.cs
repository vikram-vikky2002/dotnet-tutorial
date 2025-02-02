namespace ClassLibrary
{
    public class Doctor
    {
        public string name;
        public int DoctorId { get; private set; }
        public string specialization;
        public string hospitalName;

        public static int totalDoctors;

        static Doctor()
        {
            totalDoctors = 100;
        }

        public Doctor(string name, string specialization, string hospitalName)
        {
            this.name = name;
            this.specialization = specialization;
            this.DoctorId = ++totalDoctors;
            this.hospitalName = hospitalName;
        }

        public int TotalDoctors()
        {
            return 100 - totalDoctors;
        }

        public void DisplayDooctorInfo()
        {
            Console.WriteLine("\nDoctor Details :");
            Console.WriteLine("ID : " + DoctorId);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Specialization : " + specialization);
            Console.WriteLine("Hospital Name : " + hospitalName);
        }

    }
}

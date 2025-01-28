namespace ClassLibrary
{
    public class Doctor
    {
        public string Name;
        public int DoctorID;
        public string Specialization;
        public long ContactNumber;

        public void DisplayDetails()
        {
            Console.WriteLine("\nDoctor Details :");
            Console.WriteLine("ID : " + DoctorID);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Specialization : " + Specialization);
            Console.WriteLine("Contact Number : " + ContactNumber);
        }

        public void UpdateContactNumber(long newNumber)
        {
            ContactNumber = newNumber;
            Console.WriteLine("\nContact Updated..");
        }
    }
}

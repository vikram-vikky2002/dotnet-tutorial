namespace ClassLibrary
{
    public class Patient
    {
        public string Name;
        public int PatientID;
        public int Age;
        public string Disease;

        public void DisplayDetails()
        {
            Console.WriteLine("\nPatient Details :");
            Console.WriteLine("ID : " + PatientID);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Age : " + Age);
            Console.WriteLine("Disease : " + Disease);
        }

    }
}

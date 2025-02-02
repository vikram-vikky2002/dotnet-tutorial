namespace WeBankBusinessLayer
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }


        public Customer(int customerId, string name, int age, string gender, string phoneNumber)
        {
            CustomerId = customerId;
            Name = name;
            Age = age;
            Gender = gender;
            PhoneNumber = phoneNumber;
        }

        public virtual string DisplayCustomerInfo()
        {
            string info = CustomerId + " " + Name + " " + Age + " " + PhoneNumber + " " + Gender;
            return info;
        }
    }
}

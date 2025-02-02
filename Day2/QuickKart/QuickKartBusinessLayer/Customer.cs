namespace QuickKartBusinessLayer
{
    public class Customer
    {
        public string address;
        public int customerId;
        public string customerName;
        public string customerType;
        public DateTime dateOfBirth;
        public string emailId;
        public string gender;
        public string password;

        public Customer(int customerId, string customerName, string customerType, DateTime dateOfBirth, string emailId, 
            string gender, string password)
        {
            this.customerId = customerId;
            this.customerName = customerName;
            this.customerType = customerType;
            this.dateOfBirth = dateOfBirth;
            this.emailId = emailId;
            this.gender = gender;
            this.password = password;

        }

        public double GetDiscount()
        {
            if (customerType == "Privileged")
            {
                return 2;
            }
            else if(customerType == "Regular")
            {
                return 5;
            }
            else if (customerType == "Elite")
            {
                return 7;
            }
            else
            {
                return 0;
            }
        }
    }
}

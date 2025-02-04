using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntorkBusinessLayer
{
    public class Bill
    {
        static int counter;
        public BillingAgent Agent { get; set; }
        public double BasePrice { get; set; }
        public double BillAmount { get; set; }
        public DateTime BillDate { get; set; }
        public string BillId { get; set; }
        public DateTime DueDate { get; set; }
        public double PricePerUnit { get; set; }
        public MeterReader Reader { get; set; }
        public string Status { get; set; }

        static Bill()
        {
            counter = 1000;
        }

        public Bill()
        {
            SetBaseTariff();
        }

        public string GenerateBill(Customer customer, MeterReading reading, BillingAgent agent)
        {
            try
            {
                if(customer != null)
                {
                    if(reading != null)
                    {
                        Reader = reading.Reader;
                        Agent = agent;
                        BillId = "B" + ++counter;
                        BillDate = DateTime.Now;
                        DueDate = DateTime.Now.AddDays(30);
                        Status = "Pending";
                        if(reading.UnitsConsumed == 0)
                        {
                            BillAmount = BasePrice;
                        }
                        else
                        {
                            BillAmount = BasePrice + (reading.UnitsConsumed + PricePerUnit);
                        }
                        return $"Bill successfully generated for Customer : {customer.CustomerName} with Bill ID : {BillId}";
                    }
                    return "Bill could not be generated.";
                }
                return "Bill could not be generated.";
            }
            catch
            {
                return "Something went wrong, please try again later!";
            }
        }

        public void SetBaseTariff()
        {
            BasePrice = 100;
            PricePerUnit = 4;
        }

    }
}

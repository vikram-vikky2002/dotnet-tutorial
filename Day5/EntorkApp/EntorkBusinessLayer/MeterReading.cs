namespace EntorkBusinessLayer
{
    public class MeterReading
    {
        public int  MeterReadingId { get; set; }
        public MeterReader Reader { get; set; }
        public DateTime ReadingDate { get; set; }
        public double UnitsConsumed { get; set; }

        public MeterReading(int meterReadingId, double unitsConsumed, DateTime readingDate, MeterReader reader)
        {
            MeterReadingId = meterReadingId;
            Reader = reader;
            ReadingDate = readingDate;
            UnitsConsumed = unitsConsumed;
        }

        public string GetMeterReadingInfo()
        {
            string info = MeterReadingId + " " + UnitsConsumed + " " + ReadingDate;
            return info;
        }
    }
}

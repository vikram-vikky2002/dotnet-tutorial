using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2ZSalesBusinessLayer
{
    public class Coupon
    {
        public int CouponId { get; set; }
        public string CouponCode { get; set; }
        public DateTime ExpiryDate { get; set; }

        public Coupon(int couponId, string couponCode, DateTime expiryDate)
        {
            CouponId = couponId;
            CouponCode = couponCode;
            ExpiryDate = expiryDate;
        }
    }
}

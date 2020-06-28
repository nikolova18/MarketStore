using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class Silver
    {
        public double Turnover { get; set; }
        public double DiscountRate { get; set; } =0.02;
        public double PurchaseValue { get; set; }

        public Silver(double turnover,double purchaseValue)
        {
            this.Turnover = turnover;
            this.PurchaseValue = purchaseValue;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Silver:");
            sb.AppendLine($"a. Mock data: turnover ${this.Turnover}, purchase value ${this.PurchaseValue}");
            sb.AppendLine($"b. Ouput:");
            sb.AppendLine($"o   Purchase value: ${this.PurchaseValue:F2}" +
                $"\no   Discount rate: {this.DiscountRate*100:F1}%\no   Discount: ${(this.PurchaseValue * this.DiscountRate):F2}" +
                $"\no   Total: ${this.PurchaseValue - (this.PurchaseValue * this.DiscountRate)}");
            return sb.ToString().TrimEnd();
        }
    }
}

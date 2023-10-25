using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class AbstarctInsurancePolicy
    {
        private double policyAmt;

        public AbstarctInsurancePolicy(string? policyName, int? policyId, double premiumAmt)
        {
            this.policyName = policyName;
            this.policyId = policyId;
            this.premiumAmt = premiumAmt;
        }

        public string? policyName {  get; set; }
        public int ? policyId { get; set; } 
        public double premiumAmt {  get; set; }

        public void RenewPolicy(double newPremium)
        {
            policyAmt = newPremium;
            Console.WriteLine("Updated Premium Amount is :" + premiumAmt);
        }
        public void RenewPolicy()
        {
            premiumAmt = premiumAmt * .10;
            Console.WriteLine("Current Premium is :" + premiumAmt);
        }
    }
}

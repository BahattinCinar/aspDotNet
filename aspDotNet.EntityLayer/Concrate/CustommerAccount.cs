using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aspDotNet.EntityLayer.Concrate
{
    public class CustommerAccount
    {
        public int CustommerAccountId {  get; set; }

        public string CustommerAccountNumber {  get; set; }

        public string CustommerAccountCurrency {  get; set; }

        public decimal CustommerAccountBalance {  get; set; }

        public string BankBranch { get; set; }

        public int AppUserId { get; set; }

        public appUser AppUser { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppBillCounter.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CountMode { get; set; }
        public string CountType { get; set; }
        public string Currency { get; set; }
        public int TotalCount { get; set; }
        public DateTime Date { get; set; }
    }
}

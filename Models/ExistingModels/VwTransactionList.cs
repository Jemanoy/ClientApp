using System;
using System.Collections.Generic;

#nullable disable

namespace ClientApp.Models.ExistingModels
{
    public partial class VwTransactionList
    {
        public string ReferenceNo { get; set; }
        public string AccountNo { get; set; }
        public string AccountName { get; set; }
        public decimal Amount { get; set; }
        public string MobileNumber { get; set; }
        public string Remarks { get; set; }
        public string Name { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}

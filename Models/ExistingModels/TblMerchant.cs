using System;
using System.Collections.Generic;

#nullable disable

namespace ClientApp.Models.ExistingModels
{
    public partial class TblMerchant
    {
        public TblMerchant()
        {
            TblPaymentTransactions = new HashSet<TblPaymentTransaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TblPaymentTransaction> TblPaymentTransactions { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_tarabaev.Model
{
    class ListTransaction : ObservableCollection<Transaction>
    {
        public ListTransaction()
        {
            DbSet<Transaction> transactions = PageTransaction.DataEntitiesTransaction.Transactions;
            var queryTransaction = from transaction in transactions select transaction;
            foreach (Transaction trns in queryTransaction)
            {
                this.Add(trns);
            }
        }
    }
}

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Woodworks.Network;

namespace Woodworks.Models
{
    class Transaction
    {
        private long Transaction_id;
        private String Transaction_created;

        public String transaction_created
        {
            get { return Transaction_created; }
            set { Transaction_created = value; }
        }
        private String Transaction_updated;

        public String transaction_updated
        {
            get { return Transaction_updated; }
            set { Transaction_updated = value; }
        }
        private long Customer_id;
        private String Transaction_status;

        public String transaction_status
        {
            get { return Transaction_status; }
            set { Transaction_status = value; }
        }
        private double Transaction_total;
        private double Transaction_paid;

        public double transaction_paid
        {
            get { return Transaction_paid; }
            set { Transaction_paid = value; }
        }
        private List<Wood> Orders;

        public long transaction_id
        {
            get { return Transaction_id; }
            set { Transaction_id = value; }
        }

        public long customer_id
        {
            get { return Customer_id; }
            set { Customer_id = value; }
        }

        public List<Wood> orders
        {
            get { return Orders; }
            set { Orders = value; }
        }

        public double transaction_total
        {
            get { return Transaction_total; }
            set { Transaction_total = value; }
        }


        public bool ShouldSerializetransaction_id()
        {
            return (transaction_id != 0);
        }

        public bool ShouldSerializecustomer_id()
        {
            return (customer_id != 0);
        }

        public bool ShouldSerializeorders()
        {
            return (orders != null);
        }

        public bool ShouldSerializetransaction_total()
        {
            return (transaction_total != 0.0);
        }

        public async static Task<Boolean> addTransactions<T>(T transaction)
        {
            string result = await WoodWorksAPI.runRequest<T>("addTransaction", Config.user.user_key, transaction);
            Console.WriteLine(result);
            JObject getresult = JObject.Parse(result);
            if (getresult["error"].ToString() == "")
            {
                return true;
            }
            return false;
        }

        public async static Task<List<Transaction>> getTransactions(Transaction transaction)
        {
            string result = await WoodWorksAPI.runRequest<Transaction>("getTransaction", Config.user.user_key, transaction);
            Console.WriteLine(result);
            JObject getresult = JObject.Parse(result);
            if (getresult["error"] == null)
            {
                List<Transaction> transactions = JsonConvert.DeserializeObject<List<Transaction>>(getresult["result"].ToString());
                return transactions;
            }
            return null;
        }
    }
}

﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Woodworks.Network;

namespace Woodworks.Models
{
    public class Customer
    {
        private long Customer_id;
        private String Company_name;
        private String Company_address;
        private String Contact_person;
        private String Contact_number;
        private List<Wood> Customer_specialprices;

        [System.ComponentModel.DisplayName("ID")]
        public long customer_id
        {
            get
            {
                return Customer_id;
            }

            set
            {
                Customer_id = value;
            }
        }

        [System.ComponentModel.DisplayName("Name")]
        public String company_name
        {
            get
            {
                return Company_name;
            }

            set
            {
                Company_name = value;
            }
        }

        [System.ComponentModel.DisplayName("Address")]
        public String company_address
        {
            get
            {
                return Company_address;
            }

            set
            {
                Company_address = value;
            }
        }

        [System.ComponentModel.DisplayName("Contact Person")]
        public String contact_person
        {
            get
            {
                return Contact_person;
            }

            set
            {
                Contact_person = value;
            }
        }

        [System.ComponentModel.DisplayName("Contact Number")]
        public String contact_number
        {
            get
            {
                return Contact_number;
            }

            set
            {
                Contact_number = value;
            }
        }

        public List<Wood> customer_specialprices
        {
            get
            {
                return Customer_specialprices;
            }

            set
            {
                Customer_specialprices = value;
            }
        }

        public bool ShouldSerializecustomer_id()
        {
            return (customer_id != 0);
        }
        public bool ShouldSerializecompany_name()
        {
            return (company_name != null);
        }
        public bool ShouldSerializecompany_address()
        {
            return (company_address != null);
        }
        public bool ShouldSerializecontact_person()
        {
            return (contact_person != null);
        }
        public bool ShouldSerializecontact_number()
        {
            return (contact_number != null);
        }
        public bool ShouldSerializecustomer_specialprices()
        {
            return (customer_specialprices != null);
        }

        public async static Task<List<Customer>> getCustomers()
        {
            string result = await WoodWorksAPI.runRequest<Wood>("getCustomer", Config.user.user_key, null);
            JObject getresult = JObject.Parse(result);
            if (getresult["error"] == null)
            {
                List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(getresult["result"].ToString());
                return customers;
            }
            //string param = WoodWorksAPI.formatRequest<Wood>("getWood",null);
            return null;
        }

        public async static Task<Boolean> addCustomers<T>(T customer)
        {
            string result = await WoodWorksAPI.runRequest<T>("addCustomer", Config.user.user_key, customer);
            Console.WriteLine(result);
            JObject getresult = JObject.Parse(result);
            if (getresult["error"].ToString() == "")
            {
                return true;
            }
            return false;
        }

        public async static Task<Boolean> editCustomers(Customer customer)
        {
            string result = await WoodWorksAPI.runRequest<Customer>("editCustomer", Config.user.user_key, customer);
            Console.WriteLine(result);
            JObject editresult = JObject.Parse(result);
            if (editresult["error"].ToString() == "")
            {
                return true;
            }
            return false;

            //string param = WoodWorksAPI.formatRequest<Wood>("getWood",null);
            //return null;
        }

        public async static Task<Boolean> deleteCustomers(Customer customer)
        {
            /*Wood wood = new Wood();
            wood.wood_type = "corn";
            wood.wood_length = 10;
            wood.wood_width = 5.5f;
            wood.Wood_height = 20.1f;
            wood.wood_price = 500;*/
            string result = await WoodWorksAPI.runRequest<Customer>("deleteCustomer", Config.user.user_key, customer);
            JObject deleteresult = JObject.Parse(result);
            if (deleteresult["error"] == null)
            {
                //List<Wood> woods = JsonConvert.DeserializeObject<List<Wood>>(getresult["result"].ToString());
                return true;
            }
            //string param = WoodWorksAPI.formatRequest<Wood>("getWood",null);
            return false;
            //string param = WoodWorksAPI.formatRequest<Wood>("getWood",null);
            //return null;
        }

        public async static Task<Boolean> addSpecialPrices(Customer customer)
        {
            string result = await WoodWorksAPI.runRequest<Customer>("addSpecialPrice", Config.user.user_key, customer);
            JObject addresult = JObject.Parse(result);
            if (addresult["error"] == null)
            {
                //List<Wood> woods = JsonConvert.DeserializeObject<List<Wood>>(getresult["result"].ToString());
                return true;
            }
            //string param = WoodWorksAPI.formatRequest<Wood>("getWood",null);
            return false;
            //string param = WoodWorksAPI.formatRequest<Wood>("getWood",null);
            //return null;
        }
    }
}

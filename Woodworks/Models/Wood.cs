using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Woodworks.Network;

namespace Woodworks.Models
{
    public class Wood
    {
        private long Wood_id;
        private String Wood_type;
        private double Wood_thickness;
        private double Wood_width;
        private double Wood_length;
        private double Wood_price;
        private int Wood_qty;

        [System.ComponentModel.DisplayName("ID")]
        public long wood_id
        {
            get
            {
                return Wood_id;
            }

            set
            {
                Wood_id = value;
            }
        }

        [System.ComponentModel.DisplayName("Type")]
        public string wood_type
        {
            get
            {
                return Wood_type;
            }

            set
            {
                Wood_type = value;
            }
        }

        [System.ComponentModel.DisplayName("Thickness")]
        public double wood_thickness
        {
            get
            {
                return Wood_thickness;
            }

            set
            {
                Wood_thickness = value;
            }
        }

        [System.ComponentModel.DisplayName("Width")]
        public double wood_width
        {
            get
            {
                return Wood_width;
            }

            set
            {
                Wood_width = value;
            }
        }

        [System.ComponentModel.DisplayName("Length")]
        public double wood_length
        {
            get
            {
                return Wood_length;
            }

            set
            {
                Wood_length = value;
            }
        }

        [System.ComponentModel.DisplayName("Price")]
        public double wood_price
        {
            get
            {
                return Wood_price;
            }

            set
            {
                Wood_price = value;
            }
        }

        [System.ComponentModel.DisplayName("QTY")]
        public int wood_qty
        {
            get
            {
                return Wood_qty;
            }

            set
            {
                Wood_qty = value;
            }
        }

        public string full_name
        {
            get
            {
                return wood_type + " T" + wood_thickness + " W" + wood_width + " L" + wood_length;
            } 
        }

        [System.ComponentModel.DisplayName("Total Price")]
        public double total_price
        {
            get
            {
                return wood_qty * wood_price;
            }
        }

        public bool ShouldSerializewood_id()
        {
            return (wood_id != 0);
        }

        public bool ShouldSerializewood_type()
        {
            return (wood_type != null);
        }

        public bool ShouldSerializewood_length()
        {
            return (wood_length != 0.0);
        }

        public bool ShouldSerializewood_width()
        {
            return (wood_width != 0.0);
        }

        public bool ShouldSerializewood_thickness()
        {
            return (wood_thickness != 0.0);
        }

        public bool ShouldSerializewood_price()
        {
            return (wood_price != 0.0);
        }

        public bool ShouldSerializewood_qty()
        {
            return (wood_qty != 0);
        }

        public async static Task<List<Wood>> getWoods(Customer customer)
        {
            string result = await WoodWorksAPI.runRequest<Customer>("getWood", Config.user.user_key, customer);
            Console.WriteLine(result);
            JObject getresult = JObject.Parse(result);
            if (getresult["error"] == null)
            {
                List<Wood> woods = JsonConvert.DeserializeObject<List<Wood>>(getresult["result"].ToString());
                return woods;
            }
            //string param = WoodWorksAPI.formatRequest<Wood>("getWood",null);
            return null;
        }

        public async static Task<Boolean> addWoods<T>(T wood)
        {
            string result = await WoodWorksAPI.runRequest<T>("addWood", Config.user.user_key, wood);
            Console.WriteLine(result);
            JObject getresult = JObject.Parse(result);
            if (getresult["error"] == null)
            {
                //List<Wood> woods = JsonConvert.DeserializeObject<List<Wood>>(getresult["result"].ToString());
                return true;
            }
            //string param = WoodWorksAPI.formatRequest<Wood>("getWood",null);
            return false;
        }

        public async static Task<Boolean> editWoods(Wood wood)
        {
            string result = await WoodWorksAPI.runRequest<Wood>("editWood", Config.user.user_key, wood);
            Console.WriteLine(result);
            JObject editresult = JObject.Parse(result);
            if (editresult["error"] == null)
            {
                //List<Wood> woods = JsonConvert.DeserializeObject<List<Wood>>(getresult["result"].ToString());
                return true;
            }
            //string param = WoodWorksAPI.formatRequest<Wood>("getWood",null);
            return false;

            //string param = WoodWorksAPI.formatRequest<Wood>("getWood",null);
            //return null;
        }

        public async static Task<Boolean> deleteWoods(Wood wood)
        {
            /*Wood wood = new Wood();
            wood.wood_type = "corn";
            wood.wood_length = 10;
            wood.wood_width = 5.5f;
            wood.Wood_height = 20.1f;
            wood.wood_price = 500;*/
            string result = await WoodWorksAPI.runRequest<Wood>("deleteWood", Config.user.user_key, wood);
            Console.WriteLine(result);
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

    }
}

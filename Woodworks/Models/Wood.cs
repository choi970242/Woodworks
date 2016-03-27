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
    public class Wood
    {
        private long Wood_id;
        private String Wood_type;
        private double Wood_length;
        private double Wood_width;
        private double Wood_height;
        private String Wood_uom;
        private double Wood_price;
        private int Wood_qty;

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

        public double wood_height
        {
            get
            {
                return Wood_height;
            }

            set
            {
                Wood_height = value;
            }
        }

        public String wood_uom
        {
            get
            {
                return Wood_uom;
            }

            set
            {
                Wood_uom = value;
            }
        }

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

        public bool ShouldSerializewood_height()
        {
            return (wood_height != 0.0);
        }

        public bool ShouldSerializewood_uom()
        {
            return (wood_uom != null);
        }

        public bool ShouldSerializewood_price()
        {
            return (wood_price != 0.0);
        }

        public bool ShouldSerializewood_qty()
        {
            return (wood_qty != 0);
        }

        public async static Task<List<Wood>> getWoods()
        {
            string result = await WoodWorksAPI.runRequest<Wood>("getWood", Config.user.user_key,null);
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

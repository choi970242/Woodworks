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
    public class UOM
    {
        private String Uom_cd;
        private String Uom_desc;

        public String uom_cd
        {
            get
            {
                return Uom_cd;
            }

            set
            {
                Uom_cd = value;
            }
        }

        public String uom_desc
        {
            get
            {
                return Uom_desc;
            }

            set
            {
                Uom_desc = value;
            }
        }

        public bool ShouldSerializeuom_cd()
        {
            return (uom_cd != null);
        }

        public bool ShouldSerializeuom_desc()
        {
            return (uom_desc != null);
        }

        public async static Task<List<UOM>> getUOMs()
        {
            string result = await WoodWorksAPI.runRequest<UOM>("getUOM", Config.user.user_key, null);
            Console.WriteLine(result);
            JObject getresult = JObject.Parse(result);
            if (getresult["error"] == null || !getresult["error"].HasValues)
            {
                List<UOM> uoms = JsonConvert.DeserializeObject<List<UOM>>(getresult["result"].ToString());
                return uoms;
            }
            //string param = WoodWorksAPI.formatRequest<Wood>("getWood",null);
            return null;
        }

        public async static Task<Boolean> addUOMs(UOM uom)
        {
            string result = await WoodWorksAPI.runRequest<UOM>("addUOM", Config.user.user_key, uom);
            Console.WriteLine(result);
            JObject getresult = JObject.Parse(result);
            if (getresult["error"] == null || !getresult["error"].HasValues)
            {
                //List<Wood> woods = JsonConvert.DeserializeObject<List<Wood>>(getresult["result"].ToString());
                return true;
            }
            //string param = WoodWorksAPI.formatRequest<Wood>("getWood",null);
            return false;
        }

        public async static Task<Boolean> editUOMs(UOM uom)
        {
            string result = await WoodWorksAPI.runRequest<UOM>("editUOM", Config.user.user_key, uom);
            Console.WriteLine(result);
            JObject editresult = JObject.Parse(result);
            if (editresult["error"] == null || !editresult["error"].HasValues)
            {
                //List<Wood> woods = JsonConvert.DeserializeObject<List<Wood>>(getresult["result"].ToString());
                return true;
            }
            //string param = WoodWorksAPI.formatRequest<Wood>("getWood",null);
            return false;

            //string param = WoodWorksAPI.formatRequest<Wood>("getWood",null);
            //return null;
        }

        public async static Task<Boolean> deleteUOMs(UOM uom)
        {
            /*Wood wood = new Wood();
            wood.wood_type = "corn";
            wood.wood_length = 10;
            wood.wood_width = 5.5f;
            wood.Wood_height = 20.1f;
            wood.wood_price = 500;*/
            string result = await WoodWorksAPI.runRequest<UOM>("deleteUOM", Config.user.user_key, uom);
            Console.WriteLine(result);
            JObject deleteresult = JObject.Parse(result);
            if (deleteresult["error"] == null || !deleteresult["error"].HasValues)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Woodworks.Network;

namespace Woodworks.Models
{
    class Wood
    {
        private long Wood_id;
        private string Wood_type;
        private float Wood_length;
        private float Wood_width;
        private float Wood_height;
        private float Wood_price;
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

        public float wood_length
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

        public float wood_width
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

        public float wood_height
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

        public float wood_price
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

        public bool ShouldSerializewood_price()
        {
            return (wood_price != 0.0);
        }

        public bool ShouldSerializewood_qty()
        {
            return (wood_qty != 0);
        }

        public async static void addWoods()
        {
            Wood wood = new Wood();
            wood.wood_type = "corn";
            wood.wood_length = 10;
            wood.wood_width = 5.5f;
            wood.Wood_height = 20.1f;
            wood.wood_price = 500;
            string result = await WoodWorksAPI.runRequest<Wood>("getWood", null);
            Console.WriteLine(result);
            //string param = WoodWorksAPI.formatRequest<Wood>("getWood",null);
            //return null;
        }
    }
}

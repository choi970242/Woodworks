using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Woodworks.Models
{
    class WoodWorksRequest<T>
    {
        private string Method;
        private string User_key;
        private T Param;

        public WoodWorksRequest(string method, string user_key, T param)
        {
            this.method = method;
            this.user_key = user_key;
            this.param = param;
        }

        public string method
        {
            get
            {
                return Method;
            }

            set
            {
                Method = value;
            }
        }

        public string user_key
        {
            get
            {
                return User_key;
            }

            set
            {
                User_key = value;
            }
        }

        public T param
        {
            get
            {
                return Param;
            }

            set
            {
                Param = value;
            }
        }

        public bool ShouldSerializemethod()
        {
            return (method != null);
        }

        public bool ShouldSerializeuser_key()
        {
            return (user_key != null);
        }

        public bool ShouldSerializeparam()
        {
            return (param != null);
        }


    }
}

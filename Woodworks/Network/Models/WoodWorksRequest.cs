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
        private T Param;

        public WoodWorksRequest(string method, T param)
        {
            this.method = method;
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

        public bool ShouldSerializeparam()
        {
            return (param != null);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Woodworks.Models
{
    class Rule
    {
        private long Rule_id;
        private String Rule_name;
        private Dictionary<Wood, float> Woods;

        public long rule_id
        {
            get { return Rule_id; }
            set { Rule_id = value; }
        }

        public String rule_name
        {
            get { return Rule_name; }
            set { Rule_name = value; }
        }

        public Dictionary<Wood, float> woods
        {
            get { return Woods; }
            set { Woods = value; }
        }

    }
}

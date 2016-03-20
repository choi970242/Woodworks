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
    class User
    {
        private long User_id;
        private String First_name;
        private String Last_name;
        private String Username;
        private String Password;
        private String User_key;
        private String Role;

        public long user_id
        {
            get
            {
                return User_id;
            }

            set
            {
                User_id = value;
            }
        }

        public String first_name
        {
            get
            {
                return First_name;
            }

            set
            {
                First_name = value;
            }
        }

        public String last_name
        {
            get
            {
                return Last_name;
            }

            set
            {
                Last_name = value;
            }
        }

        public String username
        {
            get
            {
                return Username;
            }

            set
            {
                Username = value;
            }
        }

        public String password
        {
            get
            {
                return Password;
            }

            set
            {
                Password = value;
            }
        }

        public String user_key
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

        public String role
        {
            get
            {
                return Role;
            }

            set
            {
                Role = value;
            }
        }

        public bool ShouldSerializeuser_id()
        {
            return (user_id != 0);
        }

        public bool ShouldSerializefirst_name()
        {
            return (first_name != null);
        }

        public bool ShouldSerializelast_name()
        {
            return (last_name != null);
        }

        public bool ShouldSerializeusername()
        {
            return (username != null);
        }

        public bool ShouldSerializepassword()
        {
            return (password != null);
        }

        public bool ShouldSerializeuser_key()
        {
            return (user_key != null);
        }

        public bool ShouldSerializerole()
        {
            return (role != null);
        }

        public async static Task<Boolean> login(String username, String password)
        {
            User user = new User();
            user.username = username;
            user.password = password;
            string result = await WoodWorksAPI.runRequest<User>("login", null, user);
            JObject loginresult = JObject.Parse(result);
            if (loginresult["error"] == null)
            {
                user = JsonConvert.DeserializeObject<User>(loginresult["result"].ToString());
                Config.user = user;
                return true;
            }
            else
                return false;
        }
    }
}

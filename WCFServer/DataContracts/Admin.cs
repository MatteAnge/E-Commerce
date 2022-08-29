using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFServer
{
    [DataContract]
    public class Admin
    {
        [DataMember]
        public string name;
        [DataMember]
        public string surname;
        [DataMember]
        public string email;
        [DataMember]
        public string password;

        public Admin(string name, string surname, string email, string password)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.password = password;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFServer
{
    [DataContract]
    public class Address
    {
        [DataMember]
        public User user;
        [DataMember]
        public string country;
        [DataMember]
        public string city;
        [DataMember]
        public int postCode;
        [DataMember]
        public string address ;

        public Address(User user, string country, string city, int postCode, string address)
        {
            this.user = user;
            this.country = country;
            this.city = city;
            this.postCode = postCode;
            this.address = address;
        }
    }
}

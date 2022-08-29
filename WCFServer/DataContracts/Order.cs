using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFServer
{
    [DataContract]
    public class Order
    {
        [DataMember]
        public int orderId;
        [DataMember]
        public User user;
        [DataMember]
        public Product product;
        [DataMember]
        public int quantity;
        [DataMember]
        public float price;
        [DataMember]
        public Address adress;
        [DataMember]
        public DateTime orderDate;
       // [DataMember]
       // public bool isPaid;

        public Order(int orderId, User user, Product product, int quantity, float price, Address adress, DateTime orderDate, bool isPaid)
        {
            this.orderId = orderId;
            this.user = user;
            this.product = product;
            this.quantity = quantity;
            this.price = price;
            this.adress = adress;
            this.orderDate = orderDate;
            this.isPaid = isPaid;
        }
    }
}

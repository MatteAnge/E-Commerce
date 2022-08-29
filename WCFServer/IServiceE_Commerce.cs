using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServer
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di interfaccia "IService1" nel codice e nel file di configurazione contemporaneamente.
    [ServiceContract]
    public interface IServiceE_Commerce
    {
        [OperationContract]
        void Connection();
       
        [OperationContract]
        User LoginUser(string email, string password);

        [OperationContract]
        bool Sign_up(Address a, User u);

        [OperationContract]
        bool AddAddress(Address a, User u);

        [OperationContract]
        bool DeleteAddress(Address a, User u);

        [OperationContract]
        Admin LoginAdmin(string email, string password);

        [OperationContract]
        List<User> GetListUsers();

        [OperationContract]
        bool AddProduct(Product p);

        [OperationContract]
        bool DeleteProduct(Product p);

        [OperationContract]
        bool UpdateUserWallet(User u, float price, bool add);

        [OperationContract]
        bool UpdateProduct(Product p, int quantity);

        [OperationContract]
        bool BuyProduct(Product p, User u, int quantity, Address a);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCF
{
    [ServiceContract]
   public interface IMyService
    {
        [OperationContract]
        string GetData();

        [OperationContract]
        string GetMessage(String Name);

        [OperationContract]
        string GetResult(Student std);

        [OperationContract]
        int GetMax(int[] arr);

        [OperationContract]
        List<Customer> GetAllCustomer();
    }

}

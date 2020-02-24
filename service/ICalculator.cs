using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace service
{
    /*
     * Interface that the proxy and server implement. 
     */
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        double add(double no1, double no2);

        [OperationContract]
        double subtract(double no1, double no2);

        [OperationContract]
        double multiply(double no1, double no2);

        [OperationContract]
        double divide(double no1, double no2);
    }
}

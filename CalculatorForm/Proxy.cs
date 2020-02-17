using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorContract;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace proxy
{
    /*
     * The proxy that the client uses to connect to the service.
     */
    class Proxy : ClientBase<ICalculator>
    {
        public Proxy(Binding binding, EndpointAddress endpoint)
            : base(binding, endpoint)
        {}

        public ICalculator GetCalculatorService()
        {
            return base.Channel;
        }
    }
}

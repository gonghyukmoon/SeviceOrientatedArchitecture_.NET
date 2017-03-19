using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace WebApplication3
{
    [MessageContract]
    public class BookPurchaseResponse
    {
        [MessageBodyMember]
        public bool result;
        [MessageBodyMember]
        public string response;
    }
}
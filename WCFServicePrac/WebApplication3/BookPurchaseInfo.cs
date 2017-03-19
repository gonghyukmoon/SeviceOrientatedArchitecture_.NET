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
    public class BookPurchaseInfo
    {
        [MessageHeader]
        public float budget;
        [MessageBodyMember]
        public Dictionary<int, int> items;
    }
}
using System;
using System.Text;
using Newtonsoft.Json;
using Publisher;

namespace Broker
{
    public class PayloadHandler
    {
        public static void Handle(byte[] payloadData)
        {
            var payloadString = Encoding.UTF8.GetString(payloadData);
            Payload payload = JsonConvert.DeserializeObject<Payload>(payloadString);
            Console.WriteLine($"{payload.Article}");


        }
    }
}

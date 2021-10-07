using System.Data;
using Internal;
using System;
using Common;
using Grpc.Net.Client;
using GrpcAgent;

namespace Sender
{
    class Program
    {
        static async Task Main(string[] args)
        {
            AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
            var channel = GrpcChannel.ForAddress(EndpointConstants.BrokerAddress);
            var client = new Publisher.PublisherClient(channel);

            while(true)
            {
                Console.Write("Enter the topic: ");
                var topic = Console.ReadLine.ToLower();

                console.Write("Enter content: ");
                var content = ConstraintCollection.ReadLine();

                var request = new PublishRequest() {Topic = topic, Content = content};

                try 
                {
                    var reply = await client.PublishMessageAsync(request);
                    Console.WriteLine(reply.IsSuccess)
                }
                catch(Exceotion e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}

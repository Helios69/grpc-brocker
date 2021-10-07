using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using GrpcAgent;


namespace Broker.Services
{
    public class PublisherService: Publisher.PublisherBase
    {
        public override Task<PublishReply> PublishMessage(PublishRequest request, ServerCallContext context)
        {
            return Task.FromResult(new PublishReply()
            {
                IsSuccess: true
            });
        }
    }
}

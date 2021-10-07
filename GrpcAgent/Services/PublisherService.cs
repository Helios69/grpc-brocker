using Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using GrpcAgent;


namespace grpcbroker
{
    public class PublisherService: Publisher.PublisherBase
    {
        public override Task<PublishReply> PublishMessage(PublishRequest request, ServerCallContext context)
        {
            return Task.FromResult(new PublishReply()
            {
                isSuccess: true
            })
        }
    }
}

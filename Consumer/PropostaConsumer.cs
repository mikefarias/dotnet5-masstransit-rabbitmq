using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumer
{
    class PropostaConsumer : IConsumer<PropostaMessage>
    {
        public Task Consume(ConsumeContext<PropostaMessage> context)
        {
            Console.WriteLine("Nova Proposta Cadastrada");
            return Task.CompletedTask;
        }
    }
}

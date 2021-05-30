using System;
using MassTransit;

namespace Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var busControl = Bus.Factory.CreateUsingRabbitMq(cfg =>
            {
                cfg.ReceiveEndpoint("analisando-propostas", e =>
                {
                    e.Consumer<PropostaConsumer>();
                });
            });
            busControl.Start();
            while (true) ; 
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet5_masstransit_rabbitmq
{
    public interface PropostaMessage
    {
        public int Id { get; } 

        public decimal CPF { get; }

        public int CodigoProduto { get; }

        public decimal LimiteCredito { get;}

        public bool Aprovado { get; }
    }
}

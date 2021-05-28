﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet5_masstransit_rabbitmq
{
    public class DTOProposta
    {
        public decimal CPF { get; set; }

        public int CodigoProduto { get; set; }

        public decimal LimiteCredito { get; set; }

        public bool Aprovada { get; set; }

    }
}
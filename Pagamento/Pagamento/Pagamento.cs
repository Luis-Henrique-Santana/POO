﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamento
{
    public abstract class Pagamento
    {
        public string Valor { get; set; }
        public abstract void RealizarPagamento();

    }
}

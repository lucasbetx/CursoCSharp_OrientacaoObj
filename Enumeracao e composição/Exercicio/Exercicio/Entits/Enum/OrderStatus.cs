﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Entits.Enum
{
    enum OrderStatus : int
    {
        Peding_Payment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}

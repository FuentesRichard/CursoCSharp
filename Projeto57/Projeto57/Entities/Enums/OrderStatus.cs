using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto57.Entities.Enums
{
    enum OrderStatus : int // : => OrderStatus deriva de int
    {
        PendingPayment, // se eu nao declarar um valor(qualquer um) por padrao sera 0
        Processing,
        Shipped,
        Delivered
    }
}

using System;
using System.Collections.Generic;

namespace MeuProjeto.Entidades.Enums
{
    enum Orderstatus : int
    {
        Pending= 1,
        Processing=2,
        Shipped=3,
        Delivered=4,
        Cancelled=5
    }
}
﻿using System;
using System.Collections.Generic;

namespace yum_admin.Models;

public partial class CherishTradeState
{
    public byte TradeStateCode { get; set; }

    public string TradeStateDescript { get; set; } = null!;

    public virtual ICollection<CherishOrder> CherishOrders { get; set; } = new List<CherishOrder>();
}

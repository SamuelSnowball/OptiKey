﻿// Copyright (c) 2020 OPTIKEY LTD (UK company number 11854839) - All Rights Reserved
using System;

namespace JuliusSweetland.OptiKey.Services
{
    public interface INotifyErrors
    {
        event EventHandler<Exception> Error;
    }
}

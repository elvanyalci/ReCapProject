﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
   public interface IResult
    {
        //voidler için
        bool Success { get; }
        string Message { get; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;
using CS_GA.Business.Common;

namespace CS_GA.Business.Operators
{
    interface IMutationOperator
    {
        IChromosome PerformMutation(IChromosome chromosome);
    }
}

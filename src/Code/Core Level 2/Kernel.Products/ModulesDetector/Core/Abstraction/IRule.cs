﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIM.Products.ModulesDetector.Core.Abstraction
{
    public interface IRule
    {
        List<IRule> ChildRules { get; set; }
        bool Execute(IModule module, IInstanceContext context);        
    }
}
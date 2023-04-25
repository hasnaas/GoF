﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Visitor
{
    public class AnchorNode : HtmlNode
    {
        public void Execute(Operation operation)
        {
           operation.Apply(this);
        }
    }
}
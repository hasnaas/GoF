﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public interface TVdevice
    {
        void TurnOn();
        void TurnOff();
        void SetChannel(int number);
    }
}

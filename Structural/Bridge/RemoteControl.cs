﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class RemoteControl
    {
        protected TVdevice _device;

        public RemoteControl(TVdevice device)
        {
            _device = device;
        }

        public void TurnOn()
        {
            _device.TurnOn();
        }

        public void TurnOff()
        {
            _device.TurnOff();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class AdvancedRemoteControl :RemoteControl
    {
        public AdvancedRemoteControl(TVdevice device):base(device)
        {
        }

        public void setChannel(int number)
        {
            _device.SetChannel(number);
        }
    }
}

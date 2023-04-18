using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    public abstract class UIelement
    {
        protected DialogBox _owner;

        public UIelement(DialogBox owner)
        {
            _owner = owner;
        }
    }
}

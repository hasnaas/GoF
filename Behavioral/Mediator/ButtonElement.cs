using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    internal class ButtonElement : UIelement
    {
        private bool _isDisabled;
        public string Label { get; set; }
        public bool IsEnabled { get
            {
                return _isDisabled;
            }
            set
            {
                _isDisabled = value;
                _owner.changed(this);
            }
        }
        
        public ButtonElement(DialogBox owner) : base(owner) {
           
        }
        public void Click()
        {
            _owner.changed(this);
        }

    }
}

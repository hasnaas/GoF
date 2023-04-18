using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    public class CheckBoxElement : UIelement
    {
        private bool _checked;
        public string Label { get; set; }
        public bool Checked
        {
            get
            {
                return _checked;
            }
            set
            {
                _checked = value;
                _owner.changed(this);
            }
        }

        public CheckBoxElement(DialogBox owner) : base(owner)
        { }


    }
}

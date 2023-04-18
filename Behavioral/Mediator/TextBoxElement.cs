using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    public class TextBoxElement : UIelement
    {
        private string _text;
        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
                _owner.changed(this);
            }
        }
        public TextBoxElement(DialogBox owner) : base(owner) {
        }

        public bool IsEmpty()
        {
            return Text == null || Text.Length == 0;
        }

    }
}

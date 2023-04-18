using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Mediator
{
    public class RegisterFormDialogBox : DialogBox
    {
        private TextBoxElement username;
        private TextBoxElement password;
        private CheckBoxElement terms;
        private ButtonElement register;

        public RegisterFormDialogBox()
        {
            register = new ButtonElement(this);
            username = new TextBoxElement(this);
            password=new TextBoxElement(this);  
            terms=new CheckBoxElement(this);
         
        }
        public void SimulateInteraction()
        {
            Console.WriteLine("entering username"); username.Text = "visitor";
            Console.WriteLine("button status "+register.IsEnabled);
            Console.WriteLine("entering password"); password.Text = "visitorpass";
            Console.WriteLine("button status " + register.IsEnabled);
            Console.WriteLine("agrreeing with the terms"); terms.Checked = true;
            Console.WriteLine("button status " + register.IsEnabled);
            register.Click();
        }
        public override void changed(UIelement element)
        {
            if (element != register)
            {
                Console.WriteLine("Changed triggered by :" + element);
                register.IsEnabled = AreAllValid();
            }
            else
            {
                Console.WriteLine("Button clicked !");
            }      
        }

        public bool AreAllValid()
        {
            return !username.IsEmpty() && !password.IsEmpty() && terms.Checked;
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.mediator
{
    public class Client
    {
        public static void Run()
        {

            RegistrationFormMediator mediator = new RegistrationFormMediator();

            TextBox email = new TextBox(mediator);
            CheckBox terms = new CheckBox(mediator);
            SubmitButton submit = new SubmitButton(mediator);
            LoadingSpinner spinner = new LoadingSpinner(mediator);

            mediator.EmailTextBox = email;
            mediator.TermsCheckBox = terms;
            mediator.SubmitButton = submit;
            mediator.Spinner = spinner;

            email.SetText("");
            terms.SetChecked(false);

            Console.WriteLine();

            email.SetText("user@example.com");
            terms.SetChecked(true);

            Console.WriteLine();

            submit.Click();

            Console.WriteLine();
        }
    }
}

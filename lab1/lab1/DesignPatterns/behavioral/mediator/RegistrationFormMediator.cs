using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.mediator
{
    public class RegistrationFormMediator : IMediator
    {
        public TextBox EmailTextBox { get; set; } = null!;
        public CheckBox TermsCheckBox { get; set; } = null!;
        public SubmitButton SubmitButton { get; set; } = null!;
        public LoadingSpinner Spinner { get; set; } = null!;

        public void Notify(Component sender, string ev)
        {
            if (ev == "CheckChanged" || ev == "TextChanged")
            {
                ValidateForm();
            }

            if (ev == "SubmitClicked")
            {
                if (CanSubmit())
                {
                    Spinner.Show();
                    Console.WriteLine("Submitting registration form...");
                    Spinner.Hide();
                }
                else
                {
                    Console.WriteLine("Form is invalid. Cannot submit.");
                }
            }
        }

        private void ValidateForm()
        {
            if (EmailTextBox.IsEmpty())
            {
                EmailTextBox.HighlightRed();
            }
            else
            {
                EmailTextBox.ResetBorder();
            }

            if (!EmailTextBox.IsEmpty() && TermsCheckBox.IsChecked)
            {
                SubmitButton.Enable();
            }
            else
            {
                SubmitButton.Disable();
            }
        }

        private bool CanSubmit()
        {
            return !EmailTextBox.IsEmpty() && TermsCheckBox.IsChecked;
        }
    }
}

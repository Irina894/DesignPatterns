using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.behavioral.mediator
{
    public class TextBox : Component
    {
        public string Text { get; private set; } = "";
        public string BorderColor { get; private set; } = "Gray";

        public TextBox(IMediator mediator) : base(mediator)
        {
        }

        public void SetText(string text)
        {
            Text = text;
            Console.WriteLine($"TextBox value changed: '{Text}'");
            mediator.Notify(this, "TextChanged");
        }

        public void HighlightRed()
        {
            BorderColor = "Red";
            Console.WriteLine("Email field highlighted RED");
        }

        public void ResetBorder()
        {
            BorderColor = "Gray";
            Console.WriteLine("Email field border reset");
        }

        public bool IsEmpty()
        {
            return string.IsNullOrWhiteSpace(Text);
        }
    }
}

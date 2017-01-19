using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics.ValueObjects
{
    /*
     * Used to describe a plain text string
     */
    public class PlainText
    {
        private string _text;
        public string Text { get { return _text; } }

        public PlainText(string text)
        {
            Contract.Requires<ArgumentException>(text.Length >= 2 && text.Length <= 50, "Invalid plain text length!");

            _text = text;
        }
    }
}

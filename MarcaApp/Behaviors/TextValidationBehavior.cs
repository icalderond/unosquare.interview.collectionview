using System;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace MarcaApp.Behaviors
{
    public class TextValidationBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(bindable);
        }

        private void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            if (Regex.IsMatch(e.NewTextValue, @"^[a-zA-Z]+$"))
            {
                ((Entry)sender).TextColor = Color.Black;
            }
            else
            {
                ((Entry)sender).TextColor = Color.Red;
            }
        }
    }
}

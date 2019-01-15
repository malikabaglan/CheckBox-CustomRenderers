using System;
using System.Text.RegularExpressions;
using Xamarin.Forms;
namespace NABP
{
    public class PasswordValidationBehavior : Behavior<Entry>
    {
      

        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);

            bindable.TextChanged +=Bindable_TextChanged;
             }
protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.TextChanged -= Bindable_TextChanged;
        }

        void Bindable_TextChanged(object sender, TextChangedEventArgs e)
        {
          
          var password = e.NewTextValue;
            var passwordPattern = "^(?(\")(\".+?(?<!\\\\)\"@)|(([0-9a-z]((\\.(?!\\.))|[-!#\\$%&'\\*\\+/=\\?\\^`\\{\\}\\|~\\w])*)(?<=[0-9a-z])@))(?(\\[)(\\[(\\d{1,3}\\.){3}\\d{1,3}\\])|(([0-9a-z][-\\w]*[0-9a-z]*\\.)+[a-z0-9][\\-a-z0-9]{0,22}[a-z0-9]))$";

            var passwordEntry = sender as Entry;
     

            if (Regex.IsMatch(password, passwordPattern))
            {
           // passwordError.Text = "Email is valid";
             passwordEntry.BackgroundColor = Color.LightBlue;

            }
            else
            {
                //passwordError.Text = "Email is invalid";
               passwordEntry.BackgroundColor = Color.Red;

            }

        }

    }
}

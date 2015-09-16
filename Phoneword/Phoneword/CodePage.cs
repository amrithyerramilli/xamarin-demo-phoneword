using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Phoneword
{
    public class CodePage : ContentPage
    {
        public CodePage()
        {
            var numbers = App.PhoneNumbers;
            List<Label> children = new List<Label>();
            foreach(var num in numbers)
            {
                children.Add(new Label(){XAlign = TextAlignment.Center, Text = num});
            }
            ListView listView = new ListView(){
                ItemsSource = children,
                ItemTemplate = new DataTemplate(() => {
                    Label name = new Label().SetBinding(Label.TextProperty, "")
                })
            }
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children = children
            };
        }
        
    }
}

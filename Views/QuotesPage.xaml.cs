using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace quotes.Views
{
    public partial class QuotesPage : ContentPage
    {
        string[] qts = { "Insanity: doing the same thing over and over again and expecting different results.",
            "Imagination is more important than knowledge.",
            "If you can't explain it simply, you don't understand it well enough.",
            "Two things are infinite: the universe and human stupidity; and I'm not sure about the universe.",
            "Logic will get you from A to B. Imagination will take you everywhere." };
        int counter = 0;

        public QuotesPage()
        {
            InitializeComponent();

            slider.Value = 33;
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            label.Text = qts[counter];



            if (counter == qts.Length - 1)
                counter = 0;
            else
                counter++;
            
        }
    }
}

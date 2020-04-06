using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace History
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        public List<String> historyList = new List<String>();
        public WelcomePage(List<string> detailslist)
        {
            //historyList.Add(detailslist[0]);
            //historyList.Add(detailslist[1]);
            InitializeComponent();
            usernameLabel.Text = detailslist[detailslist.Count - 2];
            passwordLabel.Text = detailslist[detailslist.Count-1];

           
                
            
            


        }

       
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin;
using Xamarin.Forms.Xaml;

namespace History
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {

        public List<string> userdetailslist = new List<string>();
        public List<HistoryClass> historylist = new List<HistoryClass>();

   
        public LoginPage()
        {
            InitializeComponent();
           
            
            btnLogin.Clicked += BtnLogin_Clicked;
            btnHistory.Clicked += BtnHistory_Clicked;
        }


        private void BtnHistory_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new HistoryPage(historylist));
        }



        //List<HistoryClass> objhis = new List<HistoryClass>();
        public void BtnLogin_Clicked(object sender, EventArgs e)
        {
           
        //List<HistoryClass> objhis = new List<HistoryClass>();
        userdetailslist.Add(etusername.Text);
            userdetailslist.Add(etpassword.Text);
            historylist.Add(new HistoryClass { Username = etusername.Text, Password= etpassword.Text});
            Navigation.PushAsync
                (new WelcomePage(userdetailslist));
            



           // objhis.Add(new HistoryClass { Username = etusername.Text, Password = etpassword.Text });








        }
    }
}
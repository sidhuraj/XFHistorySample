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
    public partial class HistoryPage : ContentPage
    {
        //public List<HistoryClass> ls = new List<HistoryClass>();
        public HistoryPage(List<HistoryClass> list)
        {
            InitializeComponent();
            //ls.Add(new HistoryClass { _Username = list[0], _Password = list[1] });

            lvHistory.ItemsSource = list;


        }
    }
}
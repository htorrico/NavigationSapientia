using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App11
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewDemo : ContentPage
    {
        public ListViewDemo()
        {
            InitializeComponent();
            LoadListView();            
            LoadListViewTexCell();
        }

        private void LoadListView()
        {
            List<string> list = new List<string>();

            
            list.Add("Hugo");
            list.Add("Anabel");
            list.Add("Omar");
            list.Add("Daryl");
            list.Add("Alex");
            list.Add("Erick");

            lvtExample.ItemsSource = list;

        }
        private void LoadListViewTexCell()
        {
            List<Person> people = new List<Person>();


            people.Add( new Person { LastName = "Torrico", FirstName= "Hugo", City="Nasca" });
            people.Add(new Person { LastName = "Paredes", FirstName = "Anabel", City = "Arequipa" });
            people.Add(new Person { LastName = "Román", FirstName = "Omar", City = "Ica" });
            people.Add(new Person { LastName = "Ludeña", FirstName = "Daryl", City = "Nasca" });
            people.Add(new Person { LastName = "Fernández", FirstName = "Alex", City = "Chincha" });
            people.Add(new Person { LastName = "Fernández", FirstName = "Erick", City = "Tarma" });


            lvViewCell.ItemsSource = people;

        }
    }
}
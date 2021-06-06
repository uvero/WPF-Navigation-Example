using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.ViewModel;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for HeroMasterPage.xaml
    /// </summary>
    public partial class HeroMasterPage : Page
    {
        public List<HeroModel> heroes { get; private set; }

        private Frame parent;

        public HeroMasterPage(Frame parent)
        {
            this.parent = parent;
           
            (string real, string hero)[] tuples =
            {
                ("Peter Parker", "Spiderman"),
                ("Bruce Wayne", "Batman"),
                ("Clark Kent", "Superman"),
                ("Tony Stark", "Ironman")
            };
            
            heroes = tuples
                .Select(x => new HeroModel { HeroName = x.hero, RealName = x.real })
                .ToList(); 
            
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var parameter = (sender as Button).CommandParameter as HeroModel;
            parent.Navigate(new HeroDetailsPage(parent, parameter));
        }
    }
}

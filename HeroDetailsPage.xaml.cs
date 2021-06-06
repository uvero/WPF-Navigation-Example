using System;
using System.Collections.Generic;
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
    /// Interaction logic for HeroDetailsPage.xaml
    /// </summary>
    public partial class HeroDetailsPage : Page
    {
        public HeroModel Model { get; private set; }
        private Frame parent;

        public HeroDetailsPage(Frame parent, HeroModel hero)
        {
            this.parent = parent;
            this.Model = hero;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            parent.GoBack();

        }
    }
}

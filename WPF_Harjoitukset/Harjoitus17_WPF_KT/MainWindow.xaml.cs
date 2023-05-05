using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Harjoitus17_WPF_KT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        private void vaihdaAsetus_O_Valot(object sender, RoutedEventArgs e)
        {
            if (olohuoneValot == false)
            {
                text_olohuoneValo.Text = "Päällä";
                olohuoneValot=true;
            }
            else
            {
                text_olohuoneValo.Text = "Pois päältä";
                olohuoneValot=false;
            }
        }
        public bool olohuoneValot = false;
        
        private void vaihdaAsetus_K_Valot(object sender, RoutedEventArgs e)
        {
            if (keittioValot == false)
            {
                text_keittioValo.Text = "Päällä";
                keittioValot = true;
            }
            else
            {
                text_keittioValo.Text = "Pois päältä";
                keittioValot = false;
            }
        }
        public bool keittioValot = false;
        
        private void vaihdaAsetus_Lukko(object sender, RoutedEventArgs e)
        {
            if (oviLukkossa == false)
            {
                text_oviLukko.Text = "Lukittu";
                oviLukkossa = true;
            }
            else
            {
                text_oviLukko.Text = "Ei lukittu";
                oviLukkossa = false;
            }
        }
        public bool oviLukkossa = false;
        public MainWindow()
        {
            InitializeComponent();
        }


        public float temperature = 31.0f;
        private void temperature_decrease(object sender, RoutedEventArgs e)
        {
            if (temperature > 16.0f)
            {
                temperature = temperature - 1;
                text_temperature.Text = temperature.ToString() + " °C";
            }
            else
            {
                MessageBox.Show("Ei voi pienentää 16 astetta pienempää.");
            }
        }

        private void temperature_increase(object sender, RoutedEventArgs e)
        {
            if (temperature < 31.0f)
            {
                temperature = temperature + 1;
                text_temperature.Text = temperature.ToString() + " °C";
            }
            else
            {
                MessageBox.Show("Ei voi nostaa 31 astetta enempää.");
            }
        }
    }
}

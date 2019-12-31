using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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

namespace Random_Boss_Task_Assign_Bot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int pvmSelect = RandomNumber();
            switch (pvmSelect)
            {
                case 0:
                    MessageBox.Show("ED1");
                    break;
                case 1:
                    MessageBox.Show("ED2");
                    break;
                case 2:
                    MessageBox.Show("ED3");
                    break;
                case 3:
                    MessageBox.Show("Arraxor");
                    break;
                case 4:
                    MessageBox.Show("Barrows");
                    break;
                case 5:
                    MessageBox.Show("ROTS");
                    break;
                case 6:
                    MessageBox.Show("Corporeal Beast");
                    break;
                case 7:
                    MessageBox.Show("General Graardor");
                    break;
                case 8:
                    MessageBox.Show("k'ril Tsutsaroth");
                    break;
                case 9:
                    MessageBox.Show("Zilyana");
                    break;
                case 10:
                    MessageBox.Show("Har-Aken");
                    break;
                case 11:
                    MessageBox.Show("Helwyr");
                    break;
                case 12:
                    MessageBox.Show("Kalphite King");
                    break;
                case 13:
                    MessageBox.Show("Kalphite Queen");
                    break;
                case 14:
                    MessageBox.Show("Giant Mole");
                    break;
                case 15:
                    MessageBox.Show("Chaos Elemental");
                    break;
                case 16:
                    MessageBox.Show("Daggonath Kings");
                    break;
                case 17:
                    MessageBox.Show("Nex");
                    break;
                case 18:
                    MessageBox.Show("Nex AOD");
                    break;
                case 19:
                    MessageBox.Show("QBD");
                    break;
                case 20:
                    MessageBox.Show("KBD");
                    break;
                case 21:
                    MessageBox.Show("Vindicta");
                    break;
                case 22:
                    MessageBox.Show("Vorago");
                    break;
                case 23:
                    MessageBox.Show("Twin Furies");
                    break;
                case 24:
                    MessageBox.Show("Gregorovic");
                    break;
                case 25:
                    MessageBox.Show("Solak");
                    break;
                case 26:
                    MessageBox.Show("Telos");
                    break;
                case 27:
                    MessageBox.Show("Magister");
                    break;
                case 28:
                    MessageBox.Show("Legiones");
                    break;
            }
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(HelpText());
        
        }

        public string HelpText()
        {
            string s1 = "Hello, use this application to select a random pvm boss when you cant decide.\n";
            string s2 = "Click the Generate button to give you a boss to kill for an hour!";
            return s1 + s2;
            
        }
        public int RandomNumber()
        {
            Random random = new Random();
            return random.Next(0, 28);
        }


    }
}

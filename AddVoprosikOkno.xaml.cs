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
using System.Windows.Shapes;
using static Testiki.TestType;

namespace Testiki
{
    /// <summary>
    /// Логика взаимодействия для AddVoprosikOkno.xaml
    /// </summary>
    public partial class AddVoprosikOkno : Window
    {
        public string Name;
        public string Description;
        public string Variant1;
        public string Variant2;
        public string Variant3;
        public Pravilno prav;
        public AddVoprosikOkno()
        {
            InitializeComponent();
            List<Pravilno> pravilnos = new List<Pravilno>
            {
                Pravilno.odin,
                Pravilno.dwa, 
                Pravilno.tri
            };
            CorrectCB.ItemsSource = pravilnos;
        }

        private void ZaverchBtm_Click(object sender, RoutedEventArgs e)
        {
            if (VoprosTbox.Text != "")
            {
                Name = VoprosTbox.Text;
                Description = OpisonieTBox.Text;
                Variant1 = FirstTbox.Text;
                Variant2 = SecondTBox.Text;
                Variant3 = ThirdTbox.Text;
                prav = (Pravilno)CorrectCB.SelectedItem;
                DialogResult = true;
            }
            else
            {
                DialogResult = false;
            }
        }
    }
}

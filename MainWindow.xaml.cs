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

namespace Testiki
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ProityBtm_Click(object sender, RoutedEventArgs e)
        {
            TestikiOkno testikiOkno = new TestikiOkno();
            testikiOkno.RedactorTestBtm.IsEnabled = false;
            testikiOkno.Show();
            Close();
        }

        private void RedactirovatBtm_Click(object sender, RoutedEventArgs e)
        {
            AvtorizTbox.IsEnabled = true;
        }

        private void AvtorizTbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (AvtorizTbox.Text == "барахлюш")
            {
                TestikiOkno testikiOkno = new TestikiOkno();
                testikiOkno.Show();
                Close();
            }
        }
    }
}

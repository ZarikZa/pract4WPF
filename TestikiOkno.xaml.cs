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

namespace Testiki
{
    /// <summary>
    /// Логика взаимодействия для TestikiOkno.xaml
    /// </summary>
    public partial class TestikiOkno : Window
    {
        public TestikiOkno()
        {
            InitializeComponent();
        }

        private void ExitBtm_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void RedactorTestBtm_Click(object sender, RoutedEventArgs e)
        {
            FramePag.Content = new TestiProhoj();
        }

        private void ProhodTestBtm_Click(object sender, RoutedEventArgs e)
        {
            Converteri converter = new Converteri();
            var testTypes = converter.Jsonviser<List<TestType>>("test.json");
            if(testTypes == null)
            {
                FramePag.Content = new TestaNetPage();
            }
            else
            {
                FramePag.Content = new ProhojdeniePage();
            }

        }
    }
}

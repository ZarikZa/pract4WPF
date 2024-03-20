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
    /// Логика взаимодействия для ProhojdeniePage.xaml
    /// </summary>
    public partial class ProhojdeniePage : Page
    {
        int pravilno = 0;
        int i = 1;
        List<TestType> testTypes1 = new List<TestType>();
        public ProhojdeniePage()
        {
            InitializeComponent();
            Converteri converter = new Converteri();
            var testTypes = converter.Jsonviser<List<TestType>>("test.json");
            testTypes1 = testTypes;
            VoprosTBl.Text = testTypes[0].Name;
            OpisanieTBl.Text = testTypes[0].Description;
            odin.Content = testTypes[0].Variant1;
            dwa.Content = testTypes[0].Variant2;
            tri.Content = testTypes[0].Variant3;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as Button).Name == testTypes1[i-1].TrueOtvet.ToString())
            {
                pravilno++;
            }
            if(i != testTypes1.Count)
            {
                VoprosTBl.Text = testTypes1[i].Name;
                OpisanieTBl.Text = testTypes1[i].Description;
                odin.Content = testTypes1[i].Variant1;
                dwa.Content = testTypes1[i].Variant2;
                tri.Content = testTypes1[i].Variant3;
                i++;
            }
            else
            {
                VoprosTBl.Text = $"Правильных ответов {pravilno} из {testTypes1.Count}" ;
                if (pravilno == testTypes1.Count)
                {
                    OpisanieTBl.Text = "Ашалеть";
                }
                else
                {
                    OpisanieTBl.Text = "Лусер";
                }
                odin.IsEnabled = false;
                dwa.IsEnabled = false;
                tri.IsEnabled = false;
            }
        }
    }
}

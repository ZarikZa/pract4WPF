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
    /// Логика взаимодействия для TestiProhoj.xaml
    /// </summary>
    public partial class TestiProhoj : Page
    {
        private static Converteri converteri = new Converteri();
        List<TestType> testTypes = converteri.Jsonviser<List<TestType>>("test.json") ?? new List<TestType>();
        public TestiProhoj()
        {
            InitializeComponent();
            DatyGridy.ItemsSource = testTypes;
        }

        private void AddVoprosBtm_Click(object sender, RoutedEventArgs e)
        {
            AddVoprosikOkno addVoprosikOkno = new AddVoprosikOkno();
            addVoprosikOkno.ShowDialog();
            if (addVoprosikOkno.DialogResult == true)
            {
                testTypes.Add(new TestType(addVoprosikOkno.Name, addVoprosikOkno.Description, addVoprosikOkno.Variant1, addVoprosikOkno.Variant2, addVoprosikOkno.Variant3, addVoprosikOkno.prav));
                converteri.Jsonser(testTypes, "test.json");
                DatyGridy.ItemsSource = null;
                DatyGridy.ItemsSource = testTypes;
            }
        }

        private void DatyGridy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            converteri.Jsonser(testTypes, "test.json");
        }
    }
}

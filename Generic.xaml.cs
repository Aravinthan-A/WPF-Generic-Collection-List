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
using String_Function.Model;

namespace String_Function
{
    /// <summary>
    /// Interaction logic for Generic.xaml
    /// </summary>
    public partial class Generic : Window
    {
        public Generic()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Student> list = new List<Student>();
            list.Add(new Student { age=22,name= "Aravinthan", studentid=123});
            List<employer> employers= new List<employer>();
            employers.Add(new employer { name = "Sathish" });
        }
    }
   
    public class employer
    {
       public string name;
    }


}

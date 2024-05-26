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

namespace holistic
{
    /// <summary>
    /// Interaction logic for Profile_Page.xaml
    /// </summary>
    public partial class Profile_Page : Page
    {
        ProfilingEntities db = new ProfilingEntities();
        Profiling profilings = new Profiling();
        public Profile_Page(Profiling prof)
        {
            InitializeComponent();
            labelAge.Content = prof.Age;
            labelCity.Content = prof.City;
            labelGender.Content = prof.Gender;
            labelName.Content = prof.UserName;
            labelPass.Content = prof.Pass;
            labelPhone.Content = prof.PhoneNumber;
        }
    }
}

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
    /// Interaction logic for sign_in.xaml
    /// </summary>
    public partial class sign_in : Page
    {
        ProfilingEntities db = new ProfilingEntities();
        Profiling profilings = new Profiling();
        public sign_in()
        {
            InitializeComponent();
        }

        private void signInbtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (passtxt.Password != "" && usernametxt.Text != "")
                {
                    profilings = db.Profilings.First(x => x.UserName == usernametxt.Text && x.Pass == passtxt.Password);
                    Profile_Page profile_Page = new Profile_Page(profilings);
                    this.NavigationService.Navigate(profile_Page);
                }
                else
                {
                    MessageBox.Show("ENTER !!");
                }
            }
            catch
            {
                MessageBox.Show("Not Found");
            }
        }
    }
}

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
using System.Xml;

namespace holistic
{
    /// <summary>
    /// Interaction logic for Signup.xaml
    /// </summary>
    public partial class Signup : Page
    {
        ProfilingEntities db = new ProfilingEntities();
        Profiling profilings = new Profiling();
        public Signup()
        {
            InitializeComponent();
        }

        private void signUpbtn_Click(object sender, RoutedEventArgs e)
        {
            if (ageTxt.Text != "" && usernametxt.Text != "" && Passtxt.Password != "" && phonetxt.Text != "" && combo.Text != "" && (maleRadio.IsChecked == true || femaleRadio.IsChecked == true))
            {
                profilings.UserName = usernametxt.Text;
                profilings.PhoneNumber = phonetxt.Text;
                profilings.Age = ageTxt.Text;
                profilings.Pass = Passtxt.Password;
                if (maleRadio.IsChecked == true)
                {
                    profilings.Gender = "male";
                }
                else
                {
                    profilings.Gender = "female";
                }
                var item = combo.SelectedItem.ToString().Split(' ').Last();
                if (item == "Cairo")
                {
                    profilings.City = "Cairo";
                }
                else
                {
                    profilings.City = "Giza";
                }
                db.Profilings.Add(profilings);
                db.SaveChanges();
                sign_in signIn = new sign_in();
                this.NavigationService.Navigate(signIn);
            }
            else
            {
                MessageBox.Show("Enter !?");
            }
        }

        private void signInbtn_Click(object sender, RoutedEventArgs e)
        {
            sign_in signIn = new sign_in();
            this.NavigationService.Navigate(signIn);
        }
    }
}

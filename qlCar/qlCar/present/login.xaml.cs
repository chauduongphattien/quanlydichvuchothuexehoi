using qlCar.Business;
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

namespace qlCar.present
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login :Window
    {
        public string pw;
        public string vi_tri;
        public int id;
        public login()
        {

            InitializeComponent();
        }

        private void logBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
           

        }

        private void logBtn_Click_1(object sender, RoutedEventArgs e)
        {
            if(txtUser.Text!="" && txtpass.Password != "")
            {
                loginHand lgh = new loginHand();
                string rs = lgh.blog(txtUser.Text, txtpass.Password);

                if (rs == "not")
                {
                    notify.Content = "sai thông tin!";
                }
                else
                {
                    if (rs == "QL")
                    {
                        notify.Content = "quan ly";
                        vi_tri = "QL";
                        
                    }
                    else if (rs == "MKT")
                    {
                        vi_tri = "MKT";
                        
                    }
                    else if (rs == "TN")
                    {
                        vi_tri = "TN";
                       
                    }
                    else if (rs == "Sale")
                    {
                        vi_tri = "Sale";
                        
                    }
                    try
                    {
                        id=lgh.getID(txtUser.Text);
                    }
                    catch(Exception ex)
                    {
                        System.Windows.MessageBox.Show(ex.ToString());
                    }
                  
                    this.Close();
                }



            }
            else
            {
                notify.Content = "không được để trống thông tin";
            }
            


        }
    }
}

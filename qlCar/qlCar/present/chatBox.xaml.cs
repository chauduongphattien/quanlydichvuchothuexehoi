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
    /// Interaction logic for chatBox.xaml
    /// </summary>
    /// 

    
    public partial class chatBox : Window
    {
        public int idGui;
        public int idNhan;
        public chatBox(int id_gui,int id_nhan)
        {
            InitializeComponent();
            idGui = id_gui;
            idNhan = id_nhan;
            tinnhanHand tnH = new tinnhanHand();
            List<Gridtemplate> rows = new List<Gridtemplate>();
            rows = tnH.getalltinnhan(id_gui, id_nhan);
            foreach (var i in rows)
            {
                container.Children.Add(i);
            }

        }

        private void ctrBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void dendBut_Click(object sender, RoutedEventArgs e)
        {
            if (contentMes.Text != "")
            {
                container.Children.Clear();
                tinnhanHand tnH = new tinnhanHand();
                try
                {
                    tnH.guiTinNhan(idGui, idNhan, contentMes.Text);
                }
                catch(Exception ex) {
                    System.Windows.MessageBox.Show(ex.Message);
                }


                List<Gridtemplate> rows = new List<Gridtemplate>();
                rows = tnH.getalltinnhan(idGui, idNhan);
                foreach(var i in rows)
                {
                    container.Children.Add(i);
                }


                contentMes.Text = "";
            }
           
        }

        private void min_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

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

namespace Lamport
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        Proceso proceso_1 = new Proceso(1,0);
        Proceso proceso_2 = new Proceso(2,0);
        Proceso proceso_3 = new Proceso(3, 0);

        private void Btn_SendP1_Click(object sender, RoutedEventArgs e)
        {
            if(cbb_p1.SelectedIndex != -1)
            {
                switch (cbb_p1.SelectedIndex)
                {
                    case 0:
                        Enviar(proceso_1, proceso_2);
                        break;
                    case 1:
                        Enviar(proceso_1, proceso_3);
                        break;
                }

            }
            else
            {
                MessageBox.Show("Seleccione una opción");
            }

        }

        private void Btn_SendP2_Click(object sender, RoutedEventArgs e)
        {
            if (cbb_p2.SelectedIndex != -1)
            {
                switch (cbb_p2.SelectedIndex)
                {
                    case 0:
                        Enviar(proceso_2, proceso_1);
                        break;
                    case 1:
                        Enviar(proceso_2, proceso_3);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Seleccione una opción");
            }
        }

        private void Btn_SendP3_Click(object sender, RoutedEventArgs e)
        {
            if (cbb_p3.SelectedIndex != -1)
            {
                switch (cbb_p3.SelectedIndex)
                {
                    case 0:
                        Enviar(proceso_3, proceso_1);
                        break;
                    case 1:
                        Enviar(proceso_3, proceso_2);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Seleccione una opción");
            }
        }

        private void Enviar(Proceso procesoRemitente, Proceso procesoDestinatario)
        {
            Mensaje mensaje = new Mensaje();
            string logSend = procesoRemitente.Enviar(procesoDestinatario, mensaje);
            txb_Log.Text = txb_Log.Text + Environment.NewLine + logSend;
            txb_Log.ScrollToEnd();
        }

 
    }

}

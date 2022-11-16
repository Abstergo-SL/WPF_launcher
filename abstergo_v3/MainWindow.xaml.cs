using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace abstergo_v3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int general_vol = 50;
        private int musica_vol = 50;
        private int fps = 30;
        private Boolean modocheto = false;




        public MainWindow()
        {
            InitializeComponent();
        }

        public void generar_formulario_opciones()
        {
            StreamWriter sr = File.CreateText("settings");

            sr.WriteLine("Volume:" + general_vol + ","); //Inventate la estructura pero que
            sr.WriteLine("cosa:" + musica_vol + ","); // facilmente los datos
            sr.WriteLine("FPS:" + fps + ","); // sea estructurado para luego recoger
            sr.WriteLine("FPS:" + modocheto + ","); // sea estructurado para luego recoger

            sr.Close();
        }
        public void cerrar_opciones()
        {
            caja_opciones.Visibility = Visibility.Hidden;
            caja_secion.Visibility = Visibility.Visible;
        }
        public void abrir_opciones()
        {
            caja_opciones.Visibility = Visibility.Visible;
            caja_secion.Visibility = Visibility.Hidden;
        }
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
        }




        private void opciones_Click(object sender, RoutedEventArgs e)
        {
            abrir_opciones();
        }

        private void Button_guardar(object sender, RoutedEventArgs e)
        {
            generar_formulario_opciones();

            cerrar_opciones();
        }


        private void Button_restablecer(object sender, RoutedEventArgs e)
        {
         general_vol = 50;
         musica_vol = 50;
         fps = 30;
         modocheto = false;

            generar_formulario_opciones();

            cerrar_opciones();
        }

        private void Button_mode_desaroyo(object sender, RoutedEventArgs e)
        {
            modocheto = true;

            generar_formulario_opciones();

            cerrar_opciones();
        }

        private void iniciar_secion(object sender, RoutedEventArgs e)
        {


        }
    }
}

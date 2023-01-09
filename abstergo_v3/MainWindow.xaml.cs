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
        private int fps = 60;
        private Boolean modocheto = false;




        public MainWindow()
        {
            InitializeComponent();
            opciones_sonido_general.Value = general_vol;
            musicVolume.Value = musica_vol;
            FPS_selector.SelectedItem = fps;
        }

        public void generar_formulario_opciones()
        {
            StreamWriter sr = File.CreateText("settings");

            sr.WriteLine("volume:" + general_vol + ","); //Inventate la estructura pero que
            sr.WriteLine("music:" + musica_vol + ","); // facilmente los datos
            sr.WriteLine("fps:" + fps + ","); // sea estructurado para luego recoger
            sr.WriteLine("dev:" + modocheto + ","); // sea estructurado para luego recoger

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


        private void iniciar_secion(object sender, RoutedEventArgs e)
        {


        }

        private void volume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            musica_vol = (int)e.NewValue;
        }
        private void opciones_sonido_general_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            general_vol = (int)e.NewValue;
        }

        private void dev_Checked(object sender, RoutedEventArgs e)
        {
            modocheto = true;
        }

        private void dev_Unchecked(object sender, RoutedEventArgs e)
        {
            modocheto = false;
        }

        
    }
}

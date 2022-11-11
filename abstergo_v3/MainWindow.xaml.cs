using System;
using System.Collections.Generic;
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

        private void opciones_Click(object sender, RoutedEventArgs e)
        {
            caja_opciones.Visibility = Visibility.Visible;
            caja_secion.Visibility = Visibility.Hidden;
        }

        private void Button_guardar(object sender, RoutedEventArgs e)
        {
            StreamWriter sr = File.CreateText("settings");

            sr.WriteLine("Volume:" + general_vol + ","); //Inventate la estructura pero que
            sr.WriteLine("cosa:" + musica_vol + ","); // facilmente los datos
            sr.WriteLine("FPS:" + fps + ","); // sea estructurado para luego recoger
            sr.WriteLine("FPS:" + modocheto + ","); // sea estructurado para luego recoger

            sr.Close();


        }
    }
}

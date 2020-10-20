using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace Ejercicio_5
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            visualizarTextBlock.Foreground = Brushes.Blue;
        }

        private void radioBotonAzul_Click(object sender, RoutedEventArgs e)
        {
            visualizarTextBlock.Foreground = Brushes.Blue;
        }

        private void negritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            visualizarTextBlock.FontWeight = FontWeights.Bold;
        }

        private void escribirTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            visualizarTextBlock.Text = escribirTextBox.Text;
        }

        private void radioBotonRojo_Click(object sender, RoutedEventArgs e)
        {
            visualizarTextBlock.Foreground = Brushes.Red;
        }

        private void radioBotonVerde_Click(object sender, RoutedEventArgs e)
        {
            visualizarTextBlock.Foreground = Brushes.Green;
        }

        private void cursivaCheckBox_Click(object sender, RoutedEventArgs e)
        {
            visualizarTextBlock.FontStyle = FontStyles.Italic;
        }

        private void negritaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            visualizarTextBlock.FontWeight = FontWeights.Normal;
        }

        private void cursivaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            visualizarTextBlock.FontStyle = FontStyles.Normal;
        }
    }
}

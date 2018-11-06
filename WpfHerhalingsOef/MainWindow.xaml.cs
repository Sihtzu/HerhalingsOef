using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfHerhalingsOef
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int ingave;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOef1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Convert string ingave naar int
                ingave = int.Parse(txtIngave.Text);

                // Controleer de waarde (ingave < 10 of > 1000) met try catch en if
                if (ingave < 10 || ingave > 1000)
                {
                    throw new IndexOutOfRangeException("Kies een getal tussen 10 en 1000");
                }
                else
                {
                    lstGegevens.Items.Add(ingave);
                }
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Gelieve enkel gehele getallen in te voeren!\n\n" +
                    "Details: " + fEx.Message,
                    "Fout!",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops er is een fout gebeurd.\n\n"
                    + "Details: " + ex.Message,
                    "Fout!",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
            finally
            {
                Debug.WriteLine("Laatste uitvoering: {0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);
            }
        }

        private void btnLijstLeegMaken_Click(object sender, RoutedEventArgs e)
        {
            // Maak de listbox leeg
            lstGegevens.Items.Clear();
        }
    }
}

﻿using System;
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

        private void btnOef2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ingave = int.Parse(txtIngave.Text);

                if (ingave < 1 || ingave > 10)
                {
                    throw new IndexOutOfRangeException("Kies een getal tussen 1 en 10");
                }
                else
                {
                    switch (ingave)
                    {
                        case 1:
                            lstGegevens.Items.Add("1 : één");
                            break;
                        case 2:
                            lstGegevens.Items.Add("2 : Twee");
                            break;
                        case 3:
                            lstGegevens.Items.Add("3 : Drie");
                            break;
                        case 4:
                            lstGegevens.Items.Add("4 : Vier");
                            break;
                        case 5:
                            lstGegevens.Items.Add("5 : Vijf");
                            break;
                        case 6:
                            lstGegevens.Items.Add("6 : Zes");
                            break;
                        case 7:
                            lstGegevens.Items.Add("7 : Zeven");
                            break;
                        case 8:
                            lstGegevens.Items.Add("8 : Acht");
                            break;
                        case 9:
                            lstGegevens.Items.Add("9 : Negen");
                            break;
                        case 10:
                            lstGegevens.Items.Add("10 : Tien");
                            break;
                    }
                }
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Gelieve enkel gehele getallen in te voeren!\n\n"
                    + "Details: " + fEx.Message,
                    "Fout!",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops.. er is een fout gebeurd\n\n" +
                    "Details: " + ex.Message,
                    "Fout!",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
            finally
            {
                Debug.WriteLine("Laatste uitvoering: {0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);
            }
        }

        private void btnOef3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ingave = int.Parse(txtIngave.Text);

                if (ingave < 2)
                {
                    throw new Exception("Getal mag niet kleiner zijn dan 2");
                }
                else
                {
                    for (int i = 1; i < ingave; i++)
                    {
                        i++;
                        lstGegevens.Items.Add(i);
                    }
                }
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Gelieve gehele getallen in te voeren!\n\n"
                    + "Details: " + fEx.Message,
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
                Debug.WriteLine("Laatste uitvoering: {0:dd/MM:yyyy HH:mm:ss}", DateTime.Now);
            }
        }
    }
}
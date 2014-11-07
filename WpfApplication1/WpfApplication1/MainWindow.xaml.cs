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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, RoutedEventArgs e)
        {
            totalRecebido.Content = double.Parse(precoHora.Text) * double.Parse(totalHoras.Text);

            gastosCombustivel.Content = double.Parse(precoLitro.Text) * double.Parse(litrosHora.Text) * double.Parse(totalHoras.Text);

            gastosTratorista.Content = double.Parse(tratorista.Text) * double.Parse(totalHoras.Text);

            double gastos1 = double.Parse(precoLitro.Text) * double.Parse(litrosHora.Text) * double.Parse(totalHoras.Text);

            double gastos2 = double.Parse(tratorista.Text) * double.Parse(totalHoras.Text);

            GastosTotais.Content = gastos1 + gastos2;

            lucroLitro.Content = double.Parse(precoHora.Text) - ( ( double.Parse(tratorista.Text) + (double.Parse(precoLitro.Text) * double.Parse(litrosHora.Text))));

            lucroTotal.Content = (double.Parse(precoHora.Text) * double.Parse(totalHoras.Text)) - (gastos1 + gastos2);
        }

      
    }
}

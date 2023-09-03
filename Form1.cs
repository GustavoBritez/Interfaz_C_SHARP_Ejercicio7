using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_7
{
    public partial class Ejercicio_7 : Form
    {
        public Ejercicio_7()
        {
            InitializeComponent();
        }
        private void Ejercicio_7_Load(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            string interes = ((Decimal.Parse(TX_Monto.Text) * Decimal.Parse(TX_Tasa.Text) * Decimal.Parse(TX_Dias.Text)) / 36500).ToString() ;
            DT_1.Rows.Add(TX_Monto.Text,TX_Tasa.Text,TX_Dias.Text, interes);

        }

        private void BTN_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

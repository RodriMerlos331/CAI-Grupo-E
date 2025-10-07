using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_E.RendicionHDRLargaDistancia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfigurarGrids();
            CargarDatosFalsos();
        }

        public class ItemHDR
        {
            public int IdHDR { get; set; }           // ID de la Hoja de Ruta
            public string Patente { get; set; }     // Patente del micro
            public string NumeroGuia { get; set; }  // Número de tracking / guía
            public string TipoBulto { get; set; }   // S, M, L, XL
            public string Ubicacion { get; set; }   // "Recepcion" o "Despacho"
        }

        // Datos de ejemplo (falsos)
        private List<ItemHDR> datos;

        private void CargarDatosFalsos()
        {
            datos = new List<ItemHDR>
        {
            new ItemHDR { IdHDR = 101, Patente = "AB123CD", NumeroGuia = "000145", TipoBulto = "M", Ubicacion = "Recepcion" },
            new ItemHDR { IdHDR = 101, Patente = "AB123CD", NumeroGuia = "000146", TipoBulto = "XL", Ubicacion = "Recepcion" },
            new ItemHDR { IdHDR = 202, Patente = "AB123CD", NumeroGuia = "000147", TipoBulto = "S", Ubicacion = "Despacho" },
            new ItemHDR { IdHDR = 303, Patente = "XY789ZT", NumeroGuia = "000148", TipoBulto = "L", Ubicacion = "Despacho" },
            new ItemHDR { IdHDR = 303, Patente = "XY789ZT", NumeroGuia = "000149", TipoBulto = "M", Ubicacion = "Recepcion" }

        };
        }

        private void ConfigurarGrids()
        {
            // Recepción
            
            listView5.Columns.Clear();
            listView5.Columns.Add("IdHDR", "ID HDR");
            listView5.Columns.Add("NumeroGuia", "Número de Tracking");
            listView5.Columns.Add("TipoBulto", "Tipo de Bulto");

            // Despacho
          
            listView1.Columns.Clear();
            listView1.Columns.Add("IdHDR", "ID HDR");
            listView1.Columns.Add("NumeroGuia", "Número de Tracking");
            listView1.Columns.Add("TipoBulto", "Tipo de Bulto");
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            string patente = textBox1.Text?.Trim();
            if (string.IsNullOrEmpty(patente))
            {
                MessageBox.Show("Ingresá la patente.", "Patente requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Filtrar por patente y por ubicación
            var recepcion = datos.Where(d => string.Equals(d.Patente, patente, StringComparison.OrdinalIgnoreCase)
                                           && d.Ubicacion == "Recepcion").ToList();

            var despacho = datos.Where(d => string.Equals(d.Patente, patente, StringComparison.OrdinalIgnoreCase)
                                          && d.Ubicacion == "Despacho").ToList();

            // Cargar en grids (solo las 3 columnas requeridas)
            CargarGridSimple(listView5, recepcion);
            CargarGridSimple(listView1, despacho);



        }

        private void CargarGridSimple(DataGridView grid, List<ItemHDR> lista)
        {
            grid.Rows.Clear();
            foreach (var i in lista)
            {
                grid.Rows.Add(i.IdHDR, i.NumeroGuia, i.TipoBulto);
            }
        }

        private void CargarGridSimple(System.Windows.Forms.ListView listView, List<ItemHDR> lista)
        {
            // Asegurarnos de que el ListView está en modo detalles y tiene columnas
            listView.View = View.Details;
            listView.FullRowSelect = true;
            listView.GridLines = true;

            if (listView.Columns.Count == 0)
            {
                listView.Columns.Add("ID HDR", 80);
                listView.Columns.Add("Número de Tracking", 140);
                listView.Columns.Add("Tipo de Bulto", 100);
            }

            listView.Items.Clear();

            foreach (var i in lista)
            {
                var row = new ListViewItem(i.IdHDR.ToString());
                row.SubItems.Add(i.NumeroGuia);
                row.SubItems.Add(i.TipoBulto);
                listView.Items.Add(row);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

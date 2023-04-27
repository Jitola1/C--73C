using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AulaWindowsForm
{
    public partial class Form2 : Form
    {

        public static List<Dictionary<string,string>> valoresConsultas = new List<Dictionary<string,string>>();

        public Form2()
        {
            InitializeComponent();
            GerarColunasLista();
            GerarValores(valoresConsultas);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void GerarValores(List<Dictionary<string,string>> valores)
        {
            foreach(Dictionary<string,string> kvp in valores) {
                string[] lista = formataList(kvp);
                addListView(lista);
            }
        }

        public void GuardaValor()
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            map = pegarmap();
            valoresConsultas.Add(map);
            string[] lista = formataList(map);
            addListView(lista);
        }
        private void GerarColunasLista()
        {
            ltvUsuarios.Columns.Add("Nome Animal", 150).TextAlign = HorizontalAlignment.Center;
            ltvUsuarios.Columns.Add("Médico", 150).TextAlign = HorizontalAlignment.Center;
            ltvUsuarios.Columns.Add("Enfermidade", 150).TextAlign = HorizontalAlignment.Center;
            ltvUsuarios.Columns.Add("Diagnóstico", 150).TextAlign = HorizontalAlignment.Center;
            foreach(string value in Form1.nomeAnimas)
            {
                cbAnimal.Items.Add(value);
            }

            ltvUsuarios.View = View.Details;
        }

        public string[] formataList(Dictionary<string, string> map)
        {
            map.TryGetValue("Médico", out string medico).ToString();
            map.TryGetValue("Enfermidade", out string enferm).ToString();
            map.TryGetValue("Diagnóstico", out string diagno).ToString();
            map.TryGetValue("Nome Animal", out string animal).ToString();
            string[] lista = new string[4] { animal,medico, enferm, diagno };
            return lista;
        }

        public Dictionary<string, string> pegarmap()
        {
            Dictionary<string, string> map = new Dictionary<string, string>();

            map.TryAdd("Médico", txtMedico.Text);
            map.TryAdd("Enfermidade", txtUltima.Text);
            map.TryAdd("Diagnóstico", txtDiagno.Text);
            map.TryAdd("Nome Animal", cbAnimal.Text);
            return map;
        }

        public void LimpaCampos()
        {
           
            txtMedico.Clear();
            txtUltima.Clear();
            txtDiagno.Clear();
        }

        public void addListView(string[] list)
        {
            var listView = new ListViewItem(list);
            ltvUsuarios.Items.Add(listView);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            GuardaValor();
            LimpaCampos();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            valoresConsultas.Clear();
            ltvUsuarios.Clear();
            GerarColunasLista();

        }
    }
}

using System.Security.Permissions;
using System.Security.Policy;

namespace AulaWindowsForm

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GerarColunasLista();
        }

        public static List<string> nomeAnimas = new List<string>(); 


        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            GuardaValor();
            LimpaCampos();

        }


        public void GuardaValor()
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            map = pegarmap();
            string[] lista = formataList(map);
            addListView(lista);
        }
        private void GerarColunasLista()
        {
            ltvUsuarios.Columns.Add("Nome", 200).TextAlign = HorizontalAlignment.Center;
            ltvUsuarios.Columns.Add("Data de Nascimento", 100).TextAlign = HorizontalAlignment.Center;
            ltvUsuarios.Columns.Add("Raça", 100).TextAlign = HorizontalAlignment.Center;
            ltvUsuarios.Columns.Add("Nome Pessoa", 150).TextAlign = HorizontalAlignment.Center;
            ltvUsuarios.Columns.Add("Endereco", 150).TextAlign = HorizontalAlignment.Center;
            ltvUsuarios.Columns.Add("Telefone", 150).TextAlign = HorizontalAlignment.Center;
            ltvUsuarios.View = View.Details;
        }

        

        public string[] formataList(Dictionary<string, string> map)
        {
            map.TryGetValue("Nome", out string nome).ToString();
            map.TryGetValue("Data de Nascimento", out string nasc).ToString();
            map.TryGetValue("Raça", out string raca).ToString();
            map.TryGetValue("Nome Pessoa", out string NomPess).ToString();
            map.TryGetValue("Endereço", out string Enderco).ToString();
            map.TryGetValue("Telefone", out string tel).ToString();

            string[] lista = new string[6] { nome, nasc, raca,NomPess,Enderco,tel };
            return lista;
        }

        public Dictionary<string, string> pegarmap()
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            nomeAnimas.Add(txtNome.Text.ToString());
            map.TryAdd("Nome", txtNome.Text);
            map.TryAdd("Data de Nascimento", txtNascimento.Text);
            map.TryAdd("Raça", txtRaca.Text);
            map.TryAdd("Nome Pessoa", txtNomeP.Text);
            map.TryAdd("Endereço", txtEnder.Text);
            map.TryAdd("Telefone", txtTel.Text);

            return map;
        }

        public void LimpaCampos()
        {
            
            txtNome.Text = null;
            txtNascimento.Text = null;
            txtRaca.Text = null;
            txtNomeP.Text = null;
            txtEnder.Text = null;
            txtTel.Text = null;
        }

        public void addListView(string[] list)
        {
            var listView = new ListViewItem(list);
            ltvUsuarios.Items.Add(listView);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConsul_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nomeAnimas.Clear();
            ltvUsuarios.Clear();
            GerarColunasLista();
        }
    }
}
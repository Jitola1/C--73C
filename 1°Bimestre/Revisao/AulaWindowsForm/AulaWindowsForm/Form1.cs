namespace AulaWindowsForm

{
    public partial class Form1 : Form
    {

        private string Nome;
        public int a=0;
        private string Email;
        public Form1()
        {
            InitializeComponent();

            Nome = txtName.Text;
            Email = txtEmail.Text;
            GerarColunasLista();
        }


        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string Nome = txtName.Text;
            string Email = txtEmail.Text;

            MessageBox.Show($"Olá, {Nome}! \nEnviamos uma configuração para o email {Email}", $" Boas-vindas!");
            Dictionary<string,string> map= new Dictionary<string,string>();
            map.TryAdd("Nome", txtName.Text);
            map.TryAdd("Email", Email);
            //ltvUsuarios.Items.Add(new ListViewItem(lista));
            map.TryGetValue("Nome", out string nome).ToString();
            map.TryGetValue("Email", out string email).ToString();
            a++;
                string[] lista = new string[2] { nome, email };
                ListViewItem listViewItem = new ListViewItem(lista);
                ltvUsuarios.Items.Add(listViewItem);
            

            LimparCampos();
        }


        //public string MontarTexto(List<Dictionary<string, string>> lista)

        public Dictionary<string, string> maps(string Nome,string Email)
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.TryAdd("Nome", txtName.Text);
            map.TryAdd("Email", Email);
            return map;
        }

        public void LimparCampos()
        {
            txtName.Clear();
            txtEmail.Clear();
        }

        private void GerarColunasLista()
        {
            ltvUsuarios.Columns.Add("Nome",200).TextAlign = HorizontalAlignment.Center;
            ltvUsuarios.Columns.Add("Email", 150).TextAlign = HorizontalAlignment.Center;

            ltvUsuarios.View = View.Details;
        }
    }
}
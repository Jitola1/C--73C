using System;

public class Class1
{
	public Class1()
	{
        public int Cad = 0;
		public void GuardaValor()
		{
            Dictionary<string, string> map = new Dictionary<string, string>();
            map = pegarmap();
            string[] lista = formataList(map);
            addListView(lista);
        }
        /*private void GerarColunasLista()
        {
            ltvUsuarios.Columns.Add("Nome", 200).TextAlign = HorizontalAlignment.Center;
            ltvUsuarios.Columns.Add("Data de Nascimento", 10).TextAlign = HorizontalAlignment.Center;
            ltvUsuarios.Columns.Add("Raça", 50).TextAlign = HorizontalAlignment.Center;
            ltvUsuarios.Columns.Add("Médico", 150).TextAlign = HorizontalAlignment.Center;
            ltvUsuarios.Columns.Add("Enfermidade", 150).TextAlign = HorizontalAlignment.Center;
            ltvUsuarios.Columns.Add("Diagnóstico", 150).TextAlign = HorizontalAlignment.Center;
            ltvUsuarios.Columns.Add("Nome Pessoa", 150).TextAlign = HorizontalAlignment.Center;
            ltvUsuarios.Columns.Add("Endereco", 150).TextAlign = HorizontalAlignment.Center;
            ltvUsuarios.Columns.Add("Telefone", 150).TextAlign = HorizontalAlignment.Center;
            ltvUsuarios.View = View.Details;
        }*/

        public string[8] formataList(Dictionary<string, string> map)
        {
            map.TryGetValue("Nome", out string nome).ToString();
            map.TryGetValue("Data de Nascimento", out string nasc).ToString();
            map.TryGetValue("Raça", out string raca).ToString();
            map.TryGetValue("Médico", out string medico).ToString();
            map.TryGetValue("Enfermidade", out string enferm).ToString();
            map.TryGetValue("Diagnóstico", out string diagno).ToString();
            map.TryGetValue("Nome Pessoa", out string NomPess).ToString();
            map.TryGetValue("Endereco", out string Enderco).ToString();
            map.TryGetValue("Telefone", out string tel).ToString();
            string[] lista = new string[8] { nome, nasc, raca, medico, enferm, diagno, NomPess, Enderco, tel }
            return lista;
        }

         public Dictionary<string, string> pegarmap()
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.TryAdd("Nome", txtNome.Text);
            map.TryAdd("Data de Nascimento", txtNascimento.Text);
            map.TryAdd("Raça", txtRaca.Text);
            map.TryAdd("Médico", txtMedico.Text);
            map.TryAdd("Enfermidade", txtEnferma.Text);
            map.TryAdd("Diagnóstico", txtDiagno.Text);
            map.TryAdd("Nome Pessoa", txtPessoa.Text);
            map.TryAdd("Endereço", txtEnder.Text);
            map.TryAdd("Telefone", txtTel.Text);
            return map;
        }   

        public void addListView(string[9] list)
        {
            
        }_
    }
}

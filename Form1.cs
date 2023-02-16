using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercíciosDeFixação3
{
    public partial class Form1 : Form
    {

        private OpenFileDialog novoArquivo = new OpenFileDialog();
        private SaveFileDialog salvarNovoArquivo = new SaveFileDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void limparControles()
        {
            btnExcluir.Visible = false;
            btnEdit.Visible = false;
            txtNome.Enabled = true;
            dtNascimento.Enabled = true;
            txtSobrenome.Enabled = true;
            txtNome.Clear();
            txtSobrenome.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            dtNascimento.Value = DateTime.Now;

        }

        private void lboPessoas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboPessoas.SelectedItem == null)
            {
                txtNome.Enabled = false;
                txtSobrenome.Enabled = false;
                dtNascimento.Enabled = false;
                Pessoa pessoa = lboPessoas.SelectedItem as Pessoa;
                txtNome.Text = pessoa.Nome;
                txtSobrenome.Text = pessoa.Sobrenome;
                txtTelefone.Text = pessoa.Telefone;
                txtEmail.Text = pessoa.Email;
                dtNascimento.Value = pessoa.DataNascimento;

                btnEdit.Visible = true;
                btnExcluir.Visible = true;
                btnAdd.Text = "Cancelar";
            }
        }

        private void BtnLeitura_Click(object sender, EventArgs e)
        {

            if (btnLeitura.Text == "Inserir Dados")
            {
                limparControles();
                if (novoArquivo.ShowDialog() != DialogResult.OK)
                    return;

                if (!novoArquivo.FileName.Contains(".csv"))
                    return;
                string caminho = novoArquivo.FileName;
                string textoLido;

                try
                {
                    textoLido = File.ReadAllText(caminho);
                }
                catch (Exception Exc)
                {
                    tbPrincipal.SelectedIndex = 1;
                    lblErro.Text = Exc.Message;
                    return;
                }

                int i = 0;
                lboPessoas.Items.Clear();
                foreach (var linha in textoLido.Split('\n'))
                {
                    if (linha == "" || linha == "\r") break;
                    if (i != 0)
                    {
                        string[] tratamento = linha.Split(';');
                        Pessoa ps = new Pessoa(tratamento[0], tratamento[1], DateTime.Parse(tratamento[2]), tratamento[3], tratamento[4]);
                        lboPessoas.Items.Add(ps);
                    }
                    i++;
                }
                btnLeitura.Text = "Salvar Arquivo";
            }

            else
            {
                string txt = "Nome,Sobrenome,Data de Nascimento;Telefone;Email\n";
                foreach (Pessoa pessoa in lboPessoas.Items)
                {
                    txt += pessoa.Nome + ";";
                    txt += pessoa.Sobrenome + ";";
                    txt += pessoa.DataNascimento + ";";
                    txt += pessoa.Telefone + ";";
                    txt += pessoa.Email + "\n";
                }
                txt = txt.Substring(0, txt.Length - 5);
                salvarNovoArquivo.Filter = "Arquivo CSV|*.csv";
                salvarNovoArquivo.Title = "Salvar Arquivo";
                if (salvarNovoArquivo.ShowDialog() != DialogResult.OK && salvarNovoArquivo.FileName == null) return;
                if (salvarNovoArquivo.ShowDialog() != DialogResult.Cancel) return;

                try
                {
                    FileStream abrirArquivo = (FileStream)salvarNovoArquivo.OpenFile();
                    StreamWriter salvandoArquivo = new StreamWriter(abrirArquivo);

                    salvandoArquivo.WriteLine(txt);
                    salvandoArquivo.Close();
                    abrirArquivo.Close();
                    btnLeitura.Text = "Inserir Dados";
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            lboPessoas.Items.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Pessoa p1 = new Pessoa(txtNome.Text, txtSobrenome.Text, dtNascimento.Value, txtTelefone.Text, txtEmail.Text);
            lboPessoas.Items.Add(p1.ToString());
            limparControles();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lboPessoas.SelectedItem == null) return;
            Pessoa pessoa = (Pessoa)lboPessoas.SelectedItem;
            pessoa.Telefone = txtTelefone.Text;
            pessoa.Email = txtEmail.Text;
            for (int i = 0; i < lboPessoas.Items.Count; i++)
            {
                if (lboPessoas.Items[i] == lboPessoas.SelectedValue)
                {
                    lboPessoas.Items[i] = pessoa;
                    break;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            lboPessoas.Items.Remove(lboPessoas.SelectedItem);
            limparControles();
        }

        private void btnErro_Click(object sender, EventArgs e)
        {
            lboPessoas.Items.Remove(lboPessoas.SelectedItem);
            limparControles();
        }
    }
}

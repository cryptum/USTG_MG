using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using USTG_MG.Model;

namespace USTG_MG.AppWin32.Cadastros.Contingentes
{
    public partial class Edit : Form
    {
        private const string campoObrigatorio = "campo obrigatório!";
        private const string selecioneUm = "selecione um!";
        private readonly IRepository _repository;
        private readonly int _id;

        public Edit(IRepository repository, int id)
        {
            _id = id;
            _repository = repository;
            InitializeComponent();
            CarregarDrops();
            CarregarGrids();
            MostarNaTela();
            groupBox2.Focus();
            txtNomeDeGuerra.Focus();

        }

        private void CarregarGrids()
        {
            gridJusticaOuDisiplina.DataSource = _repository.JusticasOuDisciplinas.ObterPor(_id);
            gridFaltasOuAtrasos.DataSource = _repository.FaltasOuAtrasos.ObterPor(_id);
            gridHorasExtras.DataSource = _repository.HorasExtras.ObterPor(_id);
            gridTAF.DataSource = _repository.Tafs.ObterPor(_id);
        }

        private void CarregarDrops()
        {
            dropPatente.DataSource = _repository.Patentes.ObterTodos();
            dropPatente.SelectedIndex = -1;

            dropTurma.DataSource = _repository.Turmas.ObterTodos();
            dropTurma.SelectedIndex = -1;

            dropStatus.DataSource = Enum.GetNames(typeof(StatusDoMilitar)).Select(i => i.Replace("_"," "));
            dropStatus.SelectedIndex = -1;

            dropProfissao.DataSource = _repository.Profissoes.ObterTodos();
            dropProfissao.SelectedIndex = -1;

            dropReligiao.DataSource = _repository.Religioes.ObterTodos();
            dropReligiao.SelectedIndex = -1;

            dropEscolaridade.DataSource = _repository.Escolaridades.ObterTodos();
            dropEscolaridade.SelectedIndex = -1;

            dropVoluntario.SelectedIndex = -1;

        }

        private void MostarNaTela()
        {
            if (_id.Equals(0)) return;

            var obj = _repository.Contingentes.ObterNovoOuPor(_id);
            txtNomeCompleto.Text = obj.NomeCompleto;
            txtNomeDaMae.Text = obj.NomeDaMae;
            txtNomeDeGuerra.Text = obj.NomeDeGuerra;
            txtNomeDoPai.Text = obj.NomeDoPai;
            txtRA.Text = obj.RA;
            txtCPF.Text = obj.CPF;
            txtIdentidade.Text = obj.Identidade;
            txtTelCelular.Text = obj.TelefoneCelular;
            txtTelFixo.Text = obj.TelefoneFixo;
            txtTituloEleitor.Text = obj.TituloEleitor;
            txtNaturalDe.Text = obj.NaturalDe;
            txtDataNascimento.Text = obj.DataNascimento.ToShortDateString();
            txtEmail.Text = obj.Email;
            txtLogradouro.Text = obj.Logradouro;
            txtNumero.Text = obj.Numero;
            txtComplemento.Text = obj.Complemento;
            txtBairro.Text = obj.Bairro;
            txtCidade.Text = obj.Cidade;
            txtCep.Text = obj.CEP;
            txtAnoIncorporacao.Text = obj.AnoIncorporacao;
            dropPatente.SelectedValue = obj.PatenteId;
            dropProfissao.SelectedValue = obj.ProfissaoId;
            dropReligiao.SelectedValue = obj.ReligiaoId;
            dropStatus.SelectedIndex = (int)obj.Status - 1;
            dropTurma.SelectedValue = obj.TurmaId;
            dropVoluntario.SelectedIndex = -1;
            dropVoluntario.Text = obj.EhVoluntario;
            dropEscolaridade.SelectedValue = obj.EscolaridadeId;
            lblAtrasos.Text = obj.Atrasos.ToString();
            lblFaltas.Text = obj.Faltas.ToString();
            lblElogios.Text = obj.Elogios.ToString();
            lblPunicoes.Text = obj.Punicoes.ToString();
            lblHorasExtras.Text = obj.HorasExtras.ToString();
            if (obj.Fotos.Count > 0)
                pictureBox1.Image = Util.ObterFoto(obj.Fotos);

            groupBoxSituacao.Visible = true;
            btnTrocarFoto.Visible = true;
            groupBoxFoto.Visible = false;
            this.Text += $" ({obj.NomeDeGuerra} - {obj.RA})";


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!EhValido()) return;

            if (_id.Equals(0) && string.IsNullOrWhiteSpace(txtFotoCaminho.Text))
            {
                if (MessageBox.Show("Deseja incluir o registro sem a foto?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
            }

            try
            {
                var obj = _repository.Contingentes.ObterNovoOuPor(_id);
                obj.NomeCompleto = txtNomeCompleto.Text;
                obj.NomeDaMae = txtNomeDaMae.Text;
                obj.NomeDeGuerra = txtNomeDeGuerra.Text;
                obj.NomeDoPai = txtNomeDoPai.Text;
                obj.RA = txtRA.Text;
                obj.CPF = txtCPF.Text;
                obj.Identidade = txtIdentidade.Text;
                obj.AnoIncorporacao = txtAnoIncorporacao.Text;
                obj.TelefoneCelular = txtTelCelular.Text;
                obj.TelefoneFixo = txtTelFixo.Text;
                obj.TituloEleitor = txtTituloEleitor.Text;
                obj.NaturalDe = txtNaturalDe.Text;
                obj.DataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
                obj.Email = txtEmail.Text;
                obj.CEP = txtCep.Text;
                obj.Logradouro = txtLogradouro.Text;
                obj.Numero = txtNumero.Text;
                obj.Complemento = txtComplemento.Text;
                obj.Bairro = txtBairro.Text;
                obj.Cidade = txtCidade.Text;
                obj.Patente = _repository.Patentes.ObterNovoOuPor(Convert.ToInt32(dropPatente.SelectedValue));
                obj.Profissao = _repository.Profissoes.ObterNovoOuPor(Convert.ToInt32(dropProfissao.SelectedValue));
                obj.Religiao = _repository.Religioes.ObterNovoOuPor(Convert.ToInt32(dropReligiao.SelectedValue));
                obj.Escolaridade = _repository.Escolaridades.ObterNovoOuPor(Convert.ToInt32(dropEscolaridade.SelectedValue));
                obj.Status = (StatusDoMilitar)dropStatus.SelectedIndex + 1;
                obj.Turma = _repository.Turmas.ObterNovoOuPor(Convert.ToInt32(dropTurma.SelectedValue));
                obj.EhVoluntario = dropVoluntario.Text;
                obj.AtualizadoPor = Util.Usuario.Nome;

                if (_id.Equals(0))
                    obj.Fotos = ObterFoto();

                obj.Validar();

                _repository.Contingentes.Salvar(obj);
                _repository.SaveChanges();

                if (_id.Equals(0))
                    Limpar();
                else
                    this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private List<ContingenteFoto> ObterFoto()
        {
            var lista = new List<ContingenteFoto>();

            if (!string.IsNullOrWhiteSpace(txtFotoCaminho.Text))
            {
                var foto = new ContingenteFoto();
                foto.Binario = File.ReadAllBytes(txtFotoCaminho.Text);
                foto.Extensao = Path.GetExtension(txtFotoCaminho.Text);
                foto.NomeArquivo = Path.GetFileNameWithoutExtension(txtFotoCaminho.Text);
                foto.AtualizadoPor = Util.Usuario.Nome;
                foto.Validar();
                lista.Add(foto);
            }

            return lista;

        }

        private void Limpar()
        {
            txtCep.Text = string.Empty;
            txtNomeCompleto.Text = string.Empty;
            txtNomeDaMae.Text = string.Empty;
            txtNomeDeGuerra.Text = string.Empty;
            txtNomeDoPai.Text = string.Empty;
            txtRA.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtIdentidade.Text = string.Empty;
            txtTelCelular.Text = string.Empty;
            txtTelFixo.Text = string.Empty;
            txtTituloEleitor.Text = string.Empty;
            txtNaturalDe.Text = string.Empty;
            txtDataNascimento.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtLogradouro.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtFotoCaminho.Text = string.Empty;
            txtAnoIncorporacao.Text = string.Empty;
            dropPatente.SelectedIndex = -1;
            dropProfissao.SelectedIndex = -1;
            dropReligiao.SelectedIndex = -1;
            dropStatus.SelectedIndex = -1;
            dropTurma.SelectedIndex = -1;
            dropVoluntario.SelectedIndex = -1;
            dropEscolaridade.SelectedIndex = -1;
            txtNomeDeGuerra.Focus();

        }

        private bool EhValido()
        {
            bool ehValido = true;
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtNomeDeGuerra.Text))
            {
                errorProvider1.SetError(txtNomeDeGuerra, campoObrigatorio);
                ehValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtNomeCompleto.Text))
            {
                errorProvider1.SetError(txtNomeCompleto, campoObrigatorio);
                ehValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtIdentidade.Text))
            {
                errorProvider1.SetError(txtIdentidade, campoObrigatorio);
                ehValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtRA.Text))
            {
                errorProvider1.SetError(txtRA, campoObrigatorio);
                ehValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtAnoIncorporacao.Text))
            {
                errorProvider1.SetError(txtAnoIncorporacao, campoObrigatorio);
                ehValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtCPF.Text))
            {
                errorProvider1.SetError(txtCPF, campoObrigatorio);
                ehValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtTituloEleitor.Text))
            {
                errorProvider1.SetError(txtTituloEleitor, campoObrigatorio);
                ehValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, campoObrigatorio);
                ehValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtTelFixo.Text))
            {
                errorProvider1.SetError(txtTelFixo, campoObrigatorio);
                ehValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtTelCelular.Text))
            {
                errorProvider1.SetError(txtTelCelular, campoObrigatorio);
                ehValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtCep.Text))
            {
                errorProvider1.SetError(txtCep, campoObrigatorio);
                ehValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtLogradouro.Text))
            {
                errorProvider1.SetError(txtLogradouro, campoObrigatorio);
                ehValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                errorProvider1.SetError(txtNumero, campoObrigatorio);
                ehValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtComplemento.Text))
            {
                errorProvider1.SetError(txtComplemento, campoObrigatorio);
                ehValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtNaturalDe.Text))
            {
                errorProvider1.SetError(txtNaturalDe, campoObrigatorio);
                ehValido = false;
            }

            if (!txtDataNascimento.Text.Any(c => char.IsDigit(c)))
            {
                errorProvider1.SetError(txtDataNascimento, campoObrigatorio);
                ehValido = false;
            }

            if (!txtCep.Text.Any(c => char.IsDigit(c)))
            {
                errorProvider1.SetError(txtCep, campoObrigatorio);
                ehValido = false;
            }

            if (!txtCPF.Text.Any(c => char.IsDigit(c)))
            {
                errorProvider1.SetError(txtCPF, campoObrigatorio);
                ehValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtNomeDeGuerra.Text))
            {
                errorProvider1.SetError(txtNomeDeGuerra, campoObrigatorio);
                ehValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtBairro.Text))
            {
                errorProvider1.SetError(txtBairro, campoObrigatorio);
                ehValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtNomeDaMae.Text))
            {
                errorProvider1.SetError(txtNomeDaMae, campoObrigatorio);
                ehValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtNomeDoPai.Text))
            {
                errorProvider1.SetError(txtNomeDoPai, campoObrigatorio);
                ehValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtCidade.Text))
            {
                errorProvider1.SetError(txtCidade, campoObrigatorio);
                ehValido = false;
            }

            if (dropPatente.SelectedIndex < 0)
            {
                errorProvider1.SetError(dropPatente, selecioneUm);
                ehValido = false;
            }

            if (dropProfissao.SelectedIndex < 0)
            {
                errorProvider1.SetError(dropProfissao, selecioneUm);
                ehValido = false;
            }

            if (dropReligiao.SelectedIndex < 0)
            {
                errorProvider1.SetError(dropReligiao, selecioneUm);
                ehValido = false;
            }

            if (dropStatus.SelectedIndex < 0)
            {
                errorProvider1.SetError(dropStatus, selecioneUm);
                ehValido = false;
            }

            if (dropTurma.SelectedIndex < 0)
            {
                errorProvider1.SetError(dropTurma, selecioneUm);
                ehValido = false;
            }

            if (string.IsNullOrWhiteSpace(dropVoluntario.Text))
            {
                errorProvider1.SetError(dropVoluntario, selecioneUm);
                ehValido = false;
            }




            return ehValido;
        }

        private void btnPesquisarFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog file = new OpenFileDialog())
            {
                file.Multiselect = false;
                file.Filter = @"Image Files(*.jpg;*.jpeg;*.gif;*.png)|*.jpg;*.jpeg;*.gif;*.png";
                if (file.ShowDialog() != DialogResult.OK)
                    return;

                txtFotoCaminho.Text = file.FileName;
            }
        }

        private void btnTrocarFoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (OpenFileDialog file = new OpenFileDialog())
            {
                file.Multiselect = false;
                file.Filter = @"Image Files(*.jpg;*.jpeg;*.gif;*.png)|*.jpg;*.jpeg;*.gif;*.png";
                if (file.ShowDialog() != DialogResult.OK)
                    return;

                var foto = new ContingenteFoto();
                foto.Binario = File.ReadAllBytes(file.FileName);
                foto.Extensao = Path.GetExtension(file.FileName);
                foto.NomeArquivo = Path.GetFileNameWithoutExtension(file.FileName);
                foto.AtualizadoPor = Util.Usuario.Nome;
                foto.ContingenteId = _id;
                foto.Validar();

                _repository.ContingentesFotos.Salvar(foto);
                _repository.SaveChanges();
            }

            MostarNaTela();
        }
                
        private void textbox_Enter(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}

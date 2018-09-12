using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USTG_MG.Model
{
    public abstract class EntityBase
    {
        public int Id { get; set; }
        public string CadastradoPor { get; protected set; }
        public DateTime DataCadastro { get; protected set; }
        public string AtualizadoPor { get; set; }
        public DateTime DataAtualizacao { get; protected set; }

        protected StringBuilder _RegrasQuabradas = new StringBuilder();

        public virtual void Validar()
        {
            DataAtualizacao = DateTime.Now;
            if (Id.Equals(0))
            {
                CadastradoPor = AtualizadoPor;
                DataCadastro = DataAtualizacao;
            }

            _CampoObrigatorio("Atualizado Por", AtualizadoPor);

            if (_RegrasQuabradas.Length > 0)
                throw new ApplicationException(_RegrasQuabradas.ToString());
        }

        protected void _CampoObrigatorio(string nome, string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
                _RegrasQuabradas.Append($"O campo {nome} é obrigatório.{Environment.NewLine}");
        }

        protected void _CampoObrigatorio(string nome, int valor)
        {
            if(valor.Equals(0))
                _RegrasQuabradas.Append($"O campo {nome} é obrigatório.{Environment.NewLine}");
        }

        protected void _DataDeveSerValida(string nome, DateTime valor)
        {
            if (valor.Equals(DateTime.MinValue))
                _RegrasQuabradas.Append($"Informe uma data válida.{Environment.NewLine}");
        }

        protected void _ObjetoNaoPodeSerNulo<T>(string nome, T entidade)
        {
            if (entidade == null)
                _RegrasQuabradas.Append($"A entidade {nome} não foi definida ou encontrada.{Environment.NewLine}");
        }

        protected void _DataNaoPodeEstarNoFuturo(string nome, DateTime valor)
        {
            if (valor.Date > DateTime.Today)
                _RegrasQuabradas.Append($"Não é permitido lançamento com data futura.{Environment.NewLine}");
        }
    }

    public interface IRepositoryBase<T> where T : EntityBase
    {
        void Salvar(T entity);
        void Excluir(T entity);
        T ObterNovoOuPor(int id);
        List<T> ObterTodos();
    }

    public interface IRepository
    {
        IAtividadeExtraRepository AtividadesExtras { get; }
        IContingenteRepository Contingentes { get; }
        IContingenteFotoRepository ContingentesFotos { get; }
        IEscolaridadeRepository Escolaridades { get; }
        IFaltaOuAtrasoRepository FaltasOuAtrasos { get; }
        IHoraExtraRepository HorasExtras { get; }
        IJusticaOuDisciplinaRepository JusticasOuDisciplinas { get; }
        IPatenteRepository Patentes { get; }
        IReligiaoRepository Religioes { get; }
        ITAFRepository Tafs { get; }
        ITurmaRepository Turmas { get; }
        IProfissaoRepository Profissoes { get; }
        IConfiguracaoRepository Configuracoes { get; }
        IUsuarioRepository Usuarios { get; }
        void SaveChanges();

    }
    
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace USTG_MG.Model
{
    [Table("Contingentes")]
    public  class Contingente:EntityBase
    {       
        public string NomeDeGuerra { get; set; }
        public string NomeCompleto { get; set; }
        public DateTime DataNascimento { get; set; }
        public string RA { get; set; }
        public string Identidade { get; set; }
        public string CPF { get; set; }
        public string TituloEleitor { get; set; }
        public string NomeDoPai { get; set; }
        public string NomeDaMae { get; set; }
        public string NaturalDe { get; set; }
        public string TelefoneFixo { get; set; }
        public string TelefoneCelular { get; set; }
        public string Email { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string EhVoluntario { get; set; }
        public string AnoIncorporacao { get; set; }

        public StatusDoMilitar Status { get; set; }
        public Turma Turma { get; set; }
        public int TurmaId { get; set; }
        public Patente Patente { get; set; }
        public int PatenteId { get; set; }
        public Religiao Religiao { get; set; }
        public int ReligiaoId { get; set; }
        public Escolaridade Escolaridade { get; set; }
        public int EscolaridadeId { get; set; }
        public Profissao Profissao { get; set; }
        public int ProfissaoId { get; set; }
        
        public List<ContingenteFoto> Fotos { get; set; }

        public int Faltas { get; set; }
        public int Atrasos { get; set; }
        public int Elogios { get; set; }
        public int Punicoes { get; set; }
        public int HorasExtras { get; set; }
       

        public override void Validar()
        {
            _CampoObrigatorio(nameof(NomeCompleto), NomeCompleto);
            _CampoObrigatorio(nameof(NomeDaMae), NomeDaMae);
            _CampoObrigatorio(nameof(NomeDeGuerra), NomeDeGuerra);
            _CampoObrigatorio(nameof(NomeDoPai), NomeDoPai);
            _CampoObrigatorio(nameof(CEP), CEP);
            _CampoObrigatorio(nameof(CPF), CPF);
            _CampoObrigatorio(nameof(Identidade), Identidade);
            _CampoObrigatorio(nameof(TituloEleitor), TituloEleitor);
            _CampoObrigatorio(nameof(RA), RA);
            _CampoObrigatorio(nameof(Logradouro), Logradouro);
            _CampoObrigatorio(nameof(Numero), Numero);
            _CampoObrigatorio(nameof(Bairro), Bairro);
            _CampoObrigatorio(nameof(TelefoneCelular), TelefoneCelular);
            _CampoObrigatorio(nameof(TelefoneFixo), TelefoneFixo);
            _CampoObrigatorio(nameof(Email), Email);
            _CampoObrigatorio("Ano Incorporação", AnoIncorporacao);
            _CampoObrigatorio("Nome Completo", NomeCompleto);
            _ObjetoNaoPodeSerNulo("Profissão", Profissao);
            _ObjetoNaoPodeSerNulo(nameof(Turma), Turma);
            _ObjetoNaoPodeSerNulo(nameof(Patente), Patente);
            _ObjetoNaoPodeSerNulo(nameof(Religiao), Religiao);
            _ObjetoNaoPodeSerNulo(nameof(Escolaridade), Escolaridade);

            base.Validar();
        }

        public void ComputarFalta()
        {
            Faltas += 1;
        }

        public void ComputarAtrasos()
        {
            Atrasos += 1;
        }

        public void ComputarElogios()
        {
            Elogios += 1;
        }

        public void ComputarPunicoes()
        {
            Punicoes += 1;
        }

        public void ComputarHorasExtras(int qtdHoras)
        {
            HorasExtras += qtdHoras;
        }
    }

   
    public class ContingenteVM
    {
        public int Id { get; set; }
        public string Turma { get; set; }
        public string RA { get; set; }
        public string NomeDeGuerra { get; set; }       
        public string Patente { get; set; }
        public string Status { get; set; }
        public int Faltas { get; set; }
        public int Atrasos { get; set; }
        public int Elogios { get; set; }
        public int Punicoes { get; set; }
        public int HorasExtras { get; set; }        
        
    }

    public enum StatusDoMilitar
    {
        Ativo = 1,
        Inativo = 2,
        Em_Observação = 3
    }

    public interface IContingenteRepository : IRepositoryBase<Contingente> {
        List<ContingenteVM> ObterPorNome(string nome, int turmaId);
        List<ContingenteVM> ObterPorRA(string ra, int turmaId);
        List<ContingenteVM> ObterTodos(int turmaId);
        
    }
}

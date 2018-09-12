using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace USTG_MG.Model
{
    [Table("Turmas")]
    public class Turma:EntityBase
    {
        public string ANO { get; set; }
        public string NomeComandante { get; set; }

        public override void Validar()
        {
            _CampoObrigatorio("ANO", ANO);
            _CampoObrigatorio("Nome do Comandante", NomeComandante);

            if (ANO != null && ANO.Any(c => !char.IsDigit(c)))            
                _RegrasQuabradas.Append($"O campo ANO deve conter somente números.{Environment.NewLine}");            

            if(ANO != null && (ANO.Length > 4 || ANO.Length < 4))
                _RegrasQuabradas.Append($"O campo ANO deve conter 4 caracteres númericos.{Environment.NewLine}");
           
            base.Validar();
        }
    }

    public interface ITurmaRepository : IRepositoryBase<Turma> { }

   
}

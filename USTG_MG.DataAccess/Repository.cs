﻿using System;

using System.Data.Entity.Validation;
using USTG_MG.DataAccess.Contextos;
using USTG_MG.DataAccess.Repositorios;
using USTG_MG.Model;

namespace USTG_MG.DataAccess
{
    public class Repository : IRepository
    {
        private USGTContext context;
        private IAtividadeExtraRepository atividadesExtras;
        private IContingenteRepository contingentes;
        private IContingenteFotoRepository contingenteFotos;
        private IEscolaridadeRepository escolaridades;
        private IFaltaOuAtrasoRepository faltasOuAtrasos;
        private IHoraExtraRepository horasExtras;
        private IJusticaOuDisciplinaRepository justicasOuDisciplinas;
        private IPatenteRepository patentes;
        private IReligiaoRepository religioes;
        private ITAFRepository tAFs;
        private ITurmaRepository turmas;
        private IProfissaoRepository profissoes;
        private IUsuarioRepository usuarios;
        private IConfiguracaoRepository configuracoes;
        private IServicoRepository servicos;

        public Repository()
        {
            context = new USGTContext();
        }

        public IAtividadeExtraRepository AtividadesExtras => atividadesExtras ?? (atividadesExtras = new AtividadeExtraRepository(context));

        public IContingenteRepository Contingentes => contingentes ?? (contingentes = new ContingenteRepository(context));

        public IContingenteFotoRepository ContingentesFotos => contingenteFotos ?? (contingenteFotos = new ContingenteFotoRepository(context));

        public IEscolaridadeRepository Escolaridades => escolaridades ?? (escolaridades = new EscolaridadeRepository(context));

        public IFaltaOuAtrasoRepository FaltasOuAtrasos => faltasOuAtrasos ?? (faltasOuAtrasos = new FaltaOuAtrasoRepository(context));

        public IHoraExtraRepository HorasExtras => horasExtras ?? (horasExtras = new HoraExtraRepository(context));

        public IJusticaOuDisciplinaRepository JusticasOuDisciplinas => justicasOuDisciplinas ?? (justicasOuDisciplinas = new JusticaOuDisciplinaRepository(context));

        public IPatenteRepository Patentes => patentes ?? (patentes = new PatenteRepository(context));

        public IReligiaoRepository Religioes => religioes ?? (religioes = new ReligiaoRepository(context));

        public ITAFRepository Tafs => tAFs ?? (tAFs = new TAFRepository(context));

        public ITurmaRepository Turmas => turmas ?? (turmas = new TurmaRepository(context));

        public IProfissaoRepository Profissoes => profissoes ?? (profissoes = new ProfissaoRepository(context));

        public IConfiguracaoRepository Configuracoes => configuracoes ?? (configuracoes = new ConfiguracaoRepository(context));

        public IUsuarioRepository Usuarios => usuarios ?? (usuarios = new UsuarioRepository(context));

        public IServicoRepository Servicos => servicos ?? (servicos = new ServicoRepository(context));

        public void SaveChanges()
        {
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entidade do tipo \"{0}\" no estado \"{1}\" tem os seguintes erros de validação:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Erro: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception("Operação não pode ser realizada! " + ex.Message);
            }
            finally
            {
                ResetAll();
            }

        }

        private void ResetAll()
        {
            atividadesExtras = null;
            contingentes = null;
            contingenteFotos = null;
            escolaridades = null;
            faltasOuAtrasos = null;
            horasExtras = null;
            justicasOuDisciplinas = null;
            patentes = null;
            religioes = null;
            tAFs = null;
            turmas = null;
            profissoes = null;
            usuarios = null;
            configuracoes = null;
            servicos = null;
            context = new USGTContext();
        }
    }
}

using Kondominium.Domain.CommandsModels.Bloco;
using Kondominium.Domain.CommandsModels.Condominio;
using Kondominium.Domain.CommandsServices;
using Kondominium.RepositoryBase.Context;
using Kondominium.RepositoryBase.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kondominium.Test
{
    [TestClass]
    public class UnitTest1
    {
        private KondominiumContext context = null;
        private CondominioSaveService condominioService = null;
        private BlocoSaveService blocoService = null;

        public UnitTest1()
        {
            condominioService = new CondominioSaveService(new CondominioRepository(new KondominiumContext()));
            blocoService = new BlocoSaveService(new BlocoRepository(new KondominiumContext()));
        }

        [TestMethod]
        public void CadastrarCondominium()
        {
            CondominioSaveCommand salvarCommand = new CondominioSaveCommand()
            {
                CEP = "590000",
                Cidade = 1,
                Estado = 2,
                Complemento = "ap 101",
                Nome = "Meridien",
                Rua = "Teste"
            };

            condominioService.Save(salvarCommand);


        }


        [TestMethod]
        public void CadastrarBloco()
        {
            var salvarCommand = new BlocoSalvarCommnad("Torre Oeste", 1);

            blocoService.Save(salvarCommand);
        }
    }
}

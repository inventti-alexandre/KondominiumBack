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

        public UnitTest1()
        {
            context = new KondominiumContext();
            condominioService = new CondominioSaveService(new CondominioRepository(context));
        }

        [TestMethod]
        public void TestMethod1()
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
    }
}

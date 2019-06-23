using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebTDD.Negocio;

namespace ProjetoTeste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestarSomaEntreDoisNumeros()
        {
            var calculadora = new Calculadora();
            Assert.IsTrue(calculadora.Somar(2, 2) == 4);
        }

        [TestMethod]
        public void TestarMultiplicacaoEntreDoisNumeros()
        {
            var calculadora = new Calculadora();
            Assert.IsTrue(calculadora.Multiplicar(4, 4) == 16);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wheel.Core.Entities;

namespace Wheel.Core
{
    [TestClass]
    public partial class EnumeracionUT
    {
        [TestMethod]
        public void Equals_CasoFeliz()
        {
            Assert.IsTrue(Estado.Activado.Equals(Estado.Activado));
        }
        
        [TestMethod]
        public void Equals_CasoObjetoDistintoConMismoCodigo()
        {
            Assert.IsTrue(Estado.Activado.Equals(Estado.ActivadoDuplicado));
        }

        [TestMethod]
        public void Equals_CasoDesigualdad()
        {
            Assert.IsFalse(Estado.Activado.Equals(Estado.Bloqueado));
        }

        [TestMethod]
        public void Equals_CasoNulo()
        {
            Assert.IsFalse(Estado.Activado.Equals(null));
        }
    }
}
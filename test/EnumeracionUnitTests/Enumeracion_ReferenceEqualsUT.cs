using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wheel.Core.Entities;

namespace Wheel.Core
{
    public partial class EnumeracionUT
    {
        [TestMethod]
        public void CasoFeliz()
        {
            Assert.IsTrue(ReferenceEquals(Estado.Activado, Estado.Activado));
        }

        [TestMethod]
        public void CasoObjetoDistintoConMismoCodigo()
        {
            Assert.IsFalse(ReferenceEquals(Estado.Activado, Estado.ActivadoDuplicado));
        }

        [TestMethod]
        public void CasoDesigualdad()
        {
            Assert.IsFalse(ReferenceEquals(Estado.Activado, Estado.Bloqueado));
        }
        
        [TestMethod]
        public void CasoNulo()
        {
            Assert.IsFalse(ReferenceEquals(null, Estado.Activado.Equals(null)));
        }
    }
}
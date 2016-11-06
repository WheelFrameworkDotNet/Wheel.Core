using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wheel.Core.Entities;

namespace Wheel.Core
{
    public partial class EnumeracionUT2
    {
        [TestMethod]
        public void CasoFeliz()
        {
            Assert.IsTrue(Estado.Nulo.Equals(Estado.Nulo), "{ param1: Estado.Nulo, param2: Estado.Nulo }");
            Assert.IsTrue(Estado.Activado.Equals(Estado.ActivadoDuplicado), "{ param1: Estado.Activado, param2: Estado.ActivadoDuplicado }");
        }
        
        [TestMethod]
        public void ObjetosIguales_1_1_2()
        {
            Assert.IsTrue(Estado.Activado.Equals(Estado.Activado), "{ param1: Estado.Activado, param2: Estado.Activado }");
        }

        [TestMethod]
        public void CasoDesigualdad()
        {
            Assert.IsFalse(Estado.Bloqueado.Equals(Estado.Activado), "{ param1: Estado.Bloqueado, param2: Estado.Activado }");
            Assert.IsFalse(Estado.Activado.Equals(Estado.Bloqueado), "{ param1: Estado.Activado, param2: Estado.Bloqueado }");
            Assert.IsFalse(Estado.Nulo.Equals(Estado.Activado), "{ param1: Estado.Nulo, param2: Estado.Activado }");
            Assert.IsFalse(Estado.Activado.Equals(Estado.Nulo), "{ param1: Estado.Activado, param2: Estado.Nulo }");
        }

        [TestMethod]
        public void CasoNulo()
        {
            Assert.IsFalse(Estado.Activado.Equals(null));
        }
    }
}
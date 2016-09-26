
namespace Wheel.Core.Entities
{
    public class Estado : Enumeracion<string, Estado>
    {
        protected Estado(string codigo) : base(codigo) { }

        public static readonly Estado Activado = new Estado("ACT");
        public static readonly Estado ActivadoDuplicado = new Estado("ACT");
        public static readonly Estado Bloqueado = new Estado("BLQ");
        public static readonly Estado Nulo = new Estado(null);
    }
}

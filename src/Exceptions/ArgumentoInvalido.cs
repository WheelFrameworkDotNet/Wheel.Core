
/// <summary>
/// Espacio de nombres de las excepciones comunes de Wheel Framework.
/// </summary>
/// <remarks>
///     <para>
///         <h2 class="groupheader">Registro de versiones</h2>
///         <ul>
///             <li>1.0.0</li>
///             <table>
///                 <tr style="font-weight: bold;">
///                     <td>Autor</td>
///                     <td>Fecha</td>
///                     <td>Descripción</td>
///                 </tr>
///                 <tr>
///                     <td>Marcos Abraham Hernández Bravo.</td>
///                     <td>04/09/2016</td>
///                     <td>Versión Inicial.</td>
///                 </tr>
///             </table>
///         </ul>
///     </para>
/// </remarks>
namespace Wheel.Core.Exceptions
{
    /// <summary>
    /// Enumeración que contiene las descripciones de los argumentos nulos. Pasarlos como argumento a <see cref="System.ArgumentException"/> como mensaje.
    /// </summary>
    /// <example>
    ///     <code>
    ///         using System;
    ///         using Wheel.Core.Exceptions;
    ///         
    ///         public class Program
    ///         {
    ///             public static void Main(string[] args)
    ///             {
    ///                 if(args[0] == "")
    ///                 {
    ///                     throw new ArgumentException(ArgumentoInvalido.VACIO.Codigo, "args[0]");
    ///                 }
    ///             }
    ///         }
    ///     </code>
    /// </example>
    /// <remarks>
    ///     <para>
    ///         <h2 class="groupheader">Registro de versiones</h2>
    ///         <ul>
    ///             <li>1.0.0</li>
    ///             <table>
    ///                 <tr style="font-weight: bold;">
    ///                     <td>Autor</td>
    ///                     <td>Fecha</td>
    ///                     <td>Descripción</td>
    ///                 </tr>
    ///                 <tr>
    ///                     <td>Marcos Abraham Hernández Bravo.</td>
    ///                     <td>04/09/2016</td>
    ///                     <td>Versión Inicial.</td>
    ///                 </tr>
    ///             </table>
    ///         </ul>
    ///     </para>
    /// </remarks>
    public sealed class ArgumentoInvalido : Enumeracion<string, ArgumentoInvalido>
    {
        /// <summary>
        /// Permite obtener la descripción del valor.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>04/09/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        public string Descripcion { get; private set; }

        /// <summary>
        /// Constructor que inicializa la enumeración.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>04/09/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        /// <param name="codigo">Código del valor.</param>
        /// <param name="descripcion">Descripción del valor.</param>
        private ArgumentoInvalido(string codigo, string descripcion) : base(codigo)
        {
            Descripcion = descripcion;
        }

        /// <summary>
        /// Contiene el valor de un argumento nulo. Este campo es de sólo lectura.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>04/09/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        public static readonly ArgumentoInvalido NULO = new ArgumentoInvalido("Nulo", "¡El valor del parametro no puede ser nulo!");

        /// <summary>
        /// Contiene el valor de un argumento vacio. Este campo es de sólo lectura.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>04/09/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        public static readonly ArgumentoInvalido VACIO = new ArgumentoInvalido("Vacio", "¡El valor del parametro no puede ser vacio!");

        /// <summary>
        /// Contiene el valor de un argumento nulo o vacio. Este campo es de sólo lectura.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>04/09/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        public static readonly ArgumentoInvalido NULO_VACIO = new ArgumentoInvalido("NuloVacio", "¡El valor del parametro no puede ser nulo ni vacio!");

        /// <summary>
        /// Sobreescritura del método <see cref="Enumeracion{TipoCodigo, TipoDerivado}.ToString"/> que devuelve la descripción del valor.
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <h2 class="groupheader">Registro de versiones</h2>
        ///         <ul>
        ///             <li>1.0.0</li>
        ///             <table>
        ///                 <tr style="font-weight: bold;">
        ///                     <td>Autor</td>
        ///                     <td>Fecha</td>
        ///                     <td>Descripción</td>
        ///                 </tr>
        ///                 <tr>
        ///                     <td>Marcos Abraham Hernández Bravo.</td>
        ///                     <td>04/09/2016</td>
        ///                     <td>Versión Inicial.</td>
        ///                 </tr>
        ///             </table>
        ///         </ul>
        ///     </para>
        /// </remarks>
        /// <returns>Devuelve la descripción del valor.</returns>
        public override string ToString()
        {
            return Descripcion;
        }
    }
}

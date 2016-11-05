using System;

/// <summary>
/// Espacio de nombres que contiene los atributos o annotations aplicables a todos los objetos.
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
namespace Wheel.Core.CustomAttributes.Object
{
    /// <summary>
    /// Especifica que un objeto no tiene subpropiedades que se puedan editar.Esta clase no se puede heredar.
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
    [AttributeUsage(AttributeTargets.All)]
    public sealed class Inmutable : Attribute
    {
        /// <summary>
        /// Permite obtener o establecer un valor que indica si es o no inmutable.
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
        public bool EsInmutable { get; set; }

        /// <summary>
        /// Constructor que establece el valor de <see cref="EsInmutable"/>.
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
        /// <param name="esInmutable">Valor que indica si es o no inmutable.</param>
        public Inmutable(bool esInmutable)
        {
            EsInmutable = esInmutable;
        }
    }
}

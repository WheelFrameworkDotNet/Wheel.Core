using System;

/// <summary>
/// Espacio de nombres que contiene los atributos o annotations para manejo el desarrollo.
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
namespace Wheel.Core.CustomAttributes.Development
{
    /// <summary>
    /// Especifica que un objeto es un Dummy o valor de prueba y debe cambiarse.
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
    public class Dummy : Attribute
    {
        /// <summary>
        /// Obtiene o establece un valor que indica si el Dummy debe ser reemplazado.
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
        public bool Cambiar { get; set; }

        /// <summary>
        /// Constructor que inicializa las propiedades del atributo.
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
        /// <param name="cambiar">Valor que indica si se debe cambiar el valor o será el definitivo.</param>
        public Dummy(bool cambiar = true)
        {
            Cambiar = cambiar;
        }
    }
}

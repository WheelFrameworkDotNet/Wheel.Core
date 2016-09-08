using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

/// <summary>
/// Espacio de nombres del núcleo de Wheel Framework.
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
namespace Wheel.Core
{
    /// <summary>
    /// Concepto base de una enumeración, similar al tipo <see cref="System.Enum"/>, pero
    /// que permite que el codigo correspondiente a cada valor sea cualquier tipo, no sólo <see cref="int"/>.
    /// Su principal ventaja es que permite que una enumeración sea un objeto, por lo que cosas como la herencia,
    /// estan completamente permitidas.
    /// </summary>
    /// <example>
    ///     <code>
    ///         <![CDATA[
    ///             using System;
    ///             using Wheel.Core;
    ///             
    ///             public class Estado : Enumeracion<string, Estado>
    ///             {
    ///                 protected Estado(string codigo) : base(codigo) { }
    ///                 
    ///                 public static readonly Estado ACTIVADO = new Estado("ACT");
    ///                 public static readonly Estado BLOQUEADO = new Estado("BLQ");
    ///             }
    ///             
    ///             public class Program
    ///             {
    ///                 public static void Main(string[] args)
    ///                 {
    ///                     Estado estadoUsuario = null;
    ///                     estadoUsuario = Estado.ACTIVADO;
    ///                 }
    ///             }
    ///         ]]>
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
    /// <typeparam name="TipoCodigo">Tipo de dato del código de la enumeración.</typeparam>
    /// <typeparam name="TipoDerivado">Tipo de la clase que implementa el concepto.</typeparam>
    public abstract class Enumeracion<TipoCodigo, TipoDerivado> where TipoDerivado : Enumeracion<TipoCodigo, TipoDerivado>
    {
        /// <summary>
        /// Permite obtener el valor del código de la enumeración.
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
        public TipoCodigo Codigo { get; protected set; }

        /// <summary>
        /// Permite obtener los posibles valores de la enumeración actual.
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
        public static IList<TipoDerivado> Valores { get; private set; }

        /// <summary>
        /// Constructor protected que inicializa la instancia, cargando su código.
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
        /// <exception cref="System.ArgumentException">Se produce si <see cref="TipoCodigo"/> es distinto al tipo de la clase actual. Error de programación.</exception>
        /// <param name="codigo"></param>
        protected Enumeracion(TipoCodigo codigo)
        {
            if(GetType() != typeof(TipoDerivado))
            {
                throw new ArgumentException(string.Format("El tipo '{0}' debe ser '{1}'", typeof(TipoDerivado).Name, GetType().Name), "TipoDerivado");
            }

            if (Valores == null)
            {
                Valores = new List<TipoDerivado>();
            }

            Codigo = codigo;
            Valores.Add(this as TipoDerivado);
        }

        /// <summary>
        /// 
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
        /// <exception cref="System.ArgumentException">Se produce si <see cref="TipoCodigo"/> es distinto al tipo de la clase actual. Error de programación.</exception>
        /// <param name="enumeracion"></param>
        /// <returns></returns>
        public virtual bool Equals(Enumeracion<TipoCodigo, TipoDerivado> enumeracion)
        {
            if (GetType() != typeof(TipoDerivado))
            {
                throw new ArgumentException(string.Format("El tipo '{0}' debe ser '{1}'", typeof(TipoDerivado).Name, GetType().Name), "TipoDerivado");
            }

            return enumeracion.Codigo.Equals(Codigo);
        }

        /// <summary>
        /// Devuelve una instancia de <see cref=">System.String"/> que representa la enumeración actual.
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
        /// <exception cref="System.ArgumentException">Se produce si <see cref="TipoCodigo"/> es distinto al tipo de la clase actual. Error de programación.</exception>
        /// <returns>Devuelve un <see cref=">System.String"/>.</returns>
        public override string ToString()
        {
            if (GetType() != typeof(TipoDerivado))
            {
                throw new ArgumentException(string.Format("El tipo '{0}' debe ser '{1}'", typeof(TipoDerivado).Name, GetType().Name), "TipoDerivado");
            }

            if (Codigo == null) return null;
            return Codigo.ToString();
        }

        /// <summary>
        /// Devuelve una <see cref="Enumeracion{TipoCodigo, TipoDerivado}"/> de encontrar un valor con el mismo código.
        /// Si no encuentra un valor para ese código, retorna <value>null</value>.
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
        /// <exception cref="System.ArgumentException">Se produce si <see cref="TipoCodigo"/> es distinto al tipo de la clase actual. Error de programación.</exception>
        /// <param name="codigo">Código de la enumeración.</param>
        /// <returns>Devuelve una <see cref="Enumeracion{TipoCodigo, TipoDerivado}"/>.</returns>
        public static Enumeracion<TipoCodigo, TipoDerivado> ToEnumeracionGenerica(TipoCodigo codigo)
        {
            Type tipoActual = MethodBase.GetCurrentMethod().DeclaringType;

            if (tipoActual != typeof(TipoDerivado))
            {
                throw new ArgumentException(string.Format("El tipo '{0}' debe ser '{1}'", typeof(TipoDerivado).Name, tipoActual.Name), "TipoDerivado");
            }

            return Valores.FirstOrDefault(c => c.Codigo.Equals(codigo));
        }

        /// <summary>
        /// Devuelve una <see cref="TipoDerivado"/> de encontrar un valor con el mismo código.
        /// Si no encuentra un valor para ese código, retorna <value>null</value>.
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
        /// <exception cref="System.ArgumentException">Se produce si <see cref="TipoCodigo"/> es distinto al tipo de la clase actual. Error de programación.</exception>
        /// <param name="codigo">Código de la enumeración.</param>
        /// <returns>Devuelve un <see cref="TipoDerivado"/>.</returns>
        public static TipoDerivado ToEnumeracion(TipoCodigo codigo)
        {
            Type tipoActual = MethodBase.GetCurrentMethod().DeclaringType;

            if (tipoActual != typeof(TipoDerivado))
            {
                throw new ArgumentException(string.Format("El tipo '{0}' debe ser '{1}'", typeof(TipoDerivado).Name, tipoActual.Name), "TipoDerivado");
            }

            return Valores.FirstOrDefault(c => c.Codigo.Equals(codigo));
        }
    }
}

using ENTIDADES.EPostgrado;
using HERRAMIENTAS;
using SWADUnivalleInfo.SWADPostgrado;

namespace SWLNUnivalleInfo
{
	/// <summary>
	/// Clase que proporciona funcionalidad para operaciones relacionadas con los postgrados.
	/// </summary>
	public class LNUnivalleInfo
	{
		#region Atributos

		/// <summary>
		/// Instancia de la clase SWADPostgrado para realizar operaciones relacionadas con los postgrados.
		/// </summary>
		public SWADPostgrado swadPostgrado;

		#endregion

		#region Constructor

		/// <summary>
		/// Inicializa una nueva instancia de la clase LNUnivalleInfo.
		/// </summary>
		public LNUnivalleInfo()
		{
			swadPostgrado = new SWADPostgrado();
		}

		#endregion

		#region Metodos Publicos

		/// <summary>
		/// Agrega un postgrado utilizando los datos proporcionados en el objeto EIPostgrado.
		/// </summary>
		/// <param name="eIPostgrado">Los datos del postgrado que se va a insertar.</param>
		/// <returns>Un EResponse que indica si la operación fue exitosa y contiene un mensaje y datos adicionales.</returns>
		public async Task<EResponse<string>> Adicionar_Postgrado_EIPostgrado(EIPostgrado eIPostgrado)
		{
			EResponse<string> response = await swadPostgrado.Adicionar_Postgrado_EIPostgrado(eIPostgrado);
			return response;
		}

		/// <summary>
		/// Obtiene una lista de postgrados.
		/// </summary>
		/// <returns>Un EResponse que indica si la operación fue exitosa y contiene una lista de postgrados.</returns>
		public async Task<EResponse<List<EIPostgrado>>> Obtener_Postgrados()
		{
			EResponse<List<EIPostgrado>> response = await swadPostgrado.Obtener_Postgrados();
			return response;
		}

		/// <summary>
		/// Actualiza un postgrado utilizando los datos proporcionados en el objeto EIPostgrado.
		/// </summary>
		/// <param name="id">El identificador único del postgrado que se va a actualizar.</param>
		/// <param name="eIPostgrado">Los datos del postgrado que se van a actualizar.</param>
		/// <returns>Un EResponse que indica si la operación fue exitosa y contiene un mensaje y datos adicionales.</returns>
		public async Task<EResponse<bool>> Actualizar_Postgrado_EIPostgrado(string id, EIPostgrado eIPostgrado)
		{
			EResponse<bool> response = await swadPostgrado.Actualizar_Postgrado_EIPostgrado(id, eIPostgrado);
			return response;
		}

		/// <summary>
		/// Elimina un postgrado utilizando su identificador único.
		/// </summary>
		/// <param name="postgradoId">El identificador único del postgrado que se va a eliminar.</param>
		/// <returns>Un EResponse que indica si la operación fue exitosa y contiene un mensaje y datos adicionales.</returns>
		public async Task<EResponse<bool>> Eliminar_Postgrado_PostgradoId(string postgradoId)
		{
			EResponse<bool> response = await swadPostgrado.Eliminar_Postgrado_PostgradoId(postgradoId);
			return response;
		}
		#endregion
	}
}

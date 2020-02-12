using System;
using Newtonsoft.Json;

namespace PatronAdapter
{
    /// <summary>
    /// Servicio de Tfs.
    /// </summary>
    public class TfsService
    {
        /// <summary>
        /// Obtiene líneas de código reales.
        /// </summary>
        /// <param name="id">Id de las líneas de código.</param>
        /// <returns>Líneas de código reales.</returns>
        public string GetRealLineCode(string id)
        {
            Random rnd = new Random();
            int lines = rnd.Next(1, 50);

            var result = new { Id = id, TotalLines = lines };
            
            return JsonConvert.SerializeObject(result);
        }
    }
}

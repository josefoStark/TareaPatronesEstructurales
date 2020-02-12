using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PatronAdapter
{
    /// <summary>
    /// Adaptador.
    /// </summary>
    public class Adapter : IClient
    {
        /// <summary>
        /// Servicio de TFS.
        /// </summary>
        private readonly TfsService _tfsService;

        /// <summary>
        /// Constructor.
        /// </summary>
        public Adapter()
        {
            _tfsService = new TfsService();
        }

        /// <summary>
        /// Líneas de código por requerimiento.
        /// </summary>
        /// <param name="id">Id del requerimiento</param>
        /// <returns>Id del requerimiento.</returns>
        public int LineCodeByReq(int id)
        {
            string query = _tfsService.GetRealLineCode(JsonConvert.SerializeObject(id));

            Console.WriteLine("Json:");
            Console.WriteLine(query);

            dynamic data = JObject.Parse(query);

            return Convert.ToInt32(data.TotalLines);
        }
    }
}

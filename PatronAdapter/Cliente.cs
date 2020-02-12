using System;

namespace PatronAdapter
{
    /// <summary>
    /// Clase para llamar a los métodos principales.
    /// </summary>
    public class Cliente
    {
        /// <summary>
        /// Aplicación principal.
        /// </summary>
        public void Main()
        {
            Console.WriteLine("\n*************** ADAPTER ***************");
            Console.WriteLine("\nIngrese id de la solicitud.");
            int id = Convert.ToInt32(Console.ReadLine());

            Requirement req = new Requirement
            {
                Id = id,
                EstimatedLineCode = 20,
                Name = "SSo"
            };

            Console.WriteLine("\nConsultando lineas reales.");

            Adapter adapter = new Adapter();
            req.RealLineCode = adapter.LineCodeByReq(req.Id);

            DisplayInfo(req);
        }

        /// <summary>
        /// Despliega la información.
        /// </summary>
        /// <param name="requirement">Requerimiento.</param>
        private void DisplayInfo(Requirement requirement)
        {
            Console.WriteLine("\nRequerimiento..");
            Console.WriteLine("Id: " + requirement.Id);
            Console.WriteLine("Nombre: " + requirement.Name);
            Console.WriteLine("Lineas estimadas: " + requirement.EstimatedLineCode);
            Console.WriteLine("Lineas reales: " + requirement.RealLineCode);
        }
    }
}

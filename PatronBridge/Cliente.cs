using System;
using PatronBridge.PatronFactory;

namespace PatronBridge
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
            Console.WriteLine("\n*************** BRIDGE ***************");
            Console.WriteLine("Ingrese nombre del producto");
            string producto = Console.ReadLine()?.ToUpperInvariant();

            Console.WriteLine("\nSeleccione la paquetería de su preferencia." +
                              "\n1-DHL \n2-Fedex \n3-Estafeta");

            int option = Convert.ToInt32(Console.ReadLine());

            ICompanyFactory companyFactory = SelectCompanyFactory(option);

            if (companyFactory == null) return;

            ICompany company = companyFactory.CrearInstancia();
            Menu menu = new Menu(company);
            ITransport transport = menu.SelectTransport();
            ParcelService parcelService = new ParcelService(transport);

            parcelService.SendProduct(producto);

        }

        /// <summary>
        /// Selecciona una compañía.
        /// </summary>
        /// <param name="companyId">Id de la compañía.</param>
        /// <returns>Compañía</returns>
        private ICompanyFactory SelectCompanyFactory(int option)
        {
            switch (option)
            {
                case 1:
                    return new DhlFactory();
                case 2:
                    return new FedexFactory();
                case 3:
                    return new EstafetaFactory();
                default:
                    return null;
            }
        }
    }
}

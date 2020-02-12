using System;

namespace PatronDecorador
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
            Console.WriteLine("\n*************** DECORATOR ***************");
            Console.WriteLine("Ingrese la siguiente información: ");

            AccountData data = BuildData();
            IAccountOperation account = new AccountOperation();
            SaveHistoricDecorator decorator1 = new SaveHistoricDecorator(account);
            NotificationDecorator decorator2 = new NotificationDecorator(decorator1);

            decorator2.SaveData(data);
        }

        /// <summary>
        /// Construye la información.
        /// </summary>
        /// <returns>Información de la cuenta.</returns>
        private AccountData BuildData()
        {
            Console.WriteLine("Id CxP: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Unidad administrativa:");
            string unidad = Console.ReadLine();

            Console.WriteLine("Importe: ");
            double importe = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("¿La cuenta esta activa? Y/N");
            ConsoleKeyInfo isActiveKey = Console.ReadKey();

            Console.WriteLine("\n¿La cuenta es tipo gasto? Y/N");
            ConsoleKeyInfo isSpendKey = Console.ReadKey();

            IService service = new ConsoleService();

            AccountData data = new AccountData(service)
            {
                iIdCuentaXPagar = id,
                cIdUnidadAdministrativa = unidad,
                dImporte = importe,
                lActivo = isActiveKey.Key.Equals(ConsoleKey.Y),
                lNaturaleza = isSpendKey.Key != ConsoleKey.Y
            };

            return data;
        }
    }
}

namespace GuidoComba_DesafioCoderHouse
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            

            Producto producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "PrimerProducto";
            producto1.Costo = 100;
            producto1.PrecioVenta = 200;
            producto1.Stock = 50;
            producto1.IdUsuario = 001;

        }

        

    }

    
}
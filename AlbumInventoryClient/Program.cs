using Grpc.Net.Client;
using Grpc.Core;
using AlbumAPI;

namespace AlbumInventoryClient
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
            Application.Run(new Form_Album_Inventory());
        }
    }
}
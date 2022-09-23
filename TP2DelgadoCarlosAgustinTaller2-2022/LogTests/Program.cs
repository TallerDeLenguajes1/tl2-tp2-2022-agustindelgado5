using System;
using NLog;
namespace LogTests
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();//inicializo el objeto logger

        static void Main(string[] args)
        {
            try
            {
                logger.Info("Probando");
                Console.ReadKey();
                int num1 = 1;
                int num2 = 0;
                int division = num1 / num2;
            }
            catch (Exception ex)
            {
                //nivel de registro
                logger.Trace("Ej de mensaje de trace ");//0
                logger.Debug("Ej de mensaje debug ");//1
                logger.Info("Ej de mensaje de información");//2
                logger.Warn("Ej de mensaje de Warm");//3
                logger.Error(ex, "Ej de mensaje de error");//4
                logger.Fatal("Ej de mensaje de error Fatal");//5
            }
        }
    }
}

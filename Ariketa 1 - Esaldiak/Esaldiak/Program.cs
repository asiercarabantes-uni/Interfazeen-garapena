namespace Esaldiak
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
        }
    }


    public class Esaldia
    {
        public String esaldiaBatuta;
        private String Hitza { get; set; }
        private String EsaldiaBatuta 
        {
            get { return esaldiaBatuta; }
        }
        

        public void SetEsaldiaBatuta(String hitza)
        {
            esaldiaBatuta = esaldiaBatuta + " " + hitza;
        }
    }
}
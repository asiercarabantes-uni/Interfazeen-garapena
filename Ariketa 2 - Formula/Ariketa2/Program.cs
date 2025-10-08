namespace Ariketa2
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

    public class Eragiketa
    {
        public float A { get; set; }
        public float B { get; set; }
        public float C { get; set; }
        public float D { get; set; }
        
    
        public String SetFormula()
        {
            return $"({A} + ({B}x2) + ({C}x3) + ({D}x4) / 4 = {EmaitzaKalkulatuta()}";
        }
        
        public float EmaitzaKalkulatuta()
        {
            return (A + 2*B + 3*C + 4*D)/4;
        }
    }
}
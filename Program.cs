using _420DA3_07451_Projet_Initial.Business;
using _420DA3_07451_Projet_Initial.Presentation;

namespace _420DA3_07451_Projet_Initial;

internal static class Program {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    public static void Main(string[] args) {
        if (args.Contains("-profTests")) {
            Application.Run(new TestCours());
        } else {
            new ExampleApp().Start();
        }
    }
}
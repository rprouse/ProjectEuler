using System.Windows.Forms;

namespace Project.Euler
{
   internal static class Program
   {
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault( false );
         Application.Run( new ProblemRunner() );
      }
   }
}

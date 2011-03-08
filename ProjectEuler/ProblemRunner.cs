using System.Diagnostics;
using System.Windows.Forms;
using Project.Euler.Problems;

namespace Project.Euler
{
   public partial class ProblemRunner : Form
   {
      public ProblemRunner()
      {
         InitializeComponent();
      }

      private IProblem Problem
      {
         get { return _problems.SelectedItem as IProblem; }
      }

      private void OnLoad( object sender, System.EventArgs e )
      {
         foreach ( IProblem problem in ProjectFactory.Problems )
         {
            _problems.Items.Add( problem );
         }
      }

      private void OnSelectedProblemChanged( object sender, System.EventArgs e )
      {
         _solve.Enabled = _problems.SelectedItem != null;
         IProblem problem = Problem;
         if ( problem == null )
         {
            _problem.Text = string.Empty;
         }
         else
         {
            _problem.Text = problem.Description;
         }
      }

      private void OnSolve( object sender, System.EventArgs e )
      {
         _answer.Text = string.Empty;
         _elapsed.Text = string.Empty;
         IProblem problem = Problem;
         if ( problem == null )
         {
            MessageBox.Show(this, "The selected problem is not an IProblem", "Euler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }
         Enabled = false;
         _worker.RunWorkerAsync( problem );
      }

      private void OnDoWork( object sender, System.ComponentModel.DoWorkEventArgs e )
      {
         IProblem problem = e.Argument as IProblem;
         if ( problem == null )
         {
            return;
         }
         Stopwatch stopwatch = new Stopwatch();
         stopwatch.Start();
         long answer = problem.Solve();
         stopwatch.Stop();
         e.Result = new ProblemAnswer( answer, stopwatch.Elapsed );
      }

      private void OnRunWorkerCompleted( object sender, System.ComponentModel.RunWorkerCompletedEventArgs e )
      {
         ProblemAnswer answer = e.Result as ProblemAnswer;
         if ( answer != null )
         {
            _answer.Text = answer.Answer.ToString();
            _elapsed.Text = answer.Elapsed.TotalMilliseconds + " ms";
         }
         Enabled = true;
      }

      private void OnExit( object sender, System.EventArgs e )
      {
         Close();
      }
   }
}

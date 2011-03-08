namespace Project.Euler
{
   partial class ProblemRunner
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose( bool disposing )
      {
         if ( disposing && ( components != null ) )
         {
            components.Dispose();
         }
         base.Dispose( disposing );
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         System.Windows.Forms.PictureBox pictureBox1;
         System.Windows.Forms.Label label1;
         System.Windows.Forms.Label label2;
         System.Windows.Forms.Label label3;
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( ProblemRunner ) );
         this._problems = new System.Windows.Forms.ListBox();
         this._solve = new System.Windows.Forms.Button();
         this._answer = new System.Windows.Forms.TextBox();
         this._worker = new System.ComponentModel.BackgroundWorker();
         this._elapsed = new System.Windows.Forms.TextBox();
         this._exit = new System.Windows.Forms.Button();
         this._problem = new System.Windows.Forms.TextBox();
         pictureBox1 = new System.Windows.Forms.PictureBox();
         label1 = new System.Windows.Forms.Label();
         label2 = new System.Windows.Forms.Label();
         label3 = new System.Windows.Forms.Label();
         ( ( System.ComponentModel.ISupportInitialize )( pictureBox1 ) ).BeginInit();
         this.SuspendLayout();
         // 
         // pictureBox1
         // 
         pictureBox1.Image = global::Project.Euler.Properties.Resources.euler;
         pictureBox1.Location = new System.Drawing.Point( 12, 12 );
         pictureBox1.Name = "pictureBox1";
         pictureBox1.Size = new System.Drawing.Size( 203, 71 );
         pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
         pictureBox1.TabIndex = 0;
         pictureBox1.TabStop = false;
         // 
         // label1
         // 
         label1.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
         label1.AutoSize = true;
         label1.Location = new System.Drawing.Point( 12, 188 );
         label1.Name = "label1";
         label1.Size = new System.Drawing.Size( 42, 13 );
         label1.TabIndex = 4;
         label1.Text = "Answer";
         // 
         // label2
         // 
         label2.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
         label2.AutoSize = true;
         label2.Location = new System.Drawing.Point( 12, 239 );
         label2.Name = "label2";
         label2.Size = new System.Drawing.Size( 71, 13 );
         label2.TabIndex = 6;
         label2.Text = "Elapsed Time";
         // 
         // label3
         // 
         label3.AutoSize = true;
         label3.Location = new System.Drawing.Point( 12, 95 );
         label3.Name = "label3";
         label3.Size = new System.Drawing.Size( 45, 13 );
         label3.TabIndex = 9;
         label3.Text = "Problem";
         // 
         // _problems
         // 
         this._problems.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                     | System.Windows.Forms.AnchorStyles.Left )
                     | System.Windows.Forms.AnchorStyles.Right ) ) );
         this._problems.FormattingEnabled = true;
         this._problems.IntegralHeight = false;
         this._problems.Location = new System.Drawing.Point( 221, 12 );
         this._problems.Name = "_problems";
         this._problems.ScrollAlwaysVisible = true;
         this._problems.Size = new System.Drawing.Size( 185, 304 );
         this._problems.Sorted = true;
         this._problems.TabIndex = 1;
         this._problems.SelectedValueChanged += new System.EventHandler( this.OnSelectedProblemChanged );
         // 
         // _solve
         // 
         this._solve.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
         this._solve.Enabled = false;
         this._solve.ForeColor = System.Drawing.SystemColors.ControlText;
         this._solve.Location = new System.Drawing.Point( 12, 294 );
         this._solve.Name = "_solve";
         this._solve.Size = new System.Drawing.Size( 94, 23 );
         this._solve.TabIndex = 2;
         this._solve.Text = "Solve";
         this._solve.UseVisualStyleBackColor = true;
         this._solve.Click += new System.EventHandler( this.OnSolve );
         // 
         // _answer
         // 
         this._answer.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
         this._answer.Location = new System.Drawing.Point( 12, 207 );
         this._answer.Name = "_answer";
         this._answer.ReadOnly = true;
         this._answer.Size = new System.Drawing.Size( 203, 20 );
         this._answer.TabIndex = 3;
         // 
         // _worker
         // 
         this._worker.DoWork += new System.ComponentModel.DoWorkEventHandler( this.OnDoWork );
         this._worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler( this.OnRunWorkerCompleted );
         // 
         // _elapsed
         // 
         this._elapsed.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
         this._elapsed.Location = new System.Drawing.Point( 12, 258 );
         this._elapsed.Name = "_elapsed";
         this._elapsed.ReadOnly = true;
         this._elapsed.Size = new System.Drawing.Size( 203, 20 );
         this._elapsed.TabIndex = 5;
         // 
         // _exit
         // 
         this._exit.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left ) ) );
         this._exit.ForeColor = System.Drawing.SystemColors.ControlText;
         this._exit.Location = new System.Drawing.Point( 121, 294 );
         this._exit.Name = "_exit";
         this._exit.Size = new System.Drawing.Size( 94, 23 );
         this._exit.TabIndex = 7;
         this._exit.Text = "Exit";
         this._exit.UseVisualStyleBackColor = true;
         this._exit.Click += new System.EventHandler( this.OnExit );
         // 
         // _problem
         // 
         this._problem.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                     | System.Windows.Forms.AnchorStyles.Left ) ) );
         this._problem.Location = new System.Drawing.Point( 12, 114 );
         this._problem.Multiline = true;
         this._problem.Name = "_problem";
         this._problem.ReadOnly = true;
         this._problem.Size = new System.Drawing.Size( 203, 66 );
         this._problem.TabIndex = 8;
         // 
         // ProblemRunner
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size( 416, 327 );
         this.Controls.Add( label3 );
         this.Controls.Add( this._problem );
         this.Controls.Add( this._exit );
         this.Controls.Add( label2 );
         this.Controls.Add( this._elapsed );
         this.Controls.Add( label1 );
         this.Controls.Add( this._answer );
         this.Controls.Add( this._solve );
         this.Controls.Add( this._problems );
         this.Controls.Add( pictureBox1 );
         this.Icon = ( ( System.Drawing.Icon )( resources.GetObject( "$this.Icon" ) ) );
         this.MaximizeBox = false;
         this.MaximumSize = new System.Drawing.Size( 640, 794 );
         this.MinimumSize = new System.Drawing.Size( 375, 331 );
         this.Name = "ProblemRunner";
         this.Text = "Project Euler";
         this.Load += new System.EventHandler( this.OnLoad );
         ( ( System.ComponentModel.ISupportInitialize )( pictureBox1 ) ).EndInit();
         this.ResumeLayout( false );
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ListBox _problems;
      private System.Windows.Forms.Button _solve;
      private System.Windows.Forms.TextBox _answer;
      private System.ComponentModel.BackgroundWorker _worker;
      private System.Windows.Forms.TextBox _elapsed;
      private System.Windows.Forms.Button _exit;
      private System.Windows.Forms.TextBox _problem;
   }
}
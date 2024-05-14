namespace Attempt2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblScore = new Label();
            PbxTree = new Panel();
            PbxLumberJack = new PictureBox();
            PnlBranches = new Panel();
            ((System.ComponentModel.ISupportInitialize)PbxLumberJack).BeginInit();
            SuspendLayout();
            // 
            // LblScore
            // 
            LblScore.AutoSize = true;
            LblScore.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            LblScore.Location = new Point(10, 8);
            LblScore.Name = "LblScore";
            LblScore.Size = new Size(37, 45);
            LblScore.TabIndex = 0;
            LblScore.Text = "0";
            // 
            // PbxTree
            // 
            PbxTree.BackColor = Color.FromArgb(128, 64, 0);
            PbxTree.Location = new Point(300, 0);
            PbxTree.Name = "PbxTree";
            PbxTree.Size = new Size(100, 500);
            PbxTree.TabIndex = 1;
            // 
            // PbxLumberJack
            // 
            PbxLumberJack.Image = Properties.Resources.Lumberjack;
            PbxLumberJack.Location = new Point(185, 291);
            PbxLumberJack.Name = "PbxLumberJack";
            PbxLumberJack.Size = new Size(92, 123);
            PbxLumberJack.SizeMode = PictureBoxSizeMode.StretchImage;
            PbxLumberJack.TabIndex = 2;
            PbxLumberJack.TabStop = false;
            // 
            // PnlBranches
            // 
            PnlBranches.BackColor = SystemColors.Control;
            PnlBranches.Location = new Point(200, 0);
            PnlBranches.Name = "PnlBranches";
            PnlBranches.Size = new Size(300, 500);
            PnlBranches.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(PbxLumberJack);
            Controls.Add(PbxTree);
            Controls.Add(LblScore);
            Controls.Add(PnlBranches);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)PbxLumberJack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblScore;
        private Panel PbxTree;
        private PictureBox PbxLumberJack;
        private Panel PnlBranches;
    }
}

namespace MChSDocProcessing
{
    partial class cmd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LB
            // 
            this.LB.FormattingEnabled = true;
            this.LB.ItemHeight = 20;
            this.LB.Location = new System.Drawing.Point(23, 12);
            this.LB.Name = "LB";
            this.LB.Size = new System.Drawing.Size(533, 344);
            this.LB.TabIndex = 0;
            this.LB.SelectedIndexChanged += new System.EventHandler(this.LB_SelectedIndexChanged);
            // 
            // cmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 378);
            this.Controls.Add(this.LB);
            this.Name = "cmd";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.cmd_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LB;
    }
}
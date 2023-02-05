
namespace MChSDocProcessing
{
    partial class SODwork
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lab_hour = new System.Windows.Forms.Label();
            this.lab_min = new System.Windows.Forms.Label();
            this.lab_sec = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lab_txt_hour = new System.Windows.Forms.Label();
            this.lab_begin = new System.Windows.Forms.Label();
            this.lst_docstate = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lab_hour
            // 
            this.lab_hour.AutoSize = true;
            this.lab_hour.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lab_hour.Location = new System.Drawing.Point(12, 9);
            this.lab_hour.Name = "lab_hour";
            this.lab_hour.Size = new System.Drawing.Size(24, 23);
            this.lab_hour.TabIndex = 0;
            this.lab_hour.Text = "0";
            // 
            // lab_min
            // 
            this.lab_min.AutoSize = true;
            this.lab_min.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lab_min.Location = new System.Drawing.Point(78, 9);
            this.lab_min.Name = "lab_min";
            this.lab_min.Size = new System.Drawing.Size(24, 23);
            this.lab_min.TabIndex = 1;
            this.lab_min.Text = "0";
            // 
            // lab_sec
            // 
            this.lab_sec.AutoSize = true;
            this.lab_sec.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lab_sec.Location = new System.Drawing.Point(144, 9);
            this.lab_sec.Name = "lab_sec";
            this.lab_sec.Size = new System.Drawing.Size(24, 23);
            this.lab_sec.TabIndex = 2;
            this.lab_sec.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(115, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(49, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = ":";
            // 
            // lab_txt_hour
            // 
            this.lab_txt_hour.AutoSize = true;
            this.lab_txt_hour.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lab_txt_hour.Location = new System.Drawing.Point(12, 45);
            this.lab_txt_hour.Name = "lab_txt_hour";
            this.lab_txt_hour.Size = new System.Drawing.Size(264, 23);
            this.lab_txt_hour.TabIndex = 5;
            this.lab_txt_hour.Text = "Начало происшествия:";
            // 
            // lab_begin
            // 
            this.lab_begin.AutoSize = true;
            this.lab_begin.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lab_begin.Location = new System.Drawing.Point(12, 80);
            this.lab_begin.Name = "lab_begin";
            this.lab_begin.Size = new System.Drawing.Size(218, 23);
            this.lab_begin.TabIndex = 6;
            this.lab_begin.Text = "Начало отработки:";
            // 
            // lst_docstate
            // 
            this.lst_docstate.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lst_docstate.FormattingEnabled = true;
            this.lst_docstate.ItemHeight = 22;
            this.lst_docstate.Location = new System.Drawing.Point(12, 126);
            this.lst_docstate.Name = "lst_docstate";
            this.lst_docstate.Size = new System.Drawing.Size(485, 202);
            this.lst_docstate.TabIndex = 7;
            this.lst_docstate.SelectedIndexChanged += new System.EventHandler(this.lst_docstate_SelectedIndexChanged);
            // 
            // SODwork
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(509, 339);
            this.Controls.Add(this.lst_docstate);
            this.Controls.Add(this.lab_begin);
            this.Controls.Add(this.lab_txt_hour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lab_sec);
            this.Controls.Add(this.lab_min);
            this.Controls.Add(this.lab_hour);
            this.Name = "SODwork";
            this.Text = "Отработка";
            this.Load += new System.EventHandler(this.SODwork_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lab_hour;
        private System.Windows.Forms.Label lab_min;
        private System.Windows.Forms.Label lab_sec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lab_txt_hour;
        private System.Windows.Forms.Label lab_begin;
        private System.Windows.Forms.ListBox lst_docstate;
    }
}
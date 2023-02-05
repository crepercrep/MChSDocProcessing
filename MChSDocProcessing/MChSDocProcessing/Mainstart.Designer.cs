
namespace MChSDocProcessing
{
    partial class Mainstart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainstart));
            this.btn_SOD = new System.Windows.Forms.Button();
            this.btn_ARM = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.Mainstart_icon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // btn_SOD
            // 
            this.btn_SOD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_SOD.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_SOD.Location = new System.Drawing.Point(25, 23);
            this.btn_SOD.Name = "btn_SOD";
            this.btn_SOD.Size = new System.Drawing.Size(182, 88);
            this.btn_SOD.TabIndex = 0;
            this.btn_SOD.Text = "Войти как СОД";
            this.btn_SOD.UseVisualStyleBackColor = false;
            this.btn_SOD.Click += new System.EventHandler(this.btn_SOD_Click);
            // 
            // btn_ARM
            // 
            this.btn_ARM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ARM.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ARM.Location = new System.Drawing.Point(245, 23);
            this.btn_ARM.Name = "btn_ARM";
            this.btn_ARM.Size = new System.Drawing.Size(182, 88);
            this.btn_ARM.TabIndex = 1;
            this.btn_ARM.Text = "Войти как АРМ";
            this.btn_ARM.UseVisualStyleBackColor = false;
            this.btn_ARM.Click += new System.EventHandler(this.btn_ARM_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_exit.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_exit.Location = new System.Drawing.Point(138, 130);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(182, 88);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Выход";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Mainstart_icon
            // 
            this.Mainstart_icon.Icon = ((System.Drawing.Icon)(resources.GetObject("Mainstart_icon.Icon")));
            this.Mainstart_icon.Text = "Войти как";
            this.Mainstart_icon.Visible = true;
            this.Mainstart_icon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Mainstart_icon_MouseDoubleClick);
            // 
            // Mainstart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 238);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_ARM);
            this.Controls.Add(this.btn_SOD);
            this.Name = "Mainstart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mainstart_FormClosing);
            this.Load += new System.EventHandler(this.Mainstart_Load);
            this.Resize += new System.EventHandler(this.Mainstart_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_SOD;
        private System.Windows.Forms.Button btn_ARM;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.NotifyIcon Mainstart_icon;
    }
}
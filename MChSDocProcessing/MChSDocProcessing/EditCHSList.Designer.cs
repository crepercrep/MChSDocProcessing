
namespace MChSDocProcessing
{
    partial class IncinentsList
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
            this.btn_addchs = new System.Windows.Forms.Button();
            this.btn_delchs = new System.Windows.Forms.Button();
            this.lst_chslist = new System.Windows.Forms.ListBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_editchs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addchs
            // 
            this.btn_addchs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_addchs.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_addchs.Location = new System.Drawing.Point(12, 12);
            this.btn_addchs.Name = "btn_addchs";
            this.btn_addchs.Size = new System.Drawing.Size(214, 41);
            this.btn_addchs.TabIndex = 0;
            this.btn_addchs.Text = "Добавить ЧС";
            this.btn_addchs.UseVisualStyleBackColor = false;
            this.btn_addchs.Click += new System.EventHandler(this.btn_addchs_Click);
            // 
            // btn_delchs
            // 
            this.btn_delchs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_delchs.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_delchs.Location = new System.Drawing.Point(232, 12);
            this.btn_delchs.Name = "btn_delchs";
            this.btn_delchs.Size = new System.Drawing.Size(214, 41);
            this.btn_delchs.TabIndex = 1;
            this.btn_delchs.Text = "Убрать ЧС";
            this.btn_delchs.UseVisualStyleBackColor = false;
            this.btn_delchs.Click += new System.EventHandler(this.btn_delchs_Click);
            // 
            // lst_chslist
            // 
            this.lst_chslist.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lst_chslist.FormattingEnabled = true;
            this.lst_chslist.ItemHeight = 28;
            this.lst_chslist.Location = new System.Drawing.Point(11, 118);
            this.lst_chslist.Name = "lst_chslist";
            this.lst_chslist.Size = new System.Drawing.Size(435, 200);
            this.lst_chslist.TabIndex = 2;
            this.lst_chslist.SelectedIndexChanged += new System.EventHandler(this.lst_chslist_SelectedIndexChanged);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_exit.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_exit.Location = new System.Drawing.Point(232, 59);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(214, 41);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Выход";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_editchs
            // 
            this.btn_editchs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_editchs.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_editchs.Location = new System.Drawing.Point(12, 59);
            this.btn_editchs.Name = "btn_editchs";
            this.btn_editchs.Size = new System.Drawing.Size(214, 41);
            this.btn_editchs.TabIndex = 4;
            this.btn_editchs.Text = "Изменить ЧС";
            this.btn_editchs.UseVisualStyleBackColor = false;
            this.btn_editchs.Click += new System.EventHandler(this.btn_editchs_Click);
            // 
            // IncinentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 331);
            this.Controls.Add(this.btn_editchs);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lst_chslist);
            this.Controls.Add(this.btn_delchs);
            this.Controls.Add(this.btn_addchs);
            this.Name = "IncinentsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование списка ЧС";
            this.Load += new System.EventHandler(this.IncinentsList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addchs;
        private System.Windows.Forms.Button btn_delchs;
        private System.Windows.Forms.ListBox lst_chslist;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_editchs;
    }
}
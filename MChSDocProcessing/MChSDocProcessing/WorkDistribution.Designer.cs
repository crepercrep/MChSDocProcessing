
namespace MChSDocProcessing
{
    partial class WorkDistribution
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
            this.lst_free = new System.Windows.Forms.ListBox();
            this.lst_slaves = new System.Windows.Forms.ListBox();
            this.lst_random = new System.Windows.Forms.ListBox();
            this.lst_morerandom = new System.Windows.Forms.ListBox();
            this.btn_addslave = new System.Windows.Forms.Button();
            this.btn_addwtf = new System.Windows.Forms.Button();
            this.txt_chsname = new System.Windows.Forms.TextBox();
            this.btn_addnamechs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_delarm = new System.Windows.Forms.Button();
            this.btn_delwtf = new System.Windows.Forms.Button();
            this.btn_exitchslist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_free
            // 
            this.lst_free.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lst_free.FormattingEnabled = true;
            this.lst_free.ItemHeight = 28;
            this.lst_free.Location = new System.Drawing.Point(11, 47);
            this.lst_free.Name = "lst_free";
            this.lst_free.Size = new System.Drawing.Size(171, 144);
            this.lst_free.TabIndex = 0;
            // 
            // lst_slaves
            // 
            this.lst_slaves.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lst_slaves.FormattingEnabled = true;
            this.lst_slaves.ItemHeight = 28;
            this.lst_slaves.Location = new System.Drawing.Point(512, 47);
            this.lst_slaves.Name = "lst_slaves";
            this.lst_slaves.Size = new System.Drawing.Size(171, 144);
            this.lst_slaves.TabIndex = 1;
            // 
            // lst_random
            // 
            this.lst_random.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lst_random.FormattingEnabled = true;
            this.lst_random.ItemHeight = 28;
            this.lst_random.Location = new System.Drawing.Point(11, 205);
            this.lst_random.Name = "lst_random";
            this.lst_random.Size = new System.Drawing.Size(671, 60);
            this.lst_random.TabIndex = 2;
            this.lst_random.SelectedIndexChanged += new System.EventHandler(this.lst_random_SelectedIndexChanged);
            // 
            // lst_morerandom
            // 
            this.lst_morerandom.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lst_morerandom.FormattingEnabled = true;
            this.lst_morerandom.ItemHeight = 28;
            this.lst_morerandom.Location = new System.Drawing.Point(11, 379);
            this.lst_morerandom.Name = "lst_morerandom";
            this.lst_morerandom.Size = new System.Drawing.Size(671, 60);
            this.lst_morerandom.TabIndex = 3;
            this.lst_morerandom.SelectedIndexChanged += new System.EventHandler(this.lst_morerandom_SelectedIndexChanged);
            // 
            // btn_addslave
            // 
            this.btn_addslave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_addslave.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_addslave.Location = new System.Drawing.Point(190, 47);
            this.btn_addslave.Name = "btn_addslave";
            this.btn_addslave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_addslave.Size = new System.Drawing.Size(149, 67);
            this.btn_addslave.TabIndex = 4;
            this.btn_addslave.Text = "Добавить";
            this.btn_addslave.UseVisualStyleBackColor = false;
            this.btn_addslave.Click += new System.EventHandler(this.btn_addslave_Click);
            // 
            // btn_addwtf
            // 
            this.btn_addwtf.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_addwtf.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_addwtf.Location = new System.Drawing.Point(11, 275);
            this.btn_addwtf.Name = "btn_addwtf";
            this.btn_addwtf.Size = new System.Drawing.Size(171, 67);
            this.btn_addwtf.TabIndex = 5;
            this.btn_addwtf.Text = "Добавить";
            this.btn_addwtf.UseVisualStyleBackColor = false;
            this.btn_addwtf.Click += new System.EventHandler(this.btn_addwtf_Click);
            // 
            // txt_chsname
            // 
            this.txt_chsname.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_chsname.Location = new System.Drawing.Point(117, 495);
            this.txt_chsname.Name = "txt_chsname";
            this.txt_chsname.Size = new System.Drawing.Size(457, 35);
            this.txt_chsname.TabIndex = 6;
            this.txt_chsname.TextChanged += new System.EventHandler(this.txt_chsname_TextChanged);
            // 
            // btn_addnamechs
            // 
            this.btn_addnamechs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_addnamechs.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_addnamechs.Location = new System.Drawing.Point(14, 548);
            this.btn_addnamechs.Name = "btn_addnamechs";
            this.btn_addnamechs.Size = new System.Drawing.Size(194, 67);
            this.btn_addnamechs.TabIndex = 7;
            this.btn_addnamechs.Text = "Добавить ЧС";
            this.btn_addnamechs.UseVisualStyleBackColor = false;
            this.btn_addnamechs.Click += new System.EventHandler(this.btn_addnamechs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "АРМ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(423, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Участвующие АРМ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(301, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Файлы";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(279, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 56);
            this.label5.TabIndex = 12;
            this.label5.Text = "Файлы для \n обработки";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(263, 461);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 28);
            this.label7.TabIndex = 14;
            this.label7.Text = "Название ЧС";
            // 
            // btn_delarm
            // 
            this.btn_delarm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_delarm.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_delarm.Location = new System.Drawing.Point(357, 47);
            this.btn_delarm.Name = "btn_delarm";
            this.btn_delarm.Size = new System.Drawing.Size(149, 67);
            this.btn_delarm.TabIndex = 15;
            this.btn_delarm.Text = "Убрать";
            this.btn_delarm.UseVisualStyleBackColor = false;
            this.btn_delarm.Click += new System.EventHandler(this.btn_delarm_Click);
            // 
            // btn_delwtf
            // 
            this.btn_delwtf.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_delwtf.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_delwtf.Location = new System.Drawing.Point(512, 307);
            this.btn_delwtf.Name = "btn_delwtf";
            this.btn_delwtf.Size = new System.Drawing.Size(171, 67);
            this.btn_delwtf.TabIndex = 16;
            this.btn_delwtf.Text = "Убрать";
            this.btn_delwtf.UseVisualStyleBackColor = false;
            this.btn_delwtf.Click += new System.EventHandler(this.btn_delwtf_Click);
            // 
            // btn_exitchslist
            // 
            this.btn_exitchslist.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_exitchslist.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_exitchslist.Location = new System.Drawing.Point(486, 548);
            this.btn_exitchslist.Name = "btn_exitchslist";
            this.btn_exitchslist.Size = new System.Drawing.Size(194, 67);
            this.btn_exitchslist.TabIndex = 17;
            this.btn_exitchslist.Text = "Выход";
            this.btn_exitchslist.UseVisualStyleBackColor = false;
            this.btn_exitchslist.Click += new System.EventHandler(this.btn_exitchslist_Click);
            // 
            // WorkDistribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 629);
            this.Controls.Add(this.btn_exitchslist);
            this.Controls.Add(this.btn_delwtf);
            this.Controls.Add(this.btn_delarm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_addnamechs);
            this.Controls.Add(this.txt_chsname);
            this.Controls.Add(this.btn_addwtf);
            this.Controls.Add(this.btn_addslave);
            this.Controls.Add(this.lst_morerandom);
            this.Controls.Add(this.lst_random);
            this.Controls.Add(this.lst_slaves);
            this.Controls.Add(this.lst_free);
            this.Name = "WorkDistribution";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Распределение обязанностей";
            this.Load += new System.EventHandler(this.WorkDistribution_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_free;
        private System.Windows.Forms.ListBox lst_slaves;
        private System.Windows.Forms.ListBox lst_random;
        private System.Windows.Forms.ListBox lst_morerandom;
        private System.Windows.Forms.Button btn_addslave;
        private System.Windows.Forms.Button btn_addwtf;
        private System.Windows.Forms.TextBox txt_chsname;
        private System.Windows.Forms.Button btn_addnamechs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_delarm;
        private System.Windows.Forms.Button btn_delwtf;
        private System.Windows.Forms.Button btn_exitchslist;
    }
}
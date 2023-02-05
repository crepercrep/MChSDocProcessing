
using System;

namespace MChSDocProcessing
{
    partial class SODstart
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
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_hour = new System.Windows.Forms.TextBox();
            this.txt_min = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lst_connarms = new System.Windows.Forms.ListBox();
            this.cb_incidents = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_worktime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_settings.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_settings.Location = new System.Drawing.Point(14, 236);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(172, 75);
            this.btn_settings.TabIndex = 0;
            this.btn_settings.Text = "Настройки ЧС";
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_exit.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_exit.Location = new System.Drawing.Point(325, 236);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(129, 75);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "Выход";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_start.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_start.Location = new System.Drawing.Point(192, 236);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(127, 75);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Старт";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(114, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ввод данных";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_hour
            // 
            this.txt_hour.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_hour.Location = new System.Drawing.Point(309, 52);
            this.txt_hour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_hour.Name = "txt_hour";
            this.txt_hour.Size = new System.Drawing.Size(60, 35);
            this.txt_hour.TabIndex = 5;
            this.txt_hour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_hour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hour_KeyPress);
            this.txt_hour.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_hour_KeyUp);
            // 
            // txt_min
            // 
            this.txt_min.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_min.Location = new System.Drawing.Point(402, 52);
            this.txt_min.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_min.Name = "txt_min";
            this.txt_min.Size = new System.Drawing.Size(60, 35);
            this.txt_min.TabIndex = 6;
            this.txt_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_min_KeyPress);
            this.txt_min.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_min_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Время происшествия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(375, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Вид ЧС:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lst_connarms
            // 
            this.lst_connarms.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lst_connarms.FormattingEnabled = true;
            this.lst_connarms.ItemHeight = 28;
            this.lst_connarms.Location = new System.Drawing.Point(470, 12);
            this.lst_connarms.Name = "lst_connarms";
            this.lst_connarms.Size = new System.Drawing.Size(265, 284);
            this.lst_connarms.TabIndex = 10;
            this.lst_connarms.SelectedIndexChanged += new System.EventHandler(this.lst_connarms_SelectedIndexChanged);
            // 
            // cb_incidents
            // 
            this.cb_incidents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_incidents.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_incidents.FormattingEnabled = true;
            this.cb_incidents.Location = new System.Drawing.Point(129, 151);
            this.cb_incidents.Name = "cb_incidents";
            this.cb_incidents.Size = new System.Drawing.Size(324, 36);
            this.cb_incidents.TabIndex = 11;
            this.cb_incidents.SelectedIndexChanged += new System.EventHandler(this.cb_incidents_SelectedIndexChanged);
            this.cb_incidents.Click += new System.EventHandler(this.cb_incidents_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(56, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "Время отработки:";
            // 
            // txt_worktime
            // 
            this.txt_worktime.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_worktime.Location = new System.Drawing.Point(309, 95);
            this.txt_worktime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_worktime.Name = "txt_worktime";
            this.txt_worktime.Size = new System.Drawing.Size(60, 35);
            this.txt_worktime.TabIndex = 13;
            this.txt_worktime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_worktime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_worktime_KeyPress);
            this.txt_worktime.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_worktime_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(375, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "минут";
            // 
            // SODstart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 323);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_worktime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_incidents);
            this.Controls.Add(this.lst_connarms);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_min);
            this.Controls.Add(this.txt_hour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_settings);
            this.Name = "SODstart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ввод данных";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SODstart_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SODstart_FormClosed);
            this.Load += new System.EventHandler(this.SODstart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_hour;
        private System.Windows.Forms.TextBox txt_min;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lst_connarms;
        private System.Windows.Forms.ComboBox cb_incidents;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_worktime;
        private System.Windows.Forms.Label label6;
    }
}


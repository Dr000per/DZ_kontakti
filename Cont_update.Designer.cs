namespace WindowsFormsApp1
{
    partial class Cont_update
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
            this.checkBox_phone = new System.Windows.Forms.CheckBox();
            this.checkBox_new_name = new System.Windows.Forms.CheckBox();
            this.comboBox_old_name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.button_upd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_descr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_newname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBox_phone
            // 
            this.checkBox_phone.AutoSize = true;
            this.checkBox_phone.Location = new System.Drawing.Point(162, 104);
            this.checkBox_phone.Name = "checkBox_phone";
            this.checkBox_phone.Size = new System.Drawing.Size(15, 14);
            this.checkBox_phone.TabIndex = 30;
            this.checkBox_phone.UseVisualStyleBackColor = true;
            // 
            // checkBox_new_name
            // 
            this.checkBox_new_name.AutoSize = true;
            this.checkBox_new_name.Location = new System.Drawing.Point(99, 78);
            this.checkBox_new_name.Name = "checkBox_new_name";
            this.checkBox_new_name.Size = new System.Drawing.Size(15, 14);
            this.checkBox_new_name.TabIndex = 29;
            this.checkBox_new_name.UseVisualStyleBackColor = true;
            // 
            // comboBox_old_name
            // 
            this.comboBox_old_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_old_name.FormattingEnabled = true;
            this.comboBox_old_name.Location = new System.Drawing.Point(279, 45);
            this.comboBox_old_name.Name = "comboBox_old_name";
            this.comboBox_old_name.Size = new System.Drawing.Size(178, 21);
            this.comboBox_old_name.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "Текущее название контакта:";
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(279, 154);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(178, 24);
            this.button_close.TabIndex = 26;
            this.button_close.Text = "Отмена";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_upd
            // 
            this.button_upd.Location = new System.Drawing.Point(279, 124);
            this.button_upd.Name = "button_upd";
            this.button_upd.Size = new System.Drawing.Size(178, 24);
            this.button_upd.TabIndex = 25;
            this.button_upd.Text = "Обновить";
            this.button_upd.UseVisualStyleBackColor = true;
            this.button_upd.Click += new System.EventHandler(this.button_upd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(183, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "Телефон:";
            // 
            // textBox_descr
            // 
            this.textBox_descr.Location = new System.Drawing.Point(279, 98);
            this.textBox_descr.Name = "textBox_descr";
            this.textBox_descr.Size = new System.Drawing.Size(178, 20);
            this.textBox_descr.TabIndex = 23;
            this.textBox_descr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_descr_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(120, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Новое название:";
            // 
            // textBox_newname
            // 
            this.textBox_newname.Location = new System.Drawing.Point(279, 72);
            this.textBox_newname.Name = "textBox_newname";
            this.textBox_newname.Size = new System.Drawing.Size(178, 20);
            this.textBox_newname.TabIndex = 21;
            // 
            // Cont_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 267);
            this.Controls.Add(this.checkBox_phone);
            this.Controls.Add(this.checkBox_new_name);
            this.Controls.Add(this.comboBox_old_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_upd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_descr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_newname);
            this.Name = "Cont_update";
            this.Text = "Cont_update";
            this.Load += new System.EventHandler(this.Cont_update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_phone;
        private System.Windows.Forms.CheckBox checkBox_new_name;
        private System.Windows.Forms.ComboBox comboBox_old_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_upd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_descr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_newname;
    }
}
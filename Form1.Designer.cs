namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_show_all_cont = new System.Windows.Forms.Button();
            this.button_add_cont = new System.Windows.Forms.Button();
            this.button_update_cont = new System.Windows.Forms.Button();
            this.button_del_cont = new System.Windows.Forms.Button();
            this.button_upd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(613, 218);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_show_all_cont
            // 
            this.button_show_all_cont.Location = new System.Drawing.Point(468, 233);
            this.button_show_all_cont.Name = "button_show_all_cont";
            this.button_show_all_cont.Size = new System.Drawing.Size(157, 35);
            this.button_show_all_cont.TabIndex = 1;
            this.button_show_all_cont.Text = "Показать все контакты";
            this.button_show_all_cont.UseVisualStyleBackColor = true;
            this.button_show_all_cont.Click += new System.EventHandler(this.button_show_all_cont_Click);
            // 
            // button_add_cont
            // 
            this.button_add_cont.Location = new System.Drawing.Point(631, 12);
            this.button_add_cont.Name = "button_add_cont";
            this.button_add_cont.Size = new System.Drawing.Size(110, 35);
            this.button_add_cont.TabIndex = 6;
            this.button_add_cont.Text = "Добавить контакт";
            this.button_add_cont.UseVisualStyleBackColor = true;
            this.button_add_cont.Click += new System.EventHandler(this.button_add_cont_Click);
            // 
            // button_update_cont
            // 
            this.button_update_cont.Location = new System.Drawing.Point(631, 53);
            this.button_update_cont.Name = "button_update_cont";
            this.button_update_cont.Size = new System.Drawing.Size(110, 35);
            this.button_update_cont.TabIndex = 7;
            this.button_update_cont.Text = "Редактировать контакт";
            this.button_update_cont.UseVisualStyleBackColor = true;
            this.button_update_cont.Click += new System.EventHandler(this.button_update_cont_Click);
            // 
            // button_del_cont
            // 
            this.button_del_cont.Location = new System.Drawing.Point(631, 94);
            this.button_del_cont.Name = "button_del_cont";
            this.button_del_cont.Size = new System.Drawing.Size(110, 35);
            this.button_del_cont.TabIndex = 8;
            this.button_del_cont.Text = "Удалить контакт";
            this.button_del_cont.UseVisualStyleBackColor = true;
            this.button_del_cont.Click += new System.EventHandler(this.button_del_cont_Click);
            // 
            // button_upd
            // 
            this.button_upd.Location = new System.Drawing.Point(12, 236);
            this.button_upd.Name = "button_upd";
            this.button_upd.Size = new System.Drawing.Size(110, 42);
            this.button_upd.TabIndex = 10;
            this.button_upd.Text = "Обновить данные";
            this.button_upd.UseVisualStyleBackColor = true;
            this.button_upd.Click += new System.EventHandler(this.button_upd_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(221, 241);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(156, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Поиск:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_upd);
            this.Controls.Add(this.button_del_cont);
            this.Controls.Add(this.button_update_cont);
            this.Controls.Add(this.button_add_cont);
            this.Controls.Add(this.button_show_all_cont);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_show_all_cont;
        private System.Windows.Forms.Button button_add_cont;
        private System.Windows.Forms.Button button_update_cont;
        private System.Windows.Forms.Button button_del_cont;
        private System.Windows.Forms.Button button_upd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}


namespace Kanban
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
            this.tb_broad = new System.Windows.Forms.TextBox();
            this.b_update = new System.Windows.Forms.Button();
            this.cb_groups = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tb_broad
            // 
            this.tb_broad.Location = new System.Drawing.Point(12, 53);
            this.tb_broad.Multiline = true;
            this.tb_broad.Name = "tb_broad";
            this.tb_broad.Size = new System.Drawing.Size(379, 258);
            this.tb_broad.TabIndex = 0;
            // 
            // b_update
            // 
            this.b_update.Location = new System.Drawing.Point(12, 317);
            this.b_update.Name = "b_update";
            this.b_update.Size = new System.Drawing.Size(75, 23);
            this.b_update.TabIndex = 1;
            this.b_update.Text = "button1";
            this.b_update.UseVisualStyleBackColor = true;
            this.b_update.Click += new System.EventHandler(this.b_update_Click);
            // 
            // cb_groups
            // 
            this.cb_groups.AutoCompleteCustomSource.AddRange(new string[] {
            "Экстренные сообщения",
            "новости",
            "спорт",
            "афиша"});
            this.cb_groups.FormattingEnabled = true;
            this.cb_groups.Items.AddRange(new object[] {
            "новости",
            "спорт",
            "афиша",
            "экстренные сообщения"});
            this.cb_groups.Location = new System.Drawing.Point(13, 26);
            this.cb_groups.Name = "cb_groups";
            this.cb_groups.Size = new System.Drawing.Size(378, 21);
            this.cb_groups.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 374);
            this.Controls.Add(this.cb_groups);
            this.Controls.Add(this.b_update);
            this.Controls.Add(this.tb_broad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_broad;
        private System.Windows.Forms.Button b_update;
        private System.Windows.Forms.ComboBox cb_groups;
    }
}


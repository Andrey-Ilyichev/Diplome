namespace ExpertSystem
{
    partial class form_edit_kb
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
            this.dgv_rule = new System.Windows.Forms.DataGridView();
            this.btn_addRules = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rule)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_rule
            // 
            this.dgv_rule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rule.Location = new System.Drawing.Point(13, 12);
            this.dgv_rule.Name = "dgv_rule";
            this.dgv_rule.Size = new System.Drawing.Size(861, 323);
            this.dgv_rule.TabIndex = 0;
            // 
            // btn_addRules
            // 
            this.btn_addRules.Location = new System.Drawing.Point(12, 341);
            this.btn_addRules.Name = "btn_addRules";
            this.btn_addRules.Size = new System.Drawing.Size(115, 23);
            this.btn_addRules.TabIndex = 1;
            this.btn_addRules.Text = "Внести изменения";
            this.btn_addRules.UseVisualStyleBackColor = true;
            this.btn_addRules.Click += new System.EventHandler(this.btn_addRules_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(733, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Перейти к работе с ЭС";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_edit_kb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 373);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_addRules);
            this.Controls.Add(this.dgv_rule);
            this.Name = "form_edit_kb";
            this.Text = "Редактирование базы знаний";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_rule;
        private System.Windows.Forms.Button btn_addRules;
        private System.Windows.Forms.Button button1;
    }
}
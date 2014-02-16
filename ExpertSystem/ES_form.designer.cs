namespace ExpertSystem
{
    partial class ES_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_rule = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_fact = new System.Windows.Forms.DataGridView();
            this.btn_begin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_queue = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_result = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_varCon = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fact)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_queue)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_varCon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список правил:";
            // 
            // dgv_rule
            // 
            this.dgv_rule.AllowUserToAddRows = false;
            this.dgv_rule.AllowUserToDeleteRows = false;
            this.dgv_rule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rule.Location = new System.Drawing.Point(12, 25);
            this.dgv_rule.Name = "dgv_rule";
            this.dgv_rule.ReadOnly = true;
            this.dgv_rule.Size = new System.Drawing.Size(868, 281);
            this.dgv_rule.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(894, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Факты:";
            // 
            // dgv_fact
            // 
            this.dgv_fact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fact.EnableHeadersVisualStyles = false;
            this.dgv_fact.Location = new System.Drawing.Point(897, 25);
            this.dgv_fact.Name = "dgv_fact";
            this.dgv_fact.Size = new System.Drawing.Size(282, 252);
            this.dgv_fact.TabIndex = 3;
            // 
            // btn_begin
            // 
            this.btn_begin.Location = new System.Drawing.Point(890, 274);
            this.btn_begin.Name = "btn_begin";
            this.btn_begin.Size = new System.Drawing.Size(282, 23);
            this.btn_begin.TabIndex = 5;
            this.btn_begin.Text = "Начать работу";
            this.btn_begin.UseVisualStyleBackColor = true;
            this.btn_begin.Click += new System.EventHandler(this.btn_begin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_begin);
            this.groupBox1.Location = new System.Drawing.Point(7, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1189, 310);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = ".";
            // 
            // dgv_queue
            // 
            this.dgv_queue.AllowUserToAddRows = false;
            this.dgv_queue.AllowUserToDeleteRows = false;
            this.dgv_queue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_queue.Location = new System.Drawing.Point(6, 32);
            this.dgv_queue.Name = "dgv_queue";
            this.dgv_queue.ReadOnly = true;
            this.dgv_queue.Size = new System.Drawing.Size(244, 315);
            this.dgv_queue.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lb_result);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dgv_varCon);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dgv_queue);
            this.groupBox2.Location = new System.Drawing.Point(7, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1189, 355);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вывод:";
            // 
            // lb_result
            // 
            this.lb_result.FormattingEnabled = true;
            this.lb_result.Location = new System.Drawing.Point(890, 32);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(282, 316);
            this.lb_result.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Таблица переменных условий";
            // 
            // dgv_varCon
            // 
            this.dgv_varCon.AllowUserToAddRows = false;
            this.dgv_varCon.AllowUserToDeleteRows = false;
            this.dgv_varCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_varCon.Location = new System.Drawing.Point(347, 32);
            this.dgv_varCon.Name = "dgv_varCon";
            this.dgv_varCon.ReadOnly = true;
            this.dgv_varCon.Size = new System.Drawing.Size(443, 315);
            this.dgv_varCon.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Очередь фактов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(947, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ход работы экспертной системы";
            // 
            // ES_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 684);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_fact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_rule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ES_form";
            this.Text = "Работа экспертной системы";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fact)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_queue)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_varCon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_rule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_fact;
        private System.Windows.Forms.Button btn_begin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_queue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lb_result;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_varCon;
        private System.Windows.Forms.Label label5;
    }
}
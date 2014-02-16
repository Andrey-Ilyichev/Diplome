namespace ExpertSystem
{
    partial class startForm
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
            this.btn_createNewDB = new System.Windows.Forms.Button();
            this.btn_openDBfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_createNewDB
            // 
            this.btn_createNewDB.Location = new System.Drawing.Point(4, 17);
            this.btn_createNewDB.Name = "btn_createNewDB";
            this.btn_createNewDB.Size = new System.Drawing.Size(188, 23);
            this.btn_createNewDB.TabIndex = 0;
            this.btn_createNewDB.Text = "Создать новую БЗ";
            this.btn_createNewDB.UseVisualStyleBackColor = true;
            this.btn_createNewDB.Click += new System.EventHandler(this.btn_createNewDB_Click);
            // 
            // btn_openDBfile
            // 
            this.btn_openDBfile.Location = new System.Drawing.Point(4, 46);
            this.btn_openDBfile.Name = "btn_openDBfile";
            this.btn_openDBfile.Size = new System.Drawing.Size(188, 23);
            this.btn_openDBfile.TabIndex = 1;
            this.btn_openDBfile.Text = "Открыть существующую БЗ";
            this.btn_openDBfile.UseVisualStyleBackColor = true;
            this.btn_openDBfile.Click += new System.EventHandler(this.btn_openDBfile_Click);
            // 
            // startForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 86);
            this.Controls.Add(this.btn_openDBfile);
            this.Controls.Add(this.btn_createNewDB);
            this.Name = "startForm";
            this.Text = "Выберите БЗ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_createNewDB;
        private System.Windows.Forms.Button btn_openDBfile;
    }
}


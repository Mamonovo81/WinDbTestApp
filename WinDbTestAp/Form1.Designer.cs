namespace WinDbTestAp
{
    partial class FrmMain
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
            this.BtnMySql = new System.Windows.Forms.Button();
            this.BtnMsSQL = new System.Windows.Forms.Button();
            this.BtnSqLite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnMySql
            // 
            this.BtnMySql.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMySql.Location = new System.Drawing.Point(44, 14);
            this.BtnMySql.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMySql.Name = "BtnMySql";
            this.BtnMySql.Size = new System.Drawing.Size(144, 66);
            this.BtnMySql.TabIndex = 0;
            this.BtnMySql.Text = "MySQL";
            this.BtnMySql.UseVisualStyleBackColor = true;
            this.BtnMySql.Click += new System.EventHandler(this.BtnMySql_Click);
            // 
            // BtnMsSQL
            // 
            this.BtnMsSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnMsSQL.Location = new System.Drawing.Point(44, 98);
            this.BtnMsSQL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnMsSQL.Name = "BtnMsSQL";
            this.BtnMsSQL.Size = new System.Drawing.Size(144, 66);
            this.BtnMsSQL.TabIndex = 1;
            this.BtnMsSQL.Text = "MS SQL";
            this.BtnMsSQL.UseVisualStyleBackColor = true;
            this.BtnMsSQL.Click += new System.EventHandler(this.BtnMsSQL_Click);
            // 
            // BtnSqLite
            // 
            this.BtnSqLite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSqLite.Location = new System.Drawing.Point(48, 193);
            this.BtnSqLite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSqLite.Name = "BtnSqLite";
            this.BtnSqLite.Size = new System.Drawing.Size(139, 75);
            this.BtnSqLite.TabIndex = 2;
            this.BtnSqLite.Text = "SQLIte";
            this.BtnSqLite.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 325);
            this.Controls.Add(this.BtnSqLite);
            this.Controls.Add(this.BtnMsSQL);
            this.Controls.Add(this.BtnMySql);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMySql;
        private System.Windows.Forms.Button BtnMsSQL;
        private System.Windows.Forms.Button BtnSqLite;
    }
}


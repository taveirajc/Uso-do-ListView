namespace Uso_do_ListView
{
    partial class Form1
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
            this.txtSql = new System.Windows.Forms.TextBox();
            this.cmdExecuta = new System.Windows.Forms.Button();
            this.txtBd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lvwResultado = new System.Windows.Forms.ListView();
            this.btnSair = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o comando SQL clique em executar ===>";
            // 
            // txtSql
            // 
            this.txtSql.Location = new System.Drawing.Point(16, 40);
            this.txtSql.Multiline = true;
            this.txtSql.Name = "txtSql";
            this.txtSql.Size = new System.Drawing.Size(656, 112);
            this.txtSql.TabIndex = 1;
            // 
            // cmdExecuta
            // 
            this.cmdExecuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExecuta.Location = new System.Drawing.Point(399, 7);
            this.cmdExecuta.Name = "cmdExecuta";
            this.cmdExecuta.Size = new System.Drawing.Size(75, 23);
            this.cmdExecuta.TabIndex = 2;
            this.cmdExecuta.Text = "Executar";
            this.cmdExecuta.UseVisualStyleBackColor = true;
            this.cmdExecuta.Click += new System.EventHandler(this.cmdExecuta_Click);
            // 
            // txtBd
            // 
            this.txtBd.Location = new System.Drawing.Point(171, 164);
            this.txtBd.Name = "txtBd";
            this.txtBd.Size = new System.Drawing.Size(501, 20);
            this.txtBd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Caminho/banco de dados";
            // 
            // lvwResultado
            // 
            this.lvwResultado.HideSelection = false;
            this.lvwResultado.Location = new System.Drawing.Point(16, 192);
            this.lvwResultado.Name = "lvwResultado";
            this.lvwResultado.Size = new System.Drawing.Size(656, 272);
            this.lvwResultado.TabIndex = 5;
            this.lvwResultado.UseCompatibleStateImageBehavior = false;
            this.lvwResultado.View = System.Windows.Forms.View.Details;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(593, 8);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(19, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 509);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lvwResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBd);
            this.Controls.Add(this.cmdExecuta);
            this.Controls.Add(this.txtSql);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSql;
        private System.Windows.Forms.Button cmdExecuta;
        private System.Windows.Forms.TextBox txtBd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvwResultado;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label3;
    }
}


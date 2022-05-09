namespace AvaliacaoTecnica2.Telas
{
    partial class Repositorios
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
            this.lsbFuncionarios = new System.Windows.Forms.ListBox();
            this.lsbClientes = new System.Windows.Forms.ListBox();
            this.lsbProdutos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsbFuncionarios
            // 
            this.lsbFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbFuncionarios.FormattingEnabled = true;
            this.lsbFuncionarios.ItemHeight = 16;
            this.lsbFuncionarios.Location = new System.Drawing.Point(12, 68);
            this.lsbFuncionarios.Name = "lsbFuncionarios";
            this.lsbFuncionarios.Size = new System.Drawing.Size(253, 180);
            this.lsbFuncionarios.TabIndex = 0;
            // 
            // lsbClientes
            // 
            this.lsbClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbClientes.FormattingEnabled = true;
            this.lsbClientes.ItemHeight = 16;
            this.lsbClientes.Location = new System.Drawing.Point(285, 68);
            this.lsbClientes.Name = "lsbClientes";
            this.lsbClientes.Size = new System.Drawing.Size(248, 180);
            this.lsbClientes.TabIndex = 0;
            // 
            // lsbProdutos
            // 
            this.lsbProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbProdutos.FormattingEnabled = true;
            this.lsbProdutos.ItemHeight = 16;
            this.lsbProdutos.Location = new System.Drawing.Point(559, 68);
            this.lsbProdutos.Name = "lsbProdutos";
            this.lsbProdutos.Size = new System.Drawing.Size(124, 180);
            this.lsbProdutos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "FUNCIONÁRIOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "CLIENTES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(556, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "PRODUTOS";
            // 
            // Repositorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 319);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsbProdutos);
            this.Controls.Add(this.lsbClientes);
            this.Controls.Add(this.lsbFuncionarios);
            this.Name = "Repositorios";
            this.Text = "Repositorios";
            this.Load += new System.EventHandler(this.Repositorios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbFuncionarios;
        private System.Windows.Forms.ListBox lsbClientes;
        private System.Windows.Forms.ListBox lsbProdutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
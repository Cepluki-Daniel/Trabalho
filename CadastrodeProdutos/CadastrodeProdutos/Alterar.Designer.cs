namespace CadastrodeProdutos
{
    partial class Alterar
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
            this.boxProdutos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtMarcaProduto = new System.Windows.Forms.TextBox();
            this.txtCategoriaProduto = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnDescartar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // boxProdutos
            // 
            this.boxProdutos.FormattingEnabled = true;
            this.boxProdutos.Location = new System.Drawing.Point(224, 74);
            this.boxProdutos.Name = "boxProdutos";
            this.boxProdutos.Size = new System.Drawing.Size(316, 24);
            this.boxProdutos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alterar produtos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Produto ( Marca - Produto)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome do Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Categoria";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(224, 126);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(214, 22);
            this.txtNomeProduto.TabIndex = 6;
            // 
            // txtMarcaProduto
            // 
            this.txtMarcaProduto.Location = new System.Drawing.Point(224, 185);
            this.txtMarcaProduto.Name = "txtMarcaProduto";
            this.txtMarcaProduto.Size = new System.Drawing.Size(214, 22);
            this.txtMarcaProduto.TabIndex = 7;
            // 
            // txtCategoriaProduto
            // 
            this.txtCategoriaProduto.Location = new System.Drawing.Point(224, 250);
            this.txtCategoriaProduto.Name = "txtCategoriaProduto";
            this.txtCategoriaProduto.Size = new System.Drawing.Size(214, 22);
            this.txtCategoriaProduto.TabIndex = 8;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(159, 351);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(137, 54);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnDescartar
            // 
            this.btnDescartar.Location = new System.Drawing.Point(318, 351);
            this.btnDescartar.Name = "btnDescartar";
            this.btnDescartar.Size = new System.Drawing.Size(137, 54);
            this.btnDescartar.TabIndex = 10;
            this.btnDescartar.Text = "Descartar e sair";
            this.btnDescartar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Preço";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(224, 298);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(214, 22);
            this.txtPreco.TabIndex = 12;
            // 
            // Alterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 450);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDescartar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtCategoriaProduto);
            this.Controls.Add(this.txtMarcaProduto);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxProdutos);
            this.Name = "Alterar";
            this.Text = "Alterar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox boxProdutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtMarcaProduto;
        private System.Windows.Forms.TextBox txtCategoriaProduto;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnDescartar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPreco;
    }
}
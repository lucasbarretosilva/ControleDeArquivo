namespace ControleDeArquivo
{
    partial class Calculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCriarPasta = new System.Windows.Forms.TextBox();
            this.txtPastaOrigem = new System.Windows.Forms.TextBox();
            this.txtArquivoOrigem = new System.Windows.Forms.TextBox();
            this.txtDeletarPasta = new System.Windows.Forms.TextBox();
            this.btnCriarPasta = new System.Windows.Forms.Button();
            this.btnDeletarPasta = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPastaDestino = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o nome da pasta que será criada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o nome da pasta a ser deletada: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Arquivo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(457, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Digite a pasta de origem do arquivo que será movido:";
            // 
            // txtCriarPasta
            // 
            this.txtCriarPasta.Location = new System.Drawing.Point(475, 60);
            this.txtCriarPasta.Name = "txtCriarPasta";
            this.txtCriarPasta.Size = new System.Drawing.Size(208, 29);
            this.txtCriarPasta.TabIndex = 4;
            this.txtCriarPasta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPastaOrigem
            // 
            this.txtPastaOrigem.Location = new System.Drawing.Point(475, 220);
            this.txtPastaOrigem.Name = "txtPastaOrigem";
            this.txtPastaOrigem.Size = new System.Drawing.Size(208, 29);
            this.txtPastaOrigem.TabIndex = 5;
            this.txtPastaOrigem.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtArquivoOrigem
            // 
            this.txtArquivoOrigem.Location = new System.Drawing.Point(475, 168);
            this.txtArquivoOrigem.Name = "txtArquivoOrigem";
            this.txtArquivoOrigem.Size = new System.Drawing.Size(208, 29);
            this.txtArquivoOrigem.TabIndex = 6;
            this.txtArquivoOrigem.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtDeletarPasta
            // 
            this.txtDeletarPasta.Location = new System.Drawing.Point(475, 119);
            this.txtDeletarPasta.Name = "txtDeletarPasta";
            this.txtDeletarPasta.Size = new System.Drawing.Size(208, 29);
            this.txtDeletarPasta.TabIndex = 7;
            this.txtDeletarPasta.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnCriarPasta
            // 
            this.btnCriarPasta.Location = new System.Drawing.Point(710, 63);
            this.btnCriarPasta.Name = "btnCriarPasta";
            this.btnCriarPasta.Size = new System.Drawing.Size(83, 34);
            this.btnCriarPasta.TabIndex = 8;
            this.btnCriarPasta.Text = "OK";
            this.btnCriarPasta.UseVisualStyleBackColor = true;
            this.btnCriarPasta.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeletarPasta
            // 
            this.btnDeletarPasta.Location = new System.Drawing.Point(710, 119);
            this.btnDeletarPasta.Name = "btnDeletarPasta";
            this.btnDeletarPasta.Size = new System.Drawing.Size(83, 34);
            this.btnDeletarPasta.TabIndex = 9;
            this.btnDeletarPasta.Text = "OK";
            this.btnDeletarPasta.UseVisualStyleBackColor = true;
            this.btnDeletarPasta.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(710, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 34);
            this.button3.TabIndex = 11;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Pasta Destino";
            // 
            // txtPastaDestino
            // 
            this.txtPastaDestino.Location = new System.Drawing.Point(475, 275);
            this.txtPastaDestino.Name = "txtPastaDestino";
            this.txtPastaDestino.Size = new System.Drawing.Size(208, 29);
            this.txtPastaDestino.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(636, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 419);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPastaDestino);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDeletarPasta);
            this.Controls.Add(this.btnCriarPasta);
            this.Controls.Add(this.txtDeletarPasta);
            this.Controls.Add(this.txtArquivoOrigem);
            this.Controls.Add(this.txtPastaOrigem);
            this.Controls.Add(this.txtCriarPasta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Calculadora";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCriarPasta;
        private System.Windows.Forms.TextBox txtPastaOrigem;
        private System.Windows.Forms.TextBox txtArquivoOrigem;
        private System.Windows.Forms.TextBox txtDeletarPasta;
        private System.Windows.Forms.Button btnCriarPasta;
        private System.Windows.Forms.Button btnDeletarPasta;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPastaDestino;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


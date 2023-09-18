namespace caVeiculo
{
    partial class Form1
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
            this.RBOnibus = new System.Windows.Forms.RadioButton();
            this.RBCaminhao = new System.Windows.Forms.RadioButton();
            this.labelPlaca = new System.Windows.Forms.Label();
            this.labelAno = new System.Windows.Forms.Label();
            this.labelQTD = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RBOnibus
            // 
            this.RBOnibus.AutoSize = true;
            this.RBOnibus.Location = new System.Drawing.Point(77, 58);
            this.RBOnibus.Name = "RBOnibus";
            this.RBOnibus.Size = new System.Drawing.Size(70, 20);
            this.RBOnibus.TabIndex = 0;
            this.RBOnibus.TabStop = true;
            this.RBOnibus.Text = "Onibus";
            this.RBOnibus.UseVisualStyleBackColor = true;
            this.RBOnibus.CheckedChanged += new System.EventHandler(this.RBOnibus_CheckedChanged);
            // 
            // RBCaminhao
            // 
            this.RBCaminhao.AutoSize = true;
            this.RBCaminhao.Location = new System.Drawing.Point(264, 58);
            this.RBCaminhao.Name = "RBCaminhao";
            this.RBCaminhao.Size = new System.Drawing.Size(89, 20);
            this.RBCaminhao.TabIndex = 1;
            this.RBCaminhao.TabStop = true;
            this.RBCaminhao.Text = "Caminhao";
            this.RBCaminhao.UseVisualStyleBackColor = true;
            this.RBCaminhao.CheckedChanged += new System.EventHandler(this.RBCaminhao_CheckedChanged);
            // 
            // labelPlaca
            // 
            this.labelPlaca.AutoSize = true;
            this.labelPlaca.Location = new System.Drawing.Point(129, 152);
            this.labelPlaca.Name = "labelPlaca";
            this.labelPlaca.Size = new System.Drawing.Size(42, 16);
            this.labelPlaca.TabIndex = 2;
            this.labelPlaca.Text = "Placa";
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.Location = new System.Drawing.Point(129, 233);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(31, 16);
            this.labelAno.TabIndex = 3;
            this.labelAno.Text = "Ano";
            // 
            // labelQTD
            // 
            this.labelQTD.AutoSize = true;
            this.labelQTD.Location = new System.Drawing.Point(107, 331);
            this.labelQTD.Name = "labelQTD";
            this.labelQTD.Size = new System.Drawing.Size(87, 16);
            this.labelQTD.TabIndex = 4;
            this.labelQTD.Text = "Qtd Assentos";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(198, 152);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(166, 22);
            this.maskedTextBox1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 233);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(200, 331);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 22);
            this.textBox2.TabIndex = 7;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(110, 427);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 8;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(289, 427);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 9;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(77, 537);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(700, 97);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::caVeiculo.Properties.Resources.onibusPOO;
            this.pictureBox1.Location = new System.Drawing.Point(462, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 367);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 709);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.labelQTD);
            this.Controls.Add(this.labelAno);
            this.Controls.Add(this.labelPlaca);
            this.Controls.Add(this.RBCaminhao);
            this.Controls.Add(this.RBOnibus);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RBOnibus;
        private System.Windows.Forms.RadioButton RBCaminhao;
        private System.Windows.Forms.Label labelPlaca;
        private System.Windows.Forms.Label labelAno;
        private System.Windows.Forms.Label labelQTD;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


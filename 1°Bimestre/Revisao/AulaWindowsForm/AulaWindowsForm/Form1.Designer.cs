namespace AulaWindowsForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNascimento = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.ltvUsuarios = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsul = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEnder = new System.Windows.Forms.TextBox();
            this.txtNomeP = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(31, 110);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(293, 23);
            this.txtNome.TabIndex = 0;
            // 
            // txtNascimento
            // 
            this.txtNascimento.Location = new System.Drawing.Point(31, 192);
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(293, 23);
            this.txtNascimento.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(31, 77);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(96, 15);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Nome do animal";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(31, 159);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(114, 15);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "Data de Nascimento";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(433, 374);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(114, 41);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // ltvUsuarios
            // 
            this.ltvUsuarios.Location = new System.Drawing.Point(345, 110);
            this.ltvUsuarios.Name = "ltvUsuarios";
            this.ltvUsuarios.Size = new System.Drawing.Size(529, 191);
            this.ltvUsuarios.TabIndex = 6;
            this.ltvUsuarios.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Raça";
            // 
            // txtRaca
            // 
            this.txtRaca.Location = new System.Drawing.Point(31, 278);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(293, 23);
            this.txtRaca.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Informações do Animal";
            // 
            // btnConsul
            // 
            this.btnConsul.Location = new System.Drawing.Point(660, 374);
            this.btnConsul.Name = "btnConsul";
            this.btnConsul.Size = new System.Drawing.Size(143, 41);
            this.btnConsul.TabIndex = 10;
            this.btnConsul.Text = "Adicionar Consulta";
            this.btnConsul.UseVisualStyleBackColor = true;
            this.btnConsul.Click += new System.EventHandler(this.btnConsul_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 486);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Telefone";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(31, 519);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(293, 23);
            this.txtTel.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Endereço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nome Pessoa";
            // 
            // txtEnder
            // 
            this.txtEnder.Location = new System.Drawing.Point(31, 433);
            this.txtEnder.Name = "txtEnder";
            this.txtEnder.Size = new System.Drawing.Size(293, 23);
            this.txtEnder.TabIndex = 12;
            // 
            // txtNomeP
            // 
            this.txtNomeP.Location = new System.Drawing.Point(31, 351);
            this.txtNomeP.Name = "txtNomeP";
            this.txtNomeP.Size = new System.Drawing.Size(293, 23);
            this.txtNomeP.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 41);
            this.button1.TabIndex = 17;
            this.button1.Text = "Limpar Lista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 570);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEnder);
            this.Controls.Add(this.txtNomeP);
            this.Controls.Add(this.btnConsul);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRaca);
            this.Controls.Add(this.ltvUsuarios);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtNascimento);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNome;
        private TextBox txtNascimento;
        private Label lblName;
        private Label lbl;
        private Button btnEnviar;
        private ListView ltvUsuarios;
        private Label label1;
        private TextBox txtRaca;
        private Label label2;
        private Button btnConsul;
        private Label label3;
        private TextBox txtTel;
        private Label label4;
        private Label label5;
        private TextBox txtEnder;
        private TextBox txtNomeP;
        private Button button1;
    }
}
namespace AulaWindowsForm
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiagno = new System.Windows.Forms.TextBox();
            this.ltvUsuarios = new System.Windows.Forms.ListView();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtUltima = new System.Windows.Forms.TextBox();
            this.txtMedico = new System.Windows.Forms.TextBox();
            this.cbAnimal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Informações da Última Consulta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Diagnóstico";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDiagno
            // 
            this.txtDiagno.Location = new System.Drawing.Point(43, 342);
            this.txtDiagno.Name = "txtDiagno";
            this.txtDiagno.Size = new System.Drawing.Size(293, 23);
            this.txtDiagno.TabIndex = 16;
            // 
            // ltvUsuarios
            // 
            this.ltvUsuarios.Location = new System.Drawing.Point(357, 118);
            this.ltvUsuarios.Name = "ltvUsuarios";
            this.ltvUsuarios.Size = new System.Drawing.Size(529, 191);
            this.ltvUsuarios.TabIndex = 15;
            this.ltvUsuarios.UseCompatibleStateImageBehavior = false;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(43, 400);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(114, 41);
            this.btnEnviar.TabIndex = 14;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(43, 223);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(74, 15);
            this.lbl.TabIndex = 13;
            this.lbl.Text = "Enfermidade";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(43, 141);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 15);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Médico";
            // 
            // txtUltima
            // 
            this.txtUltima.Location = new System.Drawing.Point(43, 256);
            this.txtUltima.Name = "txtUltima";
            this.txtUltima.Size = new System.Drawing.Size(293, 23);
            this.txtUltima.TabIndex = 11;
            // 
            // txtMedico
            // 
            this.txtMedico.Location = new System.Drawing.Point(43, 174);
            this.txtMedico.Name = "txtMedico";
            this.txtMedico.Size = new System.Drawing.Size(293, 23);
            this.txtMedico.TabIndex = 10;
            // 
            // cbAnimal
            // 
            this.cbAnimal.FormattingEnabled = true;
            this.cbAnimal.Location = new System.Drawing.Point(43, 82);
            this.cbAnimal.Name = "cbAnimal";
            this.cbAnimal.Size = new System.Drawing.Size(138, 23);
            this.cbAnimal.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nome Animal";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 41);
            this.button1.TabIndex = 21;
            this.button1.Text = "Limpar Lista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 467);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbAnimal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiagno);
            this.Controls.Add(this.ltvUsuarios);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtUltima);
            this.Controls.Add(this.txtMedico);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txtDiagno;
        private ListView ltvUsuarios;
        private Button btnEnviar;
        private Label lbl;
        private Label lblName;
        private TextBox txtUltima;
        private TextBox txtMedico;
        private ComboBox cbAnimal;
        private Label label3;
        private Button button1;
    }
}
namespace SemeaJoao
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
            this.btn_perfil = new System.Windows.Forms.Button();
            this.btn_beneficios = new System.Windows.Forms.Button();
            this.btn_aprendizagem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_perfil
            // 
            this.btn_perfil.Location = new System.Drawing.Point(82, 255);
            this.btn_perfil.Name = "btn_perfil";
            this.btn_perfil.Size = new System.Drawing.Size(183, 127);
            this.btn_perfil.TabIndex = 0;
            this.btn_perfil.Text = "Exibir Perfil";
            this.btn_perfil.UseVisualStyleBackColor = true;
            // 
            // btn_beneficios
            // 
            this.btn_beneficios.Location = new System.Drawing.Point(408, 255);
            this.btn_beneficios.Name = "btn_beneficios";
            this.btn_beneficios.Size = new System.Drawing.Size(183, 127);
            this.btn_beneficios.TabIndex = 1;
            this.btn_beneficios.Text = "Gerenciar Benefícios";
            this.btn_beneficios.UseVisualStyleBackColor = true;
            this.btn_beneficios.Click += new System.EventHandler(this.btn_beneficios_Click);
            // 
            // btn_aprendizagem
            // 
            this.btn_aprendizagem.Location = new System.Drawing.Point(734, 255);
            this.btn_aprendizagem.Name = "btn_aprendizagem";
            this.btn_aprendizagem.Size = new System.Drawing.Size(183, 127);
            this.btn_aprendizagem.TabIndex = 2;
            this.btn_aprendizagem.Text = "Aprendizagem";
            this.btn_aprendizagem.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 636);
            this.Controls.Add(this.btn_aprendizagem);
            this.Controls.Add(this.btn_beneficios);
            this.Controls.Add(this.btn_perfil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_perfil;
        private System.Windows.Forms.Button btn_beneficios;
        private System.Windows.Forms.Button btn_aprendizagem;
    }
}


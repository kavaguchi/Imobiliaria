﻿
namespace ProjetoImobiliaria
{
    partial class FormPrincipal
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
            this.button3 = new System.Windows.Forms.Button();
            this.btnCadastroDeImovel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Hugo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCadastroDeImovel
            // 
            this.btnCadastroDeImovel.Location = new System.Drawing.Point(13, 124);
            this.btnCadastroDeImovel.Name = "btnCadastroDeImovel";
            this.btnCadastroDeImovel.Size = new System.Drawing.Size(221, 23);
            this.btnCadastroDeImovel.TabIndex = 3;
            this.btnCadastroDeImovel.Text = "Cadastro de Imóvel";
            this.btnCadastroDeImovel.UseVisualStyleBackColor = true;
            this.btnCadastroDeImovel.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cadastro de Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCadastroDeImovel);
            this.Controls.Add(this.button3);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCadastroDeImovel;
        private System.Windows.Forms.Button button1;
    }
}


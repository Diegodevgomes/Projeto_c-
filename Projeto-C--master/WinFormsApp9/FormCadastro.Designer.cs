﻿namespace WinFormsApp9
{
    partial class FormCadastro
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
            txtNome = new TextBox();
            txtPreco = new TextBox();
            btnSalvar = new Button();
            lblNome = new Label();
            lblPreco = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(254, 60);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(135, 23);
            txtNome.TabIndex = 0;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(254, 146);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(135, 23);
            txtPreco.TabIndex = 1;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalvar.Location = new Point(124, 264);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(135, 63);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.Location = new Point(124, 46);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(90, 37);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblPreco.Location = new Point(124, 132);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(83, 37);
            lblPreco.TabIndex = 4;
            lblPreco.Text = "Preço";
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPreco);
            Controls.Add(lblNome);
            Controls.Add(btnSalvar);
            Controls.Add(txtPreco);
            Controls.Add(txtNome);
            Name = "FormCadastro";
            Text = "FormCadastro";
            Load += FormCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtPreco;
        private Button btnSalvar;
        private Label lblNome;
        private Label lblPreco;
    }
}
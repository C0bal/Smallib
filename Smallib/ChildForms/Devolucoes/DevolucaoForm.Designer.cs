﻿
namespace Smallib.ChildForms.Devolucoes
{
    partial class DevolucaoForm
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
            this.MainTopPanel = new System.Windows.Forms.Panel();
            this.MainTopLabel = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxClasseLeitor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxDevolucaoPrevista = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxDataEmprestimo = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Site = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxIdEmprestimo = new System.Windows.Forms.TextBox();
            this.comboBoxTituloLivro = new System.Windows.Forms.ComboBox();
            this.comboBoxNomeLeitor = new System.Windows.Forms.ComboBox();
            this.txtBoxDataDevolucao = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MainTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTopPanel
            // 
            this.MainTopPanel.Controls.Add(this.MainTopLabel);
            this.MainTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTopPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTopPanel.Name = "MainTopPanel";
            this.MainTopPanel.Size = new System.Drawing.Size(1004, 52);
            this.MainTopPanel.TabIndex = 20;
            // 
            // MainTopLabel
            // 
            this.MainTopLabel.AutoSize = true;
            this.MainTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.75F);
            this.MainTopLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.MainTopLabel.Location = new System.Drawing.Point(46, 12);
            this.MainTopLabel.Name = "MainTopLabel";
            this.MainTopLabel.Size = new System.Drawing.Size(127, 29);
            this.MainTopLabel.TabIndex = 0;
            this.MainTopLabel.Text = "Devolução";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(136)))), ((int)(((byte)(217)))));
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnVoltar.Location = new System.Drawing.Point(254, 473);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(110, 40);
            this.btnVoltar.TabIndex = 169;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnDevolver
            // 
            this.btnDevolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(174)))), ((int)(((byte)(159)))));
            this.btnDevolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.btnDevolver.Location = new System.Drawing.Point(102, 473);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(110, 40);
            this.btnDevolver.TabIndex = 168;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = false;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panel1.Location = new System.Drawing.Point(62, 449);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 2);
            this.panel1.TabIndex = 167;
            // 
            // txtBoxClasseLeitor
            // 
            this.txtBoxClasseLeitor.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxClasseLeitor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxClasseLeitor.Enabled = false;
            this.txtBoxClasseLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxClasseLeitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.txtBoxClasseLeitor.Location = new System.Drawing.Point(714, 354);
            this.txtBoxClasseLeitor.Name = "txtBoxClasseLeitor";
            this.txtBoxClasseLeitor.Size = new System.Drawing.Size(185, 31);
            this.txtBoxClasseLeitor.TabIndex = 166;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.label2.Location = new System.Drawing.Point(717, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 165;
            this.label2.Text = "Classe do Leitor";
            // 
            // txtBoxDevolucaoPrevista
            // 
            this.txtBoxDevolucaoPrevista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxDevolucaoPrevista.Enabled = false;
            this.txtBoxDevolucaoPrevista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtBoxDevolucaoPrevista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.txtBoxDevolucaoPrevista.Location = new System.Drawing.Point(409, 354);
            this.txtBoxDevolucaoPrevista.Mask = "00/00/0000";
            this.txtBoxDevolucaoPrevista.Name = "txtBoxDevolucaoPrevista";
            this.txtBoxDevolucaoPrevista.Size = new System.Drawing.Size(265, 31);
            this.txtBoxDevolucaoPrevista.TabIndex = 164;
            this.txtBoxDevolucaoPrevista.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.label1.Location = new System.Drawing.Point(412, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 163;
            this.label1.Text = "Devolução Prevista";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.label4.Location = new System.Drawing.Point(98, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 161;
            this.label4.Text = "Devolver Livro";
            // 
            // txtBoxDataEmprestimo
            // 
            this.txtBoxDataEmprestimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxDataEmprestimo.Enabled = false;
            this.txtBoxDataEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtBoxDataEmprestimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.txtBoxDataEmprestimo.Location = new System.Drawing.Point(99, 354);
            this.txtBoxDataEmprestimo.Mask = "00/00/0000";
            this.txtBoxDataEmprestimo.Name = "txtBoxDataEmprestimo";
            this.txtBoxDataEmprestimo.Size = new System.Drawing.Size(265, 31);
            this.txtBoxDataEmprestimo.TabIndex = 159;
            this.txtBoxDataEmprestimo.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.label10.Location = new System.Drawing.Point(102, 327);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(206, 25);
            this.label10.TabIndex = 158;
            this.label10.Text = "Data do Empréstimo";
            // 
            // Site
            // 
            this.Site.AutoSize = true;
            this.Site.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Site.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.Site.Location = new System.Drawing.Point(520, 246);
            this.Site.Name = "Site";
            this.Site.Size = new System.Drawing.Size(151, 25);
            this.Site.TabIndex = 157;
            this.Site.Text = "Nome do Livro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.label5.Location = new System.Drawing.Point(102, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 25);
            this.label5.TabIndex = 156;
            this.label5.Text = "Nome do Leitor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.label6.Location = new System.Drawing.Point(103, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 25);
            this.label6.TabIndex = 155;
            this.label6.Text = "ID";
            // 
            // txtBoxIdEmprestimo
            // 
            this.txtBoxIdEmprestimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtBoxIdEmprestimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxIdEmprestimo.Enabled = false;
            this.txtBoxIdEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxIdEmprestimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.txtBoxIdEmprestimo.Location = new System.Drawing.Point(99, 191);
            this.txtBoxIdEmprestimo.Name = "txtBoxIdEmprestimo";
            this.txtBoxIdEmprestimo.Size = new System.Drawing.Size(71, 31);
            this.txtBoxIdEmprestimo.TabIndex = 154;
            // 
            // comboBoxTituloLivro
            // 
            this.comboBoxTituloLivro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxTituloLivro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTituloLivro.Enabled = false;
            this.comboBoxTituloLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTituloLivro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.comboBoxTituloLivro.FormattingEnabled = true;
            this.comboBoxTituloLivro.IntegralHeight = false;
            this.comboBoxTituloLivro.ItemHeight = 25;
            this.comboBoxTituloLivro.Location = new System.Drawing.Point(517, 274);
            this.comboBoxTituloLivro.Name = "comboBoxTituloLivro";
            this.comboBoxTituloLivro.Size = new System.Drawing.Size(382, 33);
            this.comboBoxTituloLivro.TabIndex = 160;
            // 
            // comboBoxNomeLeitor
            // 
            this.comboBoxNomeLeitor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxNomeLeitor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxNomeLeitor.Enabled = false;
            this.comboBoxNomeLeitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNomeLeitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.comboBoxNomeLeitor.FormattingEnabled = true;
            this.comboBoxNomeLeitor.IntegralHeight = false;
            this.comboBoxNomeLeitor.ItemHeight = 25;
            this.comboBoxNomeLeitor.Location = new System.Drawing.Point(99, 274);
            this.comboBoxNomeLeitor.Name = "comboBoxNomeLeitor";
            this.comboBoxNomeLeitor.Size = new System.Drawing.Size(383, 33);
            this.comboBoxNomeLeitor.TabIndex = 162;
            // 
            // txtBoxDataDevolucao
            // 
            this.txtBoxDataDevolucao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxDataDevolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtBoxDataDevolucao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(81)))), ((int)(((byte)(116)))));
            this.txtBoxDataDevolucao.Location = new System.Drawing.Point(634, 191);
            this.txtBoxDataDevolucao.Mask = "00/00/0000";
            this.txtBoxDataDevolucao.Name = "txtBoxDataDevolucao";
            this.txtBoxDataDevolucao.Size = new System.Drawing.Size(265, 31);
            this.txtBoxDataDevolucao.TabIndex = 171;
            this.txtBoxDataDevolucao.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.label3.Location = new System.Drawing.Point(637, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 25);
            this.label3.TabIndex = 170;
            this.label3.Text = "Data de Devolução";
            // 
            // DevolucaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(1004, 631);
            this.Controls.Add(this.txtBoxDataDevolucao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBoxClasseLeitor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxDevolucaoPrevista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxDataEmprestimo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Site);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxIdEmprestimo);
            this.Controls.Add(this.comboBoxTituloLivro);
            this.Controls.Add(this.comboBoxNomeLeitor);
            this.Controls.Add(this.MainTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DevolucaoForm";
            this.Text = "DevolucaoForm";
            this.MainTopPanel.ResumeLayout(false);
            this.MainTopPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainTopPanel;
        private System.Windows.Forms.Label MainTopLabel;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBoxClasseLeitor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtBoxDevolucaoPrevista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtBoxDataEmprestimo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Site;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxIdEmprestimo;
        private System.Windows.Forms.ComboBox comboBoxTituloLivro;
        private System.Windows.Forms.ComboBox comboBoxNomeLeitor;
        private System.Windows.Forms.MaskedTextBox txtBoxDataDevolucao;
        private System.Windows.Forms.Label label3;
    }
}
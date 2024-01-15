namespace AutomatizadorDeCadastros
{
    partial class AutomatizadorDeCadastros
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combotipocadastro = new System.Windows.Forms.ComboBox();
            this.textdiretoriodoarquivo = new System.Windows.Forms.TextBox();
            this.botaobuscararquivo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo De Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Arquivo para Cadastro";
            // 
            // combotipocadastro
            // 
            this.combotipocadastro.AutoCompleteCustomSource.AddRange(new string[] {
            "Produto",
            "Fornecedor",
            "Colaborador"});
            this.combotipocadastro.FormattingEnabled = true;
            this.combotipocadastro.Items.AddRange(new object[] {
            "Fornecedor",
            "Colaborador",
            "Produto"});
            this.combotipocadastro.Location = new System.Drawing.Point(170, 13);
            this.combotipocadastro.Name = "combotipocadastro";
            this.combotipocadastro.Size = new System.Drawing.Size(121, 21);
            this.combotipocadastro.TabIndex = 3;
            // 
            // textdiretoriodoarquivo
            // 
            this.textdiretoriodoarquivo.Location = new System.Drawing.Point(17, 81);
            this.textdiretoriodoarquivo.Name = "textdiretoriodoarquivo";
            this.textdiretoriodoarquivo.Size = new System.Drawing.Size(274, 20);
            this.textdiretoriodoarquivo.TabIndex = 4;
            // 
            // botaobuscararquivo
            // 
            this.botaobuscararquivo.Location = new System.Drawing.Point(298, 81);
            this.botaobuscararquivo.Name = "botaobuscararquivo";
            this.botaobuscararquivo.Size = new System.Drawing.Size(34, 23);
            this.botaobuscararquivo.TabIndex = 5;
            this.botaobuscararquivo.Text = "...";
            this.botaobuscararquivo.UseVisualStyleBackColor = true;
            this.botaobuscararquivo.Click += new System.EventHandler(this.botaobuscararquivo_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(17, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Realizar Cadastro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AutomatizadorDeCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 170);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botaobuscararquivo);
            this.Controls.Add(this.textdiretoriodoarquivo);
            this.Controls.Add(this.combotipocadastro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AutomatizadorDeCadastros";
            this.Text = "Automatizador De Cadastros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combotipocadastro;
        private System.Windows.Forms.TextBox textdiretoriodoarquivo;
        private System.Windows.Forms.Button botaobuscararquivo;
        private System.Windows.Forms.Button button1;
    }
}
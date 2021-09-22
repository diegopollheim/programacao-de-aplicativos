namespace ProjetoCadastro
{
    partial class CadastroSexo
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCadastrarSexo = new System.Windows.Forms.Button();
            this.ttbNomeSexo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(78, 252);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(70, 23);
            this.btnSair.TabIndex = 25;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCadastrarSexo
            // 
            this.btnCadastrarSexo.Location = new System.Drawing.Point(159, 252);
            this.btnCadastrarSexo.Name = "btnCadastrarSexo";
            this.btnCadastrarSexo.Size = new System.Drawing.Size(70, 23);
            this.btnCadastrarSexo.TabIndex = 2;
            this.btnCadastrarSexo.Text = "Cadastrar";
            this.btnCadastrarSexo.UseVisualStyleBackColor = true;
            this.btnCadastrarSexo.Click += new System.EventHandler(this.btnCadastrarSexo_Click);
            // 
            // ttbNomeSexo
            // 
            this.ttbNomeSexo.Location = new System.Drawing.Point(29, 104);
            this.ttbNomeSexo.Name = "ttbNomeSexo";
            this.ttbNomeSexo.Size = new System.Drawing.Size(201, 20);
            this.ttbNomeSexo.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nome do Sexo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cadastro de Sexos";
            // 
            // CadastroSexo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(250, 281);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastrarSexo);
            this.Controls.Add(this.ttbNomeSexo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroSexo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroSexo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCadastrarSexo;
        private System.Windows.Forms.TextBox ttbNomeSexo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
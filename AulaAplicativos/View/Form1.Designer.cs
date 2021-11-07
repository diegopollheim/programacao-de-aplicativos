
namespace AulaAplicativos
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
            this.cbbCidade = new System.Windows.Forms.ComboBox();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRelatCid = new System.Windows.Forms.Button();
            this.btnRelatEstado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbCidade
            // 
            this.cbbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCidade.FormattingEnabled = true;
            this.cbbCidade.Location = new System.Drawing.Point(60, 150);
            this.cbbCidade.Name = "cbbCidade";
            this.cbbCidade.Size = new System.Drawing.Size(306, 33);
            this.cbbCidade.TabIndex = 0;
            // 
            // cbbEstado
            // 
            this.cbbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(60, 66);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(306, 33);
            this.cbbEstado.TabIndex = 1;
            this.cbbEstado.SelectedValueChanged += new System.EventHandler(this.cbbEstado_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Estado";
            // 
            // btnRelatCid
            // 
            this.btnRelatCid.Location = new System.Drawing.Point(60, 226);
            this.btnRelatCid.Name = "btnRelatCid";
            this.btnRelatCid.Size = new System.Drawing.Size(133, 34);
            this.btnRelatCid.TabIndex = 4;
            this.btnRelatCid.Text = "Relatório Cidades";
            this.btnRelatCid.UseVisualStyleBackColor = true;
            this.btnRelatCid.Click += new System.EventHandler(this.btnRelatCid_Click);
            // 
            // btnRelatEstado
            // 
            this.btnRelatEstado.Location = new System.Drawing.Point(233, 226);
            this.btnRelatEstado.Name = "btnRelatEstado";
            this.btnRelatEstado.Size = new System.Drawing.Size(133, 34);
            this.btnRelatEstado.TabIndex = 5;
            this.btnRelatEstado.Text = "Relatório Estados";
            this.btnRelatEstado.UseVisualStyleBackColor = true;
            this.btnRelatEstado.Click += new System.EventHandler(this.btnRelatEstado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(448, 372);
            this.Controls.Add(this.btnRelatEstado);
            this.Controls.Add(this.btnRelatCid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbEstado);
            this.Controls.Add(this.cbbCidade);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbCidade;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRelatCid;
        private System.Windows.Forms.Button btnRelatEstado;
    }
}


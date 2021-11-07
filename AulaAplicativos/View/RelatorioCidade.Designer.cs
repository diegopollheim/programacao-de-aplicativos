
namespace AulaAplicativos.View
{
    partial class RelatorioCidade
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
            this.rdbIdCidade = new System.Windows.Forms.RadioButton();
            this.rdbIdEstado = new System.Windows.Forms.RadioButton();
            this.rdbNomeCidade = new System.Windows.Forms.RadioButton();
            this.dvgCidades = new System.Windows.Forms.DataGridView();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnBusca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCidades)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbIdCidade
            // 
            this.rdbIdCidade.AutoSize = true;
            this.rdbIdCidade.Location = new System.Drawing.Point(12, 19);
            this.rdbIdCidade.Name = "rdbIdCidade";
            this.rdbIdCidade.Size = new System.Drawing.Size(70, 17);
            this.rdbIdCidade.TabIndex = 0;
            this.rdbIdCidade.TabStop = true;
            this.rdbIdCidade.Text = "Id Cidade";
            this.rdbIdCidade.UseVisualStyleBackColor = true;
            // 
            // rdbIdEstado
            // 
            this.rdbIdEstado.AutoSize = true;
            this.rdbIdEstado.Location = new System.Drawing.Point(103, 19);
            this.rdbIdEstado.Name = "rdbIdEstado";
            this.rdbIdEstado.Size = new System.Drawing.Size(70, 17);
            this.rdbIdEstado.TabIndex = 1;
            this.rdbIdEstado.TabStop = true;
            this.rdbIdEstado.Text = "Id Estado";
            this.rdbIdEstado.UseVisualStyleBackColor = true;
            // 
            // rdbNomeCidade
            // 
            this.rdbNomeCidade.AutoSize = true;
            this.rdbNomeCidade.Location = new System.Drawing.Point(198, 19);
            this.rdbNomeCidade.Name = "rdbNomeCidade";
            this.rdbNomeCidade.Size = new System.Drawing.Size(89, 17);
            this.rdbNomeCidade.TabIndex = 2;
            this.rdbNomeCidade.TabStop = true;
            this.rdbNomeCidade.Text = "Nome Cidade";
            this.rdbNomeCidade.UseVisualStyleBackColor = true;
            // 
            // dvgCidades
            // 
            this.dvgCidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCidades.Location = new System.Drawing.Point(12, 94);
            this.dvgCidades.Name = "dvgCidades";
            this.dvgCidades.Size = new System.Drawing.Size(424, 248);
            this.dvgCidades.TabIndex = 3;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(12, 59);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(306, 29);
            this.txtPesquisa.TabIndex = 4;
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(348, 59);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(88, 29);
            this.btnBusca.TabIndex = 5;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // RelatorioCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(448, 372);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.dvgCidades);
            this.Controls.Add(this.rdbNomeCidade);
            this.Controls.Add(this.rdbIdEstado);
            this.Controls.Add(this.rdbIdCidade);
            this.Name = "RelatorioCidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelatorioCidade";
            ((System.ComponentModel.ISupportInitialize)(this.dvgCidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbIdCidade;
        private System.Windows.Forms.RadioButton rdbIdEstado;
        private System.Windows.Forms.RadioButton rdbNomeCidade;
        private System.Windows.Forms.DataGridView dvgCidades;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnBusca;
    }
}
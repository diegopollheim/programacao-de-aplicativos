
namespace AulaAplicativos.View
{
    partial class RelatorioEstados
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
            this.btnBusca = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dvgEstados = new System.Windows.Forms.DataGridView();
            this.rdbNomeEstado = new System.Windows.Forms.RadioButton();
            this.rdbIdEstado = new System.Windows.Forms.RadioButton();
            this.rdbSigla = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEstados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(348, 67);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(88, 29);
            this.btnBusca.TabIndex = 11;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(12, 67);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(306, 29);
            this.txtPesquisar.TabIndex = 10;
            // 
            // dvgEstados
            // 
            this.dvgEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgEstados.Location = new System.Drawing.Point(12, 102);
            this.dvgEstados.Name = "dvgEstados";
            this.dvgEstados.Size = new System.Drawing.Size(424, 248);
            this.dvgEstados.TabIndex = 9;
            // 
            // rdbNomeEstado
            // 
            this.rdbNomeEstado.AutoSize = true;
            this.rdbNomeEstado.Location = new System.Drawing.Point(110, 27);
            this.rdbNomeEstado.Name = "rdbNomeEstado";
            this.rdbNomeEstado.Size = new System.Drawing.Size(89, 17);
            this.rdbNomeEstado.TabIndex = 8;
            this.rdbNomeEstado.TabStop = true;
            this.rdbNomeEstado.Text = "Nome Estado";
            this.rdbNomeEstado.UseVisualStyleBackColor = true;
            // 
            // rdbIdEstado
            // 
            this.rdbIdEstado.AutoSize = true;
            this.rdbIdEstado.Location = new System.Drawing.Point(23, 27);
            this.rdbIdEstado.Name = "rdbIdEstado";
            this.rdbIdEstado.Size = new System.Drawing.Size(70, 17);
            this.rdbIdEstado.TabIndex = 7;
            this.rdbIdEstado.TabStop = true;
            this.rdbIdEstado.Text = "Id Estado";
            this.rdbIdEstado.UseVisualStyleBackColor = true;
            // 
            // rdbSigla
            // 
            this.rdbSigla.AutoSize = true;
            this.rdbSigla.Location = new System.Drawing.Point(217, 27);
            this.rdbSigla.Name = "rdbSigla";
            this.rdbSigla.Size = new System.Drawing.Size(48, 17);
            this.rdbSigla.TabIndex = 6;
            this.rdbSigla.TabStop = true;
            this.rdbSigla.Text = "Sigla";
            this.rdbSigla.UseVisualStyleBackColor = true;
            // 
            // RelatorioEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(448, 372);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.dvgEstados);
            this.Controls.Add(this.rdbNomeEstado);
            this.Controls.Add(this.rdbIdEstado);
            this.Controls.Add(this.rdbSigla);
            this.Name = "RelatorioEstados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelatorioEstado";
            ((System.ComponentModel.ISupportInitialize)(this.dvgEstados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView dvgEstados;
        private System.Windows.Forms.RadioButton rdbNomeEstado;
        private System.Windows.Forms.RadioButton rdbIdEstado;
        private System.Windows.Forms.RadioButton rdbSigla;
    }
}
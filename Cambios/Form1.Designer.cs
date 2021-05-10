
namespace Cambios
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_valor = new System.Windows.Forms.Label();
            this.lbl_moedaOrigem = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.lbl_moedaDestino = new System.Windows.Forms.Label();
            this.cb_moedaOrigem = new System.Windows.Forms.ComboBox();
            this.btn_converter = new System.Windows.Forms.Button();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.cb_moedaDestino = new System.Windows.Forms.ComboBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_troca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_valor
            // 
            this.lbl_valor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_valor.Location = new System.Drawing.Point(43, 44);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(163, 38);
            this.lbl_valor.TabIndex = 0;
            this.lbl_valor.Text = "Valor:";
            this.lbl_valor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_moedaOrigem
            // 
            this.lbl_moedaOrigem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_moedaOrigem.Location = new System.Drawing.Point(12, 101);
            this.lbl_moedaOrigem.Name = "lbl_moedaOrigem";
            this.lbl_moedaOrigem.Size = new System.Drawing.Size(194, 30);
            this.lbl_moedaOrigem.TabIndex = 1;
            this.lbl_moedaOrigem.Text = "Moeda de origem:";
            this.lbl_moedaOrigem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(224, 49);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(350, 31);
            this.txt_valor.TabIndex = 2;
            // 
            // lbl_moedaDestino
            // 
            this.lbl_moedaDestino.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_moedaDestino.Location = new System.Drawing.Point(12, 161);
            this.lbl_moedaDestino.Name = "lbl_moedaDestino";
            this.lbl_moedaDestino.Size = new System.Drawing.Size(194, 30);
            this.lbl_moedaDestino.TabIndex = 3;
            this.lbl_moedaDestino.Text = "Moeda de origem:";
            this.lbl_moedaDestino.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_moedaOrigem
            // 
            this.cb_moedaOrigem.FormattingEnabled = true;
            this.cb_moedaOrigem.Location = new System.Drawing.Point(224, 102);
            this.cb_moedaOrigem.Name = "cb_moedaOrigem";
            this.cb_moedaOrigem.Size = new System.Drawing.Size(350, 33);
            this.cb_moedaOrigem.TabIndex = 4;
            // 
            // btn_converter
            // 
            this.btn_converter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_converter.Location = new System.Drawing.Point(612, 44);
            this.btn_converter.Name = "btn_converter";
            this.btn_converter.Size = new System.Drawing.Size(125, 54);
            this.btn_converter.TabIndex = 5;
            this.btn_converter.Text = "Converter";
            this.btn_converter.UseVisualStyleBackColor = true;
            this.btn_converter.Click += new System.EventHandler(this.btn_converter_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_resultado.ForeColor = System.Drawing.Color.Navy;
            this.lbl_resultado.Location = new System.Drawing.Point(2, 227);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(735, 81);
            this.lbl_resultado.TabIndex = 6;
            this.lbl_resultado.Text = "Escolha um valor, uma moeda de origem e uma moeda de destino.";
            this.lbl_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_moedaDestino
            // 
            this.cb_moedaDestino.FormattingEnabled = true;
            this.cb_moedaDestino.Location = new System.Drawing.Point(224, 161);
            this.cb_moedaDestino.Name = "cb_moedaDestino";
            this.cb_moedaDestino.Size = new System.Drawing.Size(350, 33);
            this.cb_moedaDestino.TabIndex = 7;
            // 
            // lbl_status
            // 
            this.lbl_status.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_status.Location = new System.Drawing.Point(12, 373);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(194, 38);
            this.lbl_status.TabIndex = 8;
            this.lbl_status.Text = "Status:";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(524, 373);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(213, 34);
            this.progressBar1.TabIndex = 9;
            // 
            // btn_troca
            // 
            this.btn_troca.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_troca.Image = global::Cambios.Properties.Resources.icons8_up_down_arrow_32px_11;
            this.btn_troca.Location = new System.Drawing.Point(640, 126);
            this.btn_troca.Name = "btn_troca";
            this.btn_troca.Size = new System.Drawing.Size(62, 52);
            this.btn_troca.TabIndex = 10;
            this.btn_troca.UseVisualStyleBackColor = true;
            this.btn_troca.Click += new System.EventHandler(this.btn_troca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_troca);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.cb_moedaDestino);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.btn_converter);
            this.Controls.Add(this.cb_moedaOrigem);
            this.Controls.Add(this.lbl_moedaDestino);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.lbl_moedaOrigem);
            this.Controls.Add(this.lbl_valor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Câmbios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Label lbl_moedaOrigem;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label lbl_moedaDestino;
        private System.Windows.Forms.ComboBox cb_moedaOrigem;
        private System.Windows.Forms.Button btn_converter;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.ComboBox cb_moedaDestino;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_troca;
    }
}


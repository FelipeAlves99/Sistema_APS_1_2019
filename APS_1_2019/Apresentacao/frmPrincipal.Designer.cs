namespace APS_1_2019
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.btnChecar = new System.Windows.Forms.Button();
            this.grbArduinoInfo = new System.Windows.Forms.GroupBox();
            this.lblChuvaTexto = new System.Windows.Forms.Label();
            this.lblUmidadeTexto = new System.Windows.Forms.Label();
            this.lblTemperaturaTexto = new System.Windows.Forms.Label();
            this.lblChuva = new System.Windows.Forms.Label();
            this.lblUmidade = new System.Windows.Forms.Label();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.TimerArduino = new System.Windows.Forms.Timer(this.components);
            this.grbArduinoInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChecar
            // 
            this.btnChecar.Location = new System.Drawing.Point(254, 65);
            this.btnChecar.Name = "btnChecar";
            this.btnChecar.Size = new System.Drawing.Size(100, 30);
            this.btnChecar.TabIndex = 1;
            this.btnChecar.Text = "Checar Arduino";
            this.btnChecar.UseVisualStyleBackColor = true;
            this.btnChecar.Click += new System.EventHandler(this.BtnChecar_Click);
            // 
            // grbArduinoInfo
            // 
            this.grbArduinoInfo.Controls.Add(this.lblChuvaTexto);
            this.grbArduinoInfo.Controls.Add(this.lblUmidadeTexto);
            this.grbArduinoInfo.Controls.Add(this.lblTemperaturaTexto);
            this.grbArduinoInfo.Controls.Add(this.lblChuva);
            this.grbArduinoInfo.Controls.Add(this.lblUmidade);
            this.grbArduinoInfo.Controls.Add(this.lblTemperatura);
            this.grbArduinoInfo.Location = new System.Drawing.Point(12, 12);
            this.grbArduinoInfo.Name = "grbArduinoInfo";
            this.grbArduinoInfo.Size = new System.Drawing.Size(211, 222);
            this.grbArduinoInfo.TabIndex = 2;
            this.grbArduinoInfo.TabStop = false;
            this.grbArduinoInfo.Text = "Informações Arduíno";
            // 
            // lblChuvaTexto
            // 
            this.lblChuvaTexto.AutoSize = true;
            this.lblChuvaTexto.Location = new System.Drawing.Point(49, 168);
            this.lblChuvaTexto.Name = "lblChuvaTexto";
            this.lblChuvaTexto.Size = new System.Drawing.Size(106, 13);
            this.lblChuvaTexto.TabIndex = 5;
            this.lblChuvaTexto.Text = "Preciptação Arduino:";
            // 
            // lblUmidadeTexto
            // 
            this.lblUmidadeTexto.AutoSize = true;
            this.lblUmidadeTexto.Location = new System.Drawing.Point(48, 99);
            this.lblUmidadeTexto.Name = "lblUmidadeTexto";
            this.lblUmidadeTexto.Size = new System.Drawing.Size(91, 13);
            this.lblUmidadeTexto.TabIndex = 4;
            this.lblUmidadeTexto.Text = "Umidade Arduino:";
            // 
            // lblTemperaturaTexto
            // 
            this.lblTemperaturaTexto.AutoSize = true;
            this.lblTemperaturaTexto.Location = new System.Drawing.Point(49, 36);
            this.lblTemperaturaTexto.Name = "lblTemperaturaTexto";
            this.lblTemperaturaTexto.Size = new System.Drawing.Size(109, 13);
            this.lblTemperaturaTexto.TabIndex = 3;
            this.lblTemperaturaTexto.Text = "Temperatura Arduino:";
            // 
            // lblChuva
            // 
            this.lblChuva.AutoSize = true;
            this.lblChuva.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblChuva.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuva.Location = new System.Drawing.Point(47, 181);
            this.lblChuva.Name = "lblChuva";
            this.lblChuva.Size = new System.Drawing.Size(84, 26);
            this.lblChuva.TabIndex = 2;
            this.lblChuva.Text = "------------";
            // 
            // lblUmidade
            // 
            this.lblUmidade.AutoSize = true;
            this.lblUmidade.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUmidade.Location = new System.Drawing.Point(47, 112);
            this.lblUmidade.Name = "lblUmidade";
            this.lblUmidade.Size = new System.Drawing.Size(36, 26);
            this.lblUmidade.TabIndex = 1;
            this.lblUmidade.Text = "----";
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatura.Location = new System.Drawing.Point(47, 49);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(36, 26);
            this.lblTemperatura.TabIndex = 0;
            this.lblTemperatura.Text = "----";
            // 
            // btnConfig
            // 
            this.btnConfig.Location = new System.Drawing.Point(254, 111);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(100, 30);
            this.btnConfig.TabIndex = 2;
            this.btnConfig.Text = "Configurações";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.BtnConfig_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(254, 157);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 30);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // TimerArduino
            // 
            this.TimerArduino.Interval = 60000;
            this.TimerArduino.Tick += new System.EventHandler(this.TimerArduino_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 247);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.grbArduinoInfo);
            this.Controls.Add(this.btnChecar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitoramento Arduíno";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.grbArduinoInfo.ResumeLayout(false);
            this.grbArduinoInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnChecar;
        private System.Windows.Forms.GroupBox grbArduinoInfo;
        private System.Windows.Forms.Label lblChuvaTexto;
        private System.Windows.Forms.Label lblUmidadeTexto;
        private System.Windows.Forms.Label lblTemperaturaTexto;
        private System.Windows.Forms.Label lblChuva;
        private System.Windows.Forms.Label lblUmidade;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Timer TimerArduino;
    }
}


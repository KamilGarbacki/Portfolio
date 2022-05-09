namespace Gra_memory
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblCzas = new System.Windows.Forms.Label();
            this.lblCzasWartosc = new System.Windows.Forms.Label();
            this.lblPunkty = new System.Windows.Forms.Label();
            this.lblPunktyWartosc = new System.Windows.Forms.Label();
            this.lblStartInfo = new System.Windows.Forms.Label();
            this.PanelKart = new System.Windows.Forms.Panel();
            this.TimerCzasGry = new System.Windows.Forms.Timer(this.components);
            this.TimerZakrywacz = new System.Windows.Forms.Timer(this.components);
            this.TimerCzasPodglandu = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblCzas
            // 
            this.lblCzas.AutoSize = true;
            this.lblCzas.Location = new System.Drawing.Point(30, 9);
            this.lblCzas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCzas.Name = "lblCzas";
            this.lblCzas.Size = new System.Drawing.Size(45, 20);
            this.lblCzas.TabIndex = 0;
            this.lblCzas.Text = "Czas";
            // 
            // lblCzasWartosc
            // 
            this.lblCzasWartosc.AutoSize = true;
            this.lblCzasWartosc.Location = new System.Drawing.Point(133, 9);
            this.lblCzasWartosc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCzasWartosc.Name = "lblCzasWartosc";
            this.lblCzasWartosc.Size = new System.Drawing.Size(18, 20);
            this.lblCzasWartosc.TabIndex = 1;
            this.lblCzasWartosc.Text = "0";
            // 
            // lblPunkty
            // 
            this.lblPunkty.AutoSize = true;
            this.lblPunkty.Location = new System.Drawing.Point(231, 9);
            this.lblPunkty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPunkty.Name = "lblPunkty";
            this.lblPunkty.Size = new System.Drawing.Size(57, 20);
            this.lblPunkty.TabIndex = 2;
            this.lblPunkty.Text = "Punkty";
            // 
            // lblPunktyWartosc
            // 
            this.lblPunktyWartosc.AutoSize = true;
            this.lblPunktyWartosc.Location = new System.Drawing.Point(420, 9);
            this.lblPunktyWartosc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPunktyWartosc.Name = "lblPunktyWartosc";
            this.lblPunktyWartosc.Size = new System.Drawing.Size(18, 20);
            this.lblPunktyWartosc.TabIndex = 3;
            this.lblPunktyWartosc.Text = "0";
            // 
            // lblStartInfo
            // 
            this.lblStartInfo.AutoSize = true;
            this.lblStartInfo.Location = new System.Drawing.Point(565, 9);
            this.lblStartInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartInfo.Name = "lblStartInfo";
            this.lblStartInfo.Size = new System.Drawing.Size(138, 20);
            this.lblStartInfo.TabIndex = 4;
            this.lblStartInfo.Text = "Początek gry za: 5";
            // 
            // PanelKart
            // 
            this.PanelKart.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PanelKart.Location = new System.Drawing.Point(16, 59);
            this.PanelKart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelKart.Name = "PanelKart";
            this.PanelKart.Size = new System.Drawing.Size(974, 64);
            this.PanelKart.TabIndex = 5;
            this.PanelKart.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelKart_Paint);
            // 
            // TimerCzasGry
            // 
            this.TimerCzasGry.Interval = 1000;
            this.TimerCzasGry.Tick += new System.EventHandler(this.TimerCzasGry_Tick);
            // 
            // TimerZakrywacz
            // 
            this.TimerZakrywacz.Interval = 3000;
            this.TimerZakrywacz.Tick += new System.EventHandler(this.TimerZakrywacz_Tick);
            // 
            // TimerCzasPodglandu
            // 
            this.TimerCzasPodglandu.Interval = 1000;
            this.TimerCzasPodglandu.Tick += new System.EventHandler(this.TimerCzasPodglandu_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1003, 173);
            this.Controls.Add(this.PanelKart);
            this.Controls.Add(this.lblStartInfo);
            this.Controls.Add(this.lblPunktyWartosc);
            this.Controls.Add(this.lblPunkty);
            this.Controls.Add(this.lblCzasWartosc);
            this.Controls.Add(this.lblCzas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCzas;
        private System.Windows.Forms.Label lblCzasWartosc;
        private System.Windows.Forms.Label lblPunkty;
        private System.Windows.Forms.Label lblPunktyWartosc;
        private System.Windows.Forms.Label lblStartInfo;
        private System.Windows.Forms.Panel PanelKart;
        private System.Windows.Forms.Timer TimerCzasGry;
        private System.Windows.Forms.Timer TimerZakrywacz;
        private System.Windows.Forms.Timer TimerCzasPodglandu;
    }
}


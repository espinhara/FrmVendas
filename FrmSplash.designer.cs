namespace WfaVendas
{
    partial class FrmSplash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSplash));
            this.pgbSplash = new System.Windows.Forms.ProgressBar();
            this.tmrProgresso = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblNomeSistema = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pgbSplash
            // 
            this.pgbSplash.Location = new System.Drawing.Point(-3, 614);
            this.pgbSplash.Name = "pgbSplash";
            this.pgbSplash.Size = new System.Drawing.Size(640, 23);
            this.pgbSplash.TabIndex = 1;
            // 
            // tmrProgresso
            // 
            this.tmrProgresso.Enabled = true;
            this.tmrProgresso.Interval = 300;
            this.tmrProgresso.Tick += new System.EventHandler(this.tmrProgresso_Tick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(-3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(640, 611);
            this.label2.TabIndex = 0;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNomeSistema
            // 
            this.lblNomeSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeSistema.ForeColor = System.Drawing.Color.Maroon;
            this.lblNomeSistema.Location = new System.Drawing.Point(117, 364);
            this.lblNomeSistema.Name = "lblNomeSistema";
            this.lblNomeSistema.Size = new System.Drawing.Size(398, 70);
            this.lblNomeSistema.TabIndex = 2;
            this.lblNomeSistema.Text = "Controle de Vendas";
            this.lblNomeSistema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 640);
            this.ControlBox = false;
            this.Controls.Add(this.lblNomeSistema);
            this.Controls.Add(this.pgbSplash);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSplash";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSplash";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar pgbSplash;
        private System.Windows.Forms.Timer tmrProgresso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNomeSistema;
    }
}
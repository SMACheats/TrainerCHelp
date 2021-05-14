
namespace ExampleTrainerC
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddAmmo = new System.Windows.Forms.Button();
            this.FrezzeAmmo = new System.Windows.Forms.CheckBox();
            this.XTrackbar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.YTrackbar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.ZTrackbar = new System.Windows.Forms.TrackBar();
            this.BackgroundCheats = new System.ComponentModel.BackgroundWorker();
            this.XModifer = new System.Windows.Forms.CheckBox();
            this.YModifer = new System.Windows.Forms.CheckBox();
            this.ZModifer = new System.Windows.Forms.CheckBox();
            this.AllAmmo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.XTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // AddAmmo
            // 
            this.AddAmmo.Location = new System.Drawing.Point(12, 12);
            this.AddAmmo.Name = "AddAmmo";
            this.AddAmmo.Size = new System.Drawing.Size(95, 37);
            this.AddAmmo.TabIndex = 0;
            this.AddAmmo.Text = "Add Ammo";
            this.AddAmmo.UseVisualStyleBackColor = true;
            this.AddAmmo.Click += new System.EventHandler(this.AddAmmo_Click);
            // 
            // FrezzeAmmo
            // 
            this.FrezzeAmmo.AutoSize = true;
            this.FrezzeAmmo.Location = new System.Drawing.Point(113, 12);
            this.FrezzeAmmo.Name = "FrezzeAmmo";
            this.FrezzeAmmo.Size = new System.Drawing.Size(89, 17);
            this.FrezzeAmmo.TabIndex = 1;
            this.FrezzeAmmo.Text = "Frezze Ammo";
            this.FrezzeAmmo.UseVisualStyleBackColor = true;
            this.FrezzeAmmo.CheckedChanged += new System.EventHandler(this.FrezzeAmmo_CheckedChanged);
            // 
            // XTrackbar
            // 
            this.XTrackbar.Location = new System.Drawing.Point(12, 372);
            this.XTrackbar.Maximum = 1000000;
            this.XTrackbar.Minimum = -1000000;
            this.XTrackbar.Name = "XTrackbar";
            this.XTrackbar.Size = new System.Drawing.Size(204, 45);
            this.XTrackbar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "X Coord";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y Coord";
            // 
            // YTrackbar
            // 
            this.YTrackbar.Location = new System.Drawing.Point(12, 436);
            this.YTrackbar.Maximum = 1000000;
            this.YTrackbar.Minimum = -1000000;
            this.YTrackbar.Name = "YTrackbar";
            this.YTrackbar.Size = new System.Drawing.Size(204, 45);
            this.YTrackbar.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Z Coord";
            // 
            // ZTrackbar
            // 
            this.ZTrackbar.Location = new System.Drawing.Point(12, 500);
            this.ZTrackbar.Maximum = 1000000;
            this.ZTrackbar.Minimum = -1000000;
            this.ZTrackbar.Name = "ZTrackbar";
            this.ZTrackbar.Size = new System.Drawing.Size(204, 45);
            this.ZTrackbar.TabIndex = 6;
            // 
            // BackgroundCheats
            // 
            this.BackgroundCheats.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundCheats_DoWork);
            // 
            // XModifer
            // 
            this.XModifer.AutoSize = true;
            this.XModifer.Location = new System.Drawing.Point(109, 355);
            this.XModifer.Name = "XModifer";
            this.XModifer.Size = new System.Drawing.Size(107, 17);
            this.XModifer.TabIndex = 8;
            this.XModifer.Text = "X Coords Modifer";
            this.XModifer.UseVisualStyleBackColor = true;
            // 
            // YModifer
            // 
            this.YModifer.AutoSize = true;
            this.YModifer.Location = new System.Drawing.Point(109, 419);
            this.YModifer.Name = "YModifer";
            this.YModifer.Size = new System.Drawing.Size(107, 17);
            this.YModifer.TabIndex = 9;
            this.YModifer.Text = "Y Coords Modifer";
            this.YModifer.UseVisualStyleBackColor = true;
            // 
            // ZModifer
            // 
            this.ZModifer.AutoSize = true;
            this.ZModifer.Location = new System.Drawing.Point(109, 483);
            this.ZModifer.Name = "ZModifer";
            this.ZModifer.Size = new System.Drawing.Size(107, 17);
            this.ZModifer.TabIndex = 10;
            this.ZModifer.Text = "Z Coords Modifer";
            this.ZModifer.UseVisualStyleBackColor = true;
            // 
            // AllAmmo
            // 
            this.AllAmmo.AutoSize = true;
            this.AllAmmo.Location = new System.Drawing.Point(113, 32);
            this.AllAmmo.Name = "AllAmmo";
            this.AllAmmo.Size = new System.Drawing.Size(103, 17);
            this.AllAmmo.TabIndex = 11;
            this.AllAmmo.Text = "Frezze All Ammo";
            this.AllAmmo.UseVisualStyleBackColor = true;
            this.AllAmmo.CheckedChanged += new System.EventHandler(this.AllAmmo_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 557);
            this.Controls.Add(this.AllAmmo);
            this.Controls.Add(this.ZModifer);
            this.Controls.Add(this.YModifer);
            this.Controls.Add(this.XModifer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ZTrackbar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.YTrackbar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.XTrackbar);
            this.Controls.Add(this.FrezzeAmmo);
            this.Controls.Add(this.AddAmmo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Example Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.XTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZTrackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddAmmo;
        private System.Windows.Forms.CheckBox FrezzeAmmo;
        private System.Windows.Forms.TrackBar XTrackbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar YTrackbar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar ZTrackbar;
        private System.ComponentModel.BackgroundWorker BackgroundCheats;
        private System.Windows.Forms.CheckBox XModifer;
        private System.Windows.Forms.CheckBox YModifer;
        private System.Windows.Forms.CheckBox ZModifer;
        private System.Windows.Forms.CheckBox AllAmmo;
    }
}


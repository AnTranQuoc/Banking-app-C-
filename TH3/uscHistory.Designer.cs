namespace TH3
{
    partial class uscHistory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uscHistory));
            this.label1_date = new System.Windows.Forms.Label();
            this.label2_noidung = new System.Windows.Forms.Label();
            this.label3_Sotien = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1_date
            // 
            this.label1_date.AutoSize = true;
            this.label1_date.BackColor = System.Drawing.Color.Transparent;
            this.label1_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_date.Location = new System.Drawing.Point(7, 4);
            this.label1_date.Name = "label1_date";
            this.label1_date.Size = new System.Drawing.Size(38, 16);
            this.label1_date.TabIndex = 0;
            this.label1_date.Text = "date";
            this.label1_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2_noidung
            // 
            this.label2_noidung.AutoSize = true;
            this.label2_noidung.BackColor = System.Drawing.Color.Transparent;
            this.label2_noidung.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_noidung.Location = new System.Drawing.Point(7, 26);
            this.label2_noidung.Name = "label2_noidung";
            this.label2_noidung.Size = new System.Drawing.Size(62, 16);
            this.label2_noidung.TabIndex = 1;
            this.label2_noidung.Text = "noidung";
            this.label2_noidung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3_Sotien
            // 
            this.label3_Sotien.BackColor = System.Drawing.Color.Transparent;
            this.label3_Sotien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3_Sotien.ForeColor = System.Drawing.Color.Black;
            this.label3_Sotien.Location = new System.Drawing.Point(214, 26);
            this.label3_Sotien.Name = "label3_Sotien";
            this.label3_Sotien.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3_Sotien.Size = new System.Drawing.Size(101, 16);
            this.label3_Sotien.TabIndex = 2;
            this.label3_Sotien.Text = "sotien";
            // 
            // uscHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label3_Sotien);
            this.Controls.Add(this.label2_noidung);
            this.Controls.Add(this.label1_date);
            this.DoubleBuffered = true;
            this.Name = "uscHistory";
            this.Size = new System.Drawing.Size(328, 54);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_date;
        private System.Windows.Forms.Label label2_noidung;
        private System.Windows.Forms.Label label3_Sotien;
    }
}

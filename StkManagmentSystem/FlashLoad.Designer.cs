namespace StkManagmentSystem
{
    partial class FlashLoad
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
            this.loadingLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadingLable
            // 
            this.loadingLable.AutoSize = true;
            this.loadingLable.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingLable.Location = new System.Drawing.Point(114, 121);
            this.loadingLable.Name = "loadingLable";
            this.loadingLable.Size = new System.Drawing.Size(254, 22);
            this.loadingLable.TabIndex = 0;
            this.loadingLable.Text = "Loading to  Dashboard Form....";
            this.loadingLable.Click += new System.EventHandler(this.loadingLable_Click);
            // 
            // FlashLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(483, 293);
            this.Controls.Add(this.loadingLable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlashLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loadingLable;
    }
}


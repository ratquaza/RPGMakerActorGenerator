
namespace RPGMakerSpriteTools
{
    partial class RMSTMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RMSTMenu));
            this.OpenFaceMenu = new System.Windows.Forms.Button();
            this.OpenIconMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenFaceMenu
            // 
            this.OpenFaceMenu.Location = new System.Drawing.Point(13, 13);
            this.OpenFaceMenu.Name = "OpenFaceMenu";
            this.OpenFaceMenu.Size = new System.Drawing.Size(403, 80);
            this.OpenFaceMenu.TabIndex = 0;
            this.OpenFaceMenu.Text = "Face Menu";
            this.OpenFaceMenu.UseVisualStyleBackColor = true;
            this.OpenFaceMenu.Click += new System.EventHandler(this.OpenFaceMenu_Click);
            // 
            // OpenIconMenu
            // 
            this.OpenIconMenu.Location = new System.Drawing.Point(13, 99);
            this.OpenIconMenu.Name = "OpenIconMenu";
            this.OpenIconMenu.Size = new System.Drawing.Size(403, 80);
            this.OpenIconMenu.TabIndex = 1;
            this.OpenIconMenu.Text = "Iconset Menu";
            this.OpenIconMenu.UseVisualStyleBackColor = true;
            this.OpenIconMenu.Click += new System.EventHandler(this.OpenIconMenu_Click);
            // 
            // RMSTMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 196);
            this.Controls.Add(this.OpenIconMenu);
            this.Controls.Add(this.OpenFaceMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RMSTMenu";
            this.Text = "RMST";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenFaceMenu;
        private System.Windows.Forms.Button OpenIconMenu;
    }
}
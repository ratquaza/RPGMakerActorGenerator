
namespace RPGMakerSpriteTools
{
    partial class IconsetGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IconsetGenerator));
            this.SourceDirLabel = new System.Windows.Forms.Label();
            this.SourceDirText = new System.Windows.Forms.TextBox();
            this.SourceDirButton = new System.Windows.Forms.Button();
            this.OutputDirLabel = new System.Windows.Forms.Label();
            this.OutputDirText = new System.Windows.Forms.TextBox();
            this.OutputDirButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.StatusText = new System.Windows.Forms.Label();
            this.FormatLabel = new System.Windows.Forms.Label();
            this.ExtensionInput = new System.Windows.Forms.TextBox();
            this.AreNumbered = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SourceDirLabel
            // 
            this.SourceDirLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SourceDirLabel.Location = new System.Drawing.Point(12, 15);
            this.SourceDirLabel.Name = "SourceDirLabel";
            this.SourceDirLabel.Size = new System.Drawing.Size(81, 19);
            this.SourceDirLabel.TabIndex = 0;
            this.SourceDirLabel.Text = "Source Dir:";
            this.SourceDirLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SourceDirText
            // 
            this.SourceDirText.Location = new System.Drawing.Point(85, 12);
            this.SourceDirText.Name = "SourceDirText";
            this.SourceDirText.ReadOnly = true;
            this.SourceDirText.Size = new System.Drawing.Size(260, 20);
            this.SourceDirText.TabIndex = 1;
            // 
            // SourceDirButton
            // 
            this.SourceDirButton.Location = new System.Drawing.Point(351, 12);
            this.SourceDirButton.Name = "SourceDirButton";
            this.SourceDirButton.Size = new System.Drawing.Size(75, 20);
            this.SourceDirButton.TabIndex = 2;
            this.SourceDirButton.Text = "Select";
            this.SourceDirButton.UseVisualStyleBackColor = true;
            this.SourceDirButton.Click += new System.EventHandler(this.SourceDirButton_Click);
            // 
            // OutputDirLabel
            // 
            this.OutputDirLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OutputDirLabel.Location = new System.Drawing.Point(12, 40);
            this.OutputDirLabel.Name = "OutputDirLabel";
            this.OutputDirLabel.Size = new System.Drawing.Size(81, 19);
            this.OutputDirLabel.TabIndex = 3;
            this.OutputDirLabel.Text = "Output File:";
            this.OutputDirLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OutputDirText
            // 
            this.OutputDirText.Location = new System.Drawing.Point(85, 37);
            this.OutputDirText.Name = "OutputDirText";
            this.OutputDirText.ReadOnly = true;
            this.OutputDirText.Size = new System.Drawing.Size(260, 20);
            this.OutputDirText.TabIndex = 4;
            // 
            // OutputDirButton
            // 
            this.OutputDirButton.Location = new System.Drawing.Point(351, 37);
            this.OutputDirButton.Name = "OutputDirButton";
            this.OutputDirButton.Size = new System.Drawing.Size(75, 20);
            this.OutputDirButton.TabIndex = 5;
            this.OutputDirButton.Text = "Select";
            this.OutputDirButton.UseVisualStyleBackColor = true;
            this.OutputDirButton.Click += new System.EventHandler(this.OutputDirButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Enabled = false;
            this.StartButton.Location = new System.Drawing.Point(15, 145);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(411, 88);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StatusText
            // 
            this.StatusText.Location = new System.Drawing.Point(15, 236);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(411, 37);
            this.StatusText.TabIndex = 7;
            this.StatusText.Text = "Status";
            this.StatusText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StatusText.Visible = false;
            // 
            // FormatLabel
            // 
            this.FormatLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FormatLabel.Location = new System.Drawing.Point(12, 64);
            this.FormatLabel.Name = "FormatLabel";
            this.FormatLabel.Size = new System.Drawing.Size(78, 19);
            this.FormatLabel.TabIndex = 8;
            this.FormatLabel.Text = "Extension: ";
            this.FormatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ExtensionInput
            // 
            this.ExtensionInput.Location = new System.Drawing.Point(85, 63);
            this.ExtensionInput.Name = "ExtensionInput";
            this.ExtensionInput.Size = new System.Drawing.Size(66, 20);
            this.ExtensionInput.TabIndex = 9;
            this.ExtensionInput.Text = "png";
            this.ExtensionInput.TextChanged += new System.EventHandler(this.ExtensionInput_TextChanged);
            // 
            // AreNumbered
            // 
            this.AreNumbered.AutoSize = true;
            this.AreNumbered.Location = new System.Drawing.Point(272, 66);
            this.AreNumbered.Name = "AreNumbered";
            this.AreNumbered.Size = new System.Drawing.Size(154, 17);
            this.AreNumbered.TabIndex = 10;
            this.AreNumbered.Text = "Source Files are Numbered";
            this.AreNumbered.UseVisualStyleBackColor = true;
            // 
            // IconsetGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 294);
            this.Controls.Add(this.AreNumbered);
            this.Controls.Add(this.ExtensionInput);
            this.Controls.Add(this.FormatLabel);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.OutputDirButton);
            this.Controls.Add(this.OutputDirText);
            this.Controls.Add(this.OutputDirLabel);
            this.Controls.Add(this.SourceDirButton);
            this.Controls.Add(this.SourceDirText);
            this.Controls.Add(this.SourceDirLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IconsetGenerator";
            this.Text = "RMST Iconset Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SourceDirLabel;
        private System.Windows.Forms.TextBox SourceDirText;
        private System.Windows.Forms.Button SourceDirButton;
        private Ookii.Dialogs.Wpf.VistaFolderBrowserDialog SourceDirDialog = new Ookii.Dialogs.Wpf.VistaFolderBrowserDialog();
        private string SelectedInputDir;
        private System.Windows.Forms.Label OutputDirLabel;
        private System.Windows.Forms.TextBox OutputDirText;
        private System.Windows.Forms.Button OutputDirButton;
        private Ookii.Dialogs.Wpf.VistaSaveFileDialog OutputDirDialog = new Ookii.Dialogs.Wpf.VistaSaveFileDialog();
        private string SelectedOutputDir;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label StatusText;
        private System.Windows.Forms.Label FormatLabel;
        private System.Windows.Forms.TextBox ExtensionInput;
        private System.Windows.Forms.CheckBox AreNumbered;
    }
}


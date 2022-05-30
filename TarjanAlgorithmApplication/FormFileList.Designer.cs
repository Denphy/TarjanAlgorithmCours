namespace TarjanAlgorithmApplication
{
    partial class FormFileList
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
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.textOutput = new System.Windows.Forms.RichTextBox();
            this.panelHeaderFileList = new System.Windows.Forms.Panel();
            this.textHeaderFileList = new System.Windows.Forms.RichTextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelHeaderFileList.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSelectFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(44)))), ((int)(((byte)(26)))));
            this.buttonSelectFile.FlatAppearance.BorderSize = 0;
            this.buttonSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelectFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSelectFile.Location = new System.Drawing.Point(375, 180);
            this.buttonSelectFile.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(297, 41);
            this.buttonSelectFile.TabIndex = 4;
            this.buttonSelectFile.Text = "Выбрать файл";
            this.buttonSelectFile.UseVisualStyleBackColor = false;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // textOutput
            // 
            this.textOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(44)))), ((int)(((byte)(26)))));
            this.textOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textOutput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textOutput.Location = new System.Drawing.Point(38, 304);
            this.textOutput.Name = "textOutput";
            this.textOutput.ReadOnly = true;
            this.textOutput.Size = new System.Drawing.Size(971, 493);
            this.textOutput.TabIndex = 3;
            this.textOutput.Text = "";
            // 
            // panelHeaderFileList
            // 
            this.panelHeaderFileList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelHeaderFileList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(44)))), ((int)(((byte)(26)))));
            this.panelHeaderFileList.Controls.Add(this.textHeaderFileList);
            this.panelHeaderFileList.Location = new System.Drawing.Point(290, 33);
            this.panelHeaderFileList.Name = "panelHeaderFileList";
            this.panelHeaderFileList.Padding = new System.Windows.Forms.Padding(10);
            this.panelHeaderFileList.Size = new System.Drawing.Size(467, 59);
            this.panelHeaderFileList.TabIndex = 5;
            // 
            // textHeaderFileList
            // 
            this.textHeaderFileList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(44)))), ((int)(((byte)(26)))));
            this.textHeaderFileList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textHeaderFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textHeaderFileList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textHeaderFileList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textHeaderFileList.Location = new System.Drawing.Point(10, 10);
            this.textHeaderFileList.Name = "textHeaderFileList";
            this.textHeaderFileList.ReadOnly = true;
            this.textHeaderFileList.Size = new System.Drawing.Size(447, 39);
            this.textHeaderFileList.TabIndex = 0;
            this.textHeaderFileList.Text = "Ввод из файла (список смежности)";
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(44)))), ((int)(((byte)(26)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.iconButton1.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(950, 33);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(59, 59);
            this.iconButton1.TabIndex = 13;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // FormFileList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(79)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1047, 833);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.panelHeaderFileList);
            this.Controls.Add(this.buttonSelectFile);
            this.Controls.Add(this.textOutput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormFileList";
            this.Text = "FormFileList";
            this.panelHeaderFileList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.RichTextBox textOutput;
        private System.Windows.Forms.Panel panelHeaderFileList;
        private System.Windows.Forms.RichTextBox textHeaderFileList;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
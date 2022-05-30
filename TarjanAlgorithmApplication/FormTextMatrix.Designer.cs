namespace TarjanAlgorithmApplication
{
    partial class FormTextMatrix
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
            this.textOutput = new System.Windows.Forms.RichTextBox();
            this.textInput = new System.Windows.Forms.RichTextBox();
            this.buttonFindComponents = new System.Windows.Forms.Button();
            this.panelHeaderFileList = new System.Windows.Forms.Panel();
            this.textHeaderFileList = new System.Windows.Forms.RichTextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelHeaderFileList.SuspendLayout();
            this.SuspendLayout();
            // 
            // textOutput
            // 
            this.textOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(44)))), ((int)(((byte)(26)))));
            this.textOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textOutput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textOutput.Location = new System.Drawing.Point(38, 472);
            this.textOutput.Name = "textOutput";
            this.textOutput.ReadOnly = true;
            this.textOutput.Size = new System.Drawing.Size(971, 291);
            this.textOutput.TabIndex = 13;
            this.textOutput.Text = "";
            // 
            // textInput
            // 
            this.textInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(44)))), ((int)(((byte)(26)))));
            this.textInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textInput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textInput.Location = new System.Drawing.Point(38, 111);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(971, 291);
            this.textInput.TabIndex = 12;
            this.textInput.Text = "";
            // 
            // buttonFindComponents
            // 
            this.buttonFindComponents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFindComponents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(44)))), ((int)(((byte)(26)))));
            this.buttonFindComponents.FlatAppearance.BorderSize = 0;
            this.buttonFindComponents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFindComponents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFindComponents.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFindComponents.Location = new System.Drawing.Point(317, 421);
            this.buttonFindComponents.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFindComponents.Name = "buttonFindComponents";
            this.buttonFindComponents.Size = new System.Drawing.Size(413, 34);
            this.buttonFindComponents.TabIndex = 11;
            this.buttonFindComponents.Text = "Найти компоненты сильной связности";
            this.buttonFindComponents.UseVisualStyleBackColor = false;
            this.buttonFindComponents.Click += new System.EventHandler(this.buttonFindComponents_Click);
            // 
            // panelHeaderFileList
            // 
            this.panelHeaderFileList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelHeaderFileList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(44)))), ((int)(((byte)(26)))));
            this.panelHeaderFileList.Controls.Add(this.textHeaderFileList);
            this.panelHeaderFileList.Location = new System.Drawing.Point(295, 33);
            this.panelHeaderFileList.Name = "panelHeaderFileList";
            this.panelHeaderFileList.Padding = new System.Windows.Forms.Padding(10);
            this.panelHeaderFileList.Size = new System.Drawing.Size(457, 59);
            this.panelHeaderFileList.TabIndex = 14;
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
            this.textHeaderFileList.Size = new System.Drawing.Size(437, 39);
            this.textHeaderFileList.TabIndex = 0;
            this.textHeaderFileList.Text = "Ручной ввод (матрица смежности)";
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
            this.iconButton1.TabIndex = 15;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // FormTextMatrix
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(79)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1047, 833);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.panelHeaderFileList);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.buttonFindComponents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTextMatrix";
            this.Text = "FormTextMatrix";
            this.panelHeaderFileList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textOutput;
        private System.Windows.Forms.RichTextBox textInput;
        private System.Windows.Forms.Button buttonFindComponents;
        private System.Windows.Forms.Panel panelHeaderFileList;
        private System.Windows.Forms.RichTextBox textHeaderFileList;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
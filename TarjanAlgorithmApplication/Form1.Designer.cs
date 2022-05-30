namespace TarjanAlgorithmApplication
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelTextSubmenu = new System.Windows.Forms.Panel();
            this.buttonTextList = new System.Windows.Forms.Button();
            this.buttonTextMatrix = new System.Windows.Forms.Button();
            this.buttonTextInput = new FontAwesome.Sharp.IconButton();
            this.panelFileSubmenu = new System.Windows.Forms.Panel();
            this.buttonFileList = new System.Windows.Forms.Button();
            this.buttonFileMatrix = new System.Windows.Forms.Button();
            this.buttonFileInput = new FontAwesome.Sharp.IconButton();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelTextSubmenu.SuspendLayout();
            this.panelFileSubmenu.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelChildForm.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(44)))), ((int)(((byte)(26)))));
            this.panelSideMenu.Controls.Add(this.panelTextSubmenu);
            this.panelSideMenu.Controls.Add(this.buttonTextInput);
            this.panelSideMenu.Controls.Add(this.panelFileSubmenu);
            this.panelSideMenu.Controls.Add(this.buttonFileInput);
            this.panelSideMenu.Controls.Add(this.panelHeader);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(313, 833);
            this.panelSideMenu.TabIndex = 4;
            // 
            // panelTextSubmenu
            // 
            this.panelTextSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(54)))), ((int)(((byte)(33)))));
            this.panelTextSubmenu.Controls.Add(this.buttonTextList);
            this.panelTextSubmenu.Controls.Add(this.buttonTextMatrix);
            this.panelTextSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTextSubmenu.Location = new System.Drawing.Point(0, 378);
            this.panelTextSubmenu.Name = "panelTextSubmenu";
            this.panelTextSubmenu.Size = new System.Drawing.Size(313, 114);
            this.panelTextSubmenu.TabIndex = 8;
            // 
            // buttonTextList
            // 
            this.buttonTextList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(54)))), ((int)(((byte)(33)))));
            this.buttonTextList.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTextList.FlatAppearance.BorderSize = 0;
            this.buttonTextList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.buttonTextList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.buttonTextList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTextList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTextList.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonTextList.Location = new System.Drawing.Point(0, 57);
            this.buttonTextList.Name = "buttonTextList";
            this.buttonTextList.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonTextList.Size = new System.Drawing.Size(313, 57);
            this.buttonTextList.TabIndex = 9;
            this.buttonTextList.Text = "Список смежности";
            this.buttonTextList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTextList.UseVisualStyleBackColor = false;
            this.buttonTextList.Click += new System.EventHandler(this.buttonTextList_Click);
            // 
            // buttonTextMatrix
            // 
            this.buttonTextMatrix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(54)))), ((int)(((byte)(33)))));
            this.buttonTextMatrix.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTextMatrix.FlatAppearance.BorderSize = 0;
            this.buttonTextMatrix.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.buttonTextMatrix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.buttonTextMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTextMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTextMatrix.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonTextMatrix.Location = new System.Drawing.Point(0, 0);
            this.buttonTextMatrix.Name = "buttonTextMatrix";
            this.buttonTextMatrix.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonTextMatrix.Size = new System.Drawing.Size(313, 57);
            this.buttonTextMatrix.TabIndex = 9;
            this.buttonTextMatrix.Text = "Матрица смежности";
            this.buttonTextMatrix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTextMatrix.UseVisualStyleBackColor = false;
            this.buttonTextMatrix.Click += new System.EventHandler(this.buttonTextMatrix_Click);
            // 
            // buttonTextInput
            // 
            this.buttonTextInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTextInput.FlatAppearance.BorderSize = 0;
            this.buttonTextInput.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(54)))), ((int)(((byte)(33)))));
            this.buttonTextInput.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(54)))), ((int)(((byte)(33)))));
            this.buttonTextInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTextInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTextInput.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.buttonTextInput.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTextInput.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonTextInput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTextInput.Location = new System.Drawing.Point(0, 311);
            this.buttonTextInput.Name = "buttonTextInput";
            this.buttonTextInput.Size = new System.Drawing.Size(313, 67);
            this.buttonTextInput.TabIndex = 7;
            this.buttonTextInput.Text = "Ручной ввод";
            this.buttonTextInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTextInput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTextInput.UseVisualStyleBackColor = true;
            this.buttonTextInput.Click += new System.EventHandler(this.buttonTextInput_Click);
            // 
            // panelFileSubmenu
            // 
            this.panelFileSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(54)))), ((int)(((byte)(33)))));
            this.panelFileSubmenu.Controls.Add(this.buttonFileList);
            this.panelFileSubmenu.Controls.Add(this.buttonFileMatrix);
            this.panelFileSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFileSubmenu.Location = new System.Drawing.Point(0, 197);
            this.panelFileSubmenu.Name = "panelFileSubmenu";
            this.panelFileSubmenu.Size = new System.Drawing.Size(313, 114);
            this.panelFileSubmenu.TabIndex = 6;
            // 
            // buttonFileList
            // 
            this.buttonFileList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(54)))), ((int)(((byte)(33)))));
            this.buttonFileList.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFileList.FlatAppearance.BorderSize = 0;
            this.buttonFileList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.buttonFileList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.buttonFileList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFileList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFileList.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonFileList.Location = new System.Drawing.Point(0, 57);
            this.buttonFileList.Name = "buttonFileList";
            this.buttonFileList.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonFileList.Size = new System.Drawing.Size(313, 57);
            this.buttonFileList.TabIndex = 2;
            this.buttonFileList.Text = "Список смежности";
            this.buttonFileList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFileList.UseVisualStyleBackColor = false;
            this.buttonFileList.Click += new System.EventHandler(this.buttonFileList_Click);
            // 
            // buttonFileMatrix
            // 
            this.buttonFileMatrix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(54)))), ((int)(((byte)(33)))));
            this.buttonFileMatrix.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFileMatrix.FlatAppearance.BorderSize = 0;
            this.buttonFileMatrix.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.buttonFileMatrix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(74)))), ((int)(((byte)(45)))));
            this.buttonFileMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFileMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFileMatrix.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonFileMatrix.Location = new System.Drawing.Point(0, 0);
            this.buttonFileMatrix.Name = "buttonFileMatrix";
            this.buttonFileMatrix.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonFileMatrix.Size = new System.Drawing.Size(313, 57);
            this.buttonFileMatrix.TabIndex = 1;
            this.buttonFileMatrix.Text = "Матрица смежности";
            this.buttonFileMatrix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFileMatrix.UseVisualStyleBackColor = false;
            this.buttonFileMatrix.Click += new System.EventHandler(this.buttonFileMatrix_Click);
            // 
            // buttonFileInput
            // 
            this.buttonFileInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFileInput.FlatAppearance.BorderSize = 0;
            this.buttonFileInput.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(54)))), ((int)(((byte)(33)))));
            this.buttonFileInput.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(54)))), ((int)(((byte)(33)))));
            this.buttonFileInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFileInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFileInput.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            this.buttonFileInput.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFileInput.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonFileInput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFileInput.Location = new System.Drawing.Point(0, 130);
            this.buttonFileInput.Name = "buttonFileInput";
            this.buttonFileInput.Size = new System.Drawing.Size(313, 67);
            this.buttonFileInput.TabIndex = 5;
            this.buttonFileInput.Text = "Ввод из файла";
            this.buttonFileInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFileInput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFileInput.UseVisualStyleBackColor = true;
            this.buttonFileInput.Click += new System.EventHandler(this.buttonFileInput_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.pictureBox2);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(5);
            this.panelHeader.Size = new System.Drawing.Size(313, 130);
            this.panelHeader.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::TarjanAlgorithmApplication.Properties.Resources.logoAlgorithmHigh;
            this.pictureBox2.Location = new System.Drawing.Point(5, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(303, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.AutoSize = true;
            this.panelChildForm.Controls.Add(this.panel1);
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(313, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1047, 833);
            this.panelChildForm.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(44)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(548, 130);
            this.panel1.MaximumSize = new System.Drawing.Size(439, 585);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15);
            this.panel1.Size = new System.Drawing.Size(439, 585);
            this.panel1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(44)))), ((int)(((byte)(26)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.Location = new System.Drawing.Point(15, 15);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(409, 555);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::TarjanAlgorithmApplication.Properties.Resources._402px_Bob_Tarjan;
            this.pictureBox1.Location = new System.Drawing.Point(63, 130);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(406, 585);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 585);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(79)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1360, 833);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarjan\'sAlgorithm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelTextSubmenu.ResumeLayout(false);
            this.panelFileSubmenu.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTextSubmenu;
        private System.Windows.Forms.Button buttonTextList;
        private System.Windows.Forms.Button buttonTextMatrix;
        private FontAwesome.Sharp.IconButton buttonTextInput;
        private System.Windows.Forms.Panel panelFileSubmenu;
        private System.Windows.Forms.Button buttonFileList;
        private System.Windows.Forms.Button buttonFileMatrix;
        private FontAwesome.Sharp.IconButton buttonFileInput;
    }
}


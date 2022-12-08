namespace AmcorFlexibles_Staj
{
    partial class Form1
    {
        
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnLaptopNC = new System.Windows.Forms.Button();
            this.btnDesktopNC = new System.Windows.Forms.Button();
            this.btnLaptopC = new System.Windows.Forms.Button();
            this.btnDesktopC = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.buttonCloseCForm = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelButton.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButton
            // 
            this.panelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(69)))));
            this.panelButton.Controls.Add(this.btnLaptopNC);
            this.panelButton.Controls.Add(this.btnDesktopNC);
            this.panelButton.Controls.Add(this.btnLaptopC);
            this.panelButton.Controls.Add(this.btnDesktopC);
            this.panelButton.Controls.Add(this.panel2);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButton.Location = new System.Drawing.Point(0, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(146, 471);
            this.panelButton.TabIndex = 0;
            // 
            // btnLaptopNC
            // 
            this.btnLaptopNC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLaptopNC.FlatAppearance.BorderSize = 0;
            this.btnLaptopNC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaptopNC.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLaptopNC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLaptopNC.Image = ((System.Drawing.Image)(resources.GetObject("btnLaptopNC.Image")));
            this.btnLaptopNC.Location = new System.Drawing.Point(0, 343);
            this.btnLaptopNC.Name = "btnLaptopNC";
            this.btnLaptopNC.Size = new System.Drawing.Size(146, 88);
            this.btnLaptopNC.TabIndex = 4;
            this.btnLaptopNC.Text = "Amcor Ağında Olmayan Laptoplar";
            this.btnLaptopNC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLaptopNC.UseVisualStyleBackColor = true;
            this.btnLaptopNC.Click += new System.EventHandler(this.btnLaptopNC_Click);
            // 
            // btnDesktopNC
            // 
            this.btnDesktopNC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDesktopNC.FlatAppearance.BorderSize = 0;
            this.btnDesktopNC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesktopNC.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDesktopNC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDesktopNC.Image = ((System.Drawing.Image)(resources.GetObject("btnDesktopNC.Image")));
            this.btnDesktopNC.Location = new System.Drawing.Point(0, 255);
            this.btnDesktopNC.Name = "btnDesktopNC";
            this.btnDesktopNC.Size = new System.Drawing.Size(146, 88);
            this.btnDesktopNC.TabIndex = 3;
            this.btnDesktopNC.Text = "Amcor Ağında Olmayan Desktoplar";
            this.btnDesktopNC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDesktopNC.UseVisualStyleBackColor = true;
            this.btnDesktopNC.Click += new System.EventHandler(this.btnDesktopNC_Click);
            // 
            // btnLaptopC
            // 
            this.btnLaptopC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLaptopC.FlatAppearance.BorderSize = 0;
            this.btnLaptopC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaptopC.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLaptopC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLaptopC.Image = ((System.Drawing.Image)(resources.GetObject("btnLaptopC.Image")));
            this.btnLaptopC.Location = new System.Drawing.Point(0, 167);
            this.btnLaptopC.Name = "btnLaptopC";
            this.btnLaptopC.Size = new System.Drawing.Size(146, 88);
            this.btnLaptopC.TabIndex = 2;
            this.btnLaptopC.Text = "Amcor Ağındaki Laptoplar";
            this.btnLaptopC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLaptopC.UseVisualStyleBackColor = true;
            this.btnLaptopC.Click += new System.EventHandler(this.btnLaptopC_Click);
            // 
            // btnDesktopC
            // 
            this.btnDesktopC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDesktopC.FlatAppearance.BorderSize = 0;
            this.btnDesktopC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesktopC.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDesktopC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDesktopC.Image = ((System.Drawing.Image)(resources.GetObject("btnDesktopC.Image")));
            this.btnDesktopC.Location = new System.Drawing.Point(0, 79);
            this.btnDesktopC.Name = "btnDesktopC";
            this.btnDesktopC.Size = new System.Drawing.Size(146, 88);
            this.btnDesktopC.TabIndex = 1;
            this.btnDesktopC.Text = "Amcor Ağındaki Desktoplar";
            this.btnDesktopC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDesktopC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDesktopC.UseVisualStyleBackColor = true;
            this.btnDesktopC.Click += new System.EventHandler(this.btnDesktopC_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.pbLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 79);
            this.panel2.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(59)))));
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(146, 79);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(120)))));
            this.panelLogo.Controls.Add(this.buttonCloseCForm);
            this.panelLogo.Controls.Add(this.btnClose);
            this.panelLogo.Controls.Add(this.btnMax);
            this.panelLogo.Controls.Add(this.btnMin);
            this.panelLogo.Controls.Add(this.labelTitle);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(146, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(838, 80);
            this.panelLogo.TabIndex = 1;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // buttonCloseCForm
            // 
            this.buttonCloseCForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonCloseCForm.FlatAppearance.BorderSize = 0;
            this.buttonCloseCForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseCForm.Image = global::AmcorFlexibles_Staj.Properties.Resources.close;
            this.buttonCloseCForm.Location = new System.Drawing.Point(0, 0);
            this.buttonCloseCForm.Name = "buttonCloseCForm";
            this.buttonCloseCForm.Size = new System.Drawing.Size(75, 80);
            this.buttonCloseCForm.TabIndex = 2;
            this.buttonCloseCForm.UseVisualStyleBackColor = true;
            this.buttonCloseCForm.Click += new System.EventHandler(this.buttonCloseCForm_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(808, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 26);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "O";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.ForeColor = System.Drawing.Color.Green;
            this.btnMax.Location = new System.Drawing.Point(786, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(30, 26);
            this.btnMax.TabIndex = 1;
            this.btnMax.Text = "O";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnMin.Location = new System.Drawing.Point(766, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(25, 26);
            this.btnMin.TabIndex = 2;
            this.btnMin.Text = "O";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelTitle.Location = new System.Drawing.Point(367, 28);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(94, 24);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Anasayfa";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.Transparent;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(146, 80);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(838, 391);
            this.panelChildForm.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(984, 471);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.panelButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 510);
            this.Name = "Form1";
            this.Text = "Amcor Flexibles ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelButton.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button btnDesktopC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLaptopNC;
        private System.Windows.Forms.Button btnDesktopNC;
        private System.Windows.Forms.Button btnLaptopC;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button buttonCloseCForm;
    }
}


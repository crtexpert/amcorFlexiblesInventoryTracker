﻿namespace AmcorFlexibles_Staj.ChildForms
{
    partial class FormDesktopC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSearchbox = new System.Windows.Forms.Panel();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.countLabelDC = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxMachine = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxSerial = new System.Windows.Forms.TextBox();
            this.panelInsert = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonInsert2 = new System.Windows.Forms.Button();
            this.textBoxInsertLocation = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxInsertMemory = new System.Windows.Forms.TextBox();
            this.textBoxInsertHDD = new System.Windows.Forms.TextBox();
            this.textBoxInsertOS = new System.Windows.Forms.TextBox();
            this.textBoxInsertMdN = new System.Windows.Forms.TextBox();
            this.textBoxInsertMN = new System.Windows.Forms.TextBox();
            this.textBoxInsertSN = new System.Windows.Forms.TextBox();
            this.dataGridViewDC = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelSearchbox.SuspendLayout();
            this.panelInsert.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDC)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSearchbox
            // 
            this.panelSearchbox.Controls.Add(this.buttonPrint);
            this.panelSearchbox.Controls.Add(this.buttonUpdate);
            this.panelSearchbox.Controls.Add(this.buttonCancel);
            this.panelSearchbox.Controls.Add(this.buttonDelete);
            this.panelSearchbox.Controls.Add(this.buttonSave);
            this.panelSearchbox.Controls.Add(this.buttonInsert);
            this.panelSearchbox.Controls.Add(this.countLabelDC);
            this.panelSearchbox.Controls.Add(this.label3);
            this.panelSearchbox.Controls.Add(this.label2);
            this.panelSearchbox.Controls.Add(this.label1);
            this.panelSearchbox.Controls.Add(this.textBoxModel);
            this.panelSearchbox.Controls.Add(this.textBoxMachine);
            this.panelSearchbox.Controls.Add(this.button1);
            this.panelSearchbox.Controls.Add(this.textBoxSerial);
            this.panelSearchbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchbox.Location = new System.Drawing.Point(0, 0);
            this.panelSearchbox.Name = "panelSearchbox";
            this.panelSearchbox.Size = new System.Drawing.Size(838, 49);
            this.panelSearchbox.TabIndex = 1;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonPrint.FlatAppearance.BorderSize = 0;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Image = global::AmcorFlexibles_Staj.Properties.Resources.print;
            this.buttonPrint.Location = new System.Drawing.Point(741, 0);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(41, 29);
            this.buttonPrint.TabIndex = 3;
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI Historic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Image = global::AmcorFlexibles_Staj.Properties.Resources.icons8_edit_20;
            this.buttonUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdate.Location = new System.Drawing.Point(777, 1);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(61, 29);
            this.buttonUpdate.TabIndex = 18;
            this.buttonUpdate.Text = "EDIT";
            this.buttonUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI Historic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Image = global::AmcorFlexibles_Staj.Properties.Resources.icons8_cancel_16;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(756, 25);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(83, 26);
            this.buttonCancel.TabIndex = 20;
            this.buttonCancel.Text = "CANCEL";
            this.buttonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI Historic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Image = global::AmcorFlexibles_Staj.Properties.Resources.icons8_delete_bin_16__1_;
            this.buttonDelete.Location = new System.Drawing.Point(669, 25);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(83, 26);
            this.buttonDelete.TabIndex = 22;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI Historic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Image = global::AmcorFlexibles_Staj.Properties.Resources.icons8_update_16;
            this.buttonSave.Location = new System.Drawing.Point(669, 0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(83, 26);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "UPDATE";
            this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonInsert.FlatAppearance.BorderSize = 0;
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsert.Font = new System.Drawing.Font("Segoe UI Historic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsert.Image = global::AmcorFlexibles_Staj.Properties.Resources.icons8_insert_16;
            this.buttonInsert.Location = new System.Drawing.Point(756, 0);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(83, 26);
            this.buttonInsert.TabIndex = 21;
            this.buttonInsert.Text = "INSERT";
            this.buttonInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Visible = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // countLabelDC
            // 
            this.countLabelDC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.countLabelDC.AutoSize = true;
            this.countLabelDC.Location = new System.Drawing.Point(709, 33);
            this.countLabelDC.Name = "countLabelDC";
            this.countLabelDC.Size = new System.Drawing.Size(10, 13);
            this.countLabelDC.TabIndex = 1;
            this.countLabelDC.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Model Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Makine Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Seri Numarası";
            // 
            // textBoxModel
            // 
            this.textBoxModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.textBoxModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxModel.Location = new System.Drawing.Point(245, 23);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(108, 20);
            this.textBoxModel.TabIndex = 4;
            // 
            // textBoxMachine
            // 
            this.textBoxMachine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.textBoxMachine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMachine.Location = new System.Drawing.Point(131, 23);
            this.textBoxMachine.Name = "textBoxMachine";
            this.textBoxMachine.Size = new System.Drawing.Size(108, 20);
            this.textBoxMachine.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Historic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::AmcorFlexibles_Staj.Properties.Resources.icons8_search_32;
            this.button1.Location = new System.Drawing.Point(359, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 34);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSerial
            // 
            this.textBoxSerial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.textBoxSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSerial.Location = new System.Drawing.Point(12, 23);
            this.textBoxSerial.Name = "textBoxSerial";
            this.textBoxSerial.Size = new System.Drawing.Size(108, 20);
            this.textBoxSerial.TabIndex = 0;
            // 
            // panelInsert
            // 
            this.panelInsert.Controls.Add(this.panel2);
            this.panelInsert.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInsert.Location = new System.Drawing.Point(0, 0);
            this.panelInsert.Name = "panelInsert";
            this.panelInsert.Size = new System.Drawing.Size(838, 73);
            this.panelInsert.TabIndex = 2;
            this.panelInsert.Visible = false;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(181)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.buttonInsert2);
            this.panel2.Controls.Add(this.textBoxInsertLocation);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBoxInsertMemory);
            this.panel2.Controls.Add(this.textBoxInsertHDD);
            this.panel2.Controls.Add(this.textBoxInsertOS);
            this.panel2.Controls.Add(this.textBoxInsertMdN);
            this.panel2.Controls.Add(this.textBoxInsertMN);
            this.panel2.Controls.Add(this.textBoxInsertSN);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 293);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(838, 221);
            this.panel3.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(629, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Location";
            // 
            // buttonInsert2
            // 
            this.buttonInsert2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsert2.Location = new System.Drawing.Point(726, 27);
            this.buttonInsert2.Name = "buttonInsert2";
            this.buttonInsert2.Size = new System.Drawing.Size(100, 21);
            this.buttonInsert2.TabIndex = 12;
            this.buttonInsert2.Text = "INSERT";
            this.buttonInsert2.UseVisualStyleBackColor = true;
            this.buttonInsert2.Click += new System.EventHandler(this.buttonInsert2_Click);
            // 
            // textBoxInsertLocation
            // 
            this.textBoxInsertLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(181)))));
            this.textBoxInsertLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInsertLocation.Location = new System.Drawing.Point(629, 27);
            this.textBoxInsertLocation.Name = "textBoxInsertLocation";
            this.textBoxInsertLocation.Size = new System.Drawing.Size(86, 20);
            this.textBoxInsertLocation.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(524, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Memory";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(422, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "HDD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "OS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Model Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Makine Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Seri Numarası";
            // 
            // textBoxInsertMemory
            // 
            this.textBoxInsertMemory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(181)))));
            this.textBoxInsertMemory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInsertMemory.Location = new System.Drawing.Point(527, 27);
            this.textBoxInsertMemory.Name = "textBoxInsertMemory";
            this.textBoxInsertMemory.Size = new System.Drawing.Size(86, 20);
            this.textBoxInsertMemory.TabIndex = 5;
            // 
            // textBoxInsertHDD
            // 
            this.textBoxInsertHDD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(181)))));
            this.textBoxInsertHDD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInsertHDD.Location = new System.Drawing.Point(425, 27);
            this.textBoxInsertHDD.Name = "textBoxInsertHDD";
            this.textBoxInsertHDD.Size = new System.Drawing.Size(86, 20);
            this.textBoxInsertHDD.TabIndex = 4;
            // 
            // textBoxInsertOS
            // 
            this.textBoxInsertOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(181)))));
            this.textBoxInsertOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInsertOS.Location = new System.Drawing.Point(323, 27);
            this.textBoxInsertOS.Name = "textBoxInsertOS";
            this.textBoxInsertOS.Size = new System.Drawing.Size(86, 20);
            this.textBoxInsertOS.TabIndex = 3;
            // 
            // textBoxInsertMdN
            // 
            this.textBoxInsertMdN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(181)))));
            this.textBoxInsertMdN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInsertMdN.Location = new System.Drawing.Point(221, 27);
            this.textBoxInsertMdN.Name = "textBoxInsertMdN";
            this.textBoxInsertMdN.Size = new System.Drawing.Size(86, 20);
            this.textBoxInsertMdN.TabIndex = 2;
            // 
            // textBoxInsertMN
            // 
            this.textBoxInsertMN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(181)))));
            this.textBoxInsertMN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInsertMN.Location = new System.Drawing.Point(119, 27);
            this.textBoxInsertMN.Name = "textBoxInsertMN";
            this.textBoxInsertMN.Size = new System.Drawing.Size(86, 20);
            this.textBoxInsertMN.TabIndex = 1;
            // 
            // textBoxInsertSN
            // 
            this.textBoxInsertSN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(181)))));
            this.textBoxInsertSN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInsertSN.Location = new System.Drawing.Point(17, 28);
            this.textBoxInsertSN.Name = "textBoxInsertSN";
            this.textBoxInsertSN.Size = new System.Drawing.Size(86, 20);
            this.textBoxInsertSN.TabIndex = 0;
            // 
            // dataGridViewDC
            // 
            this.dataGridViewDC.AllowUserToAddRows = false;
            this.dataGridViewDC.AllowUserToDeleteRows = false;
            this.dataGridViewDC.AllowUserToResizeColumns = false;
            this.dataGridViewDC.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Historic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewDC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewDC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewDC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Historic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDC.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewDC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDC.EnableHeadersVisualStyles = false;
            this.dataGridViewDC.Location = new System.Drawing.Point(0, 73);
            this.dataGridViewDC.MultiSelect = false;
            this.dataGridViewDC.Name = "dataGridViewDC";
            this.dataGridViewDC.ReadOnly = true;
            this.dataGridViewDC.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Historic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            this.dataGridViewDC.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewDC.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewDC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDC.Size = new System.Drawing.Size(838, 217);
            this.dataGridViewDC.TabIndex = 0;
            this.dataGridViewDC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDC_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewDC);
            this.panel1.Controls.Add(this.panelInsert);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 290);
            this.panel1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormDesktopC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(838, 339);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSearchbox);
            this.Name = "FormDesktopC";
            this.Text = "DesktopC";
            this.Load += new System.EventHandler(this.FormDesktopC_Load);
            this.panelSearchbox.ResumeLayout(false);
            this.panelSearchbox.PerformLayout();
            this.panelInsert.ResumeLayout(false);
            this.panelInsert.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDC)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearchbox;
        private System.Windows.Forms.Label countLabelDC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxMachine;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxSerial;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Panel panelInsert;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonInsert2;
        private System.Windows.Forms.TextBox textBoxInsertLocation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxInsertMemory;
        private System.Windows.Forms.TextBox textBoxInsertHDD;
        private System.Windows.Forms.TextBox textBoxInsertOS;
        private System.Windows.Forms.TextBox textBoxInsertMdN;
        private System.Windows.Forms.TextBox textBoxInsertMN;
        private System.Windows.Forms.TextBox textBoxInsertSN;
        private System.Windows.Forms.DataGridView dataGridViewDC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Timer timer1;
    }
}
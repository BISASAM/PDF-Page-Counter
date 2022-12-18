namespace PDF_Counter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_cwd = new System.Windows.Forms.Button();
            this.cb_subfolder = new System.Windows.Forms.CheckBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.tb_folderpath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Indikator = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PdfName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Seiten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Speicherort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_show_files = new System.Windows.Forms.Button();
            this.btn_count = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_filecount = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_total_count = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_version = new System.Windows.Forms.Label();
            this.btn_abort = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btn_cwd
            // 
            this.btn_cwd.Location = new System.Drawing.Point(529, 23);
            this.btn_cwd.Name = "btn_cwd";
            this.btn_cwd.Size = new System.Drawing.Size(38, 23);
            this.btn_cwd.TabIndex = 29;
            this.btn_cwd.Text = "cwd";
            this.btn_cwd.UseVisualStyleBackColor = true;
            this.btn_cwd.Click += new System.EventHandler(this.btn_cwd_Click);
            // 
            // cb_subfolder
            // 
            this.cb_subfolder.AutoEllipsis = true;
            this.cb_subfolder.Location = new System.Drawing.Point(589, 23);
            this.cb_subfolder.Name = "cb_subfolder";
            this.cb_subfolder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_subfolder.Size = new System.Drawing.Size(199, 25);
            this.cb_subfolder.TabIndex = 28;
            this.cb_subfolder.Text = "Unterordner einbeziehen (Vorsicht!)";
            this.cb_subfolder.UseVisualStyleBackColor = true;
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(485, 23);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(38, 23);
            this.btn_browse.TabIndex = 27;
            this.btn_browse.Text = "...";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // tb_folderpath
            // 
            this.tb_folderpath.Location = new System.Drawing.Point(79, 25);
            this.tb_folderpath.Name = "tb_folderpath";
            this.tb_folderpath.Size = new System.Drawing.Size(400, 20);
            this.tb_folderpath.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Verzeichnis";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Indikator,
            this.PdfName,
            this.Seiten,
            this.Speicherort});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 113);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(789, 417);
            this.listView1.TabIndex = 31;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Indikator
            // 
            this.Indikator.Text = "";
            this.Indikator.Width = 30;
            // 
            // PdfName
            // 
            this.PdfName.Text = "Name";
            this.PdfName.Width = 300;
            // 
            // Seiten
            // 
            this.Seiten.Text = "Seiten";
            this.Seiten.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Speicherort
            // 
            this.Speicherort.Text = "Speicherort";
            this.Speicherort.Width = 400;
            // 
            // btn_show_files
            // 
            this.btn_show_files.Location = new System.Drawing.Point(79, 65);
            this.btn_show_files.Name = "btn_show_files";
            this.btn_show_files.Size = new System.Drawing.Size(100, 30);
            this.btn_show_files.TabIndex = 32;
            this.btn_show_files.Text = "PDF suchen";
            this.btn_show_files.UseVisualStyleBackColor = true;
            this.btn_show_files.Click += new System.EventHandler(this.btn_show_files_Click);
            // 
            // btn_count
            // 
            this.btn_count.Location = new System.Drawing.Point(197, 65);
            this.btn_count.Name = "btn_count";
            this.btn_count.Size = new System.Drawing.Size(100, 30);
            this.btn_count.TabIndex = 33;
            this.btn_count.Text = "Seiten zählen";
            this.btn_count.UseVisualStyleBackColor = true;
            this.btn_count.Click += new System.EventHandler(this.btn_count_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Status:";
            // 
            // lbl_filecount
            // 
            this.lbl_filecount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_filecount.AutoSize = true;
            this.lbl_filecount.Location = new System.Drawing.Point(748, 533);
            this.lbl_filecount.Name = "lbl_filecount";
            this.lbl_filecount.Size = new System.Drawing.Size(53, 13);
            this.lbl_filecount.TabIndex = 35;
            this.lbl_filecount.Text = "0 Dateien";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(384, 74);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(34, 13);
            this.lbl_status.TabIndex = 36;
            this.lbl_status.Text = "Bereit";
            // 
            // lbl_total_count
            // 
            this.lbl_total_count.Location = new System.Drawing.Point(535, 74);
            this.lbl_total_count.Name = "lbl_total_count";
            this.lbl_total_count.Size = new System.Drawing.Size(59, 13);
            this.lbl_total_count.TabIndex = 37;
            this.lbl_total_count.Text = "0";
            this.lbl_total_count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Gesamtzahl Seiten:";
            // 
            // lbl_version
            // 
            this.lbl_version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_version.AutoSize = true;
            this.lbl_version.Location = new System.Drawing.Point(9, 533);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(41, 13);
            this.lbl_version.TabIndex = 39;
            this.lbl_version.Text = "version";
            // 
            // btn_abort
            // 
            this.btn_abort.Location = new System.Drawing.Point(688, 65);
            this.btn_abort.Name = "btn_abort";
            this.btn_abort.Size = new System.Drawing.Size(100, 30);
            this.btn_abort.TabIndex = 40;
            this.btn_abort.Text = "abbrechen";
            this.btn_abort.UseVisualStyleBackColor = true;
            this.btn_abort.Click += new System.EventHandler(this.btn_abort_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 552);
            this.Controls.Add(this.btn_abort);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_total_count);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_filecount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_count);
            this.Controls.Add(this.btn_show_files);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cwd);
            this.Controls.Add(this.cb_subfolder);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.tb_folderpath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PDF Seiten Zähler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_cwd;
        private System.Windows.Forms.CheckBox cb_subfolder;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.TextBox tb_folderpath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader PdfName;
        private System.Windows.Forms.ColumnHeader Speicherort;
        private System.Windows.Forms.ColumnHeader Seiten;
        private System.Windows.Forms.Button btn_show_files;
        private System.Windows.Forms.Button btn_count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_filecount;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_total_count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.Button btn_abort;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ColumnHeader Indikator;
    }
}


namespace Migrate_Quota
{
    partial class GUI_migrateQuota
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_migrateQuota));
            this.lb_quotaListPath = new System.Windows.Forms.Label();
            this.txt_quotaListPath = new System.Windows.Forms.TextBox();
            this.searchQuotaFile = new System.Windows.Forms.OpenFileDialog();
            this.btn_searchQuotaList = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.tab = new System.Windows.Forms.TabControl();
            this.txtQuotafile = new System.Windows.Forms.TabPage();
            this.txt_listFile = new System.Windows.Forms.TextBox();
            this.txtReplacements = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.currentpath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLoadedQuotas = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtWordmap = new System.Windows.Forms.TabPage();
            this.wm_help = new System.Windows.Forms.TextBox();
            this.wm_txtfields = new System.Windows.Forms.FlowLayoutPanel();
            this.server = new System.Windows.Forms.TextBox();
            this.lb_fileserver = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.TextBox();
            this.lb_passwort = new System.Windows.Forms.Label();
            this.user_pw = new System.Windows.Forms.TextBox();
            this.gb_status = new System.Windows.Forms.GroupBox();
            this.show_progress = new System.Windows.Forms.ProgressBar();
            this.lb_template = new System.Windows.Forms.Label();
            this.lb_path = new System.Windows.Forms.Label();
            this.lb_currentQuota = new System.Windows.Forms.Label();
            this.show_currentTemplate = new System.Windows.Forms.Label();
            this.show_currentPath = new System.Windows.Forms.Label();
            this.show_error = new System.Windows.Forms.Label();
            this.show_success = new System.Windows.Forms.Label();
            this.show_anzQuota = new System.Windows.Forms.Label();
            this.lb_error = new System.Windows.Forms.Label();
            this.lb_quotaCount = new System.Windows.Forms.Label();
            this.lb_success = new System.Windows.Forms.Label();
            this.btn_insertQuotas = new System.Windows.Forms.Button();
            this.listOperations = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.enable = new System.Windows.Forms.ToolStripMenuItem();
            this.disable = new System.Windows.Forms.ToolStripMenuItem();
            this.label10 = new System.Windows.Forms.Label();
            this.language = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.de = new System.Windows.Forms.ToolStripMenuItem();
            this.en = new System.Windows.Forms.ToolStripMenuItem();
            this.refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.tab.SuspendLayout();
            this.txtQuotafile.SuspendLayout();
            this.txtReplacements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.txtLoadedQuotas.SuspendLayout();
            this.txtWordmap.SuspendLayout();
            this.gb_status.SuspendLayout();
            this.listOperations.SuspendLayout();
            this.language.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_quotaListPath
            // 
            this.lb_quotaListPath.AutoSize = true;
            this.lb_quotaListPath.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_quotaListPath.Location = new System.Drawing.Point(9, 30);
            this.lb_quotaListPath.Name = "lb_quotaListPath";
            this.lb_quotaListPath.Size = new System.Drawing.Size(235, 13);
            this.lb_quotaListPath.TabIndex = 0;
            this.lb_quotaListPath.Text = "Pfad zur Quota-Liste (mode con cp select=1252)";
            // 
            // txt_quotaListPath
            // 
            this.txt_quotaListPath.Location = new System.Drawing.Point(12, 46);
            this.txt_quotaListPath.Name = "txt_quotaListPath";
            this.txt_quotaListPath.Size = new System.Drawing.Size(595, 20);
            this.txt_quotaListPath.TabIndex = 1;
            this.txt_quotaListPath.Text = "C:\\Users\\biwer-r\\Documents\\SI-AU\\Fileserver_Migration\\quotas_user.txt";
            this.txt_quotaListPath.TextChanged += new System.EventHandler(this.txt_quotaListPath_TextChanged);
            // 
            // searchQuotaFile
            // 
            this.searchQuotaFile.FileName = "openFileDialog1";
            // 
            // btn_searchQuotaList
            // 
            this.btn_searchQuotaList.Location = new System.Drawing.Point(613, 45);
            this.btn_searchQuotaList.Name = "btn_searchQuotaList";
            this.btn_searchQuotaList.Size = new System.Drawing.Size(75, 23);
            this.btn_searchQuotaList.TabIndex = 2;
            this.btn_searchQuotaList.Text = "Suchen";
            this.btn_searchQuotaList.UseVisualStyleBackColor = true;
            this.btn_searchQuotaList.Click += new System.EventHandler(this.btn_searchQuotaList_Click);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(694, 45);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 23);
            this.btn_open.TabIndex = 3;
            this.btn_open.Text = "Öffnen";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // tab
            // 
            this.tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tab.Controls.Add(this.txtQuotafile);
            this.tab.Controls.Add(this.txtReplacements);
            this.tab.Controls.Add(this.txtLoadedQuotas);
            this.tab.Controls.Add(this.txtWordmap);
            this.tab.Location = new System.Drawing.Point(0, 361);
            this.tab.Name = "tab";
            this.tab.Padding = new System.Drawing.Point(8, 6);
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(785, 274);
            this.tab.TabIndex = 8;
            // 
            // txtQuotafile
            // 
            this.txtQuotafile.Controls.Add(this.txt_listFile);
            this.txtQuotafile.Location = new System.Drawing.Point(4, 28);
            this.txtQuotafile.Name = "txtQuotafile";
            this.txtQuotafile.Padding = new System.Windows.Forms.Padding(3);
            this.txtQuotafile.Size = new System.Drawing.Size(777, 242);
            this.txtQuotafile.TabIndex = 0;
            this.txtQuotafile.Text = "Quotaliste";
            this.txtQuotafile.UseVisualStyleBackColor = true;
            // 
            // txt_listFile
            // 
            this.txt_listFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_listFile.Location = new System.Drawing.Point(6, 6);
            this.txt_listFile.Multiline = true;
            this.txt_listFile.Name = "txt_listFile";
            this.txt_listFile.ReadOnly = true;
            this.txt_listFile.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_listFile.Size = new System.Drawing.Size(765, 230);
            this.txt_listFile.TabIndex = 4;
            // 
            // txtReplacements
            // 
            this.txtReplacements.Controls.Add(this.dataGridView1);
            this.txtReplacements.Location = new System.Drawing.Point(4, 28);
            this.txtReplacements.Name = "txtReplacements";
            this.txtReplacements.Padding = new System.Windows.Forms.Padding(3);
            this.txtReplacements.Size = new System.Drawing.Size(777, 242);
            this.txtReplacements.TabIndex = 1;
            this.txtReplacements.Text = "Ersetzungen";
            this.txtReplacements.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.currentpath,
            this.newPath});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(771, 236);
            this.dataGridView1.TabIndex = 0;
            // 
            // currentpath
            // 
            this.currentpath.FillWeight = 200F;
            this.currentpath.HeaderText = "Aktueller Pfad";
            this.currentpath.Name = "currentpath";
            this.currentpath.Width = 200;
            // 
            // newPath
            // 
            this.newPath.HeaderText = "Neuer Pfad";
            this.newPath.Name = "newPath";
            // 
            // txtLoadedQuotas
            // 
            this.txtLoadedQuotas.Controls.Add(this.listView1);
            this.txtLoadedQuotas.Location = new System.Drawing.Point(4, 28);
            this.txtLoadedQuotas.Name = "txtLoadedQuotas";
            this.txtLoadedQuotas.Padding = new System.Windows.Forms.Padding(3);
            this.txtLoadedQuotas.Size = new System.Drawing.Size(777, 242);
            this.txtLoadedQuotas.TabIndex = 2;
            this.txtLoadedQuotas.Text = "Erkannte Quotas";
            this.txtLoadedQuotas.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(771, 236);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView1_ItemChecked);
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // txtWordmap
            // 
            this.txtWordmap.Controls.Add(this.wm_help);
            this.txtWordmap.Controls.Add(this.wm_txtfields);
            this.txtWordmap.Location = new System.Drawing.Point(4, 28);
            this.txtWordmap.Name = "txtWordmap";
            this.txtWordmap.Padding = new System.Windows.Forms.Padding(3);
            this.txtWordmap.Size = new System.Drawing.Size(777, 242);
            this.txtWordmap.TabIndex = 3;
            this.txtWordmap.Text = "Text Zuordnung";
            this.txtWordmap.UseVisualStyleBackColor = true;
            // 
            // wm_help
            // 
            this.wm_help.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wm_help.Location = new System.Drawing.Point(407, 15);
            this.wm_help.Multiline = true;
            this.wm_help.Name = "wm_help";
            this.wm_help.ReadOnly = true;
            this.wm_help.Size = new System.Drawing.Size(355, 156);
            this.wm_help.TabIndex = 1;
            this.wm_help.Text = resources.GetString("wm_help.Text");
            this.wm_help.TextChanged += new System.EventHandler(this.wm_help_TextChanged);
            // 
            // wm_txtfields
            // 
            this.wm_txtfields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.wm_txtfields.Location = new System.Drawing.Point(6, 15);
            this.wm_txtfields.Name = "wm_txtfields";
            this.wm_txtfields.Size = new System.Drawing.Size(384, 219);
            this.wm_txtfields.TabIndex = 0;
            // 
            // server
            // 
            this.server.Location = new System.Drawing.Point(139, 91);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(197, 20);
            this.server.TabIndex = 4;
            this.server.Text = "170.60.1.32";
            // 
            // lb_fileserver
            // 
            this.lb_fileserver.AutoSize = true;
            this.lb_fileserver.Location = new System.Drawing.Point(9, 91);
            this.lb_fileserver.Name = "lb_fileserver";
            this.lb_fileserver.Size = new System.Drawing.Size(52, 13);
            this.lb_fileserver.TabIndex = 0;
            this.lb_fileserver.Text = "Fileserver";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(9, 117);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(75, 13);
            this.lb_username.TabIndex = 0;
            this.lb_username.Text = "Benutzername";
            // 
            // user_name
            // 
            this.user_name.Location = new System.Drawing.Point(139, 117);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(197, 20);
            this.user_name.TabIndex = 5;
            // 
            // lb_passwort
            // 
            this.lb_passwort.AutoSize = true;
            this.lb_passwort.Location = new System.Drawing.Point(9, 143);
            this.lb_passwort.Name = "lb_passwort";
            this.lb_passwort.Size = new System.Drawing.Size(52, 13);
            this.lb_passwort.TabIndex = 0;
            this.lb_passwort.Text = "Kennwort";
            // 
            // user_pw
            // 
            this.user_pw.Location = new System.Drawing.Point(139, 143);
            this.user_pw.Name = "user_pw";
            this.user_pw.PasswordChar = '*';
            this.user_pw.Size = new System.Drawing.Size(197, 20);
            this.user_pw.TabIndex = 6;
            this.user_pw.TextChanged += new System.EventHandler(this.user_pw_TextChanged);
            // 
            // gb_status
            // 
            this.gb_status.Controls.Add(this.show_progress);
            this.gb_status.Controls.Add(this.lb_template);
            this.gb_status.Controls.Add(this.lb_path);
            this.gb_status.Controls.Add(this.lb_currentQuota);
            this.gb_status.Controls.Add(this.show_currentTemplate);
            this.gb_status.Controls.Add(this.show_currentPath);
            this.gb_status.Controls.Add(this.show_error);
            this.gb_status.Controls.Add(this.show_success);
            this.gb_status.Controls.Add(this.show_anzQuota);
            this.gb_status.Controls.Add(this.lb_error);
            this.gb_status.Controls.Add(this.lb_quotaCount);
            this.gb_status.Controls.Add(this.lb_success);
            this.gb_status.Location = new System.Drawing.Point(13, 184);
            this.gb_status.Name = "gb_status";
            this.gb_status.Size = new System.Drawing.Size(753, 150);
            this.gb_status.TabIndex = 7;
            this.gb_status.TabStop = false;
            this.gb_status.Text = "Status";
            // 
            // show_progress
            // 
            this.show_progress.Location = new System.Drawing.Point(10, 111);
            this.show_progress.Name = "show_progress";
            this.show_progress.Size = new System.Drawing.Size(730, 23);
            this.show_progress.TabIndex = 7;
            // 
            // lb_template
            // 
            this.lb_template.AutoSize = true;
            this.lb_template.Location = new System.Drawing.Point(215, 80);
            this.lb_template.Name = "lb_template";
            this.lb_template.Size = new System.Drawing.Size(54, 13);
            this.lb_template.TabIndex = 0;
            this.lb_template.Text = "Template:";
            // 
            // lb_path
            // 
            this.lb_path.AutoSize = true;
            this.lb_path.Location = new System.Drawing.Point(215, 54);
            this.lb_path.Name = "lb_path";
            this.lb_path.Size = new System.Drawing.Size(32, 13);
            this.lb_path.TabIndex = 0;
            this.lb_path.Text = "Pfad:";
            // 
            // lb_currentQuota
            // 
            this.lb_currentQuota.AutoSize = true;
            this.lb_currentQuota.Location = new System.Drawing.Point(215, 28);
            this.lb_currentQuota.Name = "lb_currentQuota";
            this.lb_currentQuota.Size = new System.Drawing.Size(84, 13);
            this.lb_currentQuota.TabIndex = 0;
            this.lb_currentQuota.Text = "Aktuelles Objekt";
            // 
            // show_currentTemplate
            // 
            this.show_currentTemplate.AutoSize = true;
            this.show_currentTemplate.Location = new System.Drawing.Point(286, 80);
            this.show_currentTemplate.Name = "show_currentTemplate";
            this.show_currentTemplate.Size = new System.Drawing.Size(0, 13);
            this.show_currentTemplate.TabIndex = 0;
            // 
            // show_currentPath
            // 
            this.show_currentPath.AutoSize = true;
            this.show_currentPath.Location = new System.Drawing.Point(286, 54);
            this.show_currentPath.Name = "show_currentPath";
            this.show_currentPath.Size = new System.Drawing.Size(0, 13);
            this.show_currentPath.TabIndex = 0;
            // 
            // show_error
            // 
            this.show_error.AutoSize = true;
            this.show_error.Location = new System.Drawing.Point(123, 80);
            this.show_error.Name = "show_error";
            this.show_error.Size = new System.Drawing.Size(13, 13);
            this.show_error.TabIndex = 0;
            this.show_error.Text = "0";
            // 
            // show_success
            // 
            this.show_success.AutoSize = true;
            this.show_success.Location = new System.Drawing.Point(123, 54);
            this.show_success.Name = "show_success";
            this.show_success.Size = new System.Drawing.Size(13, 13);
            this.show_success.TabIndex = 0;
            this.show_success.Text = "0";
            // 
            // show_anzQuota
            // 
            this.show_anzQuota.AutoSize = true;
            this.show_anzQuota.Location = new System.Drawing.Point(123, 28);
            this.show_anzQuota.Name = "show_anzQuota";
            this.show_anzQuota.Size = new System.Drawing.Size(13, 13);
            this.show_anzQuota.TabIndex = 0;
            this.show_anzQuota.Text = "0";
            // 
            // lb_error
            // 
            this.lb_error.AutoSize = true;
            this.lb_error.Location = new System.Drawing.Point(11, 80);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(57, 13);
            this.lb_error.TabIndex = 0;
            this.lb_error.Text = "Fehlerhaft:";
            // 
            // lb_quotaCount
            // 
            this.lb_quotaCount.AutoSize = true;
            this.lb_quotaCount.Location = new System.Drawing.Point(11, 28);
            this.lb_quotaCount.Name = "lb_quotaCount";
            this.lb_quotaCount.Size = new System.Drawing.Size(79, 13);
            this.lb_quotaCount.TabIndex = 0;
            this.lb_quotaCount.Text = "Anzahl Quotas:";
            // 
            // lb_success
            // 
            this.lb_success.AutoSize = true;
            this.lb_success.Location = new System.Drawing.Point(11, 54);
            this.lb_success.Name = "lb_success";
            this.lb_success.Size = new System.Drawing.Size(60, 13);
            this.lb_success.TabIndex = 0;
            this.lb_success.Text = "Erfolgreich:";
            // 
            // btn_insertQuotas
            // 
            this.btn_insertQuotas.Location = new System.Drawing.Point(690, 133);
            this.btn_insertQuotas.Name = "btn_insertQuotas";
            this.btn_insertQuotas.Size = new System.Drawing.Size(75, 23);
            this.btn_insertQuotas.TabIndex = 7;
            this.btn_insertQuotas.Text = "Senden";
            this.btn_insertQuotas.UseVisualStyleBackColor = true;
            this.btn_insertQuotas.Click += new System.EventHandler(this.insertQuotas_Click);
            // 
            // listOperations
            // 
            this.listOperations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delete,
            this.enable,
            this.disable,
            this.refresh});
            this.listOperations.Name = "listOperations";
            this.listOperations.Size = new System.Drawing.Size(141, 92);
            // 
            // delete
            // 
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(152, 22);
            this.delete.Text = "Löschen";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // enable
            // 
            this.enable.Name = "enable";
            this.enable.Size = new System.Drawing.Size(152, 22);
            this.enable.Text = "aktivieren";
            this.enable.Click += new System.EventHandler(this.enable_Click);
            // 
            // disable
            // 
            this.disable.Name = "disable";
            this.disable.Size = new System.Drawing.Size(152, 22);
            this.disable.Text = "deaktivieren";
            this.disable.Click += new System.EventHandler(this.disable_Click);
            // 
            // label10
            // 
            this.label10.Image = global::Migrate_Quota.Properties.Resources.DE;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(642, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 18);
            this.label10.TabIndex = 8;
            this.label10.Text = "Change Language";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label10_MouseClick);
            // 
            // language
            // 
            this.language.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.de,
            this.en});
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(117, 48);
            // 
            // de
            // 
            this.de.Name = "de";
            this.de.Size = new System.Drawing.Size(116, 22);
            this.de.Text = "German";
            this.de.Click += new System.EventHandler(this.lang_Click);
            // 
            // en
            // 
            this.en.Name = "en";
            this.en.Size = new System.Drawing.Size(116, 22);
            this.en.Text = "English";
            this.en.Click += new System.EventHandler(this.lang_Click);
            // 
            // refresh
            // 
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(152, 22);
            this.refresh.Text = "aktualisieren";
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // GUI_migrateQuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 635);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gb_status);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.btn_insertQuotas);
            this.Controls.Add(this.btn_searchQuotaList);
            this.Controls.Add(this.user_pw);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.lb_passwort);
            this.Controls.Add(this.server);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.txt_quotaListPath);
            this.Controls.Add(this.lb_fileserver);
            this.Controls.Add(this.lb_quotaListPath);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimumSize = new System.Drawing.Size(800, 673);
            this.Name = "GUI_migrateQuota";
            this.Text = "Migrate Disk Quota MS Server";
            this.tab.ResumeLayout(false);
            this.txtQuotafile.ResumeLayout(false);
            this.txtQuotafile.PerformLayout();
            this.txtReplacements.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.txtLoadedQuotas.ResumeLayout(false);
            this.txtWordmap.ResumeLayout(false);
            this.txtWordmap.PerformLayout();
            this.gb_status.ResumeLayout(false);
            this.gb_status.PerformLayout();
            this.listOperations.ResumeLayout(false);
            this.language.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_quotaListPath;
        private System.Windows.Forms.TextBox txt_quotaListPath;
        private System.Windows.Forms.OpenFileDialog searchQuotaFile;
        private System.Windows.Forms.Button btn_searchQuotaList;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage txtQuotafile;
        private System.Windows.Forms.TextBox txt_listFile;
        private System.Windows.Forms.TabPage txtReplacements;
        private System.Windows.Forms.TextBox server;
        private System.Windows.Forms.Label lb_fileserver;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.Label lb_passwort;
        private System.Windows.Forms.TextBox user_pw;
        private System.Windows.Forms.TabPage txtLoadedQuotas;
        private System.Windows.Forms.GroupBox gb_status;
        private System.Windows.Forms.ProgressBar show_progress;
        private System.Windows.Forms.Label lb_currentQuota;
        private System.Windows.Forms.Label lb_quotaCount;
        private System.Windows.Forms.Label lb_success;
        private System.Windows.Forms.Label lb_template;
        private System.Windows.Forms.Label lb_path;
        private System.Windows.Forms.Button btn_insertQuotas;
        private System.Windows.Forms.Label show_currentTemplate;
        private System.Windows.Forms.Label show_currentPath;
        private System.Windows.Forms.Label show_success;
        private System.Windows.Forms.Label show_anzQuota;
        private System.Windows.Forms.Label show_error;
        private System.Windows.Forms.Label lb_error;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentpath;
        private System.Windows.Forms.DataGridViewTextBoxColumn newPath;
        private System.Windows.Forms.ContextMenuStrip listOperations;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private System.Windows.Forms.ToolStripMenuItem enable;
        private System.Windows.Forms.ToolStripMenuItem disable;
        private System.Windows.Forms.TabPage txtWordmap;
        private System.Windows.Forms.FlowLayoutPanel wm_txtfields;
        private System.Windows.Forms.TextBox wm_help;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ContextMenuStrip language;
        private System.Windows.Forms.ToolStripMenuItem de;
        private System.Windows.Forms.ToolStripMenuItem en;
        private System.Windows.Forms.ToolStripMenuItem refresh;
    }
}


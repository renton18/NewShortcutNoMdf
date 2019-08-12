namespace 新ファイル名を指定して実行
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            新ファイル名を指定して実行.Properties.Settings settings1 = new 新ファイル名を指定して実行.Properties.Settings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxMain = new System.Windows.Forms.ComboBox();
            this.labelDetailInformation = new System.Windows.Forms.Label();
            this.comboBoxDisplay = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxKidoSetting = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusLb = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aliasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commadNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commandSearchTb = new System.Windows.Forms.TextBox();
            this.commandNameSearchTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.f1Pl = new System.Windows.Forms.Panel();
            this.f2Pl = new System.Windows.Forms.Panel();
            this.anotherTb = new System.Windows.Forms.TextBox();
            this.enableWifiTb = new System.Windows.Forms.TextBox();
            this.currentWifiTb = new System.Windows.Forms.TextBox();
            this.ipStatusTb = new System.Windows.Forms.TextBox();
            this.f3Pl = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPerfmon = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBindingSource)).BeginInit();
            this.f1Pl.SuspendLayout();
            this.f2Pl.SuspendLayout();
            this.f3Pl.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxMain
            // 
            this.comboBoxMain.FormattingEnabled = true;
            this.comboBoxMain.Location = new System.Drawing.Point(79, 72);
            this.comboBoxMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxMain.Name = "comboBoxMain";
            this.comboBoxMain.Size = new System.Drawing.Size(275, 23);
            this.comboBoxMain.TabIndex = 0;
            this.comboBoxMain.TextUpdate += new System.EventHandler(this.comboBoxMain_TextUpdate);
            this.comboBoxMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxMain_KeyDown);
            this.comboBoxMain.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBoxMain_KeyUp);
            // 
            // labelDetailInformation
            // 
            this.labelDetailInformation.AutoSize = true;
            this.labelDetailInformation.BackColor = System.Drawing.Color.Orange;
            this.labelDetailInformation.Location = new System.Drawing.Point(87, 40);
            this.labelDetailInformation.Name = "labelDetailInformation";
            this.labelDetailInformation.Size = new System.Drawing.Size(0, 15);
            this.labelDetailInformation.TabIndex = 1;
            // 
            // comboBoxDisplay
            // 
            this.comboBoxDisplay.FormattingEnabled = true;
            this.comboBoxDisplay.Items.AddRange(new object[] {
            "左上",
            "左下"});
            this.comboBoxDisplay.Location = new System.Drawing.Point(90, 42);
            this.comboBoxDisplay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxDisplay.Name = "comboBoxDisplay";
            this.comboBoxDisplay.Size = new System.Drawing.Size(65, 23);
            this.comboBoxDisplay.TabIndex = 3;
            this.comboBoxDisplay.Text = "左上";
            this.comboBoxDisplay.TextChanged += new System.EventHandler(this.comboBoxDisplay_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "表示場所：";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkBoxKidoSetting);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxDisplay);
            this.panel1.Location = new System.Drawing.Point(21, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 97);
            this.panel1.TabIndex = 5;
            // 
            // checkBoxKidoSetting
            // 
            this.checkBoxKidoSetting.AutoSize = true;
            settings1.COMMANDS = ((System.Collections.Specialized.StringCollection)(resources.GetObject("settings1.COMMANDS")));
            settings1.displaySetting = "左上";
            settings1.kidoSetting = false;
            settings1.SettingsKey = "";
            this.checkBoxKidoSetting.Checked = settings1.kidoSetting;
            this.checkBoxKidoSetting.DataBindings.Add(new System.Windows.Forms.Binding("Checked", settings1, "kidoSetting", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxKidoSetting.Location = new System.Drawing.Point(16, 15);
            this.checkBoxKidoSetting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxKidoSetting.Name = "checkBoxKidoSetting";
            this.checkBoxKidoSetting.Size = new System.Drawing.Size(71, 19);
            this.checkBoxKidoSetting.TabIndex = 2;
            this.checkBoxKidoSetting.Text = "常に起動";
            this.checkBoxKidoSetting.UseVisualStyleBackColor = true;
            this.checkBoxKidoSetting.CheckedChanged += new System.EventHandler(this.checkBoxKidoSetting_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "名前(O) :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::新ファイル名を指定して実行.Properties.Resources._25_b3;
            this.pictureBox1.Location = new System.Drawing.Point(19, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(76, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "管理者権限:CTRL+SHIFT 設定:F1";
            // 
            // statusLb
            // 
            this.statusLb.BackColor = System.Drawing.SystemColors.Info;
            this.statusLb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusLb.Enabled = false;
            this.statusLb.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLb.Location = new System.Drawing.Point(120, 16);
            this.statusLb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statusLb.Multiline = true;
            this.statusLb.Name = "statusLb";
            this.statusLb.ReadOnly = true;
            this.statusLb.Size = new System.Drawing.Size(234, 48);
            this.statusLb.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aliasDataGridViewTextBoxColumn,
            this.detail1DataGridViewTextBoxColumn,
            this.detail2DataGridViewTextBoxColumn,
            this.commadNameDataGridViewTextBoxColumn,
            this.authDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.commandBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(1197, 331);
            this.dataGridView1.TabIndex = 0;
            // 
            // aliasDataGridViewTextBoxColumn
            // 
            this.aliasDataGridViewTextBoxColumn.DataPropertyName = "alias";
            this.aliasDataGridViewTextBoxColumn.HeaderText = "エイリアス";
            this.aliasDataGridViewTextBoxColumn.Name = "aliasDataGridViewTextBoxColumn";
            // 
            // detail1DataGridViewTextBoxColumn
            // 
            this.detail1DataGridViewTextBoxColumn.DataPropertyName = "detail1";
            this.detail1DataGridViewTextBoxColumn.HeaderText = "詳細1";
            this.detail1DataGridViewTextBoxColumn.Name = "detail1DataGridViewTextBoxColumn";
            // 
            // detail2DataGridViewTextBoxColumn
            // 
            this.detail2DataGridViewTextBoxColumn.DataPropertyName = "detail2";
            this.detail2DataGridViewTextBoxColumn.HeaderText = "詳細2";
            this.detail2DataGridViewTextBoxColumn.Name = "detail2DataGridViewTextBoxColumn";
            // 
            // commadNameDataGridViewTextBoxColumn
            // 
            this.commadNameDataGridViewTextBoxColumn.DataPropertyName = "commadName";
            this.commadNameDataGridViewTextBoxColumn.HeaderText = "コマンド名";
            this.commadNameDataGridViewTextBoxColumn.Name = "commadNameDataGridViewTextBoxColumn";
            // 
            // authDataGridViewTextBoxColumn
            // 
            this.authDataGridViewTextBoxColumn.DataPropertyName = "auth";
            this.authDataGridViewTextBoxColumn.HeaderText = "管理者権限";
            this.authDataGridViewTextBoxColumn.Name = "authDataGridViewTextBoxColumn";
            // 
            // commandBindingSource
            // 
            this.commandBindingSource.DataSource = typeof(新ファイル名を指定して実行.Command);
            // 
            // commandSearchTb
            // 
            this.commandSearchTb.Location = new System.Drawing.Point(82, 10);
            this.commandSearchTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.commandSearchTb.Name = "commandSearchTb";
            this.commandSearchTb.Size = new System.Drawing.Size(132, 23);
            this.commandSearchTb.TabIndex = 1;
            this.commandSearchTb.TextChanged += new System.EventHandler(this.commandSearchTb_TextChanged);
            // 
            // commandNameSearchTb
            // 
            this.commandNameSearchTb.Location = new System.Drawing.Point(304, 10);
            this.commandNameSearchTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.commandNameSearchTb.Name = "commandNameSearchTb";
            this.commandNameSearchTb.Size = new System.Drawing.Size(142, 23);
            this.commandNameSearchTb.TabIndex = 1;
            this.commandNameSearchTb.TextChanged += new System.EventHandler(this.commandNameSearchTb_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "エイリアス :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "内容 :";
            // 
            // f1Pl
            // 
            this.f1Pl.Controls.Add(this.label5);
            this.f1Pl.Controls.Add(this.label4);
            this.f1Pl.Controls.Add(this.commandNameSearchTb);
            this.f1Pl.Controls.Add(this.commandSearchTb);
            this.f1Pl.Controls.Add(this.dataGridView1);
            this.f1Pl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.f1Pl.Location = new System.Drawing.Point(3, 3);
            this.f1Pl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.f1Pl.Name = "f1Pl";
            this.f1Pl.Size = new System.Drawing.Size(1204, 376);
            this.f1Pl.TabIndex = 13;
            // 
            // f2Pl
            // 
            this.f2Pl.Controls.Add(this.anotherTb);
            this.f2Pl.Controls.Add(this.enableWifiTb);
            this.f2Pl.Controls.Add(this.currentWifiTb);
            this.f2Pl.Controls.Add(this.ipStatusTb);
            this.f2Pl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.f2Pl.Location = new System.Drawing.Point(3, 3);
            this.f2Pl.Name = "f2Pl";
            this.f2Pl.Size = new System.Drawing.Size(1204, 376);
            this.f2Pl.TabIndex = 14;
            // 
            // anotherTb
            // 
            this.anotherTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.anotherTb.BackColor = System.Drawing.SystemColors.Info;
            this.anotherTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.anotherTb.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anotherTb.Location = new System.Drawing.Point(830, 10);
            this.anotherTb.Multiline = true;
            this.anotherTb.Name = "anotherTb";
            this.anotherTb.ReadOnly = true;
            this.anotherTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.anotherTb.Size = new System.Drawing.Size(360, 354);
            this.anotherTb.TabIndex = 14;
            // 
            // enableWifiTb
            // 
            this.enableWifiTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enableWifiTb.BackColor = System.Drawing.SystemColors.Info;
            this.enableWifiTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enableWifiTb.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableWifiTb.Location = new System.Drawing.Point(426, 10);
            this.enableWifiTb.Multiline = true;
            this.enableWifiTb.Name = "enableWifiTb";
            this.enableWifiTb.ReadOnly = true;
            this.enableWifiTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.enableWifiTb.Size = new System.Drawing.Size(398, 354);
            this.enableWifiTb.TabIndex = 13;
            // 
            // currentWifiTb
            // 
            this.currentWifiTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.currentWifiTb.BackColor = System.Drawing.SystemColors.Info;
            this.currentWifiTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentWifiTb.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentWifiTb.Location = new System.Drawing.Point(10, 156);
            this.currentWifiTb.Multiline = true;
            this.currentWifiTb.Name = "currentWifiTb";
            this.currentWifiTb.ReadOnly = true;
            this.currentWifiTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.currentWifiTb.Size = new System.Drawing.Size(410, 208);
            this.currentWifiTb.TabIndex = 12;
            // 
            // ipStatusTb
            // 
            this.ipStatusTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ipStatusTb.BackColor = System.Drawing.SystemColors.Info;
            this.ipStatusTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ipStatusTb.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipStatusTb.Location = new System.Drawing.Point(14, 10);
            this.ipStatusTb.Multiline = true;
            this.ipStatusTb.Name = "ipStatusTb";
            this.ipStatusTb.ReadOnly = true;
            this.ipStatusTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ipStatusTb.Size = new System.Drawing.Size(406, 140);
            this.ipStatusTb.TabIndex = 11;
            // 
            // f3Pl
            // 
            this.f3Pl.Controls.Add(this.tableLayoutPanel3);
            this.f3Pl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.f3Pl.Location = new System.Drawing.Point(3, 3);
            this.f3Pl.Name = "f3Pl";
            this.f3Pl.Size = new System.Drawing.Size(1204, 376);
            this.f3Pl.TabIndex = 15;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.richTextBox3, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.richTextBox2, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel9, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel8, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel7, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1204, 376);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox3.Location = new System.Drawing.Point(805, 33);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(396, 340);
            this.richTextBox3.TabIndex = 5;
            this.richTextBox3.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(404, 33);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(395, 340);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "CTRL + ALT + 1　フォーム編集レイアウト\nCTRL + ALT + 2　コーディングレイアウト\nCTRL + ALT + 3　レイアウト\n\nCTRL " +
    "+ Shift + ↓　アクティブワードの次に移動する\nCTRL + G　行番号移動";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.richTextBox1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 33);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(395, 340);
            this.panel9.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(395, 340);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label8);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(805, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(396, 24);
            this.panel8.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "VisualStudioCode";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label7);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(404, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(395, 24);
            this.panel7.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "VisualStudio";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label6);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(395, 24);
            this.panel6.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Windows";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1218, 410);
            this.tabControl.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.f1Pl);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1210, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "コマンドリスト";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.f2Pl);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1210, 382);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PC情報";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.f3Pl);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1210, 382);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "チートシート";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1224, 576);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tableLayoutPanel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1218, 154);
            this.panel5.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 420F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1218, 154);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnPerfmon);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(423, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(792, 148);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.comboBoxMain);
            this.panel2.Controls.Add(this.labelDetailInformation);
            this.panel2.Controls.Add(this.statusLb);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 148);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tabControl);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 163);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1218, 410);
            this.panel4.TabIndex = 0;
            // 
            // btnPerfmon
            // 
            this.btnPerfmon.Location = new System.Drawing.Point(250, 28);
            this.btnPerfmon.Name = "btnPerfmon";
            this.btnPerfmon.Size = new System.Drawing.Size(120, 38);
            this.btnPerfmon.TabIndex = 6;
            this.btnPerfmon.Text = "信頼性モニタ";
            this.btnPerfmon.UseVisualStyleBackColor = true;
            this.btnPerfmon.Click += new System.EventHandler(this.BtnPerfmon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 576);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "新ファイル名を指定して実行";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBindingSource)).EndInit();
            this.f1Pl.ResumeLayout(false);
            this.f1Pl.PerformLayout();
            this.f2Pl.ResumeLayout(false);
            this.f2Pl.PerformLayout();
            this.f3Pl.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMain;
        private System.Windows.Forms.Label labelDetailInformation;
        private System.Windows.Forms.CheckBox checkBoxKidoSetting;
        private System.Windows.Forms.ComboBox comboBoxDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox statusLb;
        private System.Windows.Forms.BindingSource commandBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aliasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detail1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detail2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commadNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox commandSearchTb;
        private System.Windows.Forms.TextBox commandNameSearchTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel f1Pl;
        private System.Windows.Forms.Panel f2Pl;
        private System.Windows.Forms.TextBox enableWifiTb;
        private System.Windows.Forms.TextBox currentWifiTb;
        private System.Windows.Forms.TextBox ipStatusTb;
        private System.Windows.Forms.TextBox anotherTb;
        private System.Windows.Forms.Panel f3Pl;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button btnPerfmon;
    }
}


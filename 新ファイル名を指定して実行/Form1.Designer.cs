﻿namespace 新ファイル名を指定して実行
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
            新ファイル名を指定して実行.Properties.Settings settings3 = new 新ファイル名を指定して実行.Properties.Settings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxMain = new System.Windows.Forms.ComboBox();
            this.labelDetailInformation = new System.Windows.Forms.Label();
            this.comboBoxDisplay = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusLb = new System.Windows.Forms.TextBox();
            this.f1Pl = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.commandNameSearchTb = new System.Windows.Forms.TextBox();
            this.commandSearchTb = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aliasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commadNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBoxKidoSetting = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.f1Pl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxMain
            // 
            this.comboBoxMain.FormattingEnabled = true;
            this.comboBoxMain.Location = new System.Drawing.Point(65, 56);
            this.comboBoxMain.Name = "comboBoxMain";
            this.comboBoxMain.Size = new System.Drawing.Size(307, 20);
            this.comboBoxMain.TabIndex = 0;
            this.comboBoxMain.TextUpdate += new System.EventHandler(this.comboBoxMain_TextUpdate);
            this.comboBoxMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxMain_KeyDown);
            this.comboBoxMain.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBoxMain_KeyUp);
            // 
            // labelDetailInformation
            // 
            this.labelDetailInformation.AutoSize = true;
            this.labelDetailInformation.BackColor = System.Drawing.Color.Orange;
            this.labelDetailInformation.Location = new System.Drawing.Point(72, 30);
            this.labelDetailInformation.Name = "labelDetailInformation";
            this.labelDetailInformation.Size = new System.Drawing.Size(0, 12);
            this.labelDetailInformation.TabIndex = 1;
            // 
            // comboBoxDisplay
            // 
            this.comboBoxDisplay.FormattingEnabled = true;
            this.comboBoxDisplay.Items.AddRange(new object[] {
            "左上",
            "左下"});
            this.comboBoxDisplay.Location = new System.Drawing.Point(77, 34);
            this.comboBoxDisplay.Name = "comboBoxDisplay";
            this.comboBoxDisplay.Size = new System.Drawing.Size(56, 20);
            this.comboBoxDisplay.TabIndex = 3;
            this.comboBoxDisplay.Text = "左上";
            this.comboBoxDisplay.TextChanged += new System.EventHandler(this.comboBoxDisplay_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "表示場所：";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkBoxKidoSetting);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxDisplay);
            this.panel1.Location = new System.Drawing.Point(431, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 78);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "名前(O) :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::新ファイル名を指定して実行.Properties.Resources._25_b3;
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
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
            this.label3.Location = new System.Drawing.Point(63, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "管理者権限:CTRL+SHIFT 設定:F1";
            // 
            // statusLb
            // 
            this.statusLb.BackColor = System.Drawing.SystemColors.Info;
            this.statusLb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusLb.Enabled = false;
            this.statusLb.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLb.Location = new System.Drawing.Point(171, 12);
            this.statusLb.Multiline = true;
            this.statusLb.Name = "statusLb";
            this.statusLb.ReadOnly = true;
            this.statusLb.Size = new System.Drawing.Size(201, 38);
            this.statusLb.TabIndex = 11;
            // 
            // f1Pl
            // 
            this.f1Pl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.f1Pl.Controls.Add(this.label5);
            this.f1Pl.Controls.Add(this.label4);
            this.f1Pl.Controls.Add(this.commandNameSearchTb);
            this.f1Pl.Controls.Add(this.commandSearchTb);
            this.f1Pl.Controls.Add(this.dataGridView1);
            this.f1Pl.Location = new System.Drawing.Point(12, 131);
            this.f1Pl.Name = "f1Pl";
            this.f1Pl.Size = new System.Drawing.Size(1025, 318);
            this.f1Pl.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "内容 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "エイリアス :";
            // 
            // commandNameSearchTb
            // 
            this.commandNameSearchTb.Location = new System.Drawing.Point(261, 8);
            this.commandNameSearchTb.Name = "commandNameSearchTb";
            this.commandNameSearchTb.Size = new System.Drawing.Size(122, 19);
            this.commandNameSearchTb.TabIndex = 1;
            this.commandNameSearchTb.TextChanged += new System.EventHandler(this.commandNameSearchTb_TextChanged);
            // 
            // commandSearchTb
            // 
            this.commandSearchTb.Location = new System.Drawing.Point(70, 8);
            this.commandSearchTb.Name = "commandSearchTb";
            this.commandSearchTb.Size = new System.Drawing.Size(114, 19);
            this.commandSearchTb.TabIndex = 1;
            this.commandSearchTb.TextChanged += new System.EventHandler(this.commandSearchTb_TextChanged);
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(1019, 269);
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
            // checkBoxKidoSetting
            // 
            this.checkBoxKidoSetting.AutoSize = true;
            settings3.COMMANDS = ((System.Collections.Specialized.StringCollection)(resources.GetObject("settings3.COMMANDS")));
            settings3.displaySetting = "左上";
            settings3.kidoSetting = false;
            settings3.SettingsKey = "";
            this.checkBoxKidoSetting.Checked = settings3.kidoSetting;
            this.checkBoxKidoSetting.DataBindings.Add(new System.Windows.Forms.Binding("Checked", settings3, "kidoSetting", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxKidoSetting.Location = new System.Drawing.Point(14, 12);
            this.checkBoxKidoSetting.Name = "checkBoxKidoSetting";
            this.checkBoxKidoSetting.Size = new System.Drawing.Size(69, 16);
            this.checkBoxKidoSetting.TabIndex = 2;
            this.checkBoxKidoSetting.Text = "常に起動";
            this.checkBoxKidoSetting.UseVisualStyleBackColor = true;
            this.checkBoxKidoSetting.CheckedChanged += new System.EventHandler(this.checkBoxKidoSetting_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 461);
            this.Controls.Add(this.f1Pl);
            this.Controls.Add(this.statusLb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelDetailInformation);
            this.Controls.Add(this.comboBoxMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "新ファイル名を指定して実行";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.f1Pl.ResumeLayout(false);
            this.f1Pl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Panel f1Pl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox commandNameSearchTb;
        private System.Windows.Forms.TextBox commandSearchTb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aliasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detail1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detail2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commadNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authDataGridViewTextBoxColumn;
    }
}


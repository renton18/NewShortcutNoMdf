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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cOMMANDSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.cOMMANDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new 新ファイル名を指定して実行.DBDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cOMMANDSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cOMMANDSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMMANDSTableAdapter = new 新ファイル名を指定して実行.DBDataSetTableAdapters.COMMANDSTableAdapter();
            this.tableAdapterManager = new 新ファイル名を指定して実行.DBDataSetTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOMMANDSBindingNavigator)).BeginInit();
            this.cOMMANDSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOMMANDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMMANDSDataGridView)).BeginInit();
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
            this.panel1.Location = new System.Drawing.Point(14, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 128);
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
            this.checkBoxKidoSetting.Location = new System.Drawing.Point(14, 12);
            this.checkBoxKidoSetting.Name = "checkBoxKidoSetting";
            this.checkBoxKidoSetting.Size = new System.Drawing.Size(69, 16);
            this.checkBoxKidoSetting.TabIndex = 2;
            this.checkBoxKidoSetting.Text = "常に起動";
            this.checkBoxKidoSetting.UseVisualStyleBackColor = true;
            this.checkBoxKidoSetting.CheckedChanged += new System.EventHandler(this.checkBoxKidoSetting_CheckedChanged);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.cOMMANDSBindingNavigator);
            this.panel2.Controls.Add(this.cOMMANDSDataGridView);
            this.panel2.Location = new System.Drawing.Point(397, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 437);
            this.panel2.TabIndex = 11;
            // 
            // cOMMANDSBindingNavigator
            // 
            this.cOMMANDSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cOMMANDSBindingNavigator.BindingSource = this.cOMMANDSBindingSource;
            this.cOMMANDSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cOMMANDSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cOMMANDSBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.cOMMANDSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cOMMANDSBindingNavigatorSaveItem});
            this.cOMMANDSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cOMMANDSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cOMMANDSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cOMMANDSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cOMMANDSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cOMMANDSBindingNavigator.Name = "cOMMANDSBindingNavigator";
            this.cOMMANDSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cOMMANDSBindingNavigator.Size = new System.Drawing.Size(375, 25);
            this.cOMMANDSBindingNavigator.TabIndex = 12;
            this.cOMMANDSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新規追加";
            // 
            // cOMMANDSBindingSource
            // 
            this.cOMMANDSBindingSource.DataMember = "COMMANDS";
            this.cOMMANDSBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目の総数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "削除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "最初に移動";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "前に戻る";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "現在の場所";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "次に移動";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "最後に移動";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cOMMANDSBindingNavigatorSaveItem
            // 
            this.cOMMANDSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cOMMANDSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cOMMANDSBindingNavigatorSaveItem.Image")));
            this.cOMMANDSBindingNavigatorSaveItem.Name = "cOMMANDSBindingNavigatorSaveItem";
            this.cOMMANDSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cOMMANDSBindingNavigatorSaveItem.Text = "データの保存";
            this.cOMMANDSBindingNavigatorSaveItem.Click += new System.EventHandler(this.cOMMANDSBindingNavigatorSaveItem_Click);
            // 
            // cOMMANDSDataGridView
            // 
            this.cOMMANDSDataGridView.AutoGenerateColumns = false;
            this.cOMMANDSDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cOMMANDSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cOMMANDSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.cOMMANDSDataGridView.DataSource = this.cOMMANDSBindingSource;
            this.cOMMANDSDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cOMMANDSDataGridView.Location = new System.Drawing.Point(0, 28);
            this.cOMMANDSDataGridView.Name = "cOMMANDSDataGridView";
            this.cOMMANDSDataGridView.RowHeadersVisible = false;
            this.cOMMANDSDataGridView.RowTemplate.Height = 21;
            this.cOMMANDSDataGridView.Size = new System.Drawing.Size(375, 409);
            this.cOMMANDSDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "大カテゴリ";
            this.dataGridViewTextBoxColumn2.HeaderText = "大カテゴリ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "小カテゴリ";
            this.dataGridViewTextBoxColumn3.HeaderText = "小カテゴリ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "コマンド";
            this.dataGridViewTextBoxColumn4.HeaderText = "コマンド";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "詳細";
            this.dataGridViewTextBoxColumn5.HeaderText = "詳細";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // cOMMANDSTableAdapter
            // 
            this.cOMMANDSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.COMMANDSTableAdapter = this.cOMMANDSTableAdapter;
            this.tableAdapterManager.UpdateOrder = 新ファイル名を指定して実行.DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel2);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOMMANDSBindingNavigator)).EndInit();
            this.cOMMANDSBindingNavigator.ResumeLayout(false);
            this.cOMMANDSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cOMMANDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMMANDSDataGridView)).EndInit();
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
        private System.Windows.Forms.Panel panel2;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource cOMMANDSBindingSource;
        private DBDataSetTableAdapters.COMMANDSTableAdapter cOMMANDSTableAdapter;
        private DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cOMMANDSBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cOMMANDSBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cOMMANDSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}


﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace 新ファイル名を指定して実行
{
    public partial class Form1 : Form
    {
        //フォーム移動用
        [DllImport("user32.dll")] extern static int MoveWindow(IntPtr hwnd, int x, int y, int nWidth, int nHeight, int bRepaint);

        List<string> aliass = new List<string>();
        List<string> details1 = new List<string>();
        List<string> details2 = new List<string>();
        List<string> commands = new List<string>();

        List<Command> commandList = new List<Command>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //フォーム表示設定
            this.Height = 150;
            this.Width = 400;
            this.KeyPreview = true;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            //フォーム表示位置
            switch (Properties.Settings.Default.displaySetting)
            {
                case "左上": this.Top = 0; this.Left = 0; break;
                case "左下": this.Top = Screen.PrimaryScreen.Bounds.Height - this.Height - 35; this.Left = 0; break;
                default: break;
            }

            //コンボボックス サジェスト設定
            comboBoxMain.Focus();
            AutoCompleteStringCollection sAutoList = new AutoCompleteStringCollection();
            comboBoxMain.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxMain.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBoxMain.AutoCompleteCustomSource = sAutoList;
            //コンボボックス サジェストコマンド登録
            StringCollection configCommandList = Properties.Settings.Default.COMMANDS;
            foreach (String record in configCommandList)
            {
                if (string.IsNullOrEmpty(record))
                {
                    continue;
                }
                String[] items = record.Split(',');
                //コマンドリストの作成
                Command command = new Command
                {
                    alias = items[0],
                    detail1 = items[1],
                    detail2 = items[2],
                    commadName = items[3],
                    auth = items[4]
                };
                commandList.Add(command);
                //サジェスト登録
                sAutoList.Add(items[0]);
            }
        }

        /// <summary>
        /// コマンド入力
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                //int currentCount =
                // aliass.IndexOf(comboBoxMain.Text.Split(new String[] { "[" }, StringSplitOptions.None)[0].Trim());
                //String currentArg = "";
                //String currentCommand = "";
                //if (currentCount != -1)
                //{
                //    currentCommand = commands[currentCount];
                //}
                //else
                //{
                //    currentCommand = comboBoxMain.Text.Split(new String[] { "[" }, StringSplitOptions.None)[0].Trim();
                //}

                //エイリアスからコマンドを取得する
                String currentCommand;
                try
                {
                    currentCommand = commandList.SingleOrDefault(a => a.alias == comboBoxMain.Text).commadName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                //オプションを分割
                String currentArg = "";
                if (currentCommand.IndexOf(" ") != -1)
                {
                    //shell:で始まるもの抜ける
                    if (currentCommand.IndexOf("shell:") == -1)
                    {
                        currentArg = currentCommand.Substring(currentCommand.IndexOf(" "), currentCommand.Length - currentCommand.IndexOf(" ")).Trim();
                        currentCommand = currentCommand.Substring(0, currentCommand.IndexOf(" ")).Trim();
                    }
                }

                //コマンド実行
                Process p = new Process();
                p.StartInfo.FileName = currentCommand;          // コマンド名
                if (currentArg != "") { p.StartInfo.Arguments = currentArg; }         // 引数有の場合
                if (e.Shift && e.Control) { p.StartInfo.Verb = "RunAs"; }         // CTRL + Shiftが押されたら管理者権限実行
                //p.StartInfo.CreateNoWindow = true;            // DOSプロンプトの黒い画面を非表示
                //p.StartInfo.UseShellExecute = false;          // プロセスを新しいウィンドウで起動するか否か
                //p.StartInfo.RedirectStandardOutput = true;    // 標準出力をリダイレクトして取得したい

                try
                {
                    p.Start();
                    //アイドル状態になるまで待機
                    //p.WaitForInputIdle();
                    //表示サイズ
                    //if (e.Alt)
                    //{
                    //    MoveWindow(p.MainWindowHandle, 0, 0,
                    //        Screen.PrimaryScreen.Bounds.Width / 2,
                    //        Screen.PrimaryScreen.Bounds.Height,
                    //        1);
                    //}

                    //「常に起動」にチェックなしの場合
                    if (!checkBoxKidoSetting.Checked)
                    {
                        this.Close();
                        this.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("コマンドありません" + Environment.NewLine + ex.Message);
                }
            }
        }

        private void comboBoxMain_TextUpdate(object sender, EventArgs e)
        {
            int currentCount =
                 aliass.IndexOf(comboBoxMain.Text.Split(new String[] { "[" }, StringSplitOptions.None)[0].Trim());
            if (currentCount != -1)
            {
                labelDetailInformation.Text = details2[currentCount];
            }
            else
            {
                labelDetailInformation.Text = "";
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //設定モード
            if (e.KeyCode == Keys.F1)
            {
                if (this.Height == 150) { this.Height = 500; this.Width = 800; }
                else if (this.Height == 500) { this.Height = 150; this.Width = 400; }

                //フォーム位置
                switch (comboBoxDisplay.Text)
                {
                    case "左上": this.Top = 0; break;
                    case "左下": this.Top = Screen.PrimaryScreen.Bounds.Height - this.Height - 35; break;
                    default: break;
                }

                //Datagridview表示
                commandBindingSource.DataSource = commandList.ToList();
            }
            //管理者権限表示
            if (e.Shift && e.Control)
            {
                //this.Text = this.Text + "  【管理者権限】";
                //反転表示された文字列を批反転状態に戻す
                comboBoxMain.SelectionStart = comboBoxMain.Text.Length;
                comboBoxMain.ForeColor = Color.Brown;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Shift || e.Control)
            {
                //this.Text = this.Text.Replace("  【管理者権限】", "");
                comboBoxMain.ForeColor = Color.Black;
            }
        }

        private void checkBoxKidoSetting_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.kidoSetting = checkBoxKidoSetting.Checked;
            Properties.Settings.Default.Save();
        }
        private void comboBoxDisplay_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.displaySetting = comboBoxDisplay.Text;
            Properties.Settings.Default.Save();
        }

        private void comboBoxMain_KeyUp(object sender, KeyEventArgs e)
        {
            Command command;
            try
            {
                command = commandList.SingleOrDefault(a => a.alias == comboBoxMain.Text);
                statusLb.ForeColor = Color.Black;
                statusLb.Text = command.commadName + Environment.NewLine + command.detail1;
            }
            catch (Exception ex)
            {
                statusLb.ForeColor = Color.Red;
                statusLb.Text = ex.Message;
                return;
            }
        }
    }
}

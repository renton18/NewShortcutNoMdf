using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 新ファイル名を指定して実行
{
    class Command
    {
        [DisplayName("エイリアス")]
        public string alias { get; set; }
        [DisplayName("詳細1")]
        public string detail1 { get; set; }
        [DisplayName("詳細2")]
        public string detail2 { get; set; }
        [DisplayName("コマンド名")]
        public string commadName { get; set; }
        [DisplayName("管理者権限")]
        public string auth { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsClipboardWatcher;
using System.Web;
using System.Text.RegularExpressions;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClipboardSetup();
        }

        private void ClipboardSetup()
        {
            ClipboardWatcher.ClipboardUpdate += (a, b) =>
            {
                string getText = Clipboard.GetText();
                string s;
                if (getText.Length > 6 && getText.Substring(0, 6) == "https:")
                {
                    s = getText.Replace("/en-us/", "/ja-jp/");
                }
                else
                {
                    Regex reg = new Regex("\r\n(?![A-Z*])");
                    getText = reg.Replace(getText, " ");
                    getText = HttpUtility.UrlEncode(getText);
                    string sltl = 英日ToolStripMenuItem.Checked ? "sl=en&tl=ja" :
                                 ベトナム語日本語ToolStripMenuItem.Checked ? "sl=vi&tl=ja" :
                                 中国語日本語ToolStripMenuItem.Checked ? "sl=zh-CN&tl=ja" :
                                 日本語ベトナム語ToolStripMenuItem.Checked ? "sl=ja&tl=vi" :
                                 "sl=en&tl=ja";
                    s = $"https://translate.google.co.jp/?{sltl}&text={getText}&op=translate";
                }

                if (InvokeRequired) // CheckAccess returns true if you're on the dispatcher thread
                {
                    Invoke(new Action<string>(url => { webBrowser1.Url = new Uri(url); }), s);
                    return;
                }
                webBrowser1.Url = new Uri(s);
            };

        }

        private void 英日ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetAllLangCb();
            英日ToolStripMenuItem.Checked = true;
        }

        private void ベトナム語日本語ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetAllLangCb();
            ベトナム語日本語ToolStripMenuItem.Checked = true;

        }

        private void 中国語日本語ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetAllLangCb();
            中国語日本語ToolStripMenuItem.Checked = true ;

        }

        private void 日本語ベトナム語ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetAllLangCb();
            日本語ベトナム語ToolStripMenuItem.Checked = true;

        }
        private void resetAllLangCb()
        {
            英日ToolStripMenuItem.Checked = false;
            中国語日本語ToolStripMenuItem.Checked = false;
            ベトナム語日本語ToolStripMenuItem.Checked = false;
            日本語ベトナム語ToolStripMenuItem.Checked = false;

        }
    }
}

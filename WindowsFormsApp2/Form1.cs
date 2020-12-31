using System;
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
            toolStripStatusLabel1.Text = "start!";
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
                    s = $"https://translate.google.co.jp/?hl=ja&sl=en&tl=ja&text={getText}&op=translate";
                }

                if (InvokeRequired) // CheckAccess returns true if you're on the dispatcher thread
                {
                    Invoke(new Action<string>(url => { webBrowser1.Url = new Uri(url); }), s);
                    return;
                }
                webBrowser1.Url = new Uri(s);
            };

        }
    }
}

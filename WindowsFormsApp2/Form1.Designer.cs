namespace WindowsFormsApp2
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
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.翻訳ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.英日ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ベトナム語日本語ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中国語日本語ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.日本語ベトナム語ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 565);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://www.yahoo.co.jp", System.UriKind.Absolute);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.翻訳ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 翻訳ToolStripMenuItem
            // 
            this.翻訳ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.英日ToolStripMenuItem,
            this.ベトナム語日本語ToolStripMenuItem,
            this.中国語日本語ToolStripMenuItem,
            this.日本語ベトナム語ToolStripMenuItem});
            this.翻訳ToolStripMenuItem.Name = "翻訳ToolStripMenuItem";
            this.翻訳ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.翻訳ToolStripMenuItem.Text = "翻訳";
            // 
            // 英日ToolStripMenuItem
            // 
            this.英日ToolStripMenuItem.Checked = true;
            this.英日ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.英日ToolStripMenuItem.Name = "英日ToolStripMenuItem";
            this.英日ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.英日ToolStripMenuItem.Text = "英語→日本語";
            this.英日ToolStripMenuItem.Click += new System.EventHandler(this.英日ToolStripMenuItem_Click);
            // 
            // ベトナム語日本語ToolStripMenuItem
            // 
            this.ベトナム語日本語ToolStripMenuItem.Name = "ベトナム語日本語ToolStripMenuItem";
            this.ベトナム語日本語ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ベトナム語日本語ToolStripMenuItem.Text = "ベトナム語→日本語";
            this.ベトナム語日本語ToolStripMenuItem.Click += new System.EventHandler(this.ベトナム語日本語ToolStripMenuItem_Click);
            // 
            // 中国語日本語ToolStripMenuItem
            // 
            this.中国語日本語ToolStripMenuItem.Name = "中国語日本語ToolStripMenuItem";
            this.中国語日本語ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.中国語日本語ToolStripMenuItem.Text = "中国語→日本語";
            this.中国語日本語ToolStripMenuItem.Click += new System.EventHandler(this.中国語日本語ToolStripMenuItem_Click);
            // 
            // 日本語ベトナム語ToolStripMenuItem
            // 
            this.日本語ベトナム語ToolStripMenuItem.Name = "日本語ベトナム語ToolStripMenuItem";
            this.日本語ベトナム語ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.日本語ベトナム語ToolStripMenuItem.Text = "日本語→ベトナム語";
            this.日本語ベトナム語ToolStripMenuItem.Click += new System.EventHandler(this.日本語ベトナム語ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.webBrowser1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 翻訳ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 英日ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ベトナム語日本語ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中国語日本語ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 日本語ベトナム語ToolStripMenuItem;
    }
}


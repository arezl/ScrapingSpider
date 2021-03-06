﻿namespace ScrapingSpider.Forms
{
    partial class FrmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label crawlDepthLabel;
            System.Windows.Forms.Label escapeLinksLabel;
            System.Windows.Forms.Label initSeedsLabel;
            System.Windows.Forms.Label keepCookieLabel;
            System.Windows.Forms.Label lockHostLabel;
            System.Windows.Forms.Label threadsLabel;
            System.Windows.Forms.Label timeoutLabel;
            System.Windows.Forms.Label userAgentLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.crawlDepthTextBox = new System.Windows.Forms.TextBox();
            this.escapeLinksTextBox = new System.Windows.Forms.TextBox();
            this.initSeedsTextBox = new System.Windows.Forms.TextBox();
            this.keepCookieCheckBox = new System.Windows.Forms.CheckBox();
            this.lockHostCheckBox = new System.Windows.Forms.CheckBox();
            this.threadsTextBox = new System.Windows.Forms.TextBox();
            this.timeoutTextBox = new System.Windows.Forms.TextBox();
            this.userAgentTextBox = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.keywordsTextbox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.settingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regexFilterTextBox = new System.Windows.Forms.TextBox();
            crawlDepthLabel = new System.Windows.Forms.Label();
            escapeLinksLabel = new System.Windows.Forms.Label();
            initSeedsLabel = new System.Windows.Forms.Label();
            keepCookieLabel = new System.Windows.Forms.Label();
            lockHostLabel = new System.Windows.Forms.Label();
            threadsLabel = new System.Windows.Forms.Label();
            timeoutLabel = new System.Windows.Forms.Label();
            userAgentLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // crawlDepthLabel
            // 
            crawlDepthLabel.AutoSize = true;
            crawlDepthLabel.Location = new System.Drawing.Point(405, 183);
            crawlDepthLabel.Name = "crawlDepthLabel";
            crawlDepthLabel.Size = new System.Drawing.Size(77, 12);
            crawlDepthLabel.TabIndex = 1;
            crawlDepthLabel.Text = "Crawl Depth:";
            // 
            // escapeLinksLabel
            // 
            escapeLinksLabel.AutoSize = true;
            escapeLinksLabel.Location = new System.Drawing.Point(405, 210);
            escapeLinksLabel.Name = "escapeLinksLabel";
            escapeLinksLabel.Size = new System.Drawing.Size(83, 12);
            escapeLinksLabel.TabIndex = 3;
            escapeLinksLabel.Text = "Escape Links:";
            // 
            // initSeedsLabel
            // 
            initSeedsLabel.AutoSize = true;
            initSeedsLabel.Location = new System.Drawing.Point(21, 18);
            initSeedsLabel.Name = "initSeedsLabel";
            initSeedsLabel.Size = new System.Drawing.Size(71, 12);
            initSeedsLabel.TabIndex = 5;
            initSeedsLabel.Text = "Init Seeds:";
            // 
            // keepCookieLabel
            // 
            keepCookieLabel.AutoSize = true;
            keepCookieLabel.Location = new System.Drawing.Point(405, 239);
            keepCookieLabel.Name = "keepCookieLabel";
            keepCookieLabel.Size = new System.Drawing.Size(77, 12);
            keepCookieLabel.TabIndex = 7;
            keepCookieLabel.Text = "Keep Cookie:";
            // 
            // lockHostLabel
            // 
            lockHostLabel.AutoSize = true;
            lockHostLabel.Location = new System.Drawing.Point(405, 269);
            lockHostLabel.Name = "lockHostLabel";
            lockHostLabel.Size = new System.Drawing.Size(65, 12);
            lockHostLabel.TabIndex = 9;
            lockHostLabel.Text = "Lock Host:";
            // 
            // threadsLabel
            // 
            threadsLabel.AutoSize = true;
            threadsLabel.Location = new System.Drawing.Point(405, 322);
            threadsLabel.Name = "threadsLabel";
            threadsLabel.Size = new System.Drawing.Size(53, 12);
            threadsLabel.TabIndex = 11;
            threadsLabel.Text = "Threads:";
            // 
            // timeoutLabel
            // 
            timeoutLabel.AutoSize = true;
            timeoutLabel.Location = new System.Drawing.Point(405, 349);
            timeoutLabel.Name = "timeoutLabel";
            timeoutLabel.Size = new System.Drawing.Size(53, 12);
            timeoutLabel.TabIndex = 13;
            timeoutLabel.Text = "Timeout:";
            // 
            // userAgentLabel
            // 
            userAgentLabel.AutoSize = true;
            userAgentLabel.Location = new System.Drawing.Point(405, 376);
            userAgentLabel.Name = "userAgentLabel";
            userAgentLabel.Size = new System.Drawing.Size(71, 12);
            userAgentLabel.TabIndex = 15;
            userAgentLabel.Text = "User Agent:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(21, 212);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 12);
            label1.TabIndex = 5;
            label1.Text = "Keywords:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(405, 296);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(77, 12);
            label2.TabIndex = 9;
            label2.Text = "Limit Speed:";
            // 
            // crawlDepthTextBox
            // 
            this.crawlDepthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "CrawlDepth", true));
            this.crawlDepthTextBox.Location = new System.Drawing.Point(494, 180);
            this.crawlDepthTextBox.Name = "crawlDepthTextBox";
            this.crawlDepthTextBox.Size = new System.Drawing.Size(273, 21);
            this.crawlDepthTextBox.TabIndex = 2;
            // 
            // escapeLinksTextBox
            // 
            this.escapeLinksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "EscapeLinks", true));
            this.escapeLinksTextBox.Location = new System.Drawing.Point(494, 207);
            this.escapeLinksTextBox.Name = "escapeLinksTextBox";
            this.escapeLinksTextBox.Size = new System.Drawing.Size(273, 21);
            this.escapeLinksTextBox.TabIndex = 4;
            // 
            // initSeedsTextBox
            // 
            this.initSeedsTextBox.AcceptsReturn = true;
            this.initSeedsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "InitSeeds", true));
            this.initSeedsTextBox.Location = new System.Drawing.Point(23, 36);
            this.initSeedsTextBox.Multiline = true;
            this.initSeedsTextBox.Name = "initSeedsTextBox";
            this.initSeedsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.initSeedsTextBox.Size = new System.Drawing.Size(348, 163);
            this.initSeedsTextBox.TabIndex = 6;
            // 
            // keepCookieCheckBox
            // 
            this.keepCookieCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.settingsBindingSource, "KeepCookie", true));
            this.keepCookieCheckBox.Location = new System.Drawing.Point(494, 234);
            this.keepCookieCheckBox.Name = "keepCookieCheckBox";
            this.keepCookieCheckBox.Size = new System.Drawing.Size(104, 24);
            this.keepCookieCheckBox.TabIndex = 8;
            this.keepCookieCheckBox.Text = "Keep";
            this.keepCookieCheckBox.UseVisualStyleBackColor = true;
            // 
            // lockHostCheckBox
            // 
            this.lockHostCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.settingsBindingSource, "LockHost", true));
            this.lockHostCheckBox.Location = new System.Drawing.Point(494, 264);
            this.lockHostCheckBox.Name = "lockHostCheckBox";
            this.lockHostCheckBox.Size = new System.Drawing.Size(104, 24);
            this.lockHostCheckBox.TabIndex = 10;
            this.lockHostCheckBox.Text = "Lock";
            this.lockHostCheckBox.UseVisualStyleBackColor = true;
            // 
            // threadsTextBox
            // 
            this.threadsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "Threads", true));
            this.threadsTextBox.Location = new System.Drawing.Point(494, 319);
            this.threadsTextBox.Name = "threadsTextBox";
            this.threadsTextBox.Size = new System.Drawing.Size(273, 21);
            this.threadsTextBox.TabIndex = 12;
            // 
            // timeoutTextBox
            // 
            this.timeoutTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "Timeout", true));
            this.timeoutTextBox.Location = new System.Drawing.Point(494, 346);
            this.timeoutTextBox.Name = "timeoutTextBox";
            this.timeoutTextBox.Size = new System.Drawing.Size(273, 21);
            this.timeoutTextBox.TabIndex = 14;
            // 
            // userAgentTextBox
            // 
            this.userAgentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "UserAgent", true));
            this.userAgentTextBox.Location = new System.Drawing.Point(494, 373);
            this.userAgentTextBox.Name = "userAgentTextBox";
            this.userAgentTextBox.Size = new System.Drawing.Size(273, 21);
            this.userAgentTextBox.TabIndex = 16;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(676, 412);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(92, 28);
            this.btnOK.TabIndex = 17;
            this.btnOK.Text = "Start Crawl";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // keywordsTextbox
            // 
            this.keywordsTextbox.AcceptsReturn = true;
            this.keywordsTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "Keywords", true));
            this.keywordsTextbox.Location = new System.Drawing.Point(23, 231);
            this.keywordsTextbox.Multiline = true;
            this.keywordsTextbox.Name = "keywordsTextbox";
            this.keywordsTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.keywordsTextbox.Size = new System.Drawing.Size(348, 163);
            this.keywordsTextbox.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.settingsBindingSource, "LimitSpeed", true));
            this.checkBox1.Location = new System.Drawing.Point(494, 291);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 24);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Limit";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // settingsBindingSource
            // 
            this.settingsBindingSource.AllowNew = false;
            this.settingsBindingSource.DataSource = typeof(ScrapingSpider.Core.Models.Settings);
            // 
            // regexFilterTextBox
            // 
            this.regexFilterTextBox.AcceptsReturn = true;
            this.regexFilterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "RegexFilter", true));
            this.regexFilterTextBox.Location = new System.Drawing.Point(405, 36);
            this.regexFilterTextBox.Multiline = true;
            this.regexFilterTextBox.Name = "regexFilterTextBox";
            this.regexFilterTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.regexFilterTextBox.Size = new System.Drawing.Size(362, 128);
            this.regexFilterTextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(403, 18);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(83, 12);
            label3.TabIndex = 5;
            label3.Text = "Regex Filter:";
            // 
            // FrmSettings
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 456);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(crawlDepthLabel);
            this.Controls.Add(this.crawlDepthTextBox);
            this.Controls.Add(escapeLinksLabel);
            this.Controls.Add(this.escapeLinksTextBox);
            this.Controls.Add(label1);
            this.Controls.Add(label3);
            this.Controls.Add(initSeedsLabel);
            this.Controls.Add(this.keywordsTextbox);
            this.Controls.Add(this.regexFilterTextBox);
            this.Controls.Add(this.initSeedsTextBox);
            this.Controls.Add(keepCookieLabel);
            this.Controls.Add(this.keepCookieCheckBox);
            this.Controls.Add(label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(lockHostLabel);
            this.Controls.Add(this.lockHostCheckBox);
            this.Controls.Add(threadsLabel);
            this.Controls.Add(this.threadsTextBox);
            this.Controls.Add(timeoutLabel);
            this.Controls.Add(this.timeoutTextBox);
            this.Controls.Add(userAgentLabel);
            this.Controls.Add(this.userAgentTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.Text = "ScrapingSpider - Settings";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.FrmSettings_HelpButtonClicked);
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource settingsBindingSource;
        private System.Windows.Forms.TextBox crawlDepthTextBox;
        private System.Windows.Forms.TextBox escapeLinksTextBox;
        private System.Windows.Forms.TextBox initSeedsTextBox;
        private System.Windows.Forms.CheckBox keepCookieCheckBox;
        private System.Windows.Forms.CheckBox lockHostCheckBox;
        private System.Windows.Forms.TextBox threadsTextBox;
        private System.Windows.Forms.TextBox timeoutTextBox;
        private System.Windows.Forms.TextBox userAgentTextBox;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox keywordsTextbox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox regexFilterTextBox;
    }
}

namespace Browser
{
    partial class Form1
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
            this.browser = new System.Windows.Forms.WebBrowser();
            this.back = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.adresaLabel = new System.Windows.Forms.Label();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.go = new System.Windows.Forms.Button();
            this.gmailButton = new System.Windows.Forms.Button();
            this.webmailButton = new System.Windows.Forms.Button();
            this.ispisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // browser
            // 
            this.browser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browser.Location = new System.Drawing.Point(0, 41);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(802, 409);
            this.browser.TabIndex = 0;
            this.browser.Url = new System.Uri("http://web2.ss-zcrnje-rovinj.skole.hr/", System.UriKind.Absolute);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(31, 23);
            this.back.TabIndex = 2;
            this.back.Text = "<<";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.Location = new System.Drawing.Point(49, 12);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(31, 23);
            this.forwardButton.TabIndex = 3;
            this.forwardButton.Text = ">>";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // adresaLabel
            // 
            this.adresaLabel.AutoSize = true;
            this.adresaLabel.Location = new System.Drawing.Point(86, 17);
            this.adresaLabel.Name = "adresaLabel";
            this.adresaLabel.Size = new System.Drawing.Size(43, 13);
            this.adresaLabel.TabIndex = 4;
            this.adresaLabel.Text = "Adresa:";
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(136, 17);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(405, 20);
            this.urlBox.TabIndex = 5;
            // 
            // go
            // 
            this.go.Location = new System.Drawing.Point(547, 15);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(31, 23);
            this.go.TabIndex = 6;
            this.go.Text = "Idi";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // gmailButton
            // 
            this.gmailButton.Location = new System.Drawing.Point(598, 15);
            this.gmailButton.Name = "gmailButton";
            this.gmailButton.Size = new System.Drawing.Size(45, 23);
            this.gmailButton.TabIndex = 7;
            this.gmailButton.Text = "Gmail";
            this.gmailButton.UseVisualStyleBackColor = true;
            this.gmailButton.Click += new System.EventHandler(this.gmailButton_Click);
            // 
            // webmailButton
            // 
            this.webmailButton.Location = new System.Drawing.Point(649, 15);
            this.webmailButton.Name = "webmailButton";
            this.webmailButton.Size = new System.Drawing.Size(60, 23);
            this.webmailButton.TabIndex = 8;
            this.webmailButton.Text = "Webmail";
            this.webmailButton.UseVisualStyleBackColor = true;
            this.webmailButton.Click += new System.EventHandler(this.webmailButton_Click);
            // 
            // ispisButton
            // 
            this.ispisButton.Location = new System.Drawing.Point(715, 17);
            this.ispisButton.Name = "ispisButton";
            this.ispisButton.Size = new System.Drawing.Size(60, 23);
            this.ispisButton.TabIndex = 9;
            this.ispisButton.Text = "Ispis";
            this.ispisButton.UseVisualStyleBackColor = true;
            this.ispisButton.Click += new System.EventHandler(this.ispisButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ispisButton);
            this.Controls.Add(this.webmailButton);
            this.Controls.Add(this.gmailButton);
            this.Controls.Add(this.go);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.adresaLabel);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.back);
            this.Controls.Add(this.browser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Label adresaLabel;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Button gmailButton;
        private System.Windows.Forms.Button webmailButton;
        private System.Windows.Forms.Button ispisButton;
    }
}


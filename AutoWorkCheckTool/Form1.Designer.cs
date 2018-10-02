namespace AutoWorkCheckTool
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.WebViewBox = new System.Windows.Forms.GroupBox();
            this.WebBrowserView = new System.Windows.Forms.WebBrowser();
            this.ShutdownButton = new System.Windows.Forms.Button();
            this.AccountTextBox = new System.Windows.Forms.TextBox();
            this.WebViewBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // WebViewBox
            // 
            this.WebViewBox.Controls.Add(this.WebBrowserView);
            this.WebViewBox.Location = new System.Drawing.Point(12, 78);
            this.WebViewBox.Name = "WebViewBox";
            this.WebViewBox.Size = new System.Drawing.Size(425, 449);
            this.WebViewBox.TabIndex = 0;
            this.WebViewBox.TabStop = false;
            this.WebViewBox.Text = "WebViewBox";
            // 
            // WebBrowserView
            // 
            this.WebBrowserView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebBrowserView.Location = new System.Drawing.Point(3, 17);
            this.WebBrowserView.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowserView.Name = "WebBrowserView";
            this.WebBrowserView.Size = new System.Drawing.Size(419, 429);
            this.WebBrowserView.TabIndex = 0;
            this.WebBrowserView.Url = new System.Uri("http://www.naver.com", System.UriKind.Absolute);
            // 
            // ShutdownButton
            // 
            this.ShutdownButton.Location = new System.Drawing.Point(362, 12);
            this.ShutdownButton.Name = "ShutdownButton";
            this.ShutdownButton.Size = new System.Drawing.Size(75, 23);
            this.ShutdownButton.TabIndex = 3;
            this.ShutdownButton.Text = "시스템종료";
            this.ShutdownButton.UseVisualStyleBackColor = true;
            this.ShutdownButton.Click += new System.EventHandler(this.ShutdownButton_Click);
            // 
            // AccountTextBox
            // 
            this.AccountTextBox.Location = new System.Drawing.Point(15, 12);
            this.AccountTextBox.Name = "AccountTextBox";
            this.AccountTextBox.Size = new System.Drawing.Size(212, 21);
            this.AccountTextBox.TabIndex = 4;
            this.AccountTextBox.Text = "sin8392/choi8392";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 539);
            this.Controls.Add(this.AccountTextBox);
            this.Controls.Add(this.ShutdownButton);
            this.Controls.Add(this.WebViewBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WebViewBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox WebViewBox;
        private System.Windows.Forms.WebBrowser WebBrowserView;
        private System.Windows.Forms.Button ShutdownButton;
        private System.Windows.Forms.TextBox AccountTextBox;
    }
}


namespace SimpleButtonApp
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
            this.simpleButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // simpleButton
            // 
            this.simpleButton.Location = new System.Drawing.Point(120, 119);
            this.simpleButton.Name = "simpleButton";
            this.simpleButton.Size = new System.Drawing.Size(139, 63);
            this.simpleButton.TabIndex = 0;
            this.simpleButton.Text = "Click Me!";
            this.simpleButton.UseVisualStyleBackColor = true;
            this.simpleButton.Click += new System.EventHandler(this.simpleButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 313);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.simpleButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button simpleButton;
        private System.Windows.Forms.Button button1;
    }
}


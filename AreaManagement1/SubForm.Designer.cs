namespace Subform
{
    partial class SubForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.QuadRazio = new System.Windows.Forms.RadioButton();
            this.TriangleRazio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TriangleRazio);
            this.groupBox1.Controls.Add(this.QuadRazio);
            this.groupBox1.Location = new System.Drawing.Point(32, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "種類";
            // 
            // QuadRazio
            // 
            this.QuadRazio.AutoSize = true;
            this.QuadRazio.Checked = true;
            this.QuadRazio.Location = new System.Drawing.Point(19, 29);
            this.QuadRazio.Name = "QuadRazio";
            this.QuadRazio.Size = new System.Drawing.Size(59, 16);
            this.QuadRazio.TabIndex = 0;
            this.QuadRazio.TabStop = true;
            this.QuadRazio.Text = "四角形";
            this.QuadRazio.UseVisualStyleBackColor = true;
            // 
            // TriangleRazio
            // 
            this.TriangleRazio.AutoSize = true;
            this.TriangleRazio.Location = new System.Drawing.Point(113, 29);
            this.TriangleRazio.Name = "TriangleRazio";
            this.TriangleRazio.Size = new System.Drawing.Size(59, 16);
            this.TriangleRazio.TabIndex = 1;
            this.TriangleRazio.TabStop = true;
            this.TriangleRazio.Text = "三角形";
            this.TriangleRazio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "一辺の長さ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 19);
            this.textBox1.TabIndex = 2;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(32, 153);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 45);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(157, 153);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 45);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 210);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "SubForm";
            this.Text = "図形追加";
            this.Load += new System.EventHandler(this.SubForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton TriangleRazio;
        private System.Windows.Forms.RadioButton QuadRazio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
    }
}


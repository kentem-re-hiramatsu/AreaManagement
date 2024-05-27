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
            this.TrapezoidRadio = new System.Windows.Forms.RadioButton();
            this.TriangleRadio = new System.Windows.Forms.RadioButton();
            this.QuadRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.upperBaseLengthtextBox = new System.Windows.Forms.TextBox();
            this.lowerBaseLengthtextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TrapezoidRadio);
            this.groupBox1.Controls.Add(this.TriangleRadio);
            this.groupBox1.Controls.Add(this.QuadRadio);
            this.groupBox1.Location = new System.Drawing.Point(32, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "種類";
            // 
            // TrapezoidRadio
            // 
            this.TrapezoidRadio.AutoSize = true;
            this.TrapezoidRadio.Location = new System.Drawing.Point(147, 29);
            this.TrapezoidRadio.Name = "TrapezoidRadio";
            this.TrapezoidRadio.Size = new System.Drawing.Size(47, 16);
            this.TrapezoidRadio.TabIndex = 2;
            this.TrapezoidRadio.TabStop = true;
            this.TrapezoidRadio.Text = "台形";
            this.TrapezoidRadio.UseVisualStyleBackColor = true;
            this.TrapezoidRadio.CheckedChanged += new System.EventHandler(this.TrapezoidRadioButtonChange);
            // 
            // TriangleRadio
            // 
            this.TriangleRadio.AutoSize = true;
            this.TriangleRadio.Location = new System.Drawing.Point(72, 29);
            this.TriangleRadio.Name = "TriangleRadio";
            this.TriangleRadio.Size = new System.Drawing.Size(59, 16);
            this.TriangleRadio.TabIndex = 1;
            this.TriangleRadio.TabStop = true;
            this.TriangleRadio.Text = "三角形";
            this.TriangleRadio.UseVisualStyleBackColor = true;
            this.TriangleRadio.CheckedChanged += new System.EventHandler(this.TrapezoidRadioButtonChange);
            // 
            // QuadRadio
            // 
            this.QuadRadio.AutoSize = true;
            this.QuadRadio.Checked = true;
            this.QuadRadio.Location = new System.Drawing.Point(6, 29);
            this.QuadRadio.Name = "QuadRadio";
            this.QuadRadio.Size = new System.Drawing.Size(59, 16);
            this.QuadRadio.TabIndex = 0;
            this.QuadRadio.TabStop = true;
            this.QuadRadio.Text = "四角形";
            this.QuadRadio.UseVisualStyleBackColor = true;
            this.QuadRadio.CheckedChanged += new System.EventHandler(this.TrapezoidRadioButtonChange);
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
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(104, 115);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(128, 19);
            this.LengthTextBox.TabIndex = 2;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // OkButton
            // 
            this.OkButton.Enabled = false;
            this.OkButton.Location = new System.Drawing.Point(32, 201);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 45);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(157, 201);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 45);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "上底の長さ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "下底の長さ";
            // 
            // upperBaseLengthtextBox
            // 
            this.upperBaseLengthtextBox.Enabled = false;
            this.upperBaseLengthtextBox.Location = new System.Drawing.Point(104, 144);
            this.upperBaseLengthtextBox.Name = "upperBaseLengthtextBox";
            this.upperBaseLengthtextBox.Size = new System.Drawing.Size(128, 19);
            this.upperBaseLengthtextBox.TabIndex = 7;
            this.upperBaseLengthtextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lowerBaseLengthtextBox
            // 
            this.lowerBaseLengthtextBox.Enabled = false;
            this.lowerBaseLengthtextBox.Location = new System.Drawing.Point(104, 170);
            this.lowerBaseLengthtextBox.Name = "lowerBaseLengthtextBox";
            this.lowerBaseLengthtextBox.Size = new System.Drawing.Size(128, 19);
            this.lowerBaseLengthtextBox.TabIndex = 8;
            this.lowerBaseLengthtextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 258);
            this.Controls.Add(this.lowerBaseLengthtextBox);
            this.Controls.Add(this.upperBaseLengthtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.LengthTextBox);
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
        private System.Windows.Forms.RadioButton TriangleRadio;
        private System.Windows.Forms.RadioButton QuadRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.RadioButton TrapezoidRadio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox upperBaseLengthtextBox;
        private System.Windows.Forms.TextBox lowerBaseLengthtextBox;
    }
}


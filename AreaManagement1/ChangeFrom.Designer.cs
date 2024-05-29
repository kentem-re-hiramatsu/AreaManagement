namespace ChangeForm
{
    partial class ChangeFrom
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
            this.ShapeBox = new System.Windows.Forms.GroupBox();
            this.TrapezoidRadio = new System.Windows.Forms.RadioButton();
            this.TriangleRadio = new System.Windows.Forms.RadioButton();
            this.QuadRadio = new System.Windows.Forms.RadioButton();
            this.lowerBaseLengthtextBox = new System.Windows.Forms.TextBox();
            this.upperBaseLengthtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.SideLengthLabel = new System.Windows.Forms.Label();
            this.CircleRadio = new System.Windows.Forms.RadioButton();
            this.ShapeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShapeBox
            // 
            this.ShapeBox.Controls.Add(this.CircleRadio);
            this.ShapeBox.Controls.Add(this.TrapezoidRadio);
            this.ShapeBox.Controls.Add(this.TriangleRadio);
            this.ShapeBox.Controls.Add(this.QuadRadio);
            this.ShapeBox.Location = new System.Drawing.Point(39, 31);
            this.ShapeBox.Name = "ShapeBox";
            this.ShapeBox.Size = new System.Drawing.Size(245, 71);
            this.ShapeBox.TabIndex = 1;
            this.ShapeBox.TabStop = false;
            this.ShapeBox.Text = "種類";
            // 
            // TrapezoidRadio
            // 
            this.TrapezoidRadio.AutoSize = true;
            this.TrapezoidRadio.Enabled = false;
            this.TrapezoidRadio.Location = new System.Drawing.Point(147, 29);
            this.TrapezoidRadio.Name = "TrapezoidRadio";
            this.TrapezoidRadio.Size = new System.Drawing.Size(47, 16);
            this.TrapezoidRadio.TabIndex = 2;
            this.TrapezoidRadio.Text = "台形";
            this.TrapezoidRadio.UseVisualStyleBackColor = true;
            // 
            // TriangleRadio
            // 
            this.TriangleRadio.AutoSize = true;
            this.TriangleRadio.Enabled = false;
            this.TriangleRadio.Location = new System.Drawing.Point(72, 29);
            this.TriangleRadio.Name = "TriangleRadio";
            this.TriangleRadio.Size = new System.Drawing.Size(59, 16);
            this.TriangleRadio.TabIndex = 1;
            this.TriangleRadio.Text = "三角形";
            this.TriangleRadio.UseVisualStyleBackColor = true;
            // 
            // QuadRadio
            // 
            this.QuadRadio.AutoSize = true;
            this.QuadRadio.Checked = true;
            this.QuadRadio.Enabled = false;
            this.QuadRadio.Location = new System.Drawing.Point(6, 29);
            this.QuadRadio.Name = "QuadRadio";
            this.QuadRadio.Size = new System.Drawing.Size(59, 16);
            this.QuadRadio.TabIndex = 0;
            this.QuadRadio.TabStop = true;
            this.QuadRadio.Text = "四角形";
            this.QuadRadio.UseVisualStyleBackColor = true;
            // 
            // lowerBaseLengthtextBox
            // 
            this.lowerBaseLengthtextBox.Enabled = false;
            this.lowerBaseLengthtextBox.Location = new System.Drawing.Point(133, 170);
            this.lowerBaseLengthtextBox.Name = "lowerBaseLengthtextBox";
            this.lowerBaseLengthtextBox.Size = new System.Drawing.Size(128, 19);
            this.lowerBaseLengthtextBox.TabIndex = 16;
            // 
            // upperBaseLengthtextBox
            // 
            this.upperBaseLengthtextBox.Enabled = false;
            this.upperBaseLengthtextBox.Location = new System.Drawing.Point(133, 144);
            this.upperBaseLengthtextBox.Name = "upperBaseLengthtextBox";
            this.upperBaseLengthtextBox.Size = new System.Drawing.Size(128, 19);
            this.upperBaseLengthtextBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "下底の長さ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "上底の長さ";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(186, 201);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 45);
            this.CancelButton.TabIndex = 12;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Enabled = false;
            this.OkButton.Location = new System.Drawing.Point(61, 201);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 45);
            this.OkButton.TabIndex = 11;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(133, 115);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(128, 19);
            this.LengthTextBox.TabIndex = 10;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
            // 
            // SideLengthLabel
            // 
            this.SideLengthLabel.AutoSize = true;
            this.SideLengthLabel.Location = new System.Drawing.Point(61, 118);
            this.SideLengthLabel.Name = "SideLengthLabel";
            this.SideLengthLabel.Size = new System.Drawing.Size(59, 12);
            this.SideLengthLabel.TabIndex = 9;
            this.SideLengthLabel.Text = "一辺の長さ";
            // 
            // CircleRadio
            // 
            this.CircleRadio.AutoSize = true;
            this.CircleRadio.Enabled = false;
            this.CircleRadio.Location = new System.Drawing.Point(200, 29);
            this.CircleRadio.Name = "CircleRadio";
            this.CircleRadio.Size = new System.Drawing.Size(35, 16);
            this.CircleRadio.TabIndex = 17;
            this.CircleRadio.TabStop = true;
            this.CircleRadio.Text = "円";
            this.CircleRadio.UseVisualStyleBackColor = true;
            // 
            // ChangeFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 258);
            this.Controls.Add(this.lowerBaseLengthtextBox);
            this.Controls.Add(this.upperBaseLengthtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.LengthTextBox);
            this.Controls.Add(this.SideLengthLabel);
            this.Controls.Add(this.ShapeBox);
            this.Name = "ChangeFrom";
            this.Text = "図形変更画面";
            this.Load += new System.EventHandler(this.ChangeFrom_Load);
            this.ShapeBox.ResumeLayout(false);
            this.ShapeBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ShapeBox;
        private System.Windows.Forms.RadioButton TrapezoidRadio;
        private System.Windows.Forms.RadioButton TriangleRadio;
        private System.Windows.Forms.RadioButton QuadRadio;
        private System.Windows.Forms.TextBox lowerBaseLengthtextBox;
        private System.Windows.Forms.TextBox upperBaseLengthtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.Label SideLengthLabel;
        private System.Windows.Forms.RadioButton CircleRadio;
    }
}


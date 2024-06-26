﻿namespace AreaManagement1
{
    partial class MainForm
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
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.ShapeListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChangeButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.UpDigit = new System.Windows.Forms.Button();
            this.DownDigit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(281, 48);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(99, 40);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "追加";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(281, 156);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(99, 40);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.TabStop = false;
            this.DeleteButton.Text = "削除";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(279, 21);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(37, 12);
            this.TotalLabel.TabIndex = 2;
            this.TotalLabel.Text = "Total：";
            // 
            // ShapeListView
            // 
            this.ShapeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ShapeListView.FullRowSelect = true;
            this.ShapeListView.HideSelection = false;
            this.ShapeListView.Location = new System.Drawing.Point(33, 21);
            this.ShapeListView.Name = "ShapeListView";
            this.ShapeListView.Size = new System.Drawing.Size(227, 217);
            this.ShapeListView.TabIndex = 3;
            this.ShapeListView.UseCompatibleStateImageBehavior = false;
            this.ShapeListView.View = System.Windows.Forms.View.Details;
            this.ShapeListView.SelectedIndexChanged += new System.EventHandler(this.ShapeListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "図形名称";
            this.columnHeader1.Width = 104;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "面積（m²）";
            this.columnHeader2.Width = 96;
            // 
            // ChangeButton
            // 
            this.ChangeButton.Enabled = false;
            this.ChangeButton.Location = new System.Drawing.Point(281, 101);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(99, 40);
            this.ChangeButton.TabIndex = 4;
            this.ChangeButton.TabStop = false;
            this.ChangeButton.Text = "変更";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Enabled = false;
            this.ClearButton.Location = new System.Drawing.Point(330, 202);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(50, 40);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.TabStop = false;
            this.ClearButton.Text = "クリア";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // UpDigit
            // 
            this.UpDigit.Enabled = false;
            this.UpDigit.Location = new System.Drawing.Point(33, 244);
            this.UpDigit.Name = "UpDigit";
            this.UpDigit.Size = new System.Drawing.Size(37, 40);
            this.UpDigit.TabIndex = 6;
            this.UpDigit.Text = "＜";
            this.UpDigit.UseVisualStyleBackColor = true;
            this.UpDigit.Click += new System.EventHandler(this.UpDigit_Click);
            // 
            // DownDigit
            // 
            this.DownDigit.Enabled = false;
            this.DownDigit.Location = new System.Drawing.Point(76, 244);
            this.DownDigit.Name = "DownDigit";
            this.DownDigit.Size = new System.Drawing.Size(37, 40);
            this.DownDigit.TabIndex = 7;
            this.DownDigit.Text = "＞";
            this.DownDigit.UseVisualStyleBackColor = true;
            this.DownDigit.Click += new System.EventHandler(this.DownDigit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 293);
            this.Controls.Add(this.DownDigit);
            this.Controls.Add(this.UpDigit);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.ShapeListView);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Name = "MainForm";
            this.Text = "面積管理システム";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.ListView ShapeListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button UpDigit;
        private System.Windows.Forms.Button DownDigit;
    }
}


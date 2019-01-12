namespace TicTacToe.Forms
{
    partial class MainForm
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
            this.GameModeListBox = new System.Windows.Forms.CheckedListBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RowsTb = new System.Windows.Forms.TextBox();
            this.ColumnsTb = new System.Windows.Forms.TextBox();
            this.DepthSearchTb = new System.Windows.Forms.TextBox();
            this.DepthSearchLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GameModeListBox
            // 
            this.GameModeListBox.FormattingEnabled = true;
            this.GameModeListBox.Location = new System.Drawing.Point(302, 49);
            this.GameModeListBox.Name = "GameModeListBox";
            this.GameModeListBox.Size = new System.Drawing.Size(153, 49);
            this.GameModeListBox.TabIndex = 0;
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(302, 180);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(152, 23);
            this.StartBtn.TabIndex = 1;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rows:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Columns:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RowsTb
            // 
            this.RowsTb.Location = new System.Drawing.Point(355, 101);
            this.RowsTb.Name = "RowsTb";
            this.RowsTb.Size = new System.Drawing.Size(100, 20);
            this.RowsTb.TabIndex = 4;
            this.RowsTb.Text = "10";
            // 
            // ColumnsTb
            // 
            this.ColumnsTb.Location = new System.Drawing.Point(354, 127);
            this.ColumnsTb.Name = "ColumnsTb";
            this.ColumnsTb.Size = new System.Drawing.Size(100, 20);
            this.ColumnsTb.TabIndex = 5;
            this.ColumnsTb.Text = "10";
            // 
            // DepthSearchTb
            // 
            this.DepthSearchTb.Location = new System.Drawing.Point(354, 154);
            this.DepthSearchTb.Name = "DepthSearchTb";
            this.DepthSearchTb.Size = new System.Drawing.Size(100, 20);
            this.DepthSearchTb.TabIndex = 7;
            this.DepthSearchTb.Text = "2";
            // 
            // DepthSearchLbl
            // 
            this.DepthSearchLbl.AutoSize = true;
            this.DepthSearchLbl.Location = new System.Drawing.Point(230, 154);
            this.DepthSearchLbl.Name = "DepthSearchLbl";
            this.DepthSearchLbl.Size = new System.Drawing.Size(119, 13);
            this.DepthSearchLbl.TabIndex = 6;
            this.DepthSearchLbl.Text = "Głębokość poszukiwań";
            this.DepthSearchLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DepthSearchTb);
            this.Controls.Add(this.DepthSearchLbl);
            this.Controls.Add(this.ColumnsTb);
            this.Controls.Add(this.RowsTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.GameModeListBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox GameModeListBox;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RowsTb;
        private System.Windows.Forms.TextBox ColumnsTb;
        private System.Windows.Forms.TextBox DepthSearchTb;
        private System.Windows.Forms.Label DepthSearchLbl;
    }
}


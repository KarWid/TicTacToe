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
            this.BlockedFivesWeightPlayer1Tb = new System.Windows.Forms.TextBox();
            this.BlockedFivesWeightPlayer1Lbl = new System.Windows.Forms.Label();
            this.BlockedFourthWeightPlayer1Tb = new System.Windows.Forms.TextBox();
            this.BlockedFoursWeightPlayer1Lbl = new System.Windows.Forms.Label();
            this.BlockedTwoWeightPlayer1Tb = new System.Windows.Forms.TextBox();
            this.BlockedTwoWeightPlayer1Lbl = new System.Windows.Forms.Label();
            this.BlockedThirdsWeightPlayer1Tb = new System.Windows.Forms.TextBox();
            this.BlockedThirdsWeightPlayer1Lbl = new System.Windows.Forms.Label();
            this.SetTwoWeightPlayer1Tb = new System.Windows.Forms.TextBox();
            this.SetThirdsWeightPlayer1Tb = new System.Windows.Forms.TextBox();
            this.SetFourthWeightPlayer1Tb = new System.Windows.Forms.TextBox();
            this.SetFivesWeightPlayer1Tb = new System.Windows.Forms.TextBox();
            this.SetFivesWeightPlayer1Lbl = new System.Windows.Forms.Label();
            this.Player1Weights = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SetFourthWeightPlayer1Lbl = new System.Windows.Forms.Label();
            this.SetThirdWeightPlayer1Lbl = new System.Windows.Forms.Label();
            this.SetTwoWeightPlayer1Lbl = new System.Windows.Forms.Label();
            this.SetTwoWeightPlayer2Lbl = new System.Windows.Forms.Label();
            this.SetThirdWeightPlayer2Lbl = new System.Windows.Forms.Label();
            this.SetFourthWeightPlayer2Lbl = new System.Windows.Forms.Label();
            this.SetTwoWeightPlayer2Tb = new System.Windows.Forms.TextBox();
            this.SetThirdsWeightPlayer2Tb = new System.Windows.Forms.TextBox();
            this.SetFourthWeightPlayer2Tb = new System.Windows.Forms.TextBox();
            this.SetFivesWeightPlayer2Tb = new System.Windows.Forms.TextBox();
            this.SetFivesWeightPlayer2Lbl = new System.Windows.Forms.Label();
            this.BlockedTwoWeightPlayer2Tb = new System.Windows.Forms.TextBox();
            this.BlockedTwoWeightPlayer2Lbl = new System.Windows.Forms.Label();
            this.BlockedThirdsWeightPlayer2Tb = new System.Windows.Forms.TextBox();
            this.BlockedThirdsWeightPlayer2Lbl = new System.Windows.Forms.Label();
            this.BlockedFourthWeightPlayer2Tb = new System.Windows.Forms.TextBox();
            this.BlockedFoursWeightPlayer2Lbl = new System.Windows.Forms.Label();
            this.BlockedFivesWeightPlayer2Tb = new System.Windows.Forms.TextBox();
            this.BlockedFivesWeightPlayer2Lbl = new System.Windows.Forms.Label();
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
            this.StartBtn.Location = new System.Drawing.Point(303, 355);
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
            // BlockedFivesWeightPlayer1Tb
            // 
            this.BlockedFivesWeightPlayer1Tb.Location = new System.Drawing.Point(226, 249);
            this.BlockedFivesWeightPlayer1Tb.Name = "BlockedFivesWeightPlayer1Tb";
            this.BlockedFivesWeightPlayer1Tb.Size = new System.Drawing.Size(35, 20);
            this.BlockedFivesWeightPlayer1Tb.TabIndex = 9;
            this.BlockedFivesWeightPlayer1Tb.Text = "20";
            // 
            // BlockedFivesWeightPlayer1Lbl
            // 
            this.BlockedFivesWeightPlayer1Lbl.AutoSize = true;
            this.BlockedFivesWeightPlayer1Lbl.Location = new System.Drawing.Point(146, 252);
            this.BlockedFivesWeightPlayer1Lbl.Name = "BlockedFivesWeightPlayer1Lbl";
            this.BlockedFivesWeightPlayer1Lbl.Size = new System.Drawing.Size(74, 13);
            this.BlockedFivesWeightPlayer1Lbl.TabIndex = 8;
            this.BlockedFivesWeightPlayer1Lbl.Text = "Blokowanie 5:";
            this.BlockedFivesWeightPlayer1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BlockedFourthWeightPlayer1Tb
            // 
            this.BlockedFourthWeightPlayer1Tb.Location = new System.Drawing.Point(226, 278);
            this.BlockedFourthWeightPlayer1Tb.Name = "BlockedFourthWeightPlayer1Tb";
            this.BlockedFourthWeightPlayer1Tb.Size = new System.Drawing.Size(35, 20);
            this.BlockedFourthWeightPlayer1Tb.TabIndex = 11;
            this.BlockedFourthWeightPlayer1Tb.Text = "3";
            // 
            // BlockedFoursWeightPlayer1Lbl
            // 
            this.BlockedFoursWeightPlayer1Lbl.AutoSize = true;
            this.BlockedFoursWeightPlayer1Lbl.Location = new System.Drawing.Point(146, 281);
            this.BlockedFoursWeightPlayer1Lbl.Name = "BlockedFoursWeightPlayer1Lbl";
            this.BlockedFoursWeightPlayer1Lbl.Size = new System.Drawing.Size(74, 13);
            this.BlockedFoursWeightPlayer1Lbl.TabIndex = 10;
            this.BlockedFoursWeightPlayer1Lbl.Text = "Blokowanie 4:";
            this.BlockedFoursWeightPlayer1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BlockedTwoWeightPlayer1Tb
            // 
            this.BlockedTwoWeightPlayer1Tb.Location = new System.Drawing.Point(226, 334);
            this.BlockedTwoWeightPlayer1Tb.Name = "BlockedTwoWeightPlayer1Tb";
            this.BlockedTwoWeightPlayer1Tb.Size = new System.Drawing.Size(35, 20);
            this.BlockedTwoWeightPlayer1Tb.TabIndex = 15;
            this.BlockedTwoWeightPlayer1Tb.Text = "1";
            // 
            // BlockedTwoWeightPlayer1Lbl
            // 
            this.BlockedTwoWeightPlayer1Lbl.AutoSize = true;
            this.BlockedTwoWeightPlayer1Lbl.Location = new System.Drawing.Point(146, 337);
            this.BlockedTwoWeightPlayer1Lbl.Name = "BlockedTwoWeightPlayer1Lbl";
            this.BlockedTwoWeightPlayer1Lbl.Size = new System.Drawing.Size(74, 13);
            this.BlockedTwoWeightPlayer1Lbl.TabIndex = 14;
            this.BlockedTwoWeightPlayer1Lbl.Text = "Blokowanie 2:";
            this.BlockedTwoWeightPlayer1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BlockedThirdsWeightPlayer1Tb
            // 
            this.BlockedThirdsWeightPlayer1Tb.Location = new System.Drawing.Point(226, 305);
            this.BlockedThirdsWeightPlayer1Tb.Name = "BlockedThirdsWeightPlayer1Tb";
            this.BlockedThirdsWeightPlayer1Tb.Size = new System.Drawing.Size(35, 20);
            this.BlockedThirdsWeightPlayer1Tb.TabIndex = 13;
            this.BlockedThirdsWeightPlayer1Tb.Text = "2";
            // 
            // BlockedThirdsWeightPlayer1Lbl
            // 
            this.BlockedThirdsWeightPlayer1Lbl.AutoSize = true;
            this.BlockedThirdsWeightPlayer1Lbl.Location = new System.Drawing.Point(146, 308);
            this.BlockedThirdsWeightPlayer1Lbl.Name = "BlockedThirdsWeightPlayer1Lbl";
            this.BlockedThirdsWeightPlayer1Lbl.Size = new System.Drawing.Size(74, 13);
            this.BlockedThirdsWeightPlayer1Lbl.TabIndex = 12;
            this.BlockedThirdsWeightPlayer1Lbl.Text = "Blokowanie 3:";
            this.BlockedThirdsWeightPlayer1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SetTwoWeightPlayer1Tb
            // 
            this.SetTwoWeightPlayer1Tb.Location = new System.Drawing.Point(226, 447);
            this.SetTwoWeightPlayer1Tb.Name = "SetTwoWeightPlayer1Tb";
            this.SetTwoWeightPlayer1Tb.Size = new System.Drawing.Size(35, 20);
            this.SetTwoWeightPlayer1Tb.TabIndex = 23;
            this.SetTwoWeightPlayer1Tb.Text = "2";
            // 
            // SetThirdsWeightPlayer1Tb
            // 
            this.SetThirdsWeightPlayer1Tb.Location = new System.Drawing.Point(226, 418);
            this.SetThirdsWeightPlayer1Tb.Name = "SetThirdsWeightPlayer1Tb";
            this.SetThirdsWeightPlayer1Tb.Size = new System.Drawing.Size(35, 20);
            this.SetThirdsWeightPlayer1Tb.TabIndex = 21;
            this.SetThirdsWeightPlayer1Tb.Text = "4";
            // 
            // SetFourthWeightPlayer1Tb
            // 
            this.SetFourthWeightPlayer1Tb.Location = new System.Drawing.Point(226, 391);
            this.SetFourthWeightPlayer1Tb.Name = "SetFourthWeightPlayer1Tb";
            this.SetFourthWeightPlayer1Tb.Size = new System.Drawing.Size(35, 20);
            this.SetFourthWeightPlayer1Tb.TabIndex = 19;
            this.SetFourthWeightPlayer1Tb.Text = "8";
            // 
            // SetFivesWeightPlayer1Tb
            // 
            this.SetFivesWeightPlayer1Tb.Location = new System.Drawing.Point(226, 362);
            this.SetFivesWeightPlayer1Tb.Name = "SetFivesWeightPlayer1Tb";
            this.SetFivesWeightPlayer1Tb.Size = new System.Drawing.Size(35, 20);
            this.SetFivesWeightPlayer1Tb.TabIndex = 17;
            this.SetFivesWeightPlayer1Tb.Text = "10";
            // 
            // SetFivesWeightPlayer1Lbl
            // 
            this.SetFivesWeightPlayer1Lbl.AutoSize = true;
            this.SetFivesWeightPlayer1Lbl.Location = new System.Drawing.Point(146, 365);
            this.SetFivesWeightPlayer1Lbl.Name = "SetFivesWeightPlayer1Lbl";
            this.SetFivesWeightPlayer1Lbl.Size = new System.Drawing.Size(71, 13);
            this.SetFivesWeightPlayer1Lbl.TabIndex = 16;
            this.SetFivesWeightPlayer1Lbl.Text = "Ustawienie 5:";
            this.SetFivesWeightPlayer1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player1Weights
            // 
            this.Player1Weights.AutoSize = true;
            this.Player1Weights.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Player1Weights.Location = new System.Drawing.Point(135, 220);
            this.Player1Weights.Name = "Player1Weights";
            this.Player1Weights.Size = new System.Drawing.Size(126, 17);
            this.Player1Weights.TabIndex = 28;
            this.Player1Weights.Text = "Wagi dla 1 gracza:";
            this.Player1Weights.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(474, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 17);
            this.label12.TabIndex = 49;
            this.label12.Text = "Wagi dla 2 gracza:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SetFourthWeightPlayer1Lbl
            // 
            this.SetFourthWeightPlayer1Lbl.AutoSize = true;
            this.SetFourthWeightPlayer1Lbl.Location = new System.Drawing.Point(146, 394);
            this.SetFourthWeightPlayer1Lbl.Name = "SetFourthWeightPlayer1Lbl";
            this.SetFourthWeightPlayer1Lbl.Size = new System.Drawing.Size(71, 13);
            this.SetFourthWeightPlayer1Lbl.TabIndex = 50;
            this.SetFourthWeightPlayer1Lbl.Text = "Ustawienie 4:";
            this.SetFourthWeightPlayer1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SetThirdWeightPlayer1Lbl
            // 
            this.SetThirdWeightPlayer1Lbl.AutoSize = true;
            this.SetThirdWeightPlayer1Lbl.Location = new System.Drawing.Point(146, 421);
            this.SetThirdWeightPlayer1Lbl.Name = "SetThirdWeightPlayer1Lbl";
            this.SetThirdWeightPlayer1Lbl.Size = new System.Drawing.Size(71, 13);
            this.SetThirdWeightPlayer1Lbl.TabIndex = 51;
            this.SetThirdWeightPlayer1Lbl.Text = "Ustawienie 3:";
            this.SetThirdWeightPlayer1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SetTwoWeightPlayer1Lbl
            // 
            this.SetTwoWeightPlayer1Lbl.AutoSize = true;
            this.SetTwoWeightPlayer1Lbl.Location = new System.Drawing.Point(146, 450);
            this.SetTwoWeightPlayer1Lbl.Name = "SetTwoWeightPlayer1Lbl";
            this.SetTwoWeightPlayer1Lbl.Size = new System.Drawing.Size(71, 13);
            this.SetTwoWeightPlayer1Lbl.TabIndex = 52;
            this.SetTwoWeightPlayer1Lbl.Text = "Ustawienie 2:";
            this.SetTwoWeightPlayer1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SetTwoWeightPlayer2Lbl
            // 
            this.SetTwoWeightPlayer2Lbl.AutoSize = true;
            this.SetTwoWeightPlayer2Lbl.Location = new System.Drawing.Point(474, 454);
            this.SetTwoWeightPlayer2Lbl.Name = "SetTwoWeightPlayer2Lbl";
            this.SetTwoWeightPlayer2Lbl.Size = new System.Drawing.Size(71, 13);
            this.SetTwoWeightPlayer2Lbl.TabIndex = 68;
            this.SetTwoWeightPlayer2Lbl.Text = "Ustawienie 2:";
            this.SetTwoWeightPlayer2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SetThirdWeightPlayer2Lbl
            // 
            this.SetThirdWeightPlayer2Lbl.AutoSize = true;
            this.SetThirdWeightPlayer2Lbl.Location = new System.Drawing.Point(474, 425);
            this.SetThirdWeightPlayer2Lbl.Name = "SetThirdWeightPlayer2Lbl";
            this.SetThirdWeightPlayer2Lbl.Size = new System.Drawing.Size(71, 13);
            this.SetThirdWeightPlayer2Lbl.TabIndex = 67;
            this.SetThirdWeightPlayer2Lbl.Text = "Ustawienie 3:";
            this.SetThirdWeightPlayer2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SetFourthWeightPlayer2Lbl
            // 
            this.SetFourthWeightPlayer2Lbl.AutoSize = true;
            this.SetFourthWeightPlayer2Lbl.Location = new System.Drawing.Point(474, 398);
            this.SetFourthWeightPlayer2Lbl.Name = "SetFourthWeightPlayer2Lbl";
            this.SetFourthWeightPlayer2Lbl.Size = new System.Drawing.Size(71, 13);
            this.SetFourthWeightPlayer2Lbl.TabIndex = 66;
            this.SetFourthWeightPlayer2Lbl.Text = "Ustawienie 4:";
            this.SetFourthWeightPlayer2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SetTwoWeightPlayer2Tb
            // 
            this.SetTwoWeightPlayer2Tb.Location = new System.Drawing.Point(554, 451);
            this.SetTwoWeightPlayer2Tb.Name = "SetTwoWeightPlayer2Tb";
            this.SetTwoWeightPlayer2Tb.Size = new System.Drawing.Size(35, 20);
            this.SetTwoWeightPlayer2Tb.TabIndex = 65;
            this.SetTwoWeightPlayer2Tb.Text = "2";
            // 
            // SetThirdsWeightPlayer2Tb
            // 
            this.SetThirdsWeightPlayer2Tb.Location = new System.Drawing.Point(554, 422);
            this.SetThirdsWeightPlayer2Tb.Name = "SetThirdsWeightPlayer2Tb";
            this.SetThirdsWeightPlayer2Tb.Size = new System.Drawing.Size(35, 20);
            this.SetThirdsWeightPlayer2Tb.TabIndex = 64;
            this.SetThirdsWeightPlayer2Tb.Text = "30";
            // 
            // SetFourthWeightPlayer2Tb
            // 
            this.SetFourthWeightPlayer2Tb.Location = new System.Drawing.Point(554, 395);
            this.SetFourthWeightPlayer2Tb.Name = "SetFourthWeightPlayer2Tb";
            this.SetFourthWeightPlayer2Tb.Size = new System.Drawing.Size(35, 20);
            this.SetFourthWeightPlayer2Tb.TabIndex = 63;
            this.SetFourthWeightPlayer2Tb.Text = "300";
            // 
            // SetFivesWeightPlayer2Tb
            // 
            this.SetFivesWeightPlayer2Tb.Location = new System.Drawing.Point(554, 366);
            this.SetFivesWeightPlayer2Tb.Name = "SetFivesWeightPlayer2Tb";
            this.SetFivesWeightPlayer2Tb.Size = new System.Drawing.Size(35, 20);
            this.SetFivesWeightPlayer2Tb.TabIndex = 62;
            this.SetFivesWeightPlayer2Tb.Text = "2000";
            // 
            // SetFivesWeightPlayer2Lbl
            // 
            this.SetFivesWeightPlayer2Lbl.AutoSize = true;
            this.SetFivesWeightPlayer2Lbl.Location = new System.Drawing.Point(474, 369);
            this.SetFivesWeightPlayer2Lbl.Name = "SetFivesWeightPlayer2Lbl";
            this.SetFivesWeightPlayer2Lbl.Size = new System.Drawing.Size(71, 13);
            this.SetFivesWeightPlayer2Lbl.TabIndex = 61;
            this.SetFivesWeightPlayer2Lbl.Text = "Ustawienie 5:";
            this.SetFivesWeightPlayer2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BlockedTwoWeightPlayer2Tb
            // 
            this.BlockedTwoWeightPlayer2Tb.Location = new System.Drawing.Point(554, 338);
            this.BlockedTwoWeightPlayer2Tb.Name = "BlockedTwoWeightPlayer2Tb";
            this.BlockedTwoWeightPlayer2Tb.Size = new System.Drawing.Size(35, 20);
            this.BlockedTwoWeightPlayer2Tb.TabIndex = 60;
            this.BlockedTwoWeightPlayer2Tb.Text = "1";
            // 
            // BlockedTwoWeightPlayer2Lbl
            // 
            this.BlockedTwoWeightPlayer2Lbl.AutoSize = true;
            this.BlockedTwoWeightPlayer2Lbl.Location = new System.Drawing.Point(474, 341);
            this.BlockedTwoWeightPlayer2Lbl.Name = "BlockedTwoWeightPlayer2Lbl";
            this.BlockedTwoWeightPlayer2Lbl.Size = new System.Drawing.Size(74, 13);
            this.BlockedTwoWeightPlayer2Lbl.TabIndex = 59;
            this.BlockedTwoWeightPlayer2Lbl.Text = "Blokowanie 2:";
            this.BlockedTwoWeightPlayer2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BlockedThirdsWeightPlayer2Tb
            // 
            this.BlockedThirdsWeightPlayer2Tb.Location = new System.Drawing.Point(554, 309);
            this.BlockedThirdsWeightPlayer2Tb.Name = "BlockedThirdsWeightPlayer2Tb";
            this.BlockedThirdsWeightPlayer2Tb.Size = new System.Drawing.Size(35, 20);
            this.BlockedThirdsWeightPlayer2Tb.TabIndex = 58;
            this.BlockedThirdsWeightPlayer2Tb.Text = "50";
            // 
            // BlockedThirdsWeightPlayer2Lbl
            // 
            this.BlockedThirdsWeightPlayer2Lbl.AutoSize = true;
            this.BlockedThirdsWeightPlayer2Lbl.Location = new System.Drawing.Point(474, 312);
            this.BlockedThirdsWeightPlayer2Lbl.Name = "BlockedThirdsWeightPlayer2Lbl";
            this.BlockedThirdsWeightPlayer2Lbl.Size = new System.Drawing.Size(74, 13);
            this.BlockedThirdsWeightPlayer2Lbl.TabIndex = 57;
            this.BlockedThirdsWeightPlayer2Lbl.Text = "Blokowanie 3:";
            this.BlockedThirdsWeightPlayer2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BlockedFourthWeightPlayer2Tb
            // 
            this.BlockedFourthWeightPlayer2Tb.Location = new System.Drawing.Point(554, 282);
            this.BlockedFourthWeightPlayer2Tb.Name = "BlockedFourthWeightPlayer2Tb";
            this.BlockedFourthWeightPlayer2Tb.Size = new System.Drawing.Size(35, 20);
            this.BlockedFourthWeightPlayer2Tb.TabIndex = 56;
            this.BlockedFourthWeightPlayer2Tb.Text = "200";
            // 
            // BlockedFoursWeightPlayer2Lbl
            // 
            this.BlockedFoursWeightPlayer2Lbl.AutoSize = true;
            this.BlockedFoursWeightPlayer2Lbl.Location = new System.Drawing.Point(474, 285);
            this.BlockedFoursWeightPlayer2Lbl.Name = "BlockedFoursWeightPlayer2Lbl";
            this.BlockedFoursWeightPlayer2Lbl.Size = new System.Drawing.Size(74, 13);
            this.BlockedFoursWeightPlayer2Lbl.TabIndex = 55;
            this.BlockedFoursWeightPlayer2Lbl.Text = "Blokowanie 4:";
            this.BlockedFoursWeightPlayer2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BlockedFivesWeightPlayer2Tb
            // 
            this.BlockedFivesWeightPlayer2Tb.Location = new System.Drawing.Point(554, 253);
            this.BlockedFivesWeightPlayer2Tb.Name = "BlockedFivesWeightPlayer2Tb";
            this.BlockedFivesWeightPlayer2Tb.Size = new System.Drawing.Size(35, 20);
            this.BlockedFivesWeightPlayer2Tb.TabIndex = 54;
            this.BlockedFivesWeightPlayer2Tb.Text = "500";
            // 
            // BlockedFivesWeightPlayer2Lbl
            // 
            this.BlockedFivesWeightPlayer2Lbl.AutoSize = true;
            this.BlockedFivesWeightPlayer2Lbl.Location = new System.Drawing.Point(474, 256);
            this.BlockedFivesWeightPlayer2Lbl.Name = "BlockedFivesWeightPlayer2Lbl";
            this.BlockedFivesWeightPlayer2Lbl.Size = new System.Drawing.Size(74, 13);
            this.BlockedFivesWeightPlayer2Lbl.TabIndex = 53;
            this.BlockedFivesWeightPlayer2Lbl.Text = "Blokowanie 5:";
            this.BlockedFivesWeightPlayer2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 618);
            this.Controls.Add(this.SetTwoWeightPlayer2Lbl);
            this.Controls.Add(this.SetThirdWeightPlayer2Lbl);
            this.Controls.Add(this.SetFourthWeightPlayer2Lbl);
            this.Controls.Add(this.SetTwoWeightPlayer2Tb);
            this.Controls.Add(this.SetThirdsWeightPlayer2Tb);
            this.Controls.Add(this.SetFourthWeightPlayer2Tb);
            this.Controls.Add(this.SetFivesWeightPlayer2Tb);
            this.Controls.Add(this.SetFivesWeightPlayer2Lbl);
            this.Controls.Add(this.BlockedTwoWeightPlayer2Tb);
            this.Controls.Add(this.BlockedTwoWeightPlayer2Lbl);
            this.Controls.Add(this.BlockedThirdsWeightPlayer2Tb);
            this.Controls.Add(this.BlockedThirdsWeightPlayer2Lbl);
            this.Controls.Add(this.BlockedFourthWeightPlayer2Tb);
            this.Controls.Add(this.BlockedFoursWeightPlayer2Lbl);
            this.Controls.Add(this.BlockedFivesWeightPlayer2Tb);
            this.Controls.Add(this.BlockedFivesWeightPlayer2Lbl);
            this.Controls.Add(this.SetTwoWeightPlayer1Lbl);
            this.Controls.Add(this.SetThirdWeightPlayer1Lbl);
            this.Controls.Add(this.SetFourthWeightPlayer1Lbl);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Player1Weights);
            this.Controls.Add(this.SetTwoWeightPlayer1Tb);
            this.Controls.Add(this.SetThirdsWeightPlayer1Tb);
            this.Controls.Add(this.SetFourthWeightPlayer1Tb);
            this.Controls.Add(this.SetFivesWeightPlayer1Tb);
            this.Controls.Add(this.SetFivesWeightPlayer1Lbl);
            this.Controls.Add(this.BlockedTwoWeightPlayer1Tb);
            this.Controls.Add(this.BlockedTwoWeightPlayer1Lbl);
            this.Controls.Add(this.BlockedThirdsWeightPlayer1Tb);
            this.Controls.Add(this.BlockedThirdsWeightPlayer1Lbl);
            this.Controls.Add(this.BlockedFourthWeightPlayer1Tb);
            this.Controls.Add(this.BlockedFoursWeightPlayer1Lbl);
            this.Controls.Add(this.BlockedFivesWeightPlayer1Tb);
            this.Controls.Add(this.BlockedFivesWeightPlayer1Lbl);
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
        private System.Windows.Forms.TextBox BlockedFivesWeightPlayer1Tb;
        private System.Windows.Forms.Label BlockedFivesWeightPlayer1Lbl;
        private System.Windows.Forms.TextBox BlockedFourthWeightPlayer1Tb;
        private System.Windows.Forms.Label BlockedFoursWeightPlayer1Lbl;
        private System.Windows.Forms.TextBox BlockedTwoWeightPlayer1Tb;
        private System.Windows.Forms.Label BlockedTwoWeightPlayer1Lbl;
        private System.Windows.Forms.TextBox BlockedThirdsWeightPlayer1Tb;
        private System.Windows.Forms.Label BlockedThirdsWeightPlayer1Lbl;
        private System.Windows.Forms.TextBox SetTwoWeightPlayer1Tb;
        private System.Windows.Forms.TextBox SetThirdsWeightPlayer1Tb;
        private System.Windows.Forms.TextBox SetFourthWeightPlayer1Tb;
        private System.Windows.Forms.TextBox SetFivesWeightPlayer1Tb;
        private System.Windows.Forms.Label SetFivesWeightPlayer1Lbl;
        private System.Windows.Forms.Label Player1Weights;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label SetFourthWeightPlayer1Lbl;
        private System.Windows.Forms.Label SetThirdWeightPlayer1Lbl;
        private System.Windows.Forms.Label SetTwoWeightPlayer1Lbl;
        private System.Windows.Forms.Label SetTwoWeightPlayer2Lbl;
        private System.Windows.Forms.Label SetThirdWeightPlayer2Lbl;
        private System.Windows.Forms.Label SetFourthWeightPlayer2Lbl;
        private System.Windows.Forms.TextBox SetTwoWeightPlayer2Tb;
        private System.Windows.Forms.TextBox SetThirdsWeightPlayer2Tb;
        private System.Windows.Forms.TextBox SetFourthWeightPlayer2Tb;
        private System.Windows.Forms.TextBox SetFivesWeightPlayer2Tb;
        private System.Windows.Forms.Label SetFivesWeightPlayer2Lbl;
        private System.Windows.Forms.TextBox BlockedTwoWeightPlayer2Tb;
        private System.Windows.Forms.Label BlockedTwoWeightPlayer2Lbl;
        private System.Windows.Forms.TextBox BlockedThirdsWeightPlayer2Tb;
        private System.Windows.Forms.Label BlockedThirdsWeightPlayer2Lbl;
        private System.Windows.Forms.TextBox BlockedFourthWeightPlayer2Tb;
        private System.Windows.Forms.Label BlockedFoursWeightPlayer2Lbl;
        private System.Windows.Forms.TextBox BlockedFivesWeightPlayer2Tb;
        private System.Windows.Forms.Label BlockedFivesWeightPlayer2Lbl;
    }
}


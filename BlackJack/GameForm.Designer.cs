namespace BlackJack
{
    partial class GameForm
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
            this.labelDealer = new System.Windows.Forms.Label();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.playerCard1 = new System.Windows.Forms.PictureBox();
            this.playerCard2 = new System.Windows.Forms.PictureBox();
            this.playerCard3 = new System.Windows.Forms.PictureBox();
            this.dealerCard1 = new System.Windows.Forms.PictureBox();
            this.dealerCard2 = new System.Windows.Forms.PictureBox();
            this.dealerCard3 = new System.Windows.Forms.PictureBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.playerCard4 = new System.Windows.Forms.PictureBox();
            this.playerCard5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dealerCard4 = new System.Windows.Forms.PictureBox();
            this.dealerCard5 = new System.Windows.Forms.PictureBox();
            this.btnStand = new System.Windows.Forms.Button();
            this.labelDealerScore = new System.Windows.Forms.Label();
            this.labelPlayerScore = new System.Windows.Forms.Label();
            this.numericWage = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPlayerMoney = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDealer
            // 
            this.labelDealer.AutoSize = true;
            this.labelDealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.labelDealer.Location = new System.Drawing.Point(261, 21);
            this.labelDealer.Name = "labelDealer";
            this.labelDealer.Size = new System.Drawing.Size(109, 31);
            this.labelDealer.TabIndex = 0;
            this.labelDealer.Text = "Dealer:";
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.labelPlayer.Location = new System.Drawing.Point(246, 289);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(106, 31);
            this.labelPlayer.TabIndex = 1;
            this.labelPlayer.Text = "Player:";
            // 
            // playerCard1
            // 
            this.playerCard1.InitialImage = null;
            this.playerCard1.Location = new System.Drawing.Point(389, 289);
            this.playerCard1.Name = "playerCard1";
            this.playerCard1.Size = new System.Drawing.Size(72, 110);
            this.playerCard1.TabIndex = 2;
            this.playerCard1.TabStop = false;
            // 
            // playerCard2
            // 
            this.playerCard2.InitialImage = null;
            this.playerCard2.Location = new System.Drawing.Point(429, 289);
            this.playerCard2.Name = "playerCard2";
            this.playerCard2.Size = new System.Drawing.Size(72, 110);
            this.playerCard2.TabIndex = 3;
            this.playerCard2.TabStop = false;
            // 
            // playerCard3
            // 
            this.playerCard3.InitialImage = null;
            this.playerCard3.Location = new System.Drawing.Point(469, 289);
            this.playerCard3.Name = "playerCard3";
            this.playerCard3.Size = new System.Drawing.Size(72, 110);
            this.playerCard3.TabIndex = 4;
            this.playerCard3.TabStop = false;
            // 
            // dealerCard1
            // 
            this.dealerCard1.InitialImage = null;
            this.dealerCard1.Location = new System.Drawing.Point(389, 21);
            this.dealerCard1.Name = "dealerCard1";
            this.dealerCard1.Size = new System.Drawing.Size(72, 110);
            this.dealerCard1.TabIndex = 5;
            this.dealerCard1.TabStop = false;
            // 
            // dealerCard2
            // 
            this.dealerCard2.InitialImage = null;
            this.dealerCard2.Location = new System.Drawing.Point(429, 21);
            this.dealerCard2.Name = "dealerCard2";
            this.dealerCard2.Size = new System.Drawing.Size(72, 110);
            this.dealerCard2.TabIndex = 6;
            this.dealerCard2.TabStop = false;
            // 
            // dealerCard3
            // 
            this.dealerCard3.InitialImage = null;
            this.dealerCard3.Location = new System.Drawing.Point(469, 21);
            this.dealerCard3.Name = "dealerCard3";
            this.dealerCard3.Size = new System.Drawing.Size(72, 110);
            this.dealerCard3.TabIndex = 7;
            this.dealerCard3.TabStop = false;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(40, 200);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(152, 30);
            this.btnStartGame.TabIndex = 8;
            this.btnStartGame.Text = "Start";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(389, 190);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(102, 40);
            this.btnHit.TabIndex = 9;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.Location = new System.Drawing.Point(495, 190);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(102, 40);
            this.btnDouble.TabIndex = 10;
            this.btnDouble.Text = "Double";
            this.btnDouble.UseVisualStyleBackColor = true;
            // 
            // playerCard4
            // 
            this.playerCard4.InitialImage = null;
            this.playerCard4.Location = new System.Drawing.Point(509, 289);
            this.playerCard4.Name = "playerCard4";
            this.playerCard4.Size = new System.Drawing.Size(72, 110);
            this.playerCard4.TabIndex = 11;
            this.playerCard4.TabStop = false;
            // 
            // playerCard5
            // 
            this.playerCard5.InitialImage = null;
            this.playerCard5.Location = new System.Drawing.Point(549, 289);
            this.playerCard5.Name = "playerCard5";
            this.playerCard5.Size = new System.Drawing.Size(72, 110);
            this.playerCard5.TabIndex = 12;
            this.playerCard5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(264, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "3:2 BlackJack";
            // 
            // dealerCard4
            // 
            this.dealerCard4.InitialImage = null;
            this.dealerCard4.Location = new System.Drawing.Point(509, 21);
            this.dealerCard4.Name = "dealerCard4";
            this.dealerCard4.Size = new System.Drawing.Size(72, 110);
            this.dealerCard4.TabIndex = 14;
            this.dealerCard4.TabStop = false;
            // 
            // dealerCard5
            // 
            this.dealerCard5.InitialImage = null;
            this.dealerCard5.Location = new System.Drawing.Point(549, 21);
            this.dealerCard5.Name = "dealerCard5";
            this.dealerCard5.Size = new System.Drawing.Size(72, 110);
            this.dealerCard5.TabIndex = 15;
            this.dealerCard5.TabStop = false;
            // 
            // btnStand
            // 
            this.btnStand.Location = new System.Drawing.Point(601, 190);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(102, 40);
            this.btnStand.TabIndex = 16;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            // 
            // labelDealerScore
            // 
            this.labelDealerScore.AutoSize = true;
            this.labelDealerScore.Location = new System.Drawing.Point(466, 134);
            this.labelDealerScore.Name = "labelDealerScore";
            this.labelDealerScore.Size = new System.Drawing.Size(75, 13);
            this.labelDealerScore.TabIndex = 17;
            this.labelDealerScore.Text = "Dealer Score: ";
            // 
            // labelPlayerScore
            // 
            this.labelPlayerScore.AutoSize = true;
            this.labelPlayerScore.Location = new System.Drawing.Point(467, 273);
            this.labelPlayerScore.Name = "labelPlayerScore";
            this.labelPlayerScore.Size = new System.Drawing.Size(70, 13);
            this.labelPlayerScore.TabIndex = 18;
            this.labelPlayerScore.Text = "Player Score:";
            // 
            // numericWage
            // 
            this.numericWage.Location = new System.Drawing.Point(40, 172);
            this.numericWage.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericWage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericWage.Name = "numericWage";
            this.numericWage.Size = new System.Drawing.Size(152, 20);
            this.numericWage.TabIndex = 19;
            this.numericWage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "How much you wanna bet?";
            // 
            // labelPlayerMoney
            // 
            this.labelPlayerMoney.AutoSize = true;
            this.labelPlayerMoney.Location = new System.Drawing.Point(199, 386);
            this.labelPlayerMoney.Name = "labelPlayerMoney";
            this.labelPlayerMoney.Size = new System.Drawing.Size(72, 13);
            this.labelPlayerMoney.TabIndex = 21;
            this.labelPlayerMoney.Text = "Total Money: ";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 420);
            this.Controls.Add(this.labelPlayerMoney);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericWage);
            this.Controls.Add(this.labelPlayerScore);
            this.Controls.Add(this.labelDealerScore);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.dealerCard1);
            this.Controls.Add(this.playerCard1);
            this.Controls.Add(this.playerCard2);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.labelDealer);
            this.Controls.Add(this.playerCard3);
            this.Controls.Add(this.dealerCard2);
            this.Controls.Add(this.dealerCard3);
            this.Controls.Add(this.playerCard4);
            this.Controls.Add(this.playerCard5);
            this.Controls.Add(this.dealerCard4);
            this.Controls.Add(this.dealerCard5);
            this.Name = "GameForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.playerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDealer;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.PictureBox playerCard1;
        private System.Windows.Forms.PictureBox playerCard2;
        private System.Windows.Forms.PictureBox playerCard3;
        private System.Windows.Forms.PictureBox dealerCard1;
        private System.Windows.Forms.PictureBox dealerCard2;
        private System.Windows.Forms.PictureBox dealerCard3;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.PictureBox playerCard4;
        private System.Windows.Forms.PictureBox playerCard5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox dealerCard4;
        private System.Windows.Forms.PictureBox dealerCard5;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Label labelDealerScore;
        private System.Windows.Forms.Label labelPlayerScore;
        private System.Windows.Forms.NumericUpDown numericWage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPlayerMoney;
    }
}


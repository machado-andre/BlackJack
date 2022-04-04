namespace BlackJack
{
    partial class EntryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericDeckNr = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.labelstartMoney = new System.Windows.Forms.Label();
            this.numericStartingMoney = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericDeckNr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStartingMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to BlackJack";
            // 
            // numericDeckNr
            // 
            this.numericDeckNr.Location = new System.Drawing.Point(241, 74);
            this.numericDeckNr.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericDeckNr.Name = "numericDeckNr";
            this.numericDeckNr.Size = new System.Drawing.Size(35, 20);
            this.numericDeckNr.TabIndex = 2;
            this.numericDeckNr.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ammount of Decks you want to play with (0-8):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Your Username:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(101, 117);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(175, 20);
            this.textBoxUsername.TabIndex = 5;
            this.textBoxUsername.Text = "andre";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(124, 199);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 6;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // labelstartMoney
            // 
            this.labelstartMoney.AutoSize = true;
            this.labelstartMoney.Location = new System.Drawing.Point(14, 151);
            this.labelstartMoney.Name = "labelstartMoney";
            this.labelstartMoney.Size = new System.Drawing.Size(129, 13);
            this.labelstartMoney.TabIndex = 7;
            this.labelstartMoney.Text = "Starting Money (1-50000):";
            // 
            // numericStartingMoney
            // 
            this.numericStartingMoney.Location = new System.Drawing.Point(149, 149);
            this.numericStartingMoney.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericStartingMoney.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericStartingMoney.Name = "numericStartingMoney";
            this.numericStartingMoney.Size = new System.Drawing.Size(127, 20);
            this.numericStartingMoney.TabIndex = 8;
            this.numericStartingMoney.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 264);
            this.Controls.Add(this.numericStartingMoney);
            this.Controls.Add(this.labelstartMoney);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericDeckNr);
            this.Controls.Add(this.label1);
            this.Name = "EntryForm";
            this.Text = "EntryForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericDeckNr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStartingMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericDeckNr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label labelstartMoney;
        private System.Windows.Forms.NumericUpDown numericStartingMoney;
    }
}
namespace TableTennisRanking
{
    partial class AddGame
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createPlayerButton = new System.Windows.Forms.Button();
            this.champCombobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gameDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.playerAName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.setsPlayerA = new System.Windows.Forms.TextBox();
            this.setsPlayerB = new System.Windows.Forms.TextBox();
            this.playerBName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pointsExchange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Championship";
            // 
            // createPlayerButton
            // 
            this.createPlayerButton.Location = new System.Drawing.Point(262, 243);
            this.createPlayerButton.Name = "createPlayerButton";
            this.createPlayerButton.Size = new System.Drawing.Size(75, 23);
            this.createPlayerButton.TabIndex = 9;
            this.createPlayerButton.Text = "Create";
            this.createPlayerButton.UseVisualStyleBackColor = true;
            this.createPlayerButton.Click += new System.EventHandler(this.createPlayerButton_Click);
            // 
            // champCombobox
            // 
            this.champCombobox.FormattingEnabled = true;
            this.champCombobox.Location = new System.Drawing.Point(101, 76);
            this.champCombobox.Name = "champCombobox";
            this.champCombobox.Size = new System.Drawing.Size(444, 21);
            this.champCombobox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Date";
            // 
            // gameDate
            // 
            this.gameDate.Location = new System.Drawing.Point(101, 117);
            this.gameDate.Name = "gameDate";
            this.gameDate.Size = new System.Drawing.Size(444, 20);
            this.gameDate.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Player A";
            // 
            // playerAName
            // 
            this.playerAName.FormattingEnabled = true;
            this.playerAName.Location = new System.Drawing.Point(101, 168);
            this.playerAName.Name = "playerAName";
            this.playerAName.Size = new System.Drawing.Size(215, 21);
            this.playerAName.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sets";
            // 
            // setsPlayerA
            // 
            this.setsPlayerA.Location = new System.Drawing.Point(330, 168);
            this.setsPlayerA.Name = "setsPlayerA";
            this.setsPlayerA.Size = new System.Drawing.Size(25, 20);
            this.setsPlayerA.TabIndex = 16;
            // 
            // setsPlayerB
            // 
            this.setsPlayerB.Location = new System.Drawing.Point(330, 195);
            this.setsPlayerB.Name = "setsPlayerB";
            this.setsPlayerB.Size = new System.Drawing.Size(25, 20);
            this.setsPlayerB.TabIndex = 19;
            // 
            // playerBName
            // 
            this.playerBName.FormattingEnabled = true;
            this.playerBName.Location = new System.Drawing.Point(101, 195);
            this.playerBName.Name = "playerBName";
            this.playerBName.Size = new System.Drawing.Size(215, 21);
            this.playerBName.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Player B";
            // 
            // pointsExchange
            // 
            this.pointsExchange.AutoSize = true;
            this.pointsExchange.Location = new System.Drawing.Point(185, 292);
            this.pointsExchange.Name = "pointsExchange";
            this.pointsExchange.Size = new System.Drawing.Size(0, 13);
            this.pointsExchange.TabIndex = 20;
            // 
            // AddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pointsExchange);
            this.Controls.Add(this.setsPlayerB);
            this.Controls.Add(this.playerBName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.setsPlayerA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.playerAName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gameDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.champCombobox);
            this.Controls.Add(this.createPlayerButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddGame";
            this.Size = new System.Drawing.Size(575, 402);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void createPlayerButton_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button createPlayerButton;
        private System.Windows.Forms.ComboBox champCombobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker gameDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox playerAName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox setsPlayerA;
        private System.Windows.Forms.TextBox setsPlayerB;
        private System.Windows.Forms.ComboBox playerBName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label pointsExchange;
    }
}

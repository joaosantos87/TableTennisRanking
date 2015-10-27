namespace TableTennisRanking
{
    partial class RankingViewerUI
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StartDateTextbox = new System.Windows.Forms.MaskedTextBox();
            this.FinalDateTextbox = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(542, 346);
            this.dataGridView1.TabIndex = 1;
            // 
            // StartDateTextbox
            // 
            this.StartDateTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StartDateTextbox.Location = new System.Drawing.Point(52, 14);
            this.StartDateTextbox.Mask = "0000-00-00";
            this.StartDateTextbox.Name = "StartDateTextbox";
            this.StartDateTextbox.Size = new System.Drawing.Size(73, 20);
            this.StartDateTextbox.TabIndex = 2;
            this.StartDateTextbox.Text = "20000101";
            // 
            // FinalDateTextbox
            // 
            this.FinalDateTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FinalDateTextbox.Location = new System.Drawing.Point(167, 15);
            this.FinalDateTextbox.Mask = "0000-00-00";
            this.FinalDateTextbox.Name = "FinalDateTextbox";
            this.FinalDateTextbox.Size = new System.Drawing.Size(73, 20);
            this.FinalDateTextbox.TabIndex = 3;
            this.FinalDateTextbox.Text = "20151231";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(485, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(274, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // RankingViewerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FinalDateTextbox);
            this.Controls.Add(this.StartDateTextbox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RankingViewerUI";
            this.Size = new System.Drawing.Size(575, 402);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox StartDateTextbox;
        private System.Windows.Forms.MaskedTextBox FinalDateTextbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;

    }
}

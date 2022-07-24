namespace DesktopApp1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.ClickLabel = new System.Windows.Forms.Label();
            this.IntervalLabel = new System.Windows.Forms.Label();
            this.ClickAmountBox = new System.Windows.Forms.NumericUpDown();
            this.IntervalAmountBox = new System.Windows.Forms.NumericUpDown();
            this.MouseCoordLabel = new System.Windows.Forms.Label();
            this.BoxMouseX = new System.Windows.Forms.NumericUpDown();
            this.BoxMouseY = new System.Windows.Forms.NumericUpDown();
            this.HelpLabel = new System.Windows.Forms.Label();
            this.SetMousePosBox = new System.Windows.Forms.Button();
            this.CancelledLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClickAmountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalAmountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxMouseX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxMouseY)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(13, 13);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(13, 43);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "STOP";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ClickLabel
            // 
            this.ClickLabel.AutoSize = true;
            this.ClickLabel.Location = new System.Drawing.Point(165, 13);
            this.ClickLabel.Name = "ClickLabel";
            this.ClickLabel.Size = new System.Drawing.Size(35, 13);
            this.ClickLabel.TabIndex = 2;
            this.ClickLabel.Text = "Clicks";
            // 
            // IntervalLabel
            // 
            this.IntervalLabel.AutoSize = true;
            this.IntervalLabel.Location = new System.Drawing.Point(136, 43);
            this.IntervalLabel.Name = "IntervalLabel";
            this.IntervalLabel.Size = new System.Drawing.Size(70, 13);
            this.IntervalLabel.TabIndex = 3;
            this.IntervalLabel.Text = "Interval ( ms )";
            // 
            // ClickAmountBox
            // 
            this.ClickAmountBox.Location = new System.Drawing.Point(206, 11);
            this.ClickAmountBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ClickAmountBox.Name = "ClickAmountBox";
            this.ClickAmountBox.Size = new System.Drawing.Size(120, 20);
            this.ClickAmountBox.TabIndex = 4;
            // 
            // IntervalAmountBox
            // 
            this.IntervalAmountBox.Location = new System.Drawing.Point(206, 41);
            this.IntervalAmountBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.IntervalAmountBox.Name = "IntervalAmountBox";
            this.IntervalAmountBox.Size = new System.Drawing.Size(120, 20);
            this.IntervalAmountBox.TabIndex = 5;
            // 
            // MouseCoordLabel
            // 
            this.MouseCoordLabel.AutoSize = true;
            this.MouseCoordLabel.Location = new System.Drawing.Point(96, 73);
            this.MouseCoordLabel.Name = "MouseCoordLabel";
            this.MouseCoordLabel.Size = new System.Drawing.Size(110, 13);
            this.MouseCoordLabel.TabIndex = 6;
            this.MouseCoordLabel.Text = "Mouse Position ( x, y )";
            // 
            // BoxMouseX
            // 
            this.BoxMouseX.Location = new System.Drawing.Point(206, 73);
            this.BoxMouseX.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.BoxMouseX.Name = "BoxMouseX";
            this.BoxMouseX.Size = new System.Drawing.Size(120, 20);
            this.BoxMouseX.TabIndex = 7;
            // 
            // BoxMouseY
            // 
            this.BoxMouseY.Location = new System.Drawing.Point(333, 73);
            this.BoxMouseY.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.BoxMouseY.Name = "BoxMouseY";
            this.BoxMouseY.Size = new System.Drawing.Size(120, 20);
            this.BoxMouseY.TabIndex = 8;
            // 
            // HelpLabel
            // 
            this.HelpLabel.AutoSize = true;
            this.HelpLabel.Location = new System.Drawing.Point(356, 9);
            this.HelpLabel.Name = "HelpLabel";
            this.HelpLabel.Size = new System.Drawing.Size(120, 13);
            this.HelpLabel.TabIndex = 9;
            this.HelpLabel.Text = "Click the \"?\" for help! ▲";
            // 
            // SetMousePosBox
            // 
            this.SetMousePosBox.Location = new System.Drawing.Point(13, 122);
            this.SetMousePosBox.Name = "SetMousePosBox";
            this.SetMousePosBox.Size = new System.Drawing.Size(116, 23);
            this.SetMousePosBox.TabIndex = 10;
            this.SetMousePosBox.Text = "Set Mouse Position";
            this.SetMousePosBox.UseVisualStyleBackColor = true;
            this.SetMousePosBox.Click += new System.EventHandler(this.SetMousePosBox_Click);
            // 
            // CancelledLabel
            // 
            this.CancelledLabel.AutoSize = true;
            this.CancelledLabel.Location = new System.Drawing.Point(263, 148);
            this.CancelledLabel.Name = "CancelledLabel";
            this.CancelledLabel.Size = new System.Drawing.Size(72, 13);
            this.CancelledLabel.TabIndex = 11;
            this.CancelledLabel.Text = "Cancelled? ->";
            this.CancelledLabel.Click += new System.EventHandler(this.CancelledLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "TO STOP AT ANY TIME, USE CTRL + ALT + Q";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 211);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelledLabel);
            this.Controls.Add(this.SetMousePosBox);
            this.Controls.Add(this.HelpLabel);
            this.Controls.Add(this.BoxMouseY);
            this.Controls.Add(this.BoxMouseX);
            this.Controls.Add(this.MouseCoordLabel);
            this.Controls.Add(this.IntervalAmountBox);
            this.Controls.Add(this.ClickAmountBox);
            this.Controls.Add(this.IntervalLabel);
            this.Controls.Add(this.ClickLabel);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 250);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 250);
            this.Name = "Form1";
            this.Text = "TO STOP AT ANY TIME, USE CTRL + ALT + Q";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.ClickAmountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalAmountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxMouseX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxMouseY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label ClickLabel;
        private System.Windows.Forms.Label IntervalLabel;
        private System.Windows.Forms.NumericUpDown ClickAmountBox;
        private System.Windows.Forms.NumericUpDown IntervalAmountBox;
        private System.Windows.Forms.Label MouseCoordLabel;
        private System.Windows.Forms.NumericUpDown BoxMouseX;
        private System.Windows.Forms.NumericUpDown BoxMouseY;
        private System.Windows.Forms.Label HelpLabel;
        private System.Windows.Forms.Button SetMousePosBox;
        private System.Windows.Forms.Label CancelledLabel;
        private System.Windows.Forms.Label label1;
    }
}


namespace Activity_15
{
    partial class LuckyNumberDisplay
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
            titleLabel = new Label();
            luckyNumLabel = new Label();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.FromArgb(0, 0, 0, 0);
            titleLabel.Font = new Font("Matura MT Script Capitals", 19.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.Black;
            titleLabel.Location = new Point(22, 19);
            titleLabel.Margin = new Padding(6, 0, 6, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(748, 83);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Your Lucky Number is:";
            titleLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // luckyNumLabel
            // 
            luckyNumLabel.BackColor = Color.Lime;
            luckyNumLabel.Font = new Font("Wide Latin", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            luckyNumLabel.ForeColor = Color.Black;
            luckyNumLabel.Location = new Point(211, 179);
            luckyNumLabel.Margin = new Padding(6, 0, 6, 0);
            luckyNumLabel.Name = "luckyNumLabel";
            luckyNumLabel.Size = new Size(361, 246);
            luckyNumLabel.TabIndex = 1;
            luckyNumLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LuckyNumberDisplay
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(793, 739);
            Controls.Add(luckyNumLabel);
            Controls.Add(titleLabel);
            Margin = new Padding(6);
            Name = "LuckyNumberDisplay";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Your Lucky Number!";
            Load += LuckyNumberDisplay_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label titleLabel;
        public Label luckyNumLabel;
    }
}
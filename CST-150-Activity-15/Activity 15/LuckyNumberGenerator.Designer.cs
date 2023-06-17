namespace Activity_15
{
    partial class LuckyNumberGenerator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titlePanel = new Panel();
            titleLabel = new Label();
            vacationLabel = new Label();
            countryCombo = new ComboBox();
            countryLabel = new Label();
            luckyNumButton = new Button();
            cityCombo = new ComboBox();
            cityLabel = new Label();
            colorDialog1 = new ColorDialog();
            colorLabel = new Label();
            colorButton = new Button();
            titlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // titlePanel
            // 
            titlePanel.BackgroundImageLayout = ImageLayout.Center;
            titlePanel.Controls.Add(titleLabel);
            titlePanel.Font = new Font("Modern No. 20", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            titlePanel.Location = new Point(-6, -27);
            titlePanel.Margin = new Padding(6);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(767, 173);
            titlePanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.Font = new Font("Broadway", 20F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.Location = new Point(11, 34);
            titleLabel.Margin = new Padding(6, 0, 6, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(756, 139);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "What's Your Lucky Number?";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // vacationLabel
            // 
            vacationLabel.AutoSize = true;
            vacationLabel.Font = new Font("OpenSymbol", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            vacationLabel.Location = new Point(31, 233);
            vacationLabel.Margin = new Padding(6, 0, 6, 0);
            vacationLabel.Name = "vacationLabel";
            vacationLabel.Size = new Size(672, 43);
            vacationLabel.TabIndex = 1;
            vacationLabel.Text = "Where would your perfect vacation be?";
            // 
            // countryCombo
            // 
            countryCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            countryCombo.FormattingEnabled = true;
            countryCombo.Location = new Point(31, 398);
            countryCombo.Margin = new Padding(6);
            countryCombo.Name = "countryCombo";
            countryCombo.Size = new Size(318, 40);
            countryCombo.Sorted = true;
            countryCombo.TabIndex = 2;
            countryCombo.SelectedIndexChanged += countryCombo_SelectedIndexChanged;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new Font("OpenSymbol", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            countryLabel.Location = new Point(54, 325);
            countryLabel.Margin = new Padding(6, 0, 6, 0);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(295, 37);
            countryLabel.TabIndex = 3;
            countryLabel.Text = "Choose a Country:";
            // 
            // luckyNumButton
            // 
            luckyNumButton.Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point);
            luckyNumButton.Location = new Point(0, 819);
            luckyNumButton.Margin = new Padding(6);
            luckyNumButton.Name = "luckyNumButton";
            luckyNumButton.Size = new Size(756, 83);
            luckyNumButton.TabIndex = 4;
            luckyNumButton.Text = "Get Your Lucky Number!";
            luckyNumButton.UseVisualStyleBackColor = true;
            luckyNumButton.Click += luckyNumButton_Click;
            // 
            // cityCombo
            // 
            cityCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            cityCombo.FormattingEnabled = true;
            cityCombo.Location = new Point(405, 398);
            cityCombo.Margin = new Padding(6);
            cityCombo.Name = "cityCombo";
            cityCombo.Size = new Size(318, 40);
            cityCombo.Sorted = true;
            cityCombo.TabIndex = 5;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new Font("OpenSymbol", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cityLabel.Location = new Point(442, 324);
            cityLabel.Margin = new Padding(6, 0, 6, 0);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(248, 38);
            cityLabel.TabIndex = 6;
            cityLabel.Text = "Choose a City:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Font = new Font("OpenSymbol", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            colorLabel.Location = new Point(170, 467);
            colorLabel.Margin = new Padding(6, 0, 6, 0);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(441, 37);
            colorLabel.TabIndex = 7;
            colorLabel.Text = "Choose Your Favorite Color:";
            // 
            // colorButton
            // 
            colorButton.BackColor = Color.Black;
            colorButton.Location = new Point(352, 536);
            colorButton.Margin = new Padding(6);
            colorButton.Name = "colorButton";
            colorButton.Size = new Size(61, 60);
            colorButton.TabIndex = 8;
            colorButton.UseVisualStyleBackColor = false;
            colorButton.Click += colorButton_Click;
            // 
            // LuckyNumberGenerator
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(756, 902);
            Controls.Add(colorButton);
            Controls.Add(colorLabel);
            Controls.Add(cityLabel);
            Controls.Add(cityCombo);
            Controls.Add(luckyNumButton);
            Controls.Add(countryLabel);
            Controls.Add(countryCombo);
            Controls.Add(vacationLabel);
            Controls.Add(titlePanel);
            Margin = new Padding(6);
            Name = "LuckyNumberGenerator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lucky Number Generator";
            Load += LuckyNumberGenerator_Load;
            titlePanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel titlePanel;
        private Label titleLabel;
        private Label vacationLabel;
        private ComboBox countryCombo;
        private Label countryLabel;
        private Button luckyNumButton;
        private ComboBox cityCombo;
        private Label cityLabel;
        private ColorDialog colorDialog1;
        private Label colorLabel;
        private Button colorButton;
    }
}
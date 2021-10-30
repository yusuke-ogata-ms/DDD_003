
namespace DDD.WinForm.Views
{
    partial class WeatherLatestView
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AreasComboBox = new System.Windows.Forms.ComboBox();
            this.LatestButton = new System.Windows.Forms.Button();
            this.DataDateLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.WeatherListViewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "地域";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "日時";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "状態";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "温度";
            // 
            // AreasComboBox
            // 
            this.AreasComboBox.FormattingEnabled = true;
            this.AreasComboBox.Location = new System.Drawing.Point(83, 65);
            this.AreasComboBox.Name = "AreasComboBox";
            this.AreasComboBox.Size = new System.Drawing.Size(86, 20);
            this.AreasComboBox.TabIndex = 4;
            // 
            // LatestButton
            // 
            this.LatestButton.Location = new System.Drawing.Point(186, 63);
            this.LatestButton.Name = "LatestButton";
            this.LatestButton.Size = new System.Drawing.Size(75, 23);
            this.LatestButton.TabIndex = 5;
            this.LatestButton.Text = "直近地";
            this.LatestButton.UseVisualStyleBackColor = true;
            this.LatestButton.Click += new System.EventHandler(this.LatestButton_Click);
            // 
            // DataDateLabel
            // 
            this.DataDateLabel.AutoSize = true;
            this.DataDateLabel.Location = new System.Drawing.Point(97, 108);
            this.DataDateLabel.Name = "DataDateLabel";
            this.DataDateLabel.Size = new System.Drawing.Size(35, 12);
            this.DataDateLabel.TabIndex = 6;
            this.DataDateLabel.Text = "label5";
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(97, 149);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(35, 12);
            this.ConditionLabel.TabIndex = 7;
            this.ConditionLabel.Text = "label6";
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.Location = new System.Drawing.Point(97, 197);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(35, 12);
            this.TemperatureLabel.TabIndex = 8;
            this.TemperatureLabel.Text = "label7";
            // 
            // WeatherListViewButton
            // 
            this.WeatherListViewButton.Location = new System.Drawing.Point(31, 23);
            this.WeatherListViewButton.Name = "WeatherListViewButton";
            this.WeatherListViewButton.Size = new System.Drawing.Size(75, 23);
            this.WeatherListViewButton.TabIndex = 9;
            this.WeatherListViewButton.Text = "リスト";
            this.WeatherListViewButton.UseVisualStyleBackColor = true;
            this.WeatherListViewButton.Click += new System.EventHandler(this.WeatherListViewButton_Click);
            // 
            // WeatherLatestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 243);
            this.Controls.Add(this.WeatherListViewButton);
            this.Controls.Add(this.TemperatureLabel);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.DataDateLabel);
            this.Controls.Add(this.LatestButton);
            this.Controls.Add(this.AreasComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WeatherLatestView";
            this.Text = "WeatherLatestView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox AreasComboBox;
        private System.Windows.Forms.Button LatestButton;
        private System.Windows.Forms.Label DataDateLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label TemperatureLabel;
        private System.Windows.Forms.Button WeatherListViewButton;
    }
}
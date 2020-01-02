﻿using ACT_FFXIV_Kapture.Presentation.CustomControl;

namespace ACT_FFXIV_Kapture.Presentation
{
    partial class LoggingView
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
            this.logging_LoggingEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.logging_UpdateButton = new CustomButton();
            this.logging_BrowseButton = new CustomButton();
            this.logging_LogLocationTextBox = new CustomTextBox();
            this.logging_LogFormatComboBox = new CustomComboBox();
            this.SuspendLayout();
            // 
            // logging_LoggingEnabledCheckBox
            // 
            this.logging_LoggingEnabledCheckBox.AutoSize = true;
            this.logging_LoggingEnabledCheckBox.Location = new System.Drawing.Point(3, 3);
            this.logging_LoggingEnabledCheckBox.Name = "logging_LoggingEnabledCheckBox";
            this.logging_LoggingEnabledCheckBox.Size = new System.Drawing.Size(106, 17);
            this.logging_LoggingEnabledCheckBox.TabIndex = 23;
            this.logging_LoggingEnabledCheckBox.Text = "Logging Enabled";
            this.logging_LoggingEnabledCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Log Format";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Log Location";
            // 
            // logging_UpdateButton
            // 
            this.logging_UpdateButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.logging_UpdateButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.logging_UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logging_UpdateButton.Location = new System.Drawing.Point(174, 84);
            this.logging_UpdateButton.Name = "logging_UpdateButton";
            this.logging_UpdateButton.Size = new System.Drawing.Size(61, 23);
            this.logging_UpdateButton.TabIndex = 31;
            this.logging_UpdateButton.Text = "Update";
            this.logging_UpdateButton.UseVisualStyleBackColor = false;
            // 
            // logging_BrowseButton
            // 
            this.logging_BrowseButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.logging_BrowseButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.logging_BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logging_BrowseButton.Location = new System.Drawing.Point(234, 84);
            this.logging_BrowseButton.Name = "logging_BrowseButton";
            this.logging_BrowseButton.Size = new System.Drawing.Size(61, 23);
            this.logging_BrowseButton.TabIndex = 30;
            this.logging_BrowseButton.Text = "Browse";
            this.logging_BrowseButton.UseVisualStyleBackColor = false;
            // 
            // logging_LogLocationTextBox
            // 
            this.logging_LogLocationTextBox.Location = new System.Drawing.Point(84, 58);
            this.logging_LogLocationTextBox.Name = "logging_LogLocationTextBox";
            this.logging_LogLocationTextBox.Size = new System.Drawing.Size(211, 20);
            this.logging_LogLocationTextBox.TabIndex = 28;
            // 
            // logging_LogFormatComboBox
            // 
            this.logging_LogFormatComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.logging_LogFormatComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.logging_LogFormatComboBox.FormattingEnabled = true;
            this.logging_LogFormatComboBox.Location = new System.Drawing.Point(84, 27);
            this.logging_LogFormatComboBox.Name = "logging_LogFormatComboBox";
            this.logging_LogFormatComboBox.Size = new System.Drawing.Size(75, 21);
            this.logging_LogFormatComboBox.TabIndex = 27;
            // 
            // LoggingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.logging_UpdateButton);
            this.Controls.Add(this.logging_BrowseButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.logging_LogLocationTextBox);
            this.Controls.Add(this.logging_LogFormatComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.logging_LoggingEnabledCheckBox);
            this.Name = "LoggingView";
            this.Size = new System.Drawing.Size(465, 303);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox logging_LoggingEnabledCheckBox;
        private CustomComboBox logging_LogFormatComboBox;
        private System.Windows.Forms.Label label4;
        private CustomTextBox logging_LogLocationTextBox;
        private System.Windows.Forms.Label label5;
        private CustomButton logging_BrowseButton;
        private CustomButton logging_UpdateButton;
    }
}

namespace Weather_ApplicationProject
{
    partial class CfrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CfrmMain));
            this.lblCity = new System.Windows.Forms.Label();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCondition = new System.Windows.Forms.Label();
            this.lblSunset = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblSunrise = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblWindSpeed = new System.Windows.Forms.Label();
            this.lblPreasure = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCity.Location = new System.Drawing.Point(112, 116);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(54, 23);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "City : ";
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCity.Location = new System.Drawing.Point(172, 116);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(193, 23);
            this.txtBoxCity.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(552, 106);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 33);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.BackColor = System.Drawing.Color.Transparent;
            this.lblCondition.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondition.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCondition.Location = new System.Drawing.Point(112, 249);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(86, 23);
            this.lblCondition.TabIndex = 3;
            this.lblCondition.Text = "Condition";
            // 
            // lblSunset
            // 
            this.lblSunset.AutoSize = true;
            this.lblSunset.BackColor = System.Drawing.Color.Transparent;
            this.lblSunset.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSunset.Location = new System.Drawing.Point(112, 373);
            this.lblSunset.Name = "lblSunset";
            this.lblSunset.Size = new System.Drawing.Size(73, 23);
            this.lblSunset.TabIndex = 4;
            this.lblSunset.Text = "Sunset :";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblDetails.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDetails.Location = new System.Drawing.Point(112, 282);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(64, 23);
            this.lblDetails.TabIndex = 5;
            this.lblDetails.Text = "Details";
            // 
            // lblSunrise
            // 
            this.lblSunrise.AutoSize = true;
            this.lblSunrise.BackColor = System.Drawing.Color.Transparent;
            this.lblSunrise.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunrise.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSunrise.Location = new System.Drawing.Point(112, 339);
            this.lblSunrise.Name = "lblSunrise";
            this.lblSunrise.Size = new System.Drawing.Size(80, 23);
            this.lblSunrise.TabIndex = 6;
            this.lblSunrise.Text = "Sunrise : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(198, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(198, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "N/A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(648, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(666, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 23);
            this.label8.TabIndex = 13;
            this.label8.Text = "N/A";
            // 
            // lblWindSpeed
            // 
            this.lblWindSpeed.AutoSize = true;
            this.lblWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.lblWindSpeed.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindSpeed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWindSpeed.Location = new System.Drawing.Point(548, 249);
            this.lblWindSpeed.Name = "lblWindSpeed";
            this.lblWindSpeed.Size = new System.Drawing.Size(112, 23);
            this.lblWindSpeed.TabIndex = 12;
            this.lblWindSpeed.Text = "Wind Speed :";
            // 
            // lblPreasure
            // 
            this.lblPreasure.AutoSize = true;
            this.lblPreasure.BackColor = System.Drawing.Color.Transparent;
            this.lblPreasure.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreasure.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPreasure.Location = new System.Drawing.Point(547, 283);
            this.lblPreasure.Name = "lblPreasure";
            this.lblPreasure.Size = new System.Drawing.Size(91, 23);
            this.lblPreasure.TabIndex = 11;
            this.lblPreasure.Text = "Preasure : ";
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(116, 172);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(100, 50);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 15;
            this.picIcon.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(552, 451);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 33);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CfrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(768, 527);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblWindSpeed);
            this.Controls.Add(this.lblPreasure);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSunrise);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lblSunset);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBoxCity);
            this.Controls.Add(this.lblCity);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CfrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NickSean_WeatherCheck";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label lblSunset;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblSunrise;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblWindSpeed;
        private System.Windows.Forms.Label lblPreasure;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Button btnClose;
    }
}


﻿namespace ArdupilotMega.GCSViews.ConfigurationView
{
    partial class ConfigHWCompass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigHWCompass));
            this.BUT_MagCalibrationLive = new ArdupilotMega.Controls.MyButton();
            this.linkLabelmagdec = new System.Windows.Forms.LinkLabel();
            this.label100 = new System.Windows.Forms.Label();
            this.TXT_declination_deg = new System.Windows.Forms.TextBox();
            this.CHK_enablecompass = new ArdupilotMega.Controls.MavlinkCheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BUT_MagCalibrationLog = new ArdupilotMega.Controls.MyButton();
            this.CHK_autodec = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CMB_compass_orient = new ArdupilotMega.Controls.MavlinkComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.imageLabel1 = new ArdupilotMega.Controls.ImageLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonmanual = new System.Windows.Forms.RadioButton();
            this.radioButtonpx4 = new System.Windows.Forms.RadioButton();
            this.radioButton_external = new System.Windows.Forms.RadioButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.radioButton_onboard = new System.Windows.Forms.RadioButton();
            this.TXT_declination_min = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // BUT_MagCalibrationLive
            // 
            this.BUT_MagCalibrationLive.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(226)))), ((int)(((byte)(150)))));
            this.BUT_MagCalibrationLive.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            resources.ApplyResources(this.BUT_MagCalibrationLive, "BUT_MagCalibrationLive");
            this.BUT_MagCalibrationLive.Name = "BUT_MagCalibrationLive";
            this.BUT_MagCalibrationLive.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(148)))), ((int)(((byte)(41)))));
            this.BUT_MagCalibrationLive.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.BUT_MagCalibrationLive.UseVisualStyleBackColor = true;
            this.BUT_MagCalibrationLive.Click += new System.EventHandler(this.BUT_MagCalibration_Click);
            // 
            // linkLabelmagdec
            // 
            resources.ApplyResources(this.linkLabelmagdec, "linkLabelmagdec");
            this.linkLabelmagdec.Name = "linkLabelmagdec";
            this.linkLabelmagdec.TabStop = true;
            this.linkLabelmagdec.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label100
            // 
            resources.ApplyResources(this.label100, "label100");
            this.label100.Name = "label100";
            // 
            // TXT_declination_deg
            // 
            resources.ApplyResources(this.TXT_declination_deg, "TXT_declination_deg");
            this.TXT_declination_deg.Name = "TXT_declination_deg";
            this.TXT_declination_deg.Validated += new System.EventHandler(this.TXT_declination_Validated);
            // 
            // CHK_enablecompass
            // 
            resources.ApplyResources(this.CHK_enablecompass, "CHK_enablecompass");
            this.CHK_enablecompass.Name = "CHK_enablecompass";
            this.CHK_enablecompass.OffValue = 0F;
            this.CHK_enablecompass.OnValue = 1F;
            this.CHK_enablecompass.param = null;
            this.CHK_enablecompass.ParamName = null;
            this.CHK_enablecompass.UseVisualStyleBackColor = true;
            this.CHK_enablecompass.CheckedChanged += new System.EventHandler(this.CHK_enablecompass_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MissionPlanner.Properties.Resources.compass;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // BUT_MagCalibrationLog
            // 
            this.BUT_MagCalibrationLog.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(226)))), ((int)(((byte)(150)))));
            this.BUT_MagCalibrationLog.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(193)))), ((int)(((byte)(31)))));
            resources.ApplyResources(this.BUT_MagCalibrationLog, "BUT_MagCalibrationLog");
            this.BUT_MagCalibrationLog.Name = "BUT_MagCalibrationLog";
            this.BUT_MagCalibrationLog.Outline = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(148)))), ((int)(((byte)(41)))));
            this.BUT_MagCalibrationLog.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.BUT_MagCalibrationLog.UseVisualStyleBackColor = true;
            this.BUT_MagCalibrationLog.Click += new System.EventHandler(this.BUT_MagCalibrationLog_Click);
            // 
            // CHK_autodec
            // 
            resources.ApplyResources(this.CHK_autodec, "CHK_autodec");
            this.CHK_autodec.Name = "CHK_autodec";
            this.CHK_autodec.UseVisualStyleBackColor = true;
            this.CHK_autodec.CheckedChanged += new System.EventHandler(this.CHK_autodec_CheckedChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // CMB_compass_orient
            // 
            this.CMB_compass_orient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.CMB_compass_orient, "CMB_compass_orient");
            this.CMB_compass_orient.FormattingEnabled = true;
            this.CMB_compass_orient.Name = "CMB_compass_orient";
            this.CMB_compass_orient.param = null;
            this.CMB_compass_orient.ParamName = null;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // imageLabel1
            // 
            this.imageLabel1.Image = ((System.Drawing.Image)(resources.GetObject("imageLabel1.Image")));
            resources.ApplyResources(this.imageLabel1, "imageLabel1");
            this.imageLabel1.Name = "imageLabel1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::MissionPlanner.Properties.Resources.apmp2;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonmanual);
            this.groupBox1.Controls.Add(this.radioButtonpx4);
            this.groupBox1.Controls.Add(this.radioButton_external);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.CMB_compass_orient);
            this.groupBox1.Controls.Add(this.radioButton_onboard);
            this.groupBox1.Controls.Add(this.pictureBox2);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // radioButtonmanual
            // 
            resources.ApplyResources(this.radioButtonmanual, "radioButtonmanual");
            this.radioButtonmanual.Name = "radioButtonmanual";
            this.radioButtonmanual.TabStop = true;
            this.radioButtonmanual.UseVisualStyleBackColor = true;
            this.radioButtonmanual.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonpx4
            // 
            resources.ApplyResources(this.radioButtonpx4, "radioButtonpx4");
            this.radioButtonpx4.Name = "radioButtonpx4";
            this.radioButtonpx4.TabStop = true;
            this.radioButtonpx4.UseVisualStyleBackColor = true;
            this.radioButtonpx4.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton_external
            // 
            resources.ApplyResources(this.radioButton_external, "radioButton_external");
            this.radioButton_external.Name = "radioButton_external";
            this.radioButton_external.TabStop = true;
            this.radioButton_external.UseVisualStyleBackColor = true;
            this.radioButton_external.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::MissionPlanner.Properties.Resources.px4;
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::MissionPlanner.Properties.Resources.maggps;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // radioButton_onboard
            // 
            resources.ApplyResources(this.radioButton_onboard, "radioButton_onboard");
            this.radioButton_onboard.Name = "radioButton_onboard";
            this.radioButton_onboard.TabStop = true;
            this.radioButton_onboard.UseVisualStyleBackColor = true;
            this.radioButton_onboard.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // TXT_declination_min
            // 
            resources.ApplyResources(this.TXT_declination_min, "TXT_declination_min");
            this.TXT_declination_min.Name = "TXT_declination_min";
            this.TXT_declination_min.Validated += new System.EventHandler(this.TXT_declination_Validated);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // ConfigHWCompass
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXT_declination_min);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imageLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CHK_enablecompass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CHK_autodec);
            this.Controls.Add(this.BUT_MagCalibrationLog);
            this.Controls.Add(this.BUT_MagCalibrationLive);
            this.Controls.Add(this.linkLabelmagdec);
            this.Controls.Add(this.label100);
            this.Controls.Add(this.TXT_declination_deg);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ConfigHWCompass";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ArdupilotMega.Controls.MyButton BUT_MagCalibrationLive;
        private System.Windows.Forms.LinkLabel linkLabelmagdec;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.TextBox TXT_declination_deg;
        private ArdupilotMega.Controls.MavlinkCheckBox CHK_enablecompass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ArdupilotMega.Controls.MyButton BUT_MagCalibrationLog;
        private System.Windows.Forms.CheckBox CHK_autodec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private Controls.MavlinkComboBox CMB_compass_orient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private Controls.ImageLabel imageLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonmanual;
        private System.Windows.Forms.RadioButton radioButtonpx4;
        private System.Windows.Forms.RadioButton radioButton_external;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton radioButton_onboard;
        private System.Windows.Forms.TextBox TXT_declination_min;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

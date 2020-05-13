namespace FenixWebcamManager
{
    partial class FormHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.telerikMetroTheme = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.gbCameras = new Telerik.WinControls.UI.RadGroupBox();
            this.btnRefresh = new Telerik.WinControls.UI.RadButton();
            this.ddlCameras = new Telerik.WinControls.UI.RadDropDownList();
            this.gbImage = new Telerik.WinControls.UI.RadGroupBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnStart = new Telerik.WinControls.UI.RadButton();
            this.btnTakeAPicture = new Telerik.WinControls.UI.RadButton();
            this.btnStop = new Telerik.WinControls.UI.RadButton();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.lblStatus = new Telerik.WinControls.UI.RadLabelElement();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gbCameras)).BeginInit();
            this.gbCameras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlCameras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbImage)).BeginInit();
            this.gbImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTakeAPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCameras
            // 
            this.gbCameras.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbCameras.Controls.Add(this.btnRefresh);
            this.gbCameras.Controls.Add(this.ddlCameras);
            this.gbCameras.HeaderText = "Cameras";
            this.gbCameras.Location = new System.Drawing.Point(12, 12);
            this.gbCameras.Name = "gbCameras";
            this.gbCameras.Size = new System.Drawing.Size(395, 62);
            this.gbCameras.TabIndex = 0;
            this.gbCameras.Text = "Cameras";
            this.gbCameras.ThemeName = "TelerikMetro";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(270, 28);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(109, 24);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.ThemeName = "TelerikMetro";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ddlCameras
            // 
            this.ddlCameras.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlCameras.Location = new System.Drawing.Point(9, 28);
            this.ddlCameras.Name = "ddlCameras";
            this.ddlCameras.ReadOnly = true;
            this.ddlCameras.Size = new System.Drawing.Size(255, 24);
            this.ddlCameras.TabIndex = 0;
            this.ddlCameras.ThemeName = "TelerikMetro";
            // 
            // gbImage
            // 
            this.gbImage.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbImage.Controls.Add(this.pbImage);
            this.gbImage.HeaderText = "";
            this.gbImage.Location = new System.Drawing.Point(12, 80);
            this.gbImage.Name = "gbImage";
            this.gbImage.Size = new System.Drawing.Size(395, 262);
            this.gbImage.TabIndex = 1;
            this.gbImage.ThemeName = "TelerikMetro";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(9, 13);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(381, 244);
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(21, 359);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(110, 24);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.ThemeName = "TelerikMetro";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnTakeAPicture
            // 
            this.btnTakeAPicture.Location = new System.Drawing.Point(276, 359);
            this.btnTakeAPicture.Name = "btnTakeAPicture";
            this.btnTakeAPicture.Size = new System.Drawing.Size(115, 24);
            this.btnTakeAPicture.TabIndex = 3;
            this.btnTakeAPicture.Text = "Take a picture";
            this.btnTakeAPicture.ThemeName = "TelerikMetro";
            this.btnTakeAPicture.Click += new System.EventHandler(this.btnTakeAPicture_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(148, 359);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(110, 24);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.ThemeName = "TelerikMetro";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lblStatus});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 398);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(419, 25);
            this.radStatusStrip1.TabIndex = 5;
            this.radStatusStrip1.ThemeName = "TelerikMetro";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.radStatusStrip1.SetSpring(this.lblStatus, false);
            this.lblStatus.Text = "Done";
            this.lblStatus.TextWrap = true;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 423);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnTakeAPicture);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gbImage);
            this.Controls.Add(this.gbCameras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormHome";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Fenix Webcam Manager 1.0 - Copyright © Ismael Heredia 2020";
            this.ThemeName = "TelerikMetro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHome_FormClosing);
            this.Load += new System.EventHandler(this.FormHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbCameras)).EndInit();
            this.gbCameras.ResumeLayout(false);
            this.gbCameras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlCameras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbImage)).EndInit();
            this.gbImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTakeAPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme;
        private Telerik.WinControls.UI.RadGroupBox gbCameras;
        private Telerik.WinControls.UI.RadDropDownList ddlCameras;
        private Telerik.WinControls.UI.RadGroupBox gbImage;
        private System.Windows.Forms.PictureBox pbImage;
        private Telerik.WinControls.UI.RadButton btnStart;
        private Telerik.WinControls.UI.RadButton btnTakeAPicture;
        private Telerik.WinControls.UI.RadButton btnStop;
        private Telerik.WinControls.UI.RadButton btnRefresh;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement lblStatus;
        private System.Windows.Forms.Timer timer;
    }
}
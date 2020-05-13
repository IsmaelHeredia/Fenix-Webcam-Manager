// Fenix Webcam Manager 1.0
// Copyright © Ismael Heredia 2020

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using AForge.Video;
using System.Diagnostics;
using AForge.Video.DirectShow;
using System.Collections;
using System.IO;
using System.Drawing.Imaging;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace FenixWebcamManager
{
    public partial class FormHome : Telerik.WinControls.UI.RadForm
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource = null;

        public string program_title;

        public FormHome()
        {
            InitializeComponent();
            program_title = "Fenix Webcam Manager 1.0";
            RadMessageBox.SetThemeName("TelerikMetro");
        }

        public void loadCameras()
        {
            ddlCameras.Items.Clear();
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in videoDevices)
            {
                RadListDataItem item = new RadListDataItem();
                item.Text = device.Name;
                ddlCameras.Items.Add(item);
            }
            if (videoDevices.Count > 0)
            {
                ddlCameras.SelectedIndex = 0;
            }
        }

        private void StopCapture()
        {
            if (!(videoSource == null))
            {
                if (videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    videoSource = null;
                }
            }
            lblStatus.Text = "Stopped";
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
            pbImage.Image = img;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (videoDevices.Count > 0)
            {
                videoSource = new VideoCaptureDevice(videoDevices[ddlCameras.SelectedIndex].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
                StopCapture();
                videoSource.Start();
                timer.Enabled = true;
            }
            else
            {
                RadMessageBox.Show("Webcam not found", program_title, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (videoSource != null)
            {
                if (videoSource.IsRunning)
                {
                    timer.Enabled = false;
                    StopCapture();
                } else
                {
                    RadMessageBox.Show("Webcam not started", program_title, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                }
            } else
            {
                RadMessageBox.Show("Webcam not started", program_title, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnTakeAPicture_Click(object sender, EventArgs e)
        {
            Image imgCamera = pbImage.Image;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog.Title = "Save photo";
            saveFileDialog.DefaultExt = "jpeg";
            saveFileDialog.Filter = "JPEG File (.jpeg)|*.jpeg";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string photo_name = saveFileDialog.FileName;
                imgCamera.Save(photo_name, ImageFormat.Jpeg);
                RadMessageBox.Show("Picture taken", program_title, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
            }
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            loadCameras();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadCameras();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblStatus.Text = "Running... " + videoSource.FramesReceived.ToString() + " FPS";
        }

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCapture();
        }
    }
}

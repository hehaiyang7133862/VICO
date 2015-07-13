using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AForge.Video;
using AForge.Video.DirectShow;

namespace nsVicoClient.ctrls
{
    class VideoSource
    {
        private static VideoSource instance;
        /// <summary>
        /// AForge视频捕获对象
        /// </summary>
        private VideoCaptureDevice captureAForge = null;
        public NewFrameEventHandler NewFarmeEnvent;

        private VideoSource()
        { 
            FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            captureAForge = new VideoCaptureDevice(videoDevices[0].MonikerString);
            captureAForge.NewFrame += new NewFrameEventHandler(captureAForge_NewFrame);
            captureAForge.DesiredFrameSize = captureAForge.VideoCapabilities[7].FrameSize;}

        public static VideoSource getInstance()
        {
            if (instance == null)
            {
                instance = new VideoSource();
            }

            return instance;
        }


        /// <summary>
        /// 停止视频源
        /// </summary>
        public void Stop()
        {
            if (!(captureAForge == null))
                if (captureAForge.IsRunning)
                {
                    captureAForge.SignalToStop();
                }
        }

        /// <summary>
        /// 打开视频源
        /// </summary>
        public void Start()
        {
            if(!(captureAForge == null))
                if (!captureAForge.IsRunning)
                {
                    captureAForge.Start();
                }
        }

        public void Close()
        {
            if (!(captureAForge == null))
                if (captureAForge.IsRunning)
                {
                    captureAForge.SignalToStop();
                    captureAForge.WaitForStop();

                    captureAForge = null;
                }
        }

        void captureAForge_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (NewFarmeEnvent != null)
            {
                NewFarmeEnvent(sender, eventArgs);
            }
        }
    }
}

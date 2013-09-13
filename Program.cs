﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text;
using System.Threading;
using log4net;
using log4net.Config;
using System.Diagnostics;
using System.Linq;
using MissionPlanner.Utilities;
using MissionPlanner;

namespace ArdupilotMega
{
    static class Program
    {
        private static readonly ILog log = LogManager.GetLogger("Program");

        public static DateTime starttime = DateTime.Now;

        public static Splash Splash;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Console.WriteLine("If your error is about Microsoft.DirectX.DirectInput, please install the latest directx redist from here http://www.microsoft.com/en-us/download/details.aspx?id=35 \n\n");

            Application.EnableVisualStyles();
            XmlConfigurator.Configure();
            log.Info("******************* Logging Configured *******************");
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += Application_ThreadException;

            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            // fix ssl on mono
            ServicePointManager.ServerCertificateValidationCallback =
new System.Net.Security.RemoteCertificateValidationCallback((sender, certificate, chain, policyErrors) => { return true; });

            CustomMessageBox.ApplyTheme += ArdupilotMega.Utilities.ThemeManager.ApplyThemeTo;
            ArdupilotMega.Controls.MainSwitcher.ApplyTheme += ArdupilotMega.Utilities.ThemeManager.ApplyThemeTo;
            MissionPlanner.Controls.InputBox.ApplyTheme += ArdupilotMega.Utilities.ThemeManager.ApplyThemeTo;
            MissionPlanner.Comms.CommsBase.Settings += CommsBase_Settings;

       //     string[] files = Directory.GetFiles(@"C:\Users\hog\Documents\apm logs\","*.tlog");

       //     foreach (string file in files) {
          //      Console.WriteLine(Magfitrotation.magfit(file));
        //    }
       //     Magfitrotation.magfit(@"C:\Users\hog\Downloads\flight.tlog.raw");

            
            //return;
        //    MissionPlanner.Utilities.CleanDrivers.Clean();

            //Application.Idle += Application_Idle;

            //MagCalib.ProcessLog();

            //MessageBox.Show("NOTE: This version may break advanced mission scripting");

            //Common.linearRegression();

            //Console.WriteLine(srtm.getAltitude(-35.115676879882812, 117.94178754638671,20));

           // Console.ReadLine();
           // return;

            /*
            Arduino.ArduinoSTKv2 comport = new Arduino.ArduinoSTKv2();

            comport.PortName = "com8";

            comport.BaudRate = 115200;

            comport.Open();

            Arduino.Chip.Populate();

            if (comport.connectAP())
            {
                Arduino.Chip chip = comport.getChipType();
                Console.WriteLine(chip);
            }
            Console.ReadLine();

            return;
            */
            /*
            Comms.SerialPort sp = new Comms.SerialPort();

            sp.PortName = "com8";
            sp.BaudRate = 115200;

            CurrentState cs = new CurrentState();

            MAVLink mav = new MAVLink();

            mav.BaseStream = sp;

            mav.Open();

            HIL.XPlane xp = new HIL.XPlane();

            xp.SetupSockets(49005, 49000, "127.0.0.1");

            HIL.Hil.sitl_fdm data = new HIL.Hil.sitl_fdm();

            while (true)
            {
                while (mav.BaseStream.BytesToRead > 0)
                    mav.readPacket();

                // update all stats
                cs.UpdateCurrentSettings(null);

                xp.GetFromSim(ref data);
                xp.GetFromAP(); // no function

                xp.SendToAP(data);
                xp.SendToSim();

                MAVLink.mavlink_rc_channels_override_t rc = new MAVLink.mavlink_rc_channels_override_t();

                rc.chan3_raw = 1500;

                mav.sendPacket(rc);
                
            }       */
            /*
            MAVLink mav = new MAVLink();

            mav.BaseStream = new Comms.CommsFile() 
            {
                PortName = @"C:\Users\hog\AppData\Roaming\Skype\My Skype Received Files\2013-06-12 15-11-00.tlog"
            };

            mav.Open(false);

            while (mav.BaseStream.BytesToRead > 0)
            {

                byte[] packet = mav.readPacket();

                mav.DebugPacket(packet, true);
            }
            */

           // return;
          //  OSDVideo vid = new OSDVideo();

         //   vid.ShowDialog();

         //   return;

         //   new Swarm.Control().ShowDialog();
         //   return;

          //  Application.Run(new GenOTP());

            //Utilities.RSA rsa = new Utilities.RSA();

            //rsa.testit();

           // return;

            //Utilities.S3Uploader s3 = new Utilities.S3Uploader("");

            //s3.UploadTlog(@"C:\Users\hog\Documents\apm logs\2012-10-27 15-05-54.tlog");

            float t1 = 180;
            float t2 = -180;
            float t3 = -37.123456789f;
            float t4 = 37.123456789f;
            float t5 = 150.123456789f;

            Console.WriteLine("7 digits {0} {1} {2} {3} {4}",t1,t2,t3,t4,t5);

            if (File.Exists("simple.txt"))
            {
                Application.Run(new GCSViews.Simple());
                return;
            }

            Splash = new ArdupilotMega.Splash();
            Splash.Show();

            Application.DoEvents();

            try
            {
                Thread.CurrentThread.Name = "Base Thread";
                Application.Run(new MainV2());
            }
            catch (Exception ex)
            {
                log.Fatal("Fatal app exception", ex);
                Console.WriteLine(ex.ToString());

                Console.WriteLine("\nPress any key to exit!");
                Console.ReadLine();
            }
        }

        static string CommsBase_Settings(string name, string value, bool set = false)
        {
            if (set) {
                MainV2.config[name] = value;
                return value;
            }

            if (MainV2.config.ContainsKey(name)) {
                return MainV2.config[name].ToString();
            }

            return "";
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            handleException((Exception)e.ExceptionObject);
        }

        static DateTime lastidle = DateTime.Now;

        static void Application_Idle(object sender, EventArgs e)
        {
            //System.Threading.Thread.Sleep(50);
            Console.Write("Idle\n");
            if (lastidle.AddMilliseconds(100) < DateTime.Now)
            {
                Application.DoEvents();
                lastidle = DateTime.Now;
            }

            System.Threading.Thread.Sleep(1);
        }

        static void handleException(Exception ex)
        {
            MissionPlanner.Utilities.Tracking.AddException(ex);

            log.Debug(ex.ToString());

            // hyperlinks error
            if (ex.Message == "Requested registry access is not allowed.")
            {
                return;
            }
            if (ex.Message == "The port is closed.")
            {
                CustomMessageBox.Show("Serial connection has been lost");
                return;
            }
            if (ex.Message == "A device attached to the system is not functioning.")
            {
                CustomMessageBox.Show("Serial connection has been lost");
                return;
            }
            if (ex.GetType() == typeof(MissingMethodException))
            {
                CustomMessageBox.Show("Please Update - Some older library dlls are causing problems\n" + ex.Message);
                return;
            }
            if (ex.GetType() == typeof(ObjectDisposedException) || ex.GetType() == typeof(InvalidOperationException)) // something is trying to update while the form, is closing.
            {
                return; // ignore
            }
            if (ex.GetType() == typeof(FileNotFoundException) || ex.GetType() == typeof(BadImageFormatException)) // i get alot of error from people who click the exe from inside a zip file.
            {
                CustomMessageBox.Show("You are missing some DLL's. Please extract the zip file somewhere. OR Use the update feature from the menu " + ex.ToString());
                // return;
            }
            if (ex.StackTrace.Contains("System.IO.Ports.SerialStream.Dispose"))
            {
                return; // ignore
            }

            DialogResult dr = CustomMessageBox.Show("An error has occurred\n" + ex.ToString() + "\n\nReport this Error???", "Send Error", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == dr)
            {
                try
                {
                    string data = "";
                        foreach (System.Collections.DictionaryEntry de in ex.Data)
                            data += String.Format("-> {0}: {1}", de.Key, de.Value);
              

                    // Create a request using a URL that can receive a post. 
                    WebRequest request = WebRequest.Create("http://vps.oborne.me/mail.php");
                    request.Timeout = 10000; // 10 sec
                    // Set the Method property of the request to POST.
                    request.Method = "POST";
                    // Create POST data and convert it to a byte array.
                    string postData = "message=" + Environment.OSVersion.VersionString + " " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() 
                        + " " + Application.ProductVersion 
                        + "\nException " + ex.ToString().Replace('&', ' ').Replace('=', ' ') 
                        + "\nStack: " + ex.StackTrace.ToString().Replace('&', ' ').Replace('=', ' ') 
                        + "\nTargetSite " + ex.TargetSite + " " + ex.TargetSite.DeclaringType
                        + "\ndata " + data;
                    byte[] byteArray = Encoding.ASCII.GetBytes(postData);
                    // Set the ContentType property of the WebRequest.
                    request.ContentType = "application/x-www-form-urlencoded";
                    // Set the ContentLength property of the WebRequest.
                    request.ContentLength = byteArray.Length;
                    // Get the request stream.
                    Stream dataStream = request.GetRequestStream();
                    // Write the data to the request stream.
                    dataStream.Write(byteArray, 0, byteArray.Length);
                    // Close the Stream object.
                    dataStream.Close();
                    // Get the response.
                    WebResponse response = request.GetResponse();
                    // Display the status.
                    Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                    // Get the stream containing content returned by the server.
                    dataStream = response.GetResponseStream();
                    // Open the stream using a StreamReader for easy access.
                    StreamReader reader = new StreamReader(dataStream);
                    // Read the content.
                    string responseFromServer = reader.ReadToEnd();
                    // Display the content.
                    Console.WriteLine(responseFromServer);
                    // Clean up the streams.
                    reader.Close();
                    dataStream.Close();
                    response.Close();
                }
                catch
                {
                    CustomMessageBox.Show("Error sending Error report!! Youre most likerly are not on the internet");
                }
            }
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Exception ex = e.Exception;

            handleException(ex);
        }
    }
}
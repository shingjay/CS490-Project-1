using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TFTPClientNameSpace;

namespace Project1.TestAdapter
{
    public class AdapterClass
    {
        public static TFTPClient client = InitializeTestAdapter();
        public static string remoteFile = @"remote.txt";
        public static string localFile = createLocalFilePath();

        static string createLocalFilePath()
        {
            // Specify a "currently active folder" 
            string activeDir = @"C:\Users\Sulin\Documents\Proj1TestDir";

            //Create a new subfolder under the current active folder 
            string newPath = System.IO.Path.Combine(activeDir, "SubDir");

            // Create the subfolder
            System.IO.Directory.CreateDirectory(newPath);

            // Create a new file name. This example generates 
            // a random string. 
            string newFileName = System.IO.Path.GetRandomFileName();

            // Combine the new file name with the path
            newPath = System.IO.Path.Combine(newPath, newFileName);

            // Create the file and write to it. 
            // Create will overwrite the file 
            // if it already exists.
            if (!System.IO.File.Exists(newPath))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(newPath))
                {
                    for (byte i = 0; i < 100; i++)
                    {
                        fs.WriteByte(i);
                    }
                }
            }

            return newPath;
        }

        public static void Checker(int state)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual
            (state, (int)client.tftpClientMode, "AdapterClass mismatch: Model vs Implimentation.");
        }

        static TFTPClient InitializeTestAdapter()
        {
            TFTPClient c = new TFTPClient("127.0.0.1", 69);
            c.initialize();

            localFile = createLocalFilePath();
            return c;
        }

        static void AdapterSendReadRequest()
        {
            client.sendReadRequest(remoteFile, localFile, TFTPClient.Modes.NetAscii);
        }

        static void AdapterReceiveDataBlock()
        {
        }

        static void AdapterSendACK()
        {
        }

        static bool AdapterCanGetExit(int len)
        {
            return true;
        }

        static void AdapterSendWriteRequest()
        {

        }

        static void AdapterSendDataBlock()
        {
        }

        static void AdapterReceiveACK()
        {
        }

        static bool AdapterCanPutExit(int len)
        {
            return true;
        }
    }
}

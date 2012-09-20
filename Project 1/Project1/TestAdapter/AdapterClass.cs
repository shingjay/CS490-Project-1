using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using TFTPClientNameSpace;

namespace Project1.TestAdapter
{
    public class AdapterClass
    {
        public static TFTPClient client = InitializeTestAdapter();
        public static string remoteFile = @"remote.txt";
        public static string localFile = createLocalFilePath();

        //creates a local file path
        static string createLocalFilePath()
        {
            // Specify a "currently active folder" 
            string activeDir = @"C:\Users\Jay\Documents\GitHub\CS490Testing-Project-1\Project 1\";

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

        /// <summary>
        /// State Checker Pattern method(MSDN)
        /// </summary>
        /// <param name="mode"></param>
        public static void Checker(int state)   
        {
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual
            (state, (int)client.tftpClientMode, "AdapterClass mismatch: Model vs Implementation.");
        }

        /// <summary>
        /// Initialze the TFTP client. Set the state to be INIT
        /// </summary>
        public static TFTPClient InitializeTestAdapter()
        {
            TFTPClient newClient = new TFTPClient("127.0.0.1", 69);
            newClient.initialize();

            localFile = createLocalFilePath();
            return newClient;
        }

        /// <summary>
        /// Send Read Request. It creates the TFTP read request packet, send the packet. INIT --> RRQ_SENT.
        /// </summary>
        /// <param name="remoteFile">The remote file.</param>
        /// <param name="localFile">The local file.</param>
        /// <param name="tftpMode">The TFTP mode, NetAscii, Octet, Mail.</param>
        public static void AdapterSendReadRequest()
        {
            client.sendReadRequest(remoteFile, localFile, TFTPClient.Modes.NetAscii);
        }

        /// <summary>
        /// Receive Data Block from the TFTP server. RRQ_SENT or ACK_SENT --> DATA_RECEIVED.
        /// </summary>
        /// <param name="rcvBuffer">the receiving buffer for return.</param>
        /// <returns>
        /// A int variable that tell the length of the receiving buffer. 
        /// </returns>
        public static void AdapterReceiveDataBlock()
        {
            byte[] rcvBuffer;
            client.receiveDataBlock(out rcvBuffer);

        }

        /// <summary>
        /// Send ACK packet to the TFTP server, after successfully receive the data block from the TFTP server. DATA_RECEIVED --> ACK_SENT.
        /// </summary>
        public static void AdapterSendACK()
        {
            client.sendACK();
        }

        /// <summary>
        /// check whether it is time to successfully exit. If yes, current state --> EXIT; otherwise, keep the current state.
        /// </summary>
        /// <param name="len">The length of receving buffer.</param>
        /// <returns>
        /// A bool variable indicating whether it is time to successfully exit. It is TRUE for successfully exit, FALSE for staying in the loop and continuing the file transfer. 
        /// </returns>
        public static bool AdapterCanGetExit(int len)
        {
            return client.canGetExit(len);
        }

        /// <summary>
        /// Send Write Request. Create the WRQ packet, send it to the server. INIT --> WRQ_SENT.
        /// </summary>
        /// <param name="remoteFile">The remote file.</param>
        /// <param name="localFile">The local file.</param>
        /// <param name="tftpMode">The TFTP mode.</param>
        /// <param name="sndBuffer">The returned sending buffer.</param>
        public static void AdapterSendWriteRequest()
        {
            byte[] sndBuffer;
            client.sendWriteRequest(remoteFile, localFile, TFTPClient.Modes.NetAscii, out sndBuffer);
        }

        /// <summary>
        /// Send Data Block. ACK_RECEIVED --> DATA_SENT.
        /// </summary>
        /// <param name="fileStream">The file stream for writing the downloading file.</param>
        /// <param name="sndBuffer">The returned sending buffer.</param>
        public static void AdapterSendDataBlock()
        {
            BinaryReader fileStream = new BinaryReader(new FileStream(localFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite));
            byte[] sndBuffer;
            client.sendDataBlock(fileStream, out sndBuffer);
        }

        /// <summary>
        /// Receive ACK from the server. WRQ_SENT or DATA_SENT --> ACK_RECEIVED
        /// </summary>
        /// <param name="rcvBuffer">The receiving buffer.</param>
        /// <returns>
        /// A int variable that tell the length of the receiving buffer. 
        /// </returns>
        public static void AdapterReceiveACK()
        {
            byte[] rcvBuffer;
            client.receiveACK(out rcvBuffer);
        }

        /// <summary>
        /// check whether it is time to successfully exit. If yes, current state --> EXIT; otherwise, keep the current state unchanged. 
        /// </summary>
        /// <param name="len">The length of the sending buffer.</param>
        /// <returns>
        /// A bool variable indicating whether it is time to successfully exit. It is TRUE for successfully exit, FALSE for staying in the loop and continuing the file transfer. 
        /// </returns>
        public static bool AdapterCanPutExit(int len)
        {
            return client.canPutExit(len);
        }
    }
}

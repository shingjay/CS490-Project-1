﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TFTPClientNameSpace;

namespace Project1.TestAdapter
{
    public class AdapterClass
    {
        private static TFTPClient client;

        static void InitializeTestAdapter()
        {
            client = new TFTPClient("127.0.0.1");
            client.initialize();    
        }

        static void AdapterSendReadRequest()
        {
         //   client.sendReadRequest();
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

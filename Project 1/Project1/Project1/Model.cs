using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Modeling;
using TFTPClientNameSpace;

namespace Project1
{   
    static class ModelProgram
    {
        // state variable
        static TFTPClient.FSM_Modes mode;

        [Rule(Action = "InitializeTestAdapter()")]
        static void Initialize()
        {
            mode = TFTPClient.FSM_Modes.INIT;
        }

        [Rule(Action = "AdapterSendReadRequest()")]
        static void SendReadRequest()
        {
            Condition.IsTrue(mode == TFTPClient.FSM_Modes.INIT);
            mode = TFTPClient.FSM_Modes.RRQ_SENT;
        }

        [Rule(Action = "AdapterReceiveDataBlock()")]
        static void ReceiveDataBlock()
        {
            Condition.IsTrue(mode == TFTPClient.FSM_Modes.RRQ_SENT || mode == TFTPClient.FSM_Modes.ACK_SENT);
            mode = TFTPClient.FSM_Modes.DATA_RECEIVED;
        }

        [Rule(Action = "AdapterSendACK()")]
        static void SendACK()
        {
            Condition.IsTrue(mode == TFTPClient.FSM_Modes.DATA_SENT);
            mode = TFTPClient.FSM_Modes.ACK_SENT;
        }

        [Rule(Action = "AdapterSendWriteRequest()")]
        static void SendWriteRequest()
        {
            Condition.IsTrue(mode == TFTPClient.FSM_Modes.INIT);
            mode = TFTPClient.FSM_Modes.WRQ_SENT;
        }

        [Rule(Action = "AdapterSendDataBlock()")]
        static void SendDataBlock()
        {
            Condition.IsTrue(mode == TFTPClient.FSM_Modes.ACK_RECEIVED);
            mode = TFTPClient.FSM_Modes.DATA_SENT;
        }

        [Rule(Action = "AdapterReceiveACK()")]
        static void ReceiveACK()
        {
            Condition.IsTrue(mode == TFTPClient.FSM_Modes.WRQ_SENT || mode == TFTPClient.FSM_Modes.DATA_SENT);
            mode = TFTPClient.FSM_Modes.ACK_RECEIVED;
        }

        [Rule(Action = "AdapterCanPutExit(len)/result")]
        static bool CanPutExit(int len)
        {
            Condition.IsTrue(mode == TFTPClient.FSM_Modes.DATA_SENT);
            if (len > 516)
            {
                mode = TFTPClient.FSM_Modes.EXIT;
                return true;
            }
            return false;
        }

        [Rule(Action = "AdapterCanGetExit(len)/result")]
        static bool CanGetExit(int len)
        {
            Condition.IsTrue(mode == TFTPClient.FSM_Modes.DATA_RECEIVED);
            if (len > 516)
            {
                mode = TFTPClient.FSM_Modes.EXIT;
                return true;
            }
            return false;
        }

        [Rule]
        static void Checker(int state)
        {
            Condition.IsTrue((int)mode == state);
        }
    }
}

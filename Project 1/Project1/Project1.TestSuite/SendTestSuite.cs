//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GeneratedTests {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Reflection;
    using Microsoft.SpecExplorer.Runtime.Testing;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Spec Explorer", "3.5.3130.0")]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class SendTestSuite : VsTestClassBase {
        
        public SendTestSuite() {
            this.SetSwitch("ProceedControlTimeout", "100");
            this.SetSwitch("QuiescenceTimeout", "30000");
        }
        
        #region Test Initialization and Cleanup
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize() {
            this.InitializeTestManager();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void TestCleanup() {
            this.CleanupTestManager();
        }
        #endregion
        
        #region Test Starting in S0
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void SendTestSuiteS0() {
            this.Manager.BeginTest("SendTestSuiteS0");
            this.Manager.Comment("reaching state \'S0\'");
            this.Manager.Comment("executing step \'call InitializeTestAdapter()\'");
            Project1.TestAdapter.AdapterClass.InitializeTestAdapter();
            this.Manager.Comment("reaching state \'S1\'");
            this.Manager.Comment("checking step \'return InitializeTestAdapter\'");
            this.Manager.Comment("reaching state \'S14\'");
            this.Manager.Comment("executing step \'call AdapterSendWriteRequest()\'");
            Project1.TestAdapter.AdapterClass.AdapterSendWriteRequest();
            this.Manager.Comment("reaching state \'S21\'");
            this.Manager.Comment("checking step \'return AdapterSendWriteRequest\'");
            this.Manager.Comment("reaching state \'S28\'");
            this.Manager.Comment("executing step \'call AdapterReceiveACK()\'");
            Project1.TestAdapter.AdapterClass.AdapterReceiveACK();
            this.Manager.Comment("reaching state \'S35\'");
            this.Manager.Comment("checking step \'return AdapterReceiveACK\'");
            this.Manager.Comment("reaching state \'S42\'");
            this.Manager.Comment("executing step \'call AdapterSendDataBlock()\'");
            Project1.TestAdapter.AdapterClass.AdapterSendDataBlock();
            this.Manager.Comment("reaching state \'S49\'");
            this.Manager.Comment("checking step \'return AdapterSendDataBlock\'");
            this.Manager.Comment("reaching state \'S56\'");
            this.Manager.Comment("executing step \'call AdapterReceiveACK()\'");
            Project1.TestAdapter.AdapterClass.AdapterReceiveACK();
            this.Manager.Comment("reaching state \'S63\'");
            this.Manager.Comment("checking step \'return AdapterReceiveACK\'");
            this.Manager.Comment("reaching state \'S70\'");
            this.Manager.Comment("executing step \'call AdapterSendDataBlock()\'");
            Project1.TestAdapter.AdapterClass.AdapterSendDataBlock();
            this.Manager.Comment("reaching state \'S77\'");
            this.Manager.Comment("checking step \'return AdapterSendDataBlock\'");
            this.Manager.Comment("reaching state \'S84\'");
            bool temp0;
            this.Manager.Comment("executing step \'call AdapterCanPutExit(0)\'");
            temp0 = Project1.TestAdapter.AdapterClass.AdapterCanPutExit(0);
            this.Manager.Comment("reaching state \'S91\'");
            this.Manager.Comment("checking step \'return AdapterCanPutExit/False\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, temp0, "return of AdapterCanPutExit, state S91");
            this.Manager.Comment("reaching state \'S98\'");
            this.Manager.Comment("executing step \'call AdapterReceiveACK()\'");
            Project1.TestAdapter.AdapterClass.AdapterReceiveACK();
            this.Manager.Comment("reaching state \'S105\'");
            this.Manager.Comment("checking step \'return AdapterReceiveACK\'");
            this.Manager.Comment("reaching state \'S106\'");
            this.Manager.Comment("executing step \'call AdapterSendDataBlock()\'");
            Project1.TestAdapter.AdapterClass.AdapterSendDataBlock();
            this.Manager.Comment("reaching state \'S107\'");
            this.Manager.Comment("checking step \'return AdapterSendDataBlock\'");
            this.Manager.Comment("reaching state \'S108\'");
            bool temp1;
            this.Manager.Comment("executing step \'call AdapterCanPutExit(0)\'");
            temp1 = Project1.TestAdapter.AdapterClass.AdapterCanPutExit(0);
            this.Manager.Comment("reaching state \'S109\'");
            this.Manager.Comment("checking step \'return AdapterCanPutExit/False\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, temp1, "return of AdapterCanPutExit, state S109");
            this.Manager.Comment("reaching state \'S110\'");
            this.Manager.EndTest();
        }
        #endregion
        
        #region Test Starting in S10
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void SendTestSuiteS10() {
            this.Manager.BeginTest("SendTestSuiteS10");
            this.Manager.Comment("reaching state \'S10\'");
            this.Manager.Comment("executing step \'call InitializeTestAdapter()\'");
            Project1.TestAdapter.AdapterClass.InitializeTestAdapter();
            this.Manager.Comment("reaching state \'S11\'");
            this.Manager.Comment("checking step \'return InitializeTestAdapter\'");
            this.Manager.Comment("reaching state \'S19\'");
            this.Manager.Comment("executing step \'call AdapterSendWriteRequest()\'");
            Project1.TestAdapter.AdapterClass.AdapterSendWriteRequest();
            this.Manager.Comment("reaching state \'S26\'");
            this.Manager.Comment("checking step \'return AdapterSendWriteRequest\'");
            this.Manager.Comment("reaching state \'S33\'");
            this.Manager.Comment("executing step \'call AdapterReceiveACK()\'");
            Project1.TestAdapter.AdapterClass.AdapterReceiveACK();
            this.Manager.Comment("reaching state \'S40\'");
            this.Manager.Comment("checking step \'return AdapterReceiveACK\'");
            this.Manager.Comment("reaching state \'S47\'");
            this.Manager.Comment("executing step \'call AdapterSendDataBlock()\'");
            Project1.TestAdapter.AdapterClass.AdapterSendDataBlock();
            this.Manager.Comment("reaching state \'S54\'");
            this.Manager.Comment("checking step \'return AdapterSendDataBlock\'");
            this.Manager.Comment("reaching state \'S61\'");
            this.Manager.Comment("executing step \'call AdapterReceiveACK()\'");
            Project1.TestAdapter.AdapterClass.AdapterReceiveACK();
            this.Manager.Comment("reaching state \'S68\'");
            this.Manager.Comment("checking step \'return AdapterReceiveACK\'");
            this.Manager.Comment("reaching state \'S75\'");
            this.Manager.Comment("executing step \'call AdapterSendDataBlock()\'");
            Project1.TestAdapter.AdapterClass.AdapterSendDataBlock();
            this.Manager.Comment("reaching state \'S82\'");
            this.Manager.Comment("checking step \'return AdapterSendDataBlock\'");
            this.Manager.Comment("reaching state \'S89\'");
            bool temp2;
            this.Manager.Comment("executing step \'call AdapterCanPutExit(516)\'");
            temp2 = Project1.TestAdapter.AdapterClass.AdapterCanPutExit(516);
            this.Manager.Comment("reaching state \'S96\'");
            this.Manager.Comment("checking step \'return AdapterCanPutExit/False\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, temp2, "return of AdapterCanPutExit, state S96");
            this.Manager.Comment("reaching state \'S103\'");
            this.Manager.EndTest();
        }
        #endregion
        
        #region Test Starting in S12
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void SendTestSuiteS12() {
            this.Manager.BeginTest("SendTestSuiteS12");
            this.Manager.Comment("reaching state \'S12\'");
            this.Manager.Comment("executing step \'call InitializeTestAdapter()\'");
            Project1.TestAdapter.AdapterClass.InitializeTestAdapter();
            this.Manager.Comment("reaching state \'S13\'");
            this.Manager.Comment("checking step \'return InitializeTestAdapter\'");
            this.Manager.Comment("reaching state \'S20\'");
            this.Manager.Comment("executing step \'call AdapterSendWriteRequest()\'");
            Project1.TestAdapter.AdapterClass.AdapterSendWriteRequest();
            this.Manager.Comment("reaching state \'S27\'");
            this.Manager.Comment("checking step \'return AdapterSendWriteRequest\'");
            this.Manager.Comment("reaching state \'S34\'");
            this.Manager.Comment("executing step \'call AdapterReceiveACK()\'");
            Project1.TestAdapter.AdapterClass.AdapterReceiveACK();
            this.Manager.Comment("reaching state \'S41\'");
            this.Manager.Comment("checking step \'return AdapterReceiveACK\'");
            this.Manager.Comment("reaching state \'S48\'");
            this.Manager.Comment("executing step \'call AdapterSendDataBlock()\'");
            Project1.TestAdapter.AdapterClass.AdapterSendDataBlock();
            this.Manager.Comment("reaching state \'S55\'");
            this.Manager.Comment("checking step \'return AdapterSendDataBlock\'");
            this.Manager.Comment("reaching state \'S62\'");
            this.Manager.Comment("executing step \'call AdapterReceiveACK()\'");
            Project1.TestAdapter.AdapterClass.AdapterReceiveACK();
            this.Manager.Comment("reaching state \'S69\'");
            this.Manager.Comment("checking step \'return AdapterReceiveACK\'");
            this.Manager.Comment("reaching state \'S76\'");
            this.Manager.Comment("executing step \'call AdapterSendDataBlock()\'");
            Project1.TestAdapter.AdapterClass.AdapterSendDataBlock();
            this.Manager.Comment("reaching state \'S83\'");
            this.Manager.Comment("checking step \'return AdapterSendDataBlock\'");
            this.Manager.Comment("reaching state \'S90\'");
            bool temp3;
            this.Manager.Comment("executing step \'call AdapterCanPutExit(1024)\'");
            temp3 = Project1.TestAdapter.AdapterClass.AdapterCanPutExit(1024);
            this.Manager.Comment("reaching state \'S97\'");
            this.Manager.Comment("checking step \'return AdapterCanPutExit/True\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, temp3, "return of AdapterCanPutExit, state S97");
            this.Manager.Comment("reaching state \'S104\'");
            this.Manager.EndTest();
        }
        #endregion
        
        #region Test Starting in S2
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void SendTestSuiteS2() {
            this.Manager.BeginTest("SendTestSuiteS2");
            this.Manager.Comment("reaching state \'S2\'");
            this.Manager.Comment("executing step \'call InitializeTestAdapter()\'");
            Project1.TestAdapter.AdapterClass.InitializeTestAdapter();
            this.Manager.Comment("reaching state \'S3\'");
            this.Manager.Comment("checking step \'return InitializeTestAdapter\'");
            this.Manager.Comment("reaching state \'S15\'");
            this.Manager.Comment("executing step \'call AdapterSendWriteRequest()\'");
            Project1.TestAdapter.AdapterClass.AdapterSendWriteRequest();
            this.Manager.Comment("reaching state \'S22\'");
            this.Manager.Comment("checking step \'return AdapterSendWriteRequest\'");
            this.Manager.Comment("reaching state \'S29\'");
            this.Manager.Comment("executing step \'call AdapterReceiveACK()\'");
            Project1.TestAdapter.AdapterClass.AdapterReceiveACK();
            this.Manager.Comment("reaching state \'S36\'");
            this.Manager.Comment("checking step \'return AdapterReceiveACK\'");
            this.Manager.Comment("reaching state \'S43\'");
            this.Manager.Comment("executing step \'call AdapterSendDataBlock()\'");
            Project1.TestAdapter.AdapterClass.AdapterSendDataBlock();
            this.Manager.Comment("reaching state \'S50\'");
            this.Manager.Comment("checking step \'return AdapterSendDataBlock\'");
            this.Manager.Comment("reaching state \'S57\'");
            this.Manager.Comment("executing step \'call AdapterReceiveACK()\'");
            Project1.TestAdapter.AdapterClass.AdapterReceiveACK();
            this.Manager.Comment("reaching state \'S64\'");
            this.Manager.Comment("checking step \'return AdapterReceiveACK\'");
            this.Manager.Comment("reaching state \'S71\'");
            this.Manager.Comment("executing step \'call AdapterSendDataBlock()\'");
            Project1.TestAdapter.AdapterClass.AdapterSendDataBlock();
            this.Manager.Comment("reaching state \'S78\'");
            this.Manager.Comment("checking step \'return AdapterSendDataBlock\'");
            this.Manager.Comment("reaching state \'S85\'");
            bool temp4;
            this.Manager.Comment("executing step \'call AdapterCanPutExit(16)\'");
            temp4 = Project1.TestAdapter.AdapterClass.AdapterCanPutExit(16);
            this.Manager.Comment("reaching state \'S92\'");
            this.Manager.Comment("checking step \'return AdapterCanPutExit/False\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, temp4, "return of AdapterCanPutExit, state S92");
            this.Manager.Comment("reaching state \'S99\'");
            this.Manager.EndTest();
        }
        #endregion
        
        #region Test Starting in S4
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void SendTestSuiteS4() {
            this.Manager.BeginTest("SendTestSuiteS4");
            this.Manager.Comment("reaching state \'S4\'");
            this.Manager.Comment("executing step \'call InitializeTestAdapter()\'");
            Project1.TestAdapter.AdapterClass.InitializeTestAdapter();
            this.Manager.Comment("reaching state \'S5\'");
            this.Manager.Comment("checking step \'return InitializeTestAdapter\'");
            this.Manager.Comment("reaching state \'S16\'");
            this.Manager.Comment("executing step \'call AdapterSendWriteRequest()\'");
            Project1.TestAdapter.AdapterClass.AdapterSendWriteRequest();
            this.Manager.Comment("reaching state \'S23\'");
            this.Manager.Comment("checking step \'return AdapterSendWriteRequest\'");
            this.Manager.Comment("reaching state \'S30\'");
            this.Manager.Comment("executing step \'call AdapterReceiveACK()\'");
            Project1.TestAdapter.AdapterClass.AdapterReceiveACK();
            this.Manager.Comment("reaching state \'S37\'");
            this.Manager.Comment("checking step \'return AdapterReceiveACK\'");
            this.Manager.Comment("reaching state \'S44\'");
            this.Manager.Comment("executing step \'call AdapterSendDataBlock()\'");
            Project1.TestAdapter.AdapterClass.AdapterSendDataBlock();
            this.Manager.Comment("reaching state \'S51\'");
            this.Manager.Comment("checking step \'return AdapterSendDataBlock\'");
            this.Manager.Comment("reaching state \'S58\'");
            this.Manager.Comment("executing step \'call AdapterReceiveACK()\'");
            Project1.TestAdapter.AdapterClass.AdapterReceiveACK();
            this.Manager.Comment("reaching state \'S65\'");
            this.Manager.Comment("checking step \'return AdapterReceiveACK\'");
            this.Manager.Comment("reaching state \'S72\'");
            this.Manager.Comment("executing step \'call AdapterSendDataBlock()\'");
            Project1.TestAdapter.AdapterClass.AdapterSendDataBlock();
            this.Manager.Comment("reaching state \'S79\'");
            this.Manager.Comment("checking step \'return AdapterSendDataBlock\'");
            this.Manager.Comment("reaching state \'S86\'");
            bool temp5;
            this.Manager.Comment("executing step \'call AdapterCanPutExit(64)\'");
            temp5 = Project1.TestAdapter.AdapterClass.AdapterCanPutExit(64);
            this.Manager.Comment("reaching state \'S93\'");
            this.Manager.Comment("checking step \'return AdapterCanPutExit/False\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, temp5, "return of AdapterCanPutExit, state S93");
            this.Manager.Comment("reaching state \'S100\'");
            this.Manager.EndTest();
        }
        #endregion
        
        #region Test Starting in S6
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void SendTestSuiteS6() {
            this.Manager.BeginTest("SendTestSuiteS6");
            this.Manager.Comment("reaching state \'S6\'");
            this.Manager.Comment("executing step \'call InitializeTestAdapter()\'");
            Project1.TestAdapter.AdapterClass.InitializeTestAdapter();
            this.Manager.Comment("reaching state \'S7\'");
            this.Manager.Comment("checking step \'return InitializeTestAdapter\'");
            this.Manager.Comment("reaching state \'S17\'");
            this.Manager.Comment("executing step \'call AdapterSendWriteRequest()\'");
            Project1.TestAdapter.AdapterClass.AdapterSendWriteRequest();
            this.Manager.Comment("reaching state \'S24\'");
            this.Manager.Comment("checking step \'return AdapterSendWriteRequest\'");
            this.Manager.Comment("reaching state \'S31\'");
            this.Manager.Comment("executing step \'call AdapterReceiveACK()\'");
            Project1.TestAdapter.AdapterClass.AdapterReceiveACK();
            this.Manager.Comment("reaching state \'S38\'");
            this.Manager.Comment("checking step \'return AdapterReceiveACK\'");
            this.Manager.Comment("reaching state \'S45\'");
            this.Manager.Comment("executing step \'call AdapterSendDataBlock()\'");
            Project1.TestAdapter.AdapterClass.AdapterSendDataBlock();
            this.Manager.Comment("reaching state \'S52\'");
            this.Manager.Comment("checking step \'return AdapterSendDataBlock\'");
            this.Manager.Comment("reaching state \'S59\'");
            this.Manager.Comment("executing step \'call AdapterReceiveACK()\'");
            Project1.TestAdapter.AdapterClass.AdapterReceiveACK();
            this.Manager.Comment("reaching state \'S66\'");
            this.Manager.Comment("checking step \'return AdapterReceiveACK\'");
            this.Manager.Comment("reaching state \'S73\'");
            this.Manager.Comment("executing step \'call AdapterSendDataBlock()\'");
            Project1.TestAdapter.AdapterClass.AdapterSendDataBlock();
            this.Manager.Comment("reaching state \'S80\'");
            this.Manager.Comment("checking step \'return AdapterSendDataBlock\'");
            this.Manager.Comment("reaching state \'S87\'");
            bool temp6;
            this.Manager.Comment("executing step \'call AdapterCanPutExit(128)\'");
            temp6 = Project1.TestAdapter.AdapterClass.AdapterCanPutExit(128);
            this.Manager.Comment("reaching state \'S94\'");
            this.Manager.Comment("checking step \'return AdapterCanPutExit/False\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, temp6, "return of AdapterCanPutExit, state S94");
            this.Manager.Comment("reaching state \'S101\'");
            this.Manager.EndTest();
        }
        #endregion
        
        #region Test Starting in S8
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        public void SendTestSuiteS8() {
            this.Manager.BeginTest("SendTestSuiteS8");
            this.Manager.Comment("reaching state \'S8\'");
            this.Manager.Comment("executing step \'call InitializeTestAdapter()\'");
            Project1.TestAdapter.AdapterClass.InitializeTestAdapter();
            this.Manager.Comment("reaching state \'S9\'");
            this.Manager.Comment("checking step \'return InitializeTestAdapter\'");
            this.Manager.Comment("reaching state \'S18\'");
            this.Manager.Comment("executing step \'call AdapterSendWriteRequest()\'");
            Project1.TestAdapter.AdapterClass.AdapterSendWriteRequest();
            this.Manager.Comment("reaching state \'S25\'");
            this.Manager.Comment("checking step \'return AdapterSendWriteRequest\'");
            this.Manager.Comment("reaching state \'S32\'");
            this.Manager.Comment("executing step \'call AdapterReceiveACK()\'");
            Project1.TestAdapter.AdapterClass.AdapterReceiveACK();
            this.Manager.Comment("reaching state \'S39\'");
            this.Manager.Comment("checking step \'return AdapterReceiveACK\'");
            this.Manager.Comment("reaching state \'S46\'");
            this.Manager.Comment("executing step \'call AdapterSendDataBlock()\'");
            Project1.TestAdapter.AdapterClass.AdapterSendDataBlock();
            this.Manager.Comment("reaching state \'S53\'");
            this.Manager.Comment("checking step \'return AdapterSendDataBlock\'");
            this.Manager.Comment("reaching state \'S60\'");
            this.Manager.Comment("executing step \'call AdapterReceiveACK()\'");
            Project1.TestAdapter.AdapterClass.AdapterReceiveACK();
            this.Manager.Comment("reaching state \'S67\'");
            this.Manager.Comment("checking step \'return AdapterReceiveACK\'");
            this.Manager.Comment("reaching state \'S74\'");
            this.Manager.Comment("executing step \'call AdapterSendDataBlock()\'");
            Project1.TestAdapter.AdapterClass.AdapterSendDataBlock();
            this.Manager.Comment("reaching state \'S81\'");
            this.Manager.Comment("checking step \'return AdapterSendDataBlock\'");
            this.Manager.Comment("reaching state \'S88\'");
            bool temp7;
            this.Manager.Comment("executing step \'call AdapterCanPutExit(512)\'");
            temp7 = Project1.TestAdapter.AdapterClass.AdapterCanPutExit(512);
            this.Manager.Comment("reaching state \'S95\'");
            this.Manager.Comment("checking step \'return AdapterCanPutExit/False\'");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, temp7, "return of AdapterCanPutExit, state S95");
            this.Manager.Comment("reaching state \'S102\'");
            this.Manager.EndTest();
        }
        #endregion
    }
}

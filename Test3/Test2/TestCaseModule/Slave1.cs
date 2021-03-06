﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Test2.TestCaseModule
{
    /// <summary>
    ///The Slave1 recording.
    /// </summary>
    [TestModule("410edec6-159d-479d-901d-41efa2c60f44", ModuleType.Recording, 1)]
    public partial class Slave1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Test2.Test3Repository repository.
        /// </summary>
        public static Test2.Test3Repository repo = Test2.Test3Repository.Instance;

        static Slave1 instance = new Slave1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Slave1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Slave1 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.0.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.0.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.SystemCouplers' at 14;8.", repo.MainForm.SystemCouplersInfo, new RecordItemIndex(0));
            repo.MainForm.SystemCouplers.Click("14;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.Outline' at 10;37.", repo.MainForm.OutlineInfo, new RecordItemIndex(1));
            repo.MainForm.Outline.Click("10;37");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.R1EC55000x1000001' at 11;7.", repo.MainForm.R1EC55000x1000001Info, new RecordItemIndex(2));
            repo.MainForm.R1EC55000x1000001.Click("11;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'MainForm.R1EC55000x1000001' at 11;7.", repo.MainForm.R1EC55000x1000001Info, new RecordItemIndex(3));
            repo.MainForm.R1EC55000x1000001.DoubleClick("11;7");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
}

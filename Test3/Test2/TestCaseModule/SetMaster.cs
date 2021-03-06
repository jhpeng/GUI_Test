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
    ///The SetMaster recording.
    /// </summary>
    [TestModule("7b602890-5689-4e66-810c-9903af540117", ModuleType.Recording, 1)]
    public partial class SetMaster : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Test2.Test3Repository repository.
        /// </summary>
        public static Test2.Test3Repository repo = Test2.Test3Repository.Instance;

        static SetMaster instance = new SetMaster();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SetMaster()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SetMaster Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.Diagram1' at 240;112.", repo.MainForm.Diagram1Info, new RecordItemIndex(0));
            repo.MainForm.Diagram1.Click("240;112");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.Open' at 6;14.", repo.MainForm.OpenInfo, new RecordItemIndex(1));
            repo.MainForm.Open.Click("6;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EIPBuilderVshost1.ListItem2000' at 66;8.", repo.EIPBuilderVshost1.ListItem2000Info, new RecordItemIndex(2));
            repo.EIPBuilderVshost1.ListItem2000.Click("66;8");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
}

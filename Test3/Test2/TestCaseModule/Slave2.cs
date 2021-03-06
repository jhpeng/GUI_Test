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
    ///The Slave2 recording.
    /// </summary>
    [TestModule("a4ed0ae3-10a6-4db4-9190-234175435b6d", ModuleType.Recording, 1)]
    public partial class Slave2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Test2.Test3Repository repository.
        /// </summary>
        public static Test2.Test3Repository repo = Test2.Test3Repository.Instance;

        static Slave2 instance = new Slave2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Slave2()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Slave2 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.ASDAA2ECoEDrive0x20406081' at 15;7.", repo.MainForm.ASDAA2ECoEDrive0x20406081Info, new RecordItemIndex(0));
            repo.MainForm.ASDAA2ECoEDrive0x20406081.Click("15;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'MainForm.ASDAA2ECoEDrive0x20406081' at 15;7.", repo.MainForm.ASDAA2ECoEDrive0x20406081Info, new RecordItemIndex(1));
            repo.MainForm.ASDAA2ECoEDrive0x20406081.DoubleClick("15;7");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
}

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

namespace FirstProject
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AddEntry recording.
    /// </summary>
    [TestModule("7f96d67a-537a-43af-afec-4ff5c98a6fe2", ModuleType.Recording, 1)]
    public partial class AddEntry : ITestModule
    {
        /// <summary>
        /// Holds an instance of the FirstProjectRepository repository.
        /// </summary>
        public static FirstProjectRepository repo = FirstProjectRepository.Instance;

        static AddEntry instance = new AddEntry();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddEntry()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddEntry Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.AddEntry' at 14;14.", repo.MainForm.AddEntryInfo, new RecordItemIndex(0));
            repo.MainForm.AddEntry.Click("14;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PwEntryForm.MTabEntry.Text' at 26;5.", repo.PwEntryForm.MTabEntry.TextInfo, new RecordItemIndex(1));
            repo.PwEntryForm.MTabEntry.Text.Click("26;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}G{LShiftKey up}mail{Space}{LShiftKey down}P{LShiftKey up}assword{Tab}{Return}' with focus on 'PwEntryForm.MTabEntry.Text'.", repo.PwEntryForm.MTabEntry.TextInfo, new RecordItemIndex(2));
            repo.PwEntryForm.MTabEntry.Text.PressKeys("{LShiftKey down}G{LShiftKey up}mail{Space}{LShiftKey down}P{LShiftKey up}assword{Tab}{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'IconPickerForm.ListItem23' at 22;9.", repo.IconPickerForm.ListItem23Info, new RecordItemIndex(3));
            repo.IconPickerForm.ListItem23.DoubleClick("22;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(4));
            Keyboard.Press("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}A{LShiftKey up}mit.{LShiftKey down}A{LShiftKey up}swani{Tab}{LShiftKey down}A{LShiftKey up}'.", new RecordItemIndex(5));
            Keyboard.Press("{LShiftKey down}A{LShiftKey up}mit.{LShiftKey down}A{LShiftKey up}swani{Tab}{LShiftKey down}A{LShiftKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'mit{Tab}{Tab}{LShiftKey down}A{LShiftKey up}mit{Tab}{Tab}'.", new RecordItemIndex(6));
            Keyboard.Press("mit{Tab}{Tab}{LShiftKey down}A{LShiftKey up}mit{Tab}{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'www.gmail.com{Tab}{LShiftKey down}T{LShiftKey up}his{Space down}i{Space up}s{Space}for{Space}{LShiftKey down}T{LShiftKey up}esting{Space}{LShiftKey down}P{LShiftKey up}urpose.'.", new RecordItemIndex(7));
            Keyboard.Press("www.gmail.com{Tab}{LShiftKey down}T{LShiftKey up}his{Space down}i{Space up}s{Space}for{Space}{LShiftKey down}T{LShiftKey up}esting{Space}{LShiftKey down}P{LShiftKey up}urpose.");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PwEntryForm.MBtnOK' at 43;8.", repo.PwEntryForm.MBtnOKInfo, new RecordItemIndex(8));
            repo.PwEntryForm.MBtnOK.Click("43;8");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

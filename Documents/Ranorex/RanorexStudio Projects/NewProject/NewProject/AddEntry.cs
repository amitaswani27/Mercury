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

namespace NewProject
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The AddEntry recording.
    /// </summary>
    [TestModule("919576ed-7abb-453f-9c44-4ad03119ba4f", ModuleType.Recording, 1)]
    public partial class AddEntry : ITestModule
    {
        /// <summary>
        /// Holds an instance of the NewProjectRepository repository.
        /// </summary>
        public static NewProjectRepository repo = NewProjectRepository.Instance;

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.AddEntry' at 12;7.", repo.MainForm.AddEntryInfo, new RecordItemIndex(0));
            repo.MainForm.AddEntry.Click("12;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}'.", new RecordItemIndex(1));
            Keyboard.Press("{LShiftKey down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'T{LShiftKey up}esting'.", new RecordItemIndex(2));
            Keyboard.Press("T{LShiftKey up}esting");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PwEntryForm.MBtnIcon' at 13;13.", repo.PwEntryForm.MBtnIconInfo, new RecordItemIndex(3));
            repo.PwEntryForm.MBtnIcon.Click("13;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'IconPickerForm.ListItem23' at 18;6.", repo.IconPickerForm.ListItem23Info, new RecordItemIndex(4));
            repo.IconPickerForm.ListItem23.DoubleClick("18;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PwEntryForm.UserName' at 28;9.", repo.PwEntryForm.UserNameInfo, new RecordItemIndex(5));
            repo.PwEntryForm.UserName.Click("28;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}A{LShiftKey up}mit.{LShiftKey down}A{LShiftKey up}swani' with focus on 'PwEntryForm.UserName'.", repo.PwEntryForm.UserNameInfo, new RecordItemIndex(6));
            repo.PwEntryForm.UserName.PressKeys("{LShiftKey down}A{LShiftKey up}mit.{LShiftKey down}A{LShiftKey up}swani");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'PwEntryForm.UserName'.", repo.PwEntryForm.UserNameInfo, new RecordItemIndex(7));
            repo.PwEntryForm.UserName.PressKeys("{Tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'amit{Tab}{Tab}amit{Tab}{Tab}www.'.", new RecordItemIndex(8));
            Keyboard.Press("amit{Tab}{Tab}amit{Tab}{Tab}www.");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'gmail.com{Tab}{LShiftKey down}'.", new RecordItemIndex(9));
            Keyboard.Press("gmail.com{Tab}{LShiftKey down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'T{LShiftKey up}esting'.", new RecordItemIndex(10));
            Keyboard.Press("T{LShiftKey up}esting");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PwEntryForm.MBtnOK' at 38;8.", repo.PwEntryForm.MBtnOKInfo, new RecordItemIndex(11));
            repo.PwEntryForm.MBtnOK.Click("38;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.Save' at 6;8.", repo.MainForm.SaveInfo, new RecordItemIndex(12));
            repo.MainForm.Save.Click("6;8");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace NewProject
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the NewProjectRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
    [RepositoryFolder("8cab6bab-fb47-42c0-a12e-743ab3783d18")]
    public partial class NewProjectRepository : RepoGenBaseFolder
    {
        static NewProjectRepository instance = new NewProjectRepository();

        /// <summary>
        /// Gets the singleton class instance representing the NewProjectRepository element repository.
        /// </summary>
        [RepositoryFolder("8cab6bab-fb47-42c0-a12e-743ab3783d18")]
        public static NewProjectRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public NewProjectRepository() 
            : base("NewProjectRepository", "/", null, 0, false, "8cab6bab-fb47-42c0-a12e-743ab3783d18", ".\\RepositoryImages\\NewProjectRepository8cab6bab.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("8cab6bab-fb47-42c0-a12e-743ab3783d18")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
    public partial class NewProjectRepositoryFolders
    {
    }
#pragma warning restore 0436
}
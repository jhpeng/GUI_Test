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

namespace Test2
{
    /// <summary>
    /// The class representing the Repository1 element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.0.2")]
    [RepositoryFolder("f5371997-a6fa-414b-982c-ce9483774a2c")]
    public partial class Repository1 : RepoGenBaseFolder
    {
        static Repository1 instance = new Repository1();

        /// <summary>
        /// Gets the singleton class instance representing the Repository1 element repository.
        /// </summary>
        [RepositoryFolder("f5371997-a6fa-414b-982c-ce9483774a2c")]
        public static Repository1 Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public Repository1() 
            : base("Repository1", "/", null, 0, false, "f5371997-a6fa-414b-982c-ce9483774a2c", ".\\RepositoryImages\\Repository1f5371997.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("f5371997-a6fa-414b-982c-ce9483774a2c")]
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
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.0.2")]
    public partial class Repository1Folders
    {
    }
}
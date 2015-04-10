//-----------------------------------------------------------------------
// <copyright file="VersionAttributeMain.cs" company = "Telerik Academy">
// Copyright (c) Telerik Academy. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace _04.VersionAttributeMain
    {
    using System;

    /// <summary>
    /// Applies the version attribute to a sample class and displays its version at runtime.
    /// </summary>
    [Version("0.1.4 Beta")]
    public class VersionAttributeMain
        {
        public static void Main()
            {
            object[] attributes = typeof(VersionAttributeMain).GetCustomAttributes(false);
            Console.WriteLine("Version: {0}", attributes[0]);
            }
        }
    }

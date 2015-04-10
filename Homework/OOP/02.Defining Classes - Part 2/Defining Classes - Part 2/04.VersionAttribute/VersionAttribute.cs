//-----------------------------------------------------------------------
// <copyright file="VersionAttribute.cs" company = "Telerik Academy">
// Copyright (c) Telerik Academy. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace _04.VersionAttributeMain
    {
    using System;

    /// <summary>
    /// Attributes usage
    /// </summary>
    [AttributeUsage(AttributeTargets.Struct |
                    AttributeTargets.Class |
                    AttributeTargets.Interface |
                    AttributeTargets.Enum |
                    AttributeTargets.Method)]

    public class VersionAttribute : Attribute
        {
        public VersionAttribute(string version)
            {
            this.Version = version;
            }

        public string Version { get; private set; }

        public override string ToString()
            {
            return this.Version;
            }
        }
    }

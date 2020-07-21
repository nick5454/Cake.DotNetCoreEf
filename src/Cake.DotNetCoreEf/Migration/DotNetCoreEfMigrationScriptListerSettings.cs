﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake.DotNetCoreEf.Migration
{
    /// <summary>
    /// Contains settings used by <see cref="DotNetCoreEfMigrationScriptLister"/>.
    /// </summary>
    public class DotNetCoreEfMigrationScriptListerSettings : DotNetCoreEfSettings
    {
        /// <summary>
        /// The starting migration. If omitted, '0' (the initial database) is used.
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// The ending migration. If omitted, the last migration is used.
        /// </summary>
        public string To { get; set; }

        /// <summary>
        /// Prefix characters in output.
        /// </summary>
        public bool PrefixOutput { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether to not to build the project before publishing.
        /// This makes build faster, but requires build to be done before publish is executed. 
        /// </summary>
        public bool NoBuild { get; set; } = true;
    }
}
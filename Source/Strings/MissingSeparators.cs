﻿/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;

namespace Dolittle.Strings
{
    /// <summary>
    /// Gets thrown when separators are not specified
    /// </summary>
    public class MissingSeparators : ArgumentException
    {
        /// <summary>
        /// Initializes a new instance of <see cref="MissingSeparators"/>
        /// </summary>
        public MissingSeparators() : base("You must specify at least one separator") { }
    }
}

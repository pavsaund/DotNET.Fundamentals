/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;
using System.Runtime.Serialization;

namespace Dolittle.Versioning
{
    /// <summary>
    /// The exception that gets thrown when a version string is invalid
    /// </summary>
    public class InvalidVersionString : ArgumentException
    {
        /// <summary>
        /// Initializes a new instance of <see cref="InvalidVersionString"/>
        /// </summary>
        /// <param name="versionAsString">The string that holds the invalid <see cref="Version"/></param>
        public InvalidVersionString(string versionAsString) : base($"The '{versionAsString}' is not a valid version string") {}
    }
}
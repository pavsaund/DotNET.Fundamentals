﻿/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System.Collections.Generic;
using System.IO;

namespace Dolittle.IO
{
    /// <summary>
    /// Defines functionality for accessing the filesystem
    /// </summary>
    public interface IFileSystem
    {
        /// <summary>
        /// Get the current directory
        /// </summary>
        /// <returns>Path to the current directory</returns>
        string GetCurrentDirectory();

        /// <summary>
        /// Checks wether or not a path exists
        /// </summary>
        /// <param name="path">Path to check</param>
        /// <returns>True if exists, false if not</returns>
        bool Exists(string path);

        /// <summary>
        /// Read all text from a file
        /// </summary>
        /// <param name="filename">Path and filename</param>
        /// <returns>Content of file</returns>
        string ReadAllText(string filename);

        /// <summary>
        /// Get files for a specific path
        /// </summary>
        /// <param name="path">Path to get files from</param>
        /// <param name="searchPattern">Search pattern to use for filtering</param>
        /// <returns><see cref="IEnumerable{FileInfo}">Enumerable of <see cref="FileInfo"/></see></returns>
        IEnumerable<FileInfo> GetFilesFrom(string path, string searchPattern);
    }
}

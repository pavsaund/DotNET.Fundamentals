﻿/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System.Linq;
using Dolittle.Specifications;
using Microsoft.Extensions.DependencyModel;

namespace Dolittle.Assemblies.Rules
{
    /// <summary>
    /// Rule representing an exception for <see cref="IncludeAllRule"/>, 
    /// excluding assembies starting with
    /// </summary>
    public class ExceptAssembliesStartingWith : Specification<Library>
    {
        /// <summary>
        /// Initializes an instance of <see cref="ExceptAssembliesStartingWith"/>
        /// </summary>
        /// <param name="names"></param>
        public ExceptAssembliesStartingWith(params string[] names)
        {
            Predicate = a => !names.Any(n => a.Name.StartsWith(n));
        }
    }
}

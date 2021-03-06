﻿/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;

namespace Dolittle.Security
{
    /// <summary>
    /// Represents a <see cref="Securable"/> that applies to a specific namespace
    /// </summary>
    public class NamespaceSecurable : Securable
    {
        const string NAMESPACE = "InNamespace_{{{0}}}";

        /// <summary>
        /// Initializes a new instance of <see cref="NamespaceSecurable"/>
        /// </summary>
        /// <param name="namespace">Namespace to secure</param>
        public NamespaceSecurable(string @namespace) : base(string.Format(NAMESPACE,@namespace))
        {
            Namespace = @namespace;
        }

        /// <summary>
        /// Gets the namespace that is secured
        /// </summary>
        public string Namespace { get; private set; }

        /// <inheritdoc/>
        public override bool CanAuthorize(object actionToAuthorize)
        {
            return actionToAuthorize != null && actionToAuthorize.GetType().Namespace.StartsWith(Namespace,
                StringComparison.Ordinal);
        }
    }
}

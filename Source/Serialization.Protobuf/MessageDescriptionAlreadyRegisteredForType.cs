/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;

namespace Dolittle.Serialization.Protobuf
{
    /// <summary>
    /// The exception that gets thrown when a <see cref="Type"/> already has a <see cref="MessageDescription"/> associated with it
    /// </summary>
    public class MessageDescriptionAlreadyRegisteredForType : Exception
    {
        /// <summary>
        /// Initializes a new instance of <see cref="MessageDescriptionAlreadyRegisteredForType"/>
        /// </summary>
        /// <param name="type"><see cref="Type"/> trying to register twice for</param>
        public MessageDescriptionAlreadyRegisteredForType(Type type) : base($"Type '{type.AssemblyQualifiedName}' already has a MessageDescription registered")
        {

        }
    }
}
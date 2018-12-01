/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using Dolittle.Booting.Stages;
using Dolittle.Execution;
using Dolittle.IO;
using Dolittle.Scheduling;
using Dolittle.Time;

namespace Dolittle.Booting
{
    /// <summary>
    /// Extensions for building <see cref="InitialSystemSettings"/> 
    /// </summary>
    public static class InitialSystemBootBuilderExtensions
    {
        /// <summary>
        /// Set scheduling to be synchronous 
        /// </summary>
        /// <param name="bootBuilder"><see cref="BootBuilder"/> to build</param>
        /// <returns>Chained <see cref="BootBuilder"/></returns>
        /// <remarks>
        /// Asynchronous scheduling is default
        /// </remarks>
        public static IBootBuilder SynchronousScheduling(this IBootBuilder bootBuilder)
        {
            bootBuilder.Set<InitialSystemSettings>(_ => _.Scheduler, new SyncScheduler());
            return bootBuilder;
        }

        /// <summary>
        /// Use a specific <see cref="IFileSystem"/>
        /// </summary>
        /// <param name="bootBuilder"><see cref="BootBuilder"/> to build</param>
        /// <typeparam name="T">Type of <see cref="IFileSystem"/> to use</typeparam>
        /// <returns>Chained <see cref="BootBuilder"/></returns>
        public static IBootBuilder UseFileSystem<T>(this IBootBuilder bootBuilder) where T:IFileSystem
        {
            bootBuilder.Set<InitialSystemSettings>(_ => _.FileSystem, typeof(T));
            return bootBuilder;
        }

        /// <summary>
        /// Use a specific <see cref="ISystemClock"/>
        /// </summary>
        /// <param name="bootBuilder"><see cref="BootBuilder"/> to build</param>
        /// <typeparam name="T">Type of <see cref="ISystemClock"/> to use</typeparam>
        /// <returns>Chained <see cref="BootBuilder"/></returns>
        public static IBootBuilder UseSystemClock<T>(this IBootBuilder bootBuilder) where T:ISystemClock
        {
            bootBuilder.Set<InitialSystemSettings>(_ => _.SystemClock, typeof(T));
            return bootBuilder;
        }
    }
}

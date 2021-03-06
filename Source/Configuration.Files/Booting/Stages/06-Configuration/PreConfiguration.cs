/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;
using Dolittle.Booting;
using Dolittle.DependencyInversion;
using Dolittle.DependencyInversion.Booting;
using Dolittle.Types;

namespace Dolittle.Configuration.Files.Booting.Stages
{
    /// <summary>
    /// Represents bindings for booting
    /// </summary>
    public class PreConfiguration : ICanRunBeforeBootStage<NoSettings>
    {
        /// <inheritdoc/>
        public BootStage BootStage => BootStage.Configuration;

        /// <inheritdoc/>
        public void Perform(NoSettings settings, IBootStageBuilder builder)
        {
            var typeFinder = builder.GetAssociation(WellKnownAssociations.TypeFinder) as ITypeFinder;
            var parsers = new ConfigurationFileParsers(typeFinder, builder.Container);
            builder.Bindings.Bind<IConfigurationFileParsers>().To(parsers);
        }
    }
}

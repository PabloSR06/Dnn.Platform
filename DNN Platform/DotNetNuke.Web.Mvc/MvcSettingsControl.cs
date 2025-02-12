﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace DotNetNuke.Web.Mvc
{
    using DotNetNuke.Entities.Modules;
    using DotNetNuke.UI.Modules;

    public class MvcSettingsControl : MvcHostControl, ISettingsControl
    {
        public MvcSettingsControl()
            : base("Settings")
        {
            this.ExecuteModuleImmediately = false;
        }

        /// <inheritdoc/>
        public void LoadSettings()
        {
            this.ExecuteModule();
        }

        /// <inheritdoc/>
        public void UpdateSettings()
        {
            this.ExecuteModule();

            ModuleController.Instance.UpdateModule(this.ModuleContext.Configuration);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Services.Localization;

namespace DAFF.Modules.Dnn.DAFF.ReceptValaszto.Components
{
    public class AddToCartModuleBase : PortalModuleBase
    {
        #region Localization
        protected string GetLocalizedString(string Key)
        {
            return GetLocalizedString(Key, this.LocalResourceFile);
        }

        protected string GetLocalizedString(string Key, string LocalizationFilePath)
        {
            return Localization.GetString(Key, LocalizationFilePath);
        }

        #endregion
    }
}
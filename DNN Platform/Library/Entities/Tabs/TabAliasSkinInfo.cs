﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

#region Usings

using System;
using System.Data;

using DotNetNuke.Common.Utilities;
using DotNetNuke.Entities.Modules;

#endregion

namespace DotNetNuke.Entities.Tabs
{
    /// <summary>
    /// Class to represent a TabAliasSkinInfo object
    /// </summary>
    [Serializable]
    public class TabAliasSkinInfo : BaseEntityInfo, IHydratable
    {
        #region Public Properties

        public int TabAliasSkinId { get; set; }
        public string HttpAlias { get; set; }
        public int PortalAliasId { get; set; }
        public string SkinSrc { get; set; }
        public int TabId { get; set; }

        #endregion

        public int KeyID 
        { 
            get { return this.TabAliasSkinId; } 
            set { this.TabAliasSkinId = value; }
        }

        public void Fill(IDataReader dr)
        {
            base.FillInternal(dr);

            this.TabAliasSkinId = Null.SetNullInteger(dr["TabAliasSkinId"]);
            this.HttpAlias = Null.SetNullString(dr["HttpAlias"]);
            this.PortalAliasId = Null.SetNullInteger(dr["PortalAliasId"]);
            this.SkinSrc = Null.SetNullString(dr["SkinSrc"]);
            this.TabId = Null.SetNullInteger(dr["TabId"]);
        }
    }
}

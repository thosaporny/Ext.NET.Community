/********
 * This file is part of Ext.NET.
 *     
 * Ext.NET is free software: you can redistribute it and/or modify
 * it under the terms of the GNU AFFERO GENERAL PUBLIC LICENSE as 
 * published by the Free Software Foundation, either version 3 of the 
 * License, or (at your option) any later version.
 * 
 * Ext.NET is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU AFFERO GENERAL PUBLIC LICENSE for more details.
 * 
 * You should have received a copy of the GNU AFFERO GENERAL PUBLIC LICENSE
 * along with Ext.NET.  If not, see <http://www.gnu.org/licenses/>.
 *
 *
 * @version   : 2.0.0.rc1 - Community Edition (AGPLv3 License)
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-06-19
 * @copyright : Copyright (c) 2007-2012, Ext.NET, Inc. (http://www.ext.net/). All rights reserved.
 * @license   : GNU AFFERO GENERAL PUBLIC LICENSE (AGPL) 3.0. 
 *              See license.txt and http://www.ext.net/license/.
 *              See AGPL License at http://www.gnu.org/licenses/agpl-3.0.txt
 ********/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ext.Net
{
	/// <summary>
	/// 
	/// </summary>
    public abstract partial class ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : Observable.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private string[] models = null;

			/// <summary>
			/// Array of models to require from AppName.model namespace.
			/// </summary>
			[DefaultValue(null)]
			public virtual string[] Models 
			{ 
				get
				{
					return this.models;
				}
				set
				{
					this.models = value;
				}
			}

			private string[] stores = null;

			/// <summary>
			/// Array of stores to require from AppName.store namespacee.
			/// </summary>
			[DefaultValue(null)]
			public virtual string[] Stores 
			{ 
				get
				{
					return this.stores;
				}
				set
				{
					this.stores = value;
				}
			}

			private string[] views = null;

			/// <summary>
			/// Array of stores to require from AppName.store namespacee.
			/// </summary>
			[DefaultValue(null)]
			public virtual string[] Views 
			{ 
				get
				{
					return this.views;
				}
				set
				{
					this.views = value;
				}
			}

			private string name = null;

			/// <summary>
			/// The controller name. Required
			/// </summary>
			[DefaultValue(null)]
			public virtual string Name 
			{ 
				get
				{
					return this.name;
				}
				set
				{
					this.name = value;
				}
			}

        }
    }
}
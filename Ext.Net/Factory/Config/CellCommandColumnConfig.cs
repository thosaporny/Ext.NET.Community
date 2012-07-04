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
    public abstract partial class CellCommandColumn
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Config : ColumnBase.Config 
        { 
			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			
			private bool rightCommandAlign = true;

			/// <summary>
			/// 
			/// </summary>
			[DefaultValue(true)]
			public virtual bool RightCommandAlign 
			{ 
				get
				{
					return this.rightCommandAlign;
				}
				set
				{
					this.rightCommandAlign = value;
				}
			}
        
			private ImageCommandCollection commands = null;

			/// <summary>
			/// 
			/// </summary>
			public ImageCommandCollection Commands
			{
				get
				{
					if (this.commands == null)
					{
						this.commands = new ImageCommandCollection();
					}
			
					return this.commands;
				}
			}
			        
			private JFunction prepareCommand = null;

			/// <summary>
			/// 
			/// </summary>
			public JFunction PrepareCommand
			{
				get
				{
					if (this.prepareCommand == null)
					{
						this.prepareCommand = new JFunction();
					}
			
					return this.prepareCommand;
				}
			}
			        
			private JFunction prepareCommands = null;

			/// <summary>
			/// 
			/// </summary>
			public JFunction PrepareCommands
			{
				get
				{
					if (this.prepareCommands == null)
					{
						this.prepareCommands = new JFunction();
					}
			
					return this.prepareCommands;
				}
			}
			
        }
    }
}
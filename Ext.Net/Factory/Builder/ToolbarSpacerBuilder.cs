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
 * @version   : 2.1.1 - Ext.NET Community License (AGPLv3 License)
 * @author    : Ext.NET, Inc. http://www.ext.net/
 * @date      : 2012-12-10
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
    public partial class ToolbarSpacer
    {
        /// <summary>
        /// 
        /// </summary>
        new public abstract partial class Builder<TToolbarSpacer, TBuilder> : ToolbarItem.Builder<TToolbarSpacer, TBuilder>
            where TToolbarSpacer : ToolbarSpacer
            where TBuilder : Builder<TToolbarSpacer, TBuilder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder(TToolbarSpacer component) : base(component) { }


			/*  ConfigOptions
				-----------------------------------------------------------------------------------------------*/
			

			/*  Methods
				-----------------------------------------------------------------------------------------------*/
			
        }
		
		/// <summary>
        /// 
        /// </summary>
        public partial class Builder : ToolbarSpacer.Builder<ToolbarSpacer, ToolbarSpacer.Builder>
        {
            /*  Ctor
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public Builder() : base(new ToolbarSpacer()) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ToolbarSpacer component) : base(component) { }

			/// <summary>
			/// 
			/// </summary>
            public Builder(ToolbarSpacer.Config config) : base(new ToolbarSpacer(config)) { }


            /*  Implicit Conversion
                -----------------------------------------------------------------------------------------------*/

			/// <summary>
			/// 
			/// </summary>
            public static implicit operator Builder(ToolbarSpacer component)
            {
                return component.ToBuilder();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolbarSpacer.Builder ToBuilder()
		{
			return Ext.Net.X.Builder.ToolbarSpacer(this);
		}
		
		/// <summary>
        /// 
        /// </summary>
        public override IControlBuilder ToNativeBuilder()
		{
			return (IControlBuilder)this.ToBuilder();
		}
    }
    
    
    /*  Builder
        -----------------------------------------------------------------------------------------------*/
    
    public partial class BuilderFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public ToolbarSpacer.Builder ToolbarSpacer()
        {
#if MVC
			return this.ToolbarSpacer(new ToolbarSpacer { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return this.ToolbarSpacer(new ToolbarSpacer());
#endif			
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolbarSpacer.Builder ToolbarSpacer(ToolbarSpacer component)
        {
#if MVC
			component.ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null;
#endif			
			return new ToolbarSpacer.Builder(component);
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolbarSpacer.Builder ToolbarSpacer(ToolbarSpacer.Config config)
        {
#if MVC
			return new ToolbarSpacer.Builder(new ToolbarSpacer(config) { ViewContext = this.HtmlHelper != null ? this.HtmlHelper.ViewContext : null });
#else
			return new ToolbarSpacer.Builder(new ToolbarSpacer(config));
#endif			
        }
    }
}
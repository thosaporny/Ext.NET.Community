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
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace Ext.Net
{
    /// <summary>
    /// 
    /// </summary>
    public abstract partial class NumberFieldBase
    {
        /// <summary>
        /// 
        /// </summary>
		[Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[XmlIgnore]
        [JsonIgnore]
        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;
                
                list.Add("inputType", new ConfigOption("inputType", new SerializationOptions(JsonMode.ToLower), InputType.Text, this.InputType ));
                list.Add("allowDecimals", new ConfigOption("allowDecimals", null, true, this.AllowDecimals ));
                list.Add("autoStripChars", new ConfigOption("autoStripChars", null, false, this.AutoStripChars ));
                list.Add("baseChars", new ConfigOption("baseChars", null, "0123456789", this.BaseChars ));
                list.Add("decimalPrecision", new ConfigOption("decimalPrecision", null, 2, this.DecimalPrecision ));
                list.Add("decimalSeparatorProxy", new ConfigOption("decimalSeparatorProxy", new SerializationOptions("decimalSeparator"), "", this.DecimalSeparatorProxy ));
                list.Add("maxText", new ConfigOption("maxText", null, "The maximum value for this field is {0}", this.MaxText ));
                list.Add("maxValue", new ConfigOption("maxValue", null, Double.MaxValue, this.MaxValue ));
                list.Add("minText", new ConfigOption("minText", null, "The minimum value for this field is {0}", this.MinText ));
                list.Add("minValue", new ConfigOption("minValue", null, Double.MinValue, this.MinValue ));
                list.Add("nanText", new ConfigOption("nanText", null, "{0} is not a valid number", this.NanText ));
                list.Add("negativeText", new ConfigOption("negativeText", null, "", this.NegativeText ));
                list.Add("step", new ConfigOption("step", null, 1.0, this.Step ));
                list.Add("trimTrailedZeros", new ConfigOption("trimTrailedZeros", null, true, this.TrimTrailedZeros ));
                list.Add("submitLocaleSeparator", new ConfigOption("submitLocaleSeparator", null, true, this.SubmitLocaleSeparator ));

                return list;
            }
        }
    }
}
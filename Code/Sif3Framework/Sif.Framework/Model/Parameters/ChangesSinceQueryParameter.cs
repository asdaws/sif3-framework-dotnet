﻿/*
 * Copyright 2018 Systemic Pty Ltd
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using Sif.Framework.Extensions;

namespace Sif.Framework.Model.Parameters
{
    /// <summary>
    /// Message parameter associated with a Changes Since request.
    /// </summary>
    public class ChangesSinceQueryParameter : MessageParameter
    {
        /// <summary>
        /// Create an instance of a Changes Since message parameter.
        /// </summary>
        /// <param name="value">Value associated with the message parameter.</param>
        /// <exception cref="System.ArgumentNullException">The value parameter is null or empty.</exception>
        public ChangesSinceQueryParameter(string value)
            : base(RequestParameterType.changesSinceMarker.ToDescription(), ConveyanceType.QueryParameter, value)
        {
        }
    }
}
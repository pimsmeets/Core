﻿#region License Header

/*
* QUANTCONNECT.COM - Democratizing Finance, Empowering Individuals.
* Lean Algorithmic Trading Engine v2.0. Copyright 2014 QuantConnect Corporation.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
* Modifications Copyright 2018 Quantler B.V.
*
*/

#endregion License Header

using System;
using System.Collections.Generic;

namespace Quantler.Data.Feed
{
    /// <summary>
    /// Transport type for algorithm update data. This is intended to provide a
    /// list of base data used to perform updates against the specified target
    /// </summary>
    /// <typeparam name="T">The target type</typeparam>
    public class UpdateData<T>
    {
        #region Public Fields

        /// <summary>
        /// The data used to update the target
        /// </summary>
        public readonly IReadOnlyList<DataPoint> Data;

        /// <summary>
        /// The type of data in the data list
        /// </summary>
        public readonly Type DataType;

        /// <summary>
        /// The target, such as a security or subscription data config
        /// </summary>
        public readonly T Target;

        #endregion Public Fields

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateData{T}"/> class
        /// </summary>
        /// <param name="target">The end consumer/user of the dat</param>
        /// <param name="dataType">The type of data in the list</param>
        /// <param name="data">The update data</param>
        public UpdateData(T target, Type dataType, IReadOnlyList<DataPoint> data)
        {
            Target = target;
            Data = data;
            DataType = dataType;
        }

        #endregion Public Constructors
    }
}
// <copyright file="EnumerableExtensions.cs" company="Heleonix - Hennadii Lutsyshyn">
// Copyright (c) 2017-present Heleonix - Hennadii Lutsyshyn. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the repository root for full license information.
// </copyright>

namespace Heleonix.Extensions
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Provides functionality to work with enumerables.
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <typeparam name="T">A type of items.</typeparam>
        /// <param name="instance">The instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsEmpty<T>(this IEnumerable<T> instance) => instance != null && !instance.Any();

        /// <summary>
        /// Determines whether this instance is <c>null</c> or empty.
        /// </summary>
        /// <typeparam name="T">A type of items.</typeparam>
        /// <param name="instance">The instance.</param>
        /// <returns>
        ///   <c>true</c> if this instance is <c>null</c> or empty, otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> instance) => instance == null || !instance.Any();
    }
}
// <copyright file="ComparableExtensions.cs" company="Heleonix - Hennadii Lutsyshyn">
// Copyright (c) Heleonix - Hennadii Lutsyshyn. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the repository root for full license information.
// </copyright>

namespace Heleonix.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Provides functionality to work with comparables.
    /// </summary>
    public static class ComparableExtensions
    {
        /// <summary>
        /// Determines whether this instance is less than the provided value.
        /// </summary>
        /// <typeparam name="T">A type of a comparable instance.</typeparam>
        /// <param name="instance">The instance.</param>
        /// <param name="value">The value to compare with.</param>
        /// <returns>
        ///   <c>true</c> if this instance is less than the provided value, otherwise <c>false</c>.
        /// </returns>
        public static bool IsLessThan<T>(this IComparable<T> instance, T value)
            => instance != null && instance.CompareTo(value) < 0;

        /// <summary>
        /// Determines whether this instance is less than or equals to the provided value.
        /// </summary>
        /// <typeparam name="T">A type of a comparable instance.</typeparam>
        /// <param name="instance">The instance.</param>
        /// <param name="value">The value to compare with.</param>
        /// <returns>
        ///   <c>true</c> if this instance is less than or equals to the provided value, otherwise <c>false</c>.
        /// </returns>
        public static bool IsLessThanOrEqualTo<T>(this IComparable<T> instance, T value)
            => instance != null && instance.CompareTo(value) <= 0;

        /// <summary>
        /// Determines whether this instance is greater than the provided value.
        /// </summary>
        /// <typeparam name="T">A type of a comparable instance.</typeparam>
        /// <param name="instance">The instance.</param>
        /// <param name="value">The value to compare with.</param>
        /// <returns>
        ///   <c>true</c> if this instance is greater than the provided value, otherwise <c>false</c>.
        /// </returns>
        public static bool IsGreaterThan<T>(this IComparable<T> instance, T value)
            => instance != null && instance.CompareTo(value) > 0;

        /// <summary>
        /// Determines whether this instance is greater than or equals to the provided value.
        /// </summary>
        /// <typeparam name="T">A type of a comparable instance.</typeparam>
        /// <param name="instance">The instance.</param>
        /// <param name="value">The value to compare with.</param>
        /// <returns>
        ///   <c>true</c> if this instance is greater than or equals to the provided value, otherwise <c>false</c>.
        /// </returns>
        public static bool IsGreaterThanOrEqualTo<T>(this IComparable<T> instance, T value)
            => instance != null && instance.CompareTo(value) >= 0;

        /// <summary>
        /// Determines whether this instance is in range (inclusive) of the provided values.
        /// </summary>
        /// <typeparam name="T">A type of a comparable instance.</typeparam>
        /// <param name="instance">The instance.</param>
        /// <param name="min">The minimal value to compare with.</param>
        /// <param name="max">The maximum value to compare with.</param>
        /// <returns>
        ///   <c>true</c> if this instance is in range of the provided values, otherwise <c>false</c>.
        /// </returns>
        public static bool IsInRange<T>(this IComparable<T> instance, T min, T max)
            => instance != null && instance.CompareTo(min) >= 0 && instance.CompareTo(max) <= 0;

        /// <summary>
        /// Determines whether this instance is between (exclusive) the provided values.
        /// </summary>
        /// <typeparam name="T">A type of a comparable instance.</typeparam>
        /// <param name="instance">The instance.</param>
        /// <param name="min">The minimal value to compare with.</param>
        /// <param name="max">The maximum value to compare with.</param>
        /// <returns>
        ///   <c>true</c> if this instance is between the provided values, otherwise <c>false</c>.
        /// </returns>
        public static bool IsBetween<T>(this IComparable<T> instance, T min, T max)
            => instance != null && instance.CompareTo(min) > 0 && instance.CompareTo(max) < 0;
    }
}
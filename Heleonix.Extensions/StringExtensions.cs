// <copyright file="StringExtensions.cs" company="Heleonix - Hennadii Lutsyshyn">
// Copyright (c) 2017-present Heleonix - Hennadii Lutsyshyn. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the repository root for full license information.
// </copyright>

namespace Heleonix.Extensions
{
    using System;
    using System.Globalization;

    /// <summary>
    /// Provides functionality to work with strings.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Formats the specified format string with the specified arguments.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The arguments.</param>
        /// <exception cref="FormatException">
        /// <paramref name="format" /> is invalid or the index of a format item
        /// is less than zero, or greater than or equal to the length of the
        /// <paramref name="args" /> array.
        /// </exception>
        /// <returns>Formatted string or empty string if <paramref name="format"/> is not specified.</returns>
        /// <example>
        /// var str = "{0} plus {1} equals {2}".FormatWith(1, 2, 3);
        ///
        /// // "1 plus 2 equals 3".
        /// </example>
        public static string FormatWith(this string format, params object[] args)
            => string.IsNullOrEmpty(format) ? string.Empty : string.Format(CultureInfo.CurrentCulture, format, args);

        /// <summary>
        /// Formats the specified format string with the specified arguments using a specified format provider.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="formatProvider">The format provider.</param>
        /// <param name="args">The arguments.</param>
        /// <exception cref="ArgumentNullException">The <paramref name="formatProvider"/> is <c>null</c>.</exception>
        /// <exception cref="FormatException">
        /// <paramref name="format" /> is invalid the index of a format item
        /// is less than zero, or greater than or equal to the length of the
        /// <paramref name="args" /> array.
        /// </exception>
        /// <returns>Formatted string or empty string if <paramref name="format"/> is not specified.</returns>
        public static string FormatWith(this string format, IFormatProvider formatProvider, params object[] args)
            => string.IsNullOrEmpty(format) ? string.Empty : string.Format(formatProvider, format, args);

        /// <summary>
        /// Determines whether this instance is <c>null</c> or empty or whitespace.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <returns>
        ///   <c>true</c> if this instance is <c>null</c> or empty or whitespace, otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNullOrEmptyOrWhiteSpace(this string instance)
            => string.IsNullOrEmpty(instance) || string.IsNullOrWhiteSpace(instance);
    }
}
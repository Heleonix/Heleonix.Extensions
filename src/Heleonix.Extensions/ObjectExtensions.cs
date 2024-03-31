// <copyright file="ObjectExtensions.cs" company="Heleonix - Hennadii Lutsyshyn">
// Copyright (c) Heleonix - Hennadii Lutsyshyn. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the repository root for full license information.
// </copyright>

namespace Heleonix.Extensions
{
    using System;
    using System.Reflection;

    /// <summary>
    /// Provides functionality to work with objects.
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// Determines whether this instance is <c>null</c>.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified object is <c>null</c>; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNull(this object instance) => instance == null;

        /// <summary>
        /// Determines whether this instance equals zero.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified object equals zero, otherwise <c>false</c>.
        /// </returns>
        public static bool IsZero(this object instance) => 0.Equals(instance);

        /// <summary>
        /// Determines whether this instance equals one.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified object equals one, otherwise <c>false</c>.
        /// </returns>
        public static bool IsOne(this object instance) => 1.Equals(instance);

        /// <summary>
        /// Determines whether this instance is negative.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified instance is negative, otherwise <c>false</c>.
        /// </returns>
        public static bool IsNegative(this object instance) =>
            instance != null && ((IComparable)0).CompareTo(instance) > 0;

        /// <summary>
        /// Determines whether this instance is positive.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified instance is positive, otherwise <c>false</c>.
        /// </returns>
        public static bool IsPositive(this object instance) =>
            instance != null && ((IComparable)0).CompareTo(instance) < 0;

        /// <summary>
        /// Determines whether this instance is equal to the <paramref name="other"/>.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="other">The other instance.</param>
        /// <returns>
        ///   <c>true</c> this instance is equal to the <paramref name="other"/>, otherwise <c>false</c>.
        /// </returns>
        public static bool IsEqualTo(this object instance, object other) => instance?.Equals(other) ?? other == null;

        /// <summary>
        /// Determines whether this instance is subclass of or exactly the specified type.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="type">The type.</param>
        /// <returns>
        ///   <c>true</c> if the specified instance is subclass of or exactly the specified type, otherwise <c>false</c>.
        /// </returns>
        public static bool IsAs(this object instance, Type type)
            => instance != null
                && type != null
                && (instance.GetType() == type || instance.GetType().GetTypeInfo().IsSubclassOf(type));

        /// <summary>
        /// Determines whether a type of this instance exactly equals the specified type.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="type">The type.</param>
        /// <returns>
        ///   <c>true</c> if a type of this instance exactly equals the specified type, otherwise <c>false</c>.
        /// </returns>
        public static bool IsTypeOf(this object instance, Type type) => instance != null && instance.GetType() == type;
    }
}
// <copyright file="EnumerableExtensionsTests.cs" company="Heleonix - Hennadii Lutsyshyn">
// Copyright (c) 2017-present Heleonix - Hennadii Lutsyshyn. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the repository root for full license information.
// </copyright>

namespace Heleonix.Extensions.Tests
{
    using System.Collections.Generic;
    using Heleonix.Extensions;
    using Heleonix.Testing.NUnit.Aaa;
    using NUnit.Framework;
    using static Heleonix.Testing.NUnit.Aaa.AaaSpec;

    /// <summary>
    /// Tests the <see cref="EnumerableExtensions"/>.
    /// </summary>
    [ComponentTest(Type = typeof(EnumerableExtensions))]
    public static class EnumerableExtensionsTests
    {
        /// <summary>
        /// Tests the <see cref="EnumerableExtensions.IsEmpty{T}(IEnumerable{T})"/>.
        /// </summary>
        [MemberTest(Name = nameof(EnumerableExtensions.IsEmpty))]
        public static void IsEmpty()
        {
            string instance = null;
            var result = false;

            When("an extension is called", () =>
            {
                Act(() =>
                {
                    result = instance.IsEmpty();
                });

                And("an instance is null", () =>
                {
                    instance = null;

                    Should("return false", () =>
                    {
                        Assert.That(result, Is.False);
                    });
                });

                And("an instance is not empty", () =>
                {
                    instance = "111";

                    Should("return false", () =>
                    {
                        Assert.That(result, Is.False);
                    });
                });

                And("an instance is empty", () =>
                {
                    instance = string.Empty;

                    Should("return true", () =>
                    {
                        Assert.That(result, Is.True);
                    });
                });
            });
        }

        /// <summary>
        /// Tests the <see cref="EnumerableExtensions.IsNullOrEmpty{T}(IEnumerable{T})"/>.
        /// </summary>
        [MemberTest(Name = nameof(EnumerableExtensions.IsNullOrEmpty))]
        public static void IsNullOrEmpty()
        {
            string instance = null;
            var result = false;

            When("an extension is called", () =>
            {
                Act(() =>
                {
                    result = instance.IsNullOrEmpty();
                });

                And("an instance is null", () =>
                {
                    instance = null;

                    Should("return true", () =>
                    {
                        Assert.That(result, Is.True);
                    });
                });

                And("an instance is not empty", () =>
                {
                    instance = "111";

                    Should("return false", () =>
                    {
                        Assert.That(result, Is.False);
                    });
                });

                And("an instance is empty", () =>
                {
                    instance = string.Empty;

                    Should("return true", () =>
                    {
                        Assert.That(result, Is.True);
                    });
                });
            });
        }
    }
}

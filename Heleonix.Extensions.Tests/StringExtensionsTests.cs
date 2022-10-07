// <copyright file="StringExtensionsTests.cs" company="Heleonix - Hennadii Lutsyshyn">
// Copyright (c) Heleonix - Hennadii Lutsyshyn. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the repository root for full license information.
// </copyright>

namespace Heleonix.Extensions.Tests
{
    using System;
    using System.Globalization;
    using Heleonix.Extensions;
    using Heleonix.Testing.NUnit.Aaa;
    using NUnit.Framework;
    using static Heleonix.Testing.NUnit.Aaa.AaaSpec;

    /// <summary>
    /// Tests the <see cref="StringExtensions"/>.
    /// </summary>
    [ComponentTest(Type = typeof(StringExtensions))]
    public static class StringExtensionsTests
    {
        /// <summary>
        /// Tests the <see cref="StringExtensions.FormatWith(string,object[])"/>.
        /// </summary>
        [MemberTest(Name = nameof(StringExtensions.FormatWith) + "(string, object[])")]
        public static void FormatWith1()
        {
            string input = null;
            object[] arguments = null;
            string result = null;

            When("an extension is called", () =>
            {
                Act(() =>
                {
                    result = input.FormatWith(arguments);
                });

                And("a format string is null", () =>
                {
                    input = null;

                    Should("return an empty string", () =>
                    {
                        Assert.That(result, Is.Empty);
                    });
                });

                And("a format string is empty", () =>
                {
                    input = string.Empty;

                    Should("return an empty string", () =>
                    {
                        Assert.That(result, Is.Empty);
                    });
                });

                And("a format string has two parameters", () =>
                {
                    input = "{0},{1}";
                    arguments = new[] { "1", "2" };

                    Should("return a formatted value", () =>
                    {
                        Assert.That(result, Is.EqualTo("1,2"));
                    });
                });
            });
        }

        /// <summary>
        /// Tests the <see cref="StringExtensions.FormatWith(string,IFormatProvider,object[])"/>.
        /// </summary>
        [MemberTest(Name = nameof(StringExtensions.FormatWith) + "(string, IFormatProvider, object[])")]
        public static void FormatWith2()
        {
            string input = null;
            object[] arguments = null;
            string result = null;

            When("an extension is called", () =>
            {
                Act(() =>
                {
                    result = input.FormatWith(CultureInfo.GetCultureInfo("en-US"), arguments);
                });

                And("a format string is null", () =>
                {
                    input = null;

                    Should("return an empty string", () =>
                    {
                        Assert.That(result, Is.Empty);
                    });
                });

                And("a format string is empty", () =>
                {
                    input = string.Empty;

                    Should("return an empty string", () =>
                    {
                        Assert.That(result, Is.Empty);
                    });
                });

                And("a format string has two formatted parameters", () =>
                {
                    input = "{0:C};{1:C}";
                    arguments = new[] { (object)1.3, 1.5 };

                    Should("return a value formatted with provided formatters", () =>
                    {
                        Assert.That(result, Is.EqualTo("$1.30;$1.50"));
                    });
                });
            });
        }

        /// <summary>
        /// Tests the <see cref="StringExtensions.IsNullOrEmptyOrWhiteSpace(string)"/>.
        /// </summary>
        [MemberTest(Name = nameof(StringExtensions.IsNullOrEmptyOrWhiteSpace))]
        public static void IsNullOrEmptyOrWhiteSpace()
        {
            string instance = null;
            var result = false;

            When("an extension is called", () =>
            {
                Act(() =>
                {
                    result = instance.IsNullOrEmptyOrWhiteSpace();
                });

                And("an instance is null", () =>
                {
                    instance = null;

                    Should("return true", () =>
                    {
                        Assert.That(result, Is.True);
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

                And("an instance is whitespace", () =>
                {
                    instance = " ";

                    Should("return true", () =>
                    {
                        Assert.That(result, Is.True);
                    });
                });

                And("an instance has characters", () =>
                {
                    instance = "characters";

                    Should("return false", () =>
                    {
                        Assert.That(result, Is.False);
                    });
                });
            });
        }
    }
}
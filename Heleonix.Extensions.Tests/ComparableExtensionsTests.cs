// <copyright file="ComparableExtensionsTests.cs" company="Heleonix - Hennadii Lutsyshyn">
// Copyright (c) Heleonix - Hennadii Lutsyshyn. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the repository root for full license information.
// </copyright>

namespace Heleonix.Extensions.Tests
{
    using System;
    using Heleonix.Extensions;
    using Heleonix.Testing.NUnit.Aaa;
    using NUnit.Framework;
    using static Heleonix.Testing.NUnit.Aaa.AaaSpec;

    /// <summary>
    /// Tests the <see cref="ComparableExtensions"/>.
    /// </summary>
    [ComponentTest(Type = typeof(ComparableExtensions))]
    public static class ComparableExtensionsTests
    {
        /// <summary>
        /// Tests the <see cref="ComparableExtensions.IsLessThan{T}(IComparable{T}, T)"/>.
        /// </summary>
        [MemberTest(Name = nameof(ComparableExtensions.IsLessThan))]
        public static void IsLessThan()
        {
            IComparable<string> instance = null;
            string value = null;
            var result = false;

            When("an extension is called", () =>
            {
                Act(() =>
                {
                    result = instance.IsLessThan(value);
                });

                And("an instance is null", () =>
                {
                    instance = null;

                    Should("return false", () =>
                    {
                        Assert.That(result, Is.False);
                    });
                });

                And("an instance is not null", () =>
                {
                    value = "121";

                    And("the instance is less than the value", () =>
                    {
                        instance = "111";

                        Should("return true", () =>
                        {
                            Assert.That(result, Is.True);
                        });
                    });

                    And("the instance is greater than the value", () =>
                    {
                        instance = "131";

                        Should("return false", () =>
                        {
                            Assert.That(result, Is.False);
                        });
                    });

                    And("the instance is equal to the value", () =>
                    {
                        instance = "121";

                        Should("return false", () =>
                        {
                            Assert.That(result, Is.False);
                        });
                    });
                });
            });
        }

        /// <summary>
        /// Tests the <see cref="ComparableExtensions.IsLessThanOrEqualTo{T}(IComparable{T}, T)"/>.
        /// </summary>
        [MemberTest(Name = nameof(ComparableExtensions.IsLessThanOrEqualTo))]
        public static void IsLessThanOrEqualTo()
        {
            IComparable<string> instance = null;
            string value = null;
            var result = false;

            When("an extension is called", () =>
            {
                Act(() =>
                {
                    result = instance.IsLessThanOrEqualTo(value);
                });

                And("an instance is null", () =>
                {
                    instance = null;

                    Should("return false", () =>
                    {
                        Assert.That(result, Is.False);
                    });
                });

                And("an instance is not null", () =>
                {
                    value = "121";

                    And("the instance is less than the value", () =>
                    {
                        instance = "111";

                        Should("return true", () =>
                        {
                            Assert.That(result, Is.True);
                        });
                    });

                    And("the instance is greater than the value", () =>
                    {
                        instance = "131";

                        Should("return false", () =>
                        {
                            Assert.That(result, Is.False);
                        });
                    });

                    And("the instance is equal to the value", () =>
                    {
                        instance = "121";

                        Should("return true", () =>
                        {
                            Assert.That(result, Is.True);
                        });
                    });
                });
            });
        }

        /// <summary>
        /// Tests the <see cref="ComparableExtensions.IsGreaterThan{T}(IComparable{T}, T)"/>.
        /// </summary>
        [MemberTest(Name = nameof(ComparableExtensions.IsGreaterThan))]
        public static void IsGreaterThan()
        {
            IComparable<string> instance = null;
            string value = null;
            var result = false;

            When("an extension is called", () =>
            {
                Act(() =>
                {
                    result = instance.IsGreaterThan(value);
                });

                And("an instance is null", () =>
                {
                    instance = null;

                    Should("return false", () =>
                    {
                        Assert.That(result, Is.False);
                    });
                });

                And("an instance is not null", () =>
                {
                    value = "121";

                    And("the instance is less than the value", () =>
                    {
                        instance = "111";

                        Should("return false", () =>
                        {
                            Assert.That(result, Is.False);
                        });
                    });

                    And("the instance is greater than the value", () =>
                    {
                        instance = "131";

                        Should("return true", () =>
                        {
                            Assert.That(result, Is.True);
                        });
                    });

                    And("the instance is equal to the value", () =>
                    {
                        instance = "121";

                        Should("return false", () =>
                        {
                            Assert.That(result, Is.False);
                        });
                    });
                });
            });
        }

        /// <summary>
        /// Tests the <see cref="ComparableExtensions.IsGreaterThanOrEqualTo{T}(IComparable{T}, T)"/>.
        /// </summary>
        [MemberTest(Name = nameof(ComparableExtensions.IsGreaterThanOrEqualTo))]
        public static void IsGreaterThanOrEqualTo()
        {
            IComparable<string> instance = null;
            string value = null;
            var result = false;

            When("an extension is called", () =>
            {
                Act(() =>
                {
                    result = instance.IsGreaterThanOrEqualTo(value);
                });

                And("an instance is null", () =>
                {
                    instance = null;

                    Should("return false", () =>
                    {
                        Assert.That(result, Is.False);
                    });
                });

                And("an instance is not null", () =>
                {
                    value = "121";

                    And("the instance is less than the value", () =>
                    {
                        instance = "111";

                        Should("return false", () =>
                        {
                            Assert.That(result, Is.False);
                        });
                    });

                    And("the instance is greater than the value", () =>
                    {
                        instance = "131";

                        Should("return true", () =>
                        {
                            Assert.That(result, Is.True);
                        });
                    });

                    And("the instance is equal to the value", () =>
                    {
                        instance = "121";

                        Should("return true", () =>
                        {
                            Assert.That(result, Is.True);
                        });
                    });
                });
            });
        }

        /// <summary>
        /// Tests the <see cref="ComparableExtensions.IsInRange{T}(IComparable{T}, T, T)"/>.
        /// </summary>
        [MemberTest(Name = nameof(ComparableExtensions.IsInRange))]
        public static void IsInRange()
        {
            IComparable<string> instance = null;
            string min = null;
            string max = null;
            var result = false;

            When("an extension is called", () =>
            {
                Act(() =>
                {
                    result = instance.IsInRange(min, max);
                });

                And("an instance is null", () =>
                {
                    instance = null;

                    Should("return false", () =>
                    {
                        Assert.That(result, Is.False);
                    });
                });

                And("an instance is not null", () =>
                {
                    min = "111";
                    max = "222";

                    And("the instance is less than the minimum value", () =>
                    {
                        instance = "101";

                        Should("return false", () =>
                        {
                            Assert.That(result, Is.False);
                        });
                    });

                    And("the instance is greater than the maximum value", () =>
                    {
                        instance = "333";

                        Should("return false", () =>
                        {
                            Assert.That(result, Is.False);
                        });
                    });

                    And("the instance is equal to the minimum value", () =>
                    {
                        instance = "111";

                        Should("return true", () =>
                        {
                            Assert.That(result, Is.True);
                        });
                    });

                    And("the instance is equal to the maximum value", () =>
                    {
                        instance = "222";

                        Should("return true", () =>
                        {
                            Assert.That(result, Is.True);
                        });
                    });

                    And("the instance is between the minimum and maximum value", () =>
                    {
                        instance = "121";

                        Should("return true", () =>
                        {
                            Assert.That(result, Is.True);
                        });
                    });
                });
            });
        }

        /// <summary>
        /// Tests the <see cref="ComparableExtensions.IsBetween{T}(IComparable{T}, T, T)"/>.
        /// </summary>
        [MemberTest(Name = nameof(ComparableExtensions.IsBetween))]
        public static void IsBetween()
        {
            IComparable<string> instance = null;
            string min = null;
            string max = null;
            var result = false;

            When("an extension is called", () =>
            {
                Act(() =>
                {
                    result = instance.IsBetween(min, max);
                });

                And("an instance is null", () =>
                {
                    instance = null;

                    Should("return false", () =>
                    {
                        Assert.That(result, Is.False);
                    });
                });

                And("an instance is not null", () =>
                {
                    min = "111";
                    max = "222";

                    And("the instance is less than the minimum value", () =>
                    {
                        instance = "101";

                        Should("return false", () =>
                        {
                            Assert.That(result, Is.False);
                        });
                    });

                    And("the instance is greater than the maximum value", () =>
                    {
                        instance = "333";

                        Should("return false", () =>
                        {
                            Assert.That(result, Is.False);
                        });
                    });

                    And("the instance is equal to the minimum value", () =>
                    {
                        instance = "111";

                        Should("return false", () =>
                        {
                            Assert.That(result, Is.False);
                        });
                    });

                    And("the instance is equal to the maximum value", () =>
                    {
                        instance = "222";

                        Should("return false", () =>
                        {
                            Assert.That(result, Is.False);
                        });
                    });

                    And("the instance is between the minimum and maximum value", () =>
                    {
                        instance = "121";

                        Should("return true", () =>
                        {
                            Assert.That(result, Is.True);
                        });
                    });
                });
            });
        }
    }
}

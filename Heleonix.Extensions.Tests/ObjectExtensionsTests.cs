// <copyright file="ObjectExtensionsTests.cs" company="Heleonix - Hennadii Lutsyshyn">
// Copyright (c) 2017-present Heleonix - Hennadii Lutsyshyn. All rights reserved.
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
    /// Tests the <see cref="ObjectExtensions"/>.
    /// </summary>
    [ComponentTest(Type = typeof(ObjectExtensions))]
    public static class ObjectExtensionsTests
    {
        /// <summary>
        /// Tests the <see cref="ObjectExtensions.IsNull(object)"/>.
        /// </summary>
        [MemberTest(Name = nameof(ObjectExtensions.IsNull))]
        public static void IsNull()
        {
            object instance = null;
            var result = false;

            When("an extension is called", () =>
            {
                Act(() =>
                {
                    result = instance.IsNull();
                });

                And("an instance is null", () =>
                {
                    instance = null;

                    Should("return true", () =>
                    {
                        Assert.That(result, Is.True);
                    });
                });

                And("an instance is not null", () =>
                {
                    instance = new object();

                    Should("return false", () =>
                    {
                        Assert.That(result, Is.False);
                    });
                });
            });
        }

        /// <summary>
        /// Tests the <see cref="ObjectExtensions.IsZero(object)"/>.
        /// </summary>
        [MemberTest(Name = nameof(ObjectExtensions.IsZero))]
        public static void IsZero()
        {
            object instance = null;
            var result = false;

            When("an extension is called", () =>
            {
                Act(() =>
                {
                    result = instance.IsZero();
                });

                And("an instance is null", () =>
                {
                    instance = null;

                    Should("return false", () =>
                    {
                        Assert.That(result, Is.False);
                    });
                });

                And("an instance is zero", () =>
                {
                    instance = 0;

                    Should("return true", () =>
                    {
                        Assert.That(result, Is.True);
                    });
                });

                And("an instance is not zero", () =>
                {
                    instance = "123";

                    Should("return false", () =>
                    {
                        Assert.That(result, Is.False);
                    });
                });
            });
        }

        /// <summary>
        /// Tests the <see cref="ObjectExtensions.IsOne(object)"/>.
        /// </summary>
        [MemberTest(Name = nameof(ObjectExtensions.IsOne))]
        public static void IsOne()
        {
            object instance = null;
            var result = false;

            When("an extension is called", () =>
            {
                Act(() =>
                {
                    result = instance.IsOne();
                });

                And("an instance is null", () =>
                {
                    instance = null;

                    Should("return false", () =>
                    {
                        Assert.That(result, Is.False);
                    });
                });

                And("an instance is one", () =>
                {
                    instance = 1;

                    Should("return true", () =>
                    {
                        Assert.That(result, Is.True);
                    });
                });

                And("an instance is not one", () =>
                {
                    instance = "123";

                    Should("return false", () =>
                    {
                        Assert.That(result, Is.False);
                    });
                });
            });
        }

        /// <summary>
        /// Tests the <see cref="ObjectExtensions.IsNegative(object)"/>.
        /// </summary>
        [MemberTest(Name = nameof(ObjectExtensions.IsNegative))]
        public static void IsNegative()
        {
            object instance = null;
            var result = false;

            When("an extension is called", () =>
            {
                Act(() =>
                {
                    result = instance.IsNegative();
                });

                And("an instance is null", () =>
                {
                    instance = null;

                    Should("return false", () =>
                    {
                        Assert.That(result, Is.False);
                    });
                });

                And("an instance is negative", () =>
                {
                    instance = -1;

                    Should("return true", () =>
                    {
                        Assert.That(result, Is.True);
                    });
                });

                And("an instance is zero", () =>
                {
                    instance = 0;

                    Should("return false", () =>
                    {
                        Assert.That(result, Is.False);
                    });
                });

                And("an instance is positive", () =>
                {
                    instance = +1;

                    Should("return false", () =>
                    {
                        Assert.That(result, Is.False);
                    });
                });
            });
        }

        /// <summary>
        /// Tests the <see cref="ObjectExtensions.IsPositive(object)"/>.
        /// </summary>
        [MemberTest(Name = nameof(ObjectExtensions.IsPositive))]
        public static void IsPositive()
        {
            object instance = null;
            var result = false;

            When("an extension is called", () =>
            {
                Act(() =>
                {
                    result = instance.IsPositive();
                });

                And("an instance is null", () =>
                {
                    instance = null;

                    Should("return false", () =>
                    {
                        Assert.That(result, Is.False);
                    });
                });

                And("an instance is positive", () =>
                {
                    instance = +1;

                    Should("return true", () =>
                    {
                        Assert.That(result, Is.True);
                    });
                });

                And("an instance is zero", () =>
                {
                    instance = 0;

                    Should("return false", () =>
                    {
                        Assert.That(result, Is.False);
                    });
                });

                And("an instance is negative", () =>
                {
                    instance = -1;

                    Should("return false", () =>
                    {
                        Assert.That(result, Is.False);
                    });
                });
            });
        }

        /// <summary>
        /// Tests the <see cref="ObjectExtensions.IsEqualTo(object, object)"/>.
        /// </summary>
        [MemberTest(Name = nameof(ObjectExtensions.IsEqualTo))]
        public static void IsEqualTo()
        {
            object instance = null;
            object other = null;
            var result = false;

            When("an extension is called", () =>
            {
                Act(() =>
                {
                    result = instance.IsEqualTo(other);
                });

                And("an instance is null", () =>
                {
                    instance = null;

                    And("an other value is null", () =>
                    {
                        other = null;

                        Should("return true", () =>
                        {
                            Assert.That(result, Is.True);
                        });
                    });

                    And("an other value is not null", () =>
                    {
                        other = new object();

                        Should("return false", () =>
                        {
                            Assert.That(result, Is.False);
                        });
                    });
                });

                And("an instance not null", () =>
                {
                    instance = new object();

                    And("an other value is null", () =>
                    {
                        other = null;

                        Should("return false", () =>
                        {
                            Assert.That(result, Is.False);
                        });
                    });

                    And("an other value is not null", () =>
                    {
                        other = new object();

                        Should("return false", () =>
                        {
                            Assert.That(result, Is.False);
                        });
                    });

                    And("an other value is the same reference as the instance", () =>
                    {
                        other = instance;

                        Should("return true", () =>
                        {
                            Assert.That(result, Is.True);
                        });
                    });
                });
            });
        }

        /// <summary>
        /// Tests the <see cref="ObjectExtensions.IsAs(object, Type)"/>.
        /// </summary>
        [MemberTest(Name = nameof(ObjectExtensions.IsAs))]
        public static void IsAs()
        {
            object instance = null;
            Type type = null;
            var result = false;

            When("an extension is called", () =>
            {
                Act(() =>
                {
                    result = instance.IsAs(type);
                });

                And("an instance is null", () =>
                {
                    instance = null;

                    And("a type is null", () =>
                    {
                        type = null;

                        Should("return false", () =>
                        {
                            Assert.That(result, Is.False);
                        });
                    });

                    And("a type is not null", () =>
                    {
                        type = typeof(string);

                        Should("return false", () =>
                        {
                            Assert.That(result, Is.False);
                        });
                    });
                });

                And("an instance not null", () =>
                {
                    instance = "some object";

                    And("a type is null", () =>
                    {
                        type = null;

                        Should("return false", () =>
                        {
                            Assert.That(result, Is.False);
                        });
                    });

                    And("a type is not a type of the instance", () =>
                    {
                        type = typeof(int);

                        Should("return false", () =>
                        {
                            Assert.That(result, Is.False);
                        });
                    });

                    And("a type is a base type of the instance", () =>
                    {
                        type = typeof(object);

                        Should("return true", () =>
                        {
                            Assert.That(result, Is.True);
                        });
                    });

                    And("a type is exact type of the instance", () =>
                    {
                        type = typeof(string);

                        Should("return true", () =>
                        {
                            Assert.That(result, Is.True);
                        });
                    });
                });
            });
        }

        /// <summary>
        /// Tests the <see cref="ObjectExtensions.IsTypeOf(object, Type)"/>.
        /// </summary>
        [MemberTest(Name = nameof(ObjectExtensions.IsTypeOf))]
        public static void IsTypeOf()
        {
            object instance = null;
            Type type = null;
            var result = false;

            When("an extension is called", () =>
            {
                Act(() =>
                {
                    result = instance.IsTypeOf(type);
                });

                And("an instance is null", () =>
                {
                    instance = null;

                    And("a type is null", () =>
                    {
                        type = null;

                        Should("return false", () =>
                        {
                            Assert.That(result, Is.False);
                        });
                    });

                    And("a type is not null", () =>
                    {
                        type = typeof(string);

                        Should("return false", () =>
                        {
                            Assert.That(result, Is.False);
                        });
                    });
                });

                And("an instance not null", () =>
                {
                    instance = "some object";

                    And("a type is null", () =>
                    {
                        type = null;

                        Should("return false", () =>
                        {
                            Assert.That(result, Is.False);
                        });
                    });

                    And("a type is not a type of the instance", () =>
                    {
                        type = typeof(int);

                        Should("return false", () =>
                        {
                            Assert.That(result, Is.False);
                        });
                    });

                    And("a type is a base type of the instance", () =>
                    {
                        type = typeof(object);

                        Should("return false", () =>
                        {
                            Assert.That(result, Is.False);
                        });
                    });

                    And("a type is exact type of the instance", () =>
                    {
                        type = typeof(string);

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

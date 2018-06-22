# Heleonix.Extensions

Provides predicative and other useful extensions for objects, strings, enumerables etc.

## Install

https://www.nuget.org/packages/Heleonix.Extensions

**These extensions do not throw exceptions, so they can be used without try/catch blocks or extra `if` statements**.
All of the extensions are straightforward, so descriptions provided by intellisense is pretty enough.

## Heleonix.Extensions.ObjectExtensions

### Methods

* `public static bool IsNull(this object instance)`

* `public static bool IsZero(this object instance)`

* `public static bool IsOne(this object instance)`

* `public static bool IsNegative(this object instance)`

* `public static bool IsPositive(this object instance)`

* `public static bool IsEqualTo(this object instance, object other)`

* `public static bool IsAs(this object instance, Type type)`

  Determines whether this instance is subclass of or exactly the specified type.

* `public static bool IsTypeOf(this object instance, Type type)`

  Determines whether a type of this instance exactly equals the specified type.

## Heleonix.Extensions.EnumerableExtensions

### Methods

* `public static bool IsEmpty<T>(this IEnumerable<T> instance)`

* `public static bool IsNullOrEmpty<T>(this IEnumerable<T> instance)`

## Heleonix.Extensions.ComparableExtensions

### Methods

* `public static bool IsLessThan<T>(this IComparable<T> instance, T value)`

* `public static bool IsLessThanOrEqualTo<T>(this IComparable<T> instance, T value)`

* `public static bool IsGreaterThan<T>(this IComparable<T> instance, T value)`

* `public static bool IsGreaterThanOrEqualTo<T>(this IComparable<T> instance, T value)`

* `public static bool IsInRange<T>(this IComparable<T> instance, T min, T max)`

  Determines whether this instance is in range (inclusive) of the provided values.

* `public static bool IsBetween<T>(this IComparable<T> instance, T min, T max)`

  Determines whether this instance is between (exclusive) the provided values.

## Heleonix.Extensions.StringExtensions

### Methods

* `public static string FormatWith(this string format, params object[] args)`

  Formats the specified format string with the specified arguments.

  ###### Example

  ```csharp
  var str = "{0} plus {1} equals {2}".FormatWith(1, 2, 3);

  // "1 plus 2 equals 3"
  ```

* `public static string FormatWith(this string format, IFormatProvider formatProvider, params object[] args)`

  Formats the specified format string with the specified arguments using a specified format provider.

* `public static bool IsNullOrEmptyOrWhiteSpace(this string instance)`
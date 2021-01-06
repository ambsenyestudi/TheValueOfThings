# TheValueOfThings

How to approach value objects as a clean code practice

## Value objects what are they?

Your typical definition about value objects is:
Kind of objects that are important for what they represent. They don't have an identifier. And they usually wrap a primitive (string, int, or such).

By this definition the options pattern of asp.net is value object, but in my opinion a value object is so much more.
Actually, a value object has an identity as of part of domain knowledge, it represents a concept so it encloses business rules.

## Business rules

The very first thing that you can avoid with a value object is so much null checks. You encapsulate the null check at the constructor of your value object
ensuring that it will never be null.

A second characteristic of value objects is that you must be able to compare with no effort


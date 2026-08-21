# Getting started

JLib Storage provides simple stores for working with collections of values.

## Integer storage

The `IntStore` class can be used to add and retrieve integers and calculate their total.

```csharp
var store = new IntStore();

store.Add(10);
store.Add(20);
store.Add(30);

var total = store.Sum();
```

`IntStore` uses functionality provided by JLib Tools to perform the calculation.

## String storage

The `StringStore` class provides similar functionality for collections of strings.

```csharp
var store = new StringStore();

store.Add("First");
store.Add("Second");

var value = store.Get(0);
```

See the [API reference](../api/JLib.Storage.html) for the complete list of available types and members.
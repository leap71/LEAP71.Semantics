# LEAP71.Semantics

`LEAP71.Semantics` contains minimal, dependency-free semantic marker interfaces shared across LEAP 71 .NET projects.

The package deliberately contains no implementation logic and no dependencies.

## Marker interfaces

### `IQuantityValue`

Marks a strongly typed quantity value. LEAP 71 coding conventions use the `u` prefix for these values.

```csharp
public readonly record struct TokenCount(ulong nValue) : IQuantityValue;

TokenCount uTokens;
```

### `IIdentityValue`

Marks a strongly typed identity value. LEAP 71 coding conventions use the `id` prefix for these values.

```csharp
public readonly record struct ObjectId(Guid oValue) : IIdentityValue;

ObjectId idObject;
```

## Design rule

A marker belongs in this package only when independent libraries need to communicate a shared semantic category to generic infrastructure without depending on each other's concrete types.

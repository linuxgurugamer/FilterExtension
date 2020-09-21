# Config References: Filters and Checks

FILTER and CHECK  nodes are the basis for setting which parts are visible in each CATEGORY and SUBCATEGORIES.

## FILTER nodes

These nodes are wrappers for a set of conditions defined by each CHECH node.

Each category and subcategory can have multiple filters available, with a part being required to meet all the conditions of at least one filter to be visible. Filters can also be inverted so the reverse is true (must not pass any nodes to be visible) but this is generally not required.

## CHECK nodes

These nodes contain the details of a single condition.

Each check node contains a single yes/no condition that a part must pass to be accepted. Each Check has a type which details what on the part will be compared against as well as a value (or list of values) and several optional parameters.

## Example

```ksp
// An example Filter checking for all parts that would be visible in the stock "Pods" subcategory.

FILTER
{
    CHECK
    {
        type = category
        value = Pods
    }
}
```

All valid Check Types are listed [HERE](https://github.com/7ranceaddic7/FilterExtension/wiki/16-Config_References-Check-Types)

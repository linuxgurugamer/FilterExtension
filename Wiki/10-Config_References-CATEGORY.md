# Config References: CATEGORY

A CATEGORY definition provides the topmost-level of filtering available.

In this example, we use the 'Filter by Function' definition to define the CATEGORY.

```ksp
CATEGORY
{
    name = Filter by Function
    type = stock
    value = replace

    FILTER
    {
        CHECK
        {
            type = folder
            value = Squad
        }
    }

    SUBCATEGORIES
    {
        list = 0,Pods
        list = 1,Fuel Tanks
        list = 2,Engines
        list = 3,Command and Control
        list = 4,Structural
        list = 5,Aerodynamics
        list = 6,Utility
        list = 7,Science, don't template
    }
}
```

In-depth explanation of each element:

```ksp
CATEGORY
{
    // The name/title of the category that will be visible in-game and the id used for Module Manager patches.
    // e.g. @CATEGORY[Filter?by?Function] will target this node.
    // This field must be unique.

    name = Filter by Function

    // The type and value fields are used to specify some of the more interesting behavioral characteristics of a category.
    // Making changes to any of the 6 stock categories requires the line "type = stock" with the value line choosing between completely replacing all subcategories or just appending new ones.
    // There is also the "type = engines" which generates and adds subcategories for every variant of engine present.

    type = stock
    value = replace

    // Any Filter nodes found inside a category are applied prior to those in each subcategory, further limiting the parts that will show up.
    // This template for example would limit the visible parts of any subcategory added to those located inside the Squad folder.

    FILTER
    {
        CHECK
        {
            type = folder
            value = Squad
        }
    }

    // The SUBCATEGORIES node contains a 0 indexed list of all the subcategories to be added to this category.
    // No particular key is required, "list" is just used as a default.
    // The index specifies the position the subcategory will be visible at.
    // If two entries use the same index, the latter will replace the former.
    // If no index is used, the subcategory will be tacked on to the end after all indexed additions.

    SUBCATEGORIES
    {
        list = 0,Pods
        list = 1,Fuel Tanks
        list = 2,Engines
        list = 3,Command and Control
        list = 4,Structural
        list = 5,Aerodynamics
        list = 6,Utility
        list = 7,Science, don't template // the "don't template" keyword excludes this subcategory from the category level filtering
    }

    // NOTE: Regardless where FILTER:CHECK nodes are placed they will be loaded before any SUBCATEGORIES.
}
```

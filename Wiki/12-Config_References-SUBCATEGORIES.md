# Config References: SUBCATEGORIES

A SUBCATEGORIES definition provides an additional level of filtering below the CATEGORY level.

```ksp
SUBCATEGORY
{
    name = Ablative Heat Shields
    icon = Ablative_Shield

    FILTER
    {
        // invert = false

        CHECK
        {
            type = moduleName
            value = ModuleHeatShield, ModuleAblator
            // invert = true
            // contains = true
            // equality = Equals
        }
    }
}
```

In depth explanation of each element:

```ksp
// Three node types are used to completely define a subcategory.  
// SUBCATEGORY, root node, contains the UI and logic elements.
// FILTER and CHECK nodes are used to identify which parts should be visible within the subcategory
// A part must pass all CHECK's in any of the FILTER's to be visible in the SUBCATEGORY

SUBCATEGORY
{
    // The name/title of the subcategory that will be visible in-game and the id used for Module Manager
    // e.g. @SUBCATEGORY[Ablative?Heat?Shields] will target this node.
    // This field must be unique.

    name = Ablative Heat Shields

    // The name of any image file in GameData with dimensions between 25 and 40 pixels and without the file extension.
    // NOTE: Internal KSP limitations prevent DDS formatted images being loaded as of 1.0.4.

    icon = Ablative_Shield

    // FILTER type nodes form one part of the system which specifies which parts will show in a subcategory.  
    // Multiple FILTER nodes are OR'd together when checking parts.

    FILTER
    {
        // NOT logic elements are specified using the line "invert = true".
        // Default is false.

        // invert = false

        // CHECK type nodes form the majority of the logic required to identify which parts should show in this subcategory.
        // Multiple CHECK nodes are AND'd together when checking parts.

        CHECK
        {
            // The check type specifies which parameters the check is performed against.
            // As of v2.3.0, there are 21 types to choose from. Of these, 18 are directed at basic part stats while.
            // 3 special types enable faster and/or more complex filtering.

            type = moduleName

            // The value line lists all the things to match against. Most check types support comma separated values.
            // Only one value in a list needs to be matched (so this check is: has(ModuleHeatShield OR ModuleAblator)).

            value = ModuleHeatShield, ModuleAblator

            // By default checks evaluate true if a match is found. This can be changed by adding the line "invert = true
            // Default is false.

            // invert = true

            // The contains element is valid for all check types that accept lists of values.
            // When true, matching any one element in the list of values will set the CHECK state to true
            // When false, matching any one element NOT in the list of values will set the CHECK state true
            // Most commonly it is used in combination with "invert = false" to specify that there is nothing other than the listed elements
            // Default is true.

            // contains = true

            // The equality element is valid for types accepting numeric values.
            // Accepted values: "Equals", "GreaterThan", "LessThan".
            // Default is "Equals".

            // equality = Equals
        }
    }
}
```

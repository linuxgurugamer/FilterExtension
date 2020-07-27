# Simple Example

Whether CATEGORY or SUBCATEGORIES, the method is the same. Identify requirements common to all the parts

This set has two conditions:

* The part is stock (created by Squad)
* The part functions as a wing

Checking that the part is a stock one can be accomplished in several ways, but the most straight forward is to look at which GameData folder it is located in. All stock parts exist inside the Squad folder

```ksp
FILTER
{
    CHECK
    {
        type = folder
        value = Squad
    }
}
```

The second condition, that the parts are wings can also be done in several ways. Prior to KSP 1.0, a title check was used with the values "wing" and "fin". Since KSP 1.0, wings make use of the PartModule system so a much more robust check can be performed using that module

```ksp
FILTER
{
    CHECK
    {
        type = folder
        value = Squad
    }

    CHECK
    {
        type = moduleName
        value = ModuleLiftingSurface
    }
}
```

---

That works ... most of the time. Some users will have installed Ferram Aerospace Research and FAR replaces the stock wing module with its own module named "FARWingAerodynamicModel".  To catch FAR and stock wings, we need to see either the stock module OR the FAR module.

```ksp
FILTER
{
    CHECK
    {
        type = folder
        value = Squad
    }

    CHECK
    {
        type = moduleName
        value = ModuleLiftingSurface, FARWingAerodynamicModel
    }
}
```

Add to a CATEGORY or A SUBCATEGORIES and all wings distributed by Squad will be visible.

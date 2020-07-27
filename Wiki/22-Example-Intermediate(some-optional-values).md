# Intermediate-level Example

In this example, we find all engines which consume a mixture ONLY  of Liquid Oxygen and Liquid Hydrogen.

## ***Conditions***

* Must show all engines that:
  * Consume LH and LOx
  * Do not consume any other propellants

```ksp
FILTER
{
    CHECK
    {
        type = propellant
        value = LiquidHydrogen
    }

    CHECK
    {
        type = propellant
        value = LiquidOxygen
    }
}
```

There are couple traps to watch for, here.  First, because both propellants are required they must each be CHECKed separately as conditions.

Remember, we want **only** those engine which "Consume LH and LOx, and have **no** other propellants."  The second trap is that this FILTER is incomplete.  An engine using a third or fourth propellant would still be capable of matching these conditions.

To ensure we get the engines we want, a third CHECK is required using two optional parameters: _invert_ and _contains_.

```ksp
FILTER
{
    CHECK
    {
        type = propellant
        value = LiquidHydrogen
    }

    CHECK
    {
        type = propellant
        value = LiquidOxygen
    }

    CHECK
    {
        type = propellant
        value = LiquidHydrogen, LiquidOxygen
        contains = false
        invert = true
    }
}
```

Using **"contains = false"** filters for _"propellants **NOT** listed ("value") in this engine"_. This will return _true_ if there is a third propellant type. That's all well and good but not what we want; it should only return true when **no** additional propellants (other than more LiquidHydrogen or LiquidOxygen) are present. To do that, we make _true_ become  _false_ with the line **"invert = true"**.

You may have noticed the lack of a specific check for an engine.  Propellant nodes return false when no engine is found so in this case we can skip that.

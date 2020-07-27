# Config References: Check Types

The type field of a CHECK controls what piece of information the comparison will be made against.

All types support the optional field: _invert_

## Check Type: Basic

All basic types support comma separated lists of values.

---

Module Name : _moduleName_

_Checks for the presence of a module name **as listed in the part.cfg** (e.g. ModuleEngines, ModuleCommand). Respects inheritance of stock classes (e.g. checking for ModuleEngines will catch parts using ModuleEngines, ModuleEnginesFX, and a wide variety of Mod Engine modules)_.

---

Part Name : _name_

_Check will compare against the name field **as listed in the part.cfg** (e.g. Mark1Cockpit)_.

---

Module Title : _moduleTitle_

_Checks for the presence of a module by the module name **as listed in the editor right click menu**_.

---

Part Title : _title_

_Checks for the presence of a case insensitive substring **as listed in the part title**. This is searching for partial matches so "cargo bay" will catch all stock cargo bays_.

---

Technology : _tech_

_Matches the ID of a tech node (**NOT** the title visible in-game)_.

---

Manufacturer : _manufacturer_

_Matches the manufacturer field in the part.cfg_.

---

Folder : _folder_

<!-- markdownlint-disable MD033 -->

_Matches to the **root** <ksp>/GameData folder the part is found in (e.g. Squad)_.

<!-- markdownlint-restore -->

---

Path : _path_

_Matches to the full file path from the GameData directory to the part (e.g. Squad/Parts/FuelTanks/)_.

---

Category : _category_

_Matches to the category field in the part.cfg (e.g. Pods)_.

---

Resource : _resource_

_Matches to parts containing a specific resource. Matches against the in-game title (e.g. Electric Charge)_.

---

Profile : _profile_

_Matches to parts with a certain bulkhead profile listed in their part.cfg file_.

## Check Type: Numeric

Optional field valid for use with numeric types are: equality.
All numeric checks support comma separated lists of values to compare against.

---

Crew Capacity : _crew_

_Compares against the part crew capacity_.

---

Attach Node Size : _size_

_Compares against the size parameter of all the attach nodes on a part_.

---

Mass : _mass_

_Compares against the **wet** mass (the value listed when right clicking in the editor) of each part_.

---

Cost : _cost_

_Compares against the purchase price for a single part in career mode_.

---

Crash Tolerance : _crash_

_Compares against the impact speed required to destroy the part_.

## Check Type: Other

Custom : _custom_

_Custom type checks are shorthand for some checks that would be difficult or impossible to achieve with the standard syntax. Current valid values are: "adapter", "multicoupler", "purchased"_.

---

Propellant : _propellant_

_Checks against the resources consumed by engine modules on the part_.

---

Condition Group : _check_

_Used to group several conditions together (e.g. NOT category(Pods) AND NOT category(Engines) is different to NOT (category(Pods) AND category(Engines)). The second requires a conditional grouping to express_.

---

Subcategories : _subcategory_

_Checks against the full conditions defined in another subcategory_.



## ModuleManager patches to Filter Extensions

These are some ModuleManager patches I made to enhance Filter Extensions.

As it stands right now it is an all or nothing patch. I wanted to reorder the
default categories to emulate the order of stock categories and to also add
a new "Rovers" default category. In order to accomplish this using only
ModuleManager patches, I had to delete the original default categories and
rebuild them. What follows is a list of the patches and what they do, as well as some additional information.

Additional files are modified icons from Roverdude and Squad. For some reason they show up reversed so I just inverted them.

**1: 000_DefaultReOrderContortionist.cfg**
This file deletes the original categories and rebuilds them in a new order. Contained within this file is the new "Rovers" category. To rebuild the "*Default*" categories, it was necessary to rename them. I did this by appending a "0" to the end of the original name. Therefore, any patches made to the "*Default*" categories will be directed to the original category with a "0" appended. If you  would like to use only a particular patch for one of the "*Default*" categories you will need to delete the "0" from the end of the name. Say you wanted to just use the **Custom_ProceduralFairings.cfg** patch for example:

	@CATEGORY[ProceduralFairings0]:NEEDS[FilterExtensions]
	{
		FILTER
		{
			stuff...
		}
	}
    
would become:

	@CATEGORY[ProceduralFairings]:NEEDS[FilterExtensions]
	{
	FILTER
		{
			stuff...
		}
	}

(Should you decide to edit these files, ModuleManager requires a "?" for 
                spaces and other special characters, just a FYI).

**2: ColorChange.cfg**
Changes the color of the "*Default*" icons.

**3: Custom_ISRU.cfg**
Added more filters to this. I like the parts I need for a particular job in one place.

**4: Custom_KerbalFoundries.cfg**
Kerbal Foundries came with a cfg file for FE, but it wasn't configured properly as best as I could tell. It doesn't have a ground, wheels or landing gear filter.

**5: Custom_KPBS.cfg**
KPBS comes with it's own filter extension, separate from FilterExtensions. You can turn theirs off with a ModuleManager patch. I added a Life Support category to emulate the filter they used. I prefer this one because it allows me more control.

**6: Custom_ProceduralFairings.cfg**
I modified ProceduralFairings because they left out "Payload" category, which is the only category that contains the fairings. However, once this is repaired, then the placeholders for the tech tree upgrades show up. I use "The Janitor's Closet" to hide them.

**7: Custom_Repairs.cfg**
This changes the category of the original Squad fuel tanks from "none" to "fuel". The reason I did this was because "ColorCodedCannisters" copies the fuel tanks and I wound up with two sets, one set with Interstellar Fuel Switch and one without. The set that was showing up in FE were the ones without while the others would only show up under the stock category filters. So I changed the categories and removed the duplicates with "The Janitor's Closet".

**8: Custom_Squad.cfg**
Adds a "Wings" and a "Parachute" filter to the Squad category.

**9: Custom_SubCategories_Aero.cfg**
This patch removes heat shields from the "Wings" filter.

**10: Custom_SubCategories_ISRU**
Support subcategory filters for the modified ISRU "*Default*" category

**11: Custom_SubCategoriesFuel.cfg**
Modified these subcategory filters to also recognize fuel tanks with Interstellar Fuel Switch and/or Firespitter.

**12: Custom_Umbra_Space_Industries**
Added several filters to USI. Roverdude's contributions are vast! In my current play through I am utilizing all of his mods and needed to wrangle them in a bit. Added filters for the more dedicated parts. This included the PackRat, Akita,  Malemute, Karibou and Otter. Also included his CCK filters in here as well.

**13: SubCategories_Land**
This is the support subcategories for the new "Rovers" category.

**14: SubCategories_USI.cfg**
The number contributions from Roverdude justified having a separate support subcategory file in an attempt to keep it somewhat organized.



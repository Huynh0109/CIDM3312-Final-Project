using Microsoft.EntityFrameworkCore;

namespace CIDM3312_Final_Project.Models
{
  public static class SeedData
  {
    public static void Initialize(IServiceProvider serviceProvider)
    {
      using (var context = new RecipeDbContext(
        serviceProvider.GetRequiredService<DbContextOptions<RecipeDbContext>>()))
      {
        if (context.Recipes.Any())
        {
          return;
        }

        context.Recipes.AddRange(
          new Recipe
          {
            RecipeName = "Honey Butter Chicken",
            RecipeDescription = "This butter honey chicken is loaded with flavor and takes minimal ingredients to make. Serve it with rice or mashed potatoes for a delicious lunch or dinner! This chicken is super easy to prepare and tastes like restaurant-style chicken!",
            Ingredient = "Chicken - use either chicken thighs or chicken breast, butter, honey, soy sauce, garlic, flour, salt, black pepper.",
            Instruction = "(1) In a large bowl or a large flat plate, mix together the flour, salt, black pepper, and garlic powder. (2) Add the chicken chunks and coat them well with the flour mixture. (3)Heat a large pan with oil over medium-high heat and cook the chicken on each side until it is crispy and golden brown on the outside. (4)Remove the chicken from the pan while you make the sauce (Place the cooked chicken on a plate). (5) Melt the butter over medium heat along with the honey, soy sauce, and garlic. Mix well and cook for about 2 minutes until the sauce is bubbly. (6) Add the chicken to the sauce and mix well and cook for another minute or so to let the sauce cling to the crust. Serve hot and enjoy!",
            Categories = new List<Category> {
              new Category {CategoryName = "Main Dish"}
            },
            Tag = new List<Tag> {
              new Tag {TagName = "Easy"}
            }
          },

        new Recipe
        {
            RecipeName = "Air Fryer Tilapia",
            RecipeDescription = "This recipe uses a super simple seasoning that is just perfect with this fish. You can make this fish with fresh fillets or defrosted frozen fillets. Both taste amazingly delicious.",
            Ingredient = "Tilapia, Olive Oil, Paprika, Garlic powder, Onion powder, Salt, Black pepper, Lemon zest.",
            Instruction = "(1) Into a small mixing bowl, add the olive oil, lemon zest, paprika, kosher salt, black pepper, onion powder, and garlic powder, and mix with a spoon until well combined. (2) Lightly rinse and pat dry the tilapia fillets until they are dry. Split the spice mixture and brush each fillet with half of the mixture. (3) Brush the air fryer basket with the oil of your choice and place the fillets with the skin side down without overlapping. (4) Cook at 200c (400f) for 9-12 minutes depending on the thickness of the fillets. I cooked mine for exactly 10 minutes. Cook until golden brown and check doneness with a fork. If the fish feels tender, it's ready! (5) Top the fish with chopped parsley and serve with slices of lemon next to your favorite side dish!",
            Categories = new List<Category> {
              new Category {CategoryName = "Main Dish"}
            },
            Tag = new List<Tag> {
              new Tag {TagName = "Air Fryer"}
            }
        },

        new Recipe
        {
            RecipeName = "Air Fryer Chicken Tender",
            RecipeDescription = "Air Fryer chicken tender",
            Ingredient = "Chicken tenders, flour, Salt, Black pepper, Garlic powder, Eggs.",
            Instruction = "(1) Into a shallow bowl, add the flour, garlic powder, kosher salt, and black pepper and mix. (2) In a second shallow bowl, add the eggs and whisk them with a fork. (3) Into a third shallow bowl, add the panko breadcrumb and grated parmesan cheese and mix well. (4) Dip the chicken in the flour, coating it well, then dip it in the egg mixture, and finally dip it in the panko mixture, coating the chicken and pressing the breadcrumbs into the chicken to make sure they stick to the chicken. (5) Brush the air fryer basket with olive oil or your favorite oil. Place the chicken in the air fryer basket leaving spaces between each chicken tender. Cook in the air fryer for 10-12 minutes at 200c (400f) until the chicken is cooked through, golden brown, and crispy. (6) Garnish with freshly chopped parsley and serve hot!",
            Categories = new List<Category> {
              new Category {CategoryName = "Apetizer, Main Course"}
            },
            Tag = new List<Tag> {
              new Tag {TagName = "Air Fryer"}
            }
        },

        new Recipe
        {
            RecipeName = "Butter Chicken Fish Sauce",
            RecipeDescription = "This is a vietnamese dish",
            Ingredient = "Chicken, flour, butter, garlic, chillies, sugar, chinsu chilli sauce, fish sauce",
            Instruction = "(1) Marinate the chicken in the garlic powder, chicken bouillon powder, pepper, salt and fish sauce for 20 minutes minimum. Alternatively, make it ahead of time to marinate overnight. (2) Using a low heat, add the chopped garlic to 2 tbsp cooking oil and let it fry until golden. (3) Use a zip lock bag to shake and coat the marinated wings in the starch mixture. (4) Pour the chicken into a colander to shake off any excess. (5) Add oil into a deep pan or wok and fry the wings on a medium heat for 5 minutes on each side or until lightly golden brown and cooked. (6) Bring the heat back up to high and fry the wings for a second time for 2 minutes or until they develop a deeper golden color. Transfer onto a sieve to drip dry or on a plate lined with paper towels. (7) Use a mortor and pestle to mash the garlic and chili, then set aside as you work on the sauce. (8) Pour 4 tbsp oil in a saucepan and brown the red shallots. Add in the sugar, fish sauce, garlic, chili and water to caramelize for 15 minutes or until it reaches a thick consistency, then stir the lime juice and spring onions in. (9) Mix the fried wings back into the sauce and toss until all are coated. (10) Stir in the fried chopped garlic until well combined.",
            Categories = new List<Category> {
              new Category {CategoryName = "Main Dish"}
            },
            Tag = new List<Tag> {
              new Tag {TagName = "Vietnamese Food"}
            }
        },

        new Recipe
        {
            RecipeName = "Pho",
            RecipeDescription = "This Pho recipe has been in the works for a while now. It's been quietly made and remade by various RecipeTin family members since our first trip to Vietnam. We've compared notes, debated furiously about how the latest iteration compared to the (many) bowls of Pho soup we slurped during our travels, and our favourite Pho restaurants back home here in Sydney.",
            Ingredient = "AROMATICS: 2 large onions, 150g / 5oz ginger. SPICES: 10 star anise, 4 cinnamon quills, 4 cardamon pods, 3 cloves, 1.5 tbsp coriander seeds. BEEF BONES: 1.5kg / 3lb beef brisket, 1kg / 2lb meaty beef bones, 1kg / 2lb marrow bones, 3.5 litres / 3.75 quarts water. SEASONING: 2 tbsp white sugar, 1 tbsp salt, 40 ml / 3 tbsp fish sauce. ",
            Instruction = "(1) Heat a heavy based skillet over high heat (no oil) until smoking. (2) Place onion and ginger in pan cut side down. Cook for a few minutes until it's charred, then turn. Remove and set aside. (3) Toast Spices lightly in a dry skillet over medium high heat for 3 minutes. Remove Impurities, (1) Rinse bones & brisket then cover with water in large stock pot. (2) Boil for 5 minutes, then drain. (3) Rinse each bone and brisket under tap water. Broth (1) Wipe pot clean, bring 3.5 litres / 3.75 quarts water to boil. (2) Add bones and brisket, onion, ginger, Spices (3) Add onion, ginger, Spices, sugar and salt - water should just barely cover everything. (4) Cover with lid, simmer 3 hours. (5) Remove brisket (should be fall-apart tender), cool then refrigerate for later (6) Simmer remaining soup UNCOVERED for 40 minutes. (7) Strain broth into another pot, discard bones and spices. Should be about 2.5 litres / 2.65 quarts (10 cups), if loads more, reduce. (8) Add fish sauce, adjust salt and sugar if needed. Broth should be beefy, fragrant with spices, savoury and barely sweet.",
            Categories = new List<Category> {
              new Category {CategoryName = "Main Dish"}
            },
            Tag = new List<Tag> {
              new Tag {TagName = "Vietnamese Food"}
            }
        },

        new Recipe
        {
            RecipeName = "Baked Fish with Lemon Cream Sauce",
            RecipeDescription = "This Baked Fish recipe comes with a Lemon Cream Sauce and is made in ONE baking dish! Yup, just throw it all in one pan, bake it, and you end up with a tender juicy fish in a creamy lemon sauce. The the juices of the fish mingles in with the sauce while it's baking, as if made from the best fish stock!",
            Ingredient = "Fish fillet, Unsalted butter, Heave cream, garlic, Dijon mustard, lemon juice, Salt, Pepper, Eschallots",
            Instruction = "(1) Preheat oven to 200°C / 390°F (all oven types). (2) Place fish in a baking dish - ensure the fish isn't crammed in too snugly. See video or photos in post. Sprinkle both sides of fish with salt and pepper. (3) Place butter, cream, garlic, mustard, lemon juice, salt and pepper in a microwave proof jug or bowl. Microwave in 2 x 30 sec bursts, stirring in between, until melted and smooth. (4) Sprinkle fish with shallots, then pour over sauce. (5) Bake for 10 - 12 minutes, or until fish is just cooked. Remove from oven and transfer fish to serving plates. Spoon over sauce, and garnish with parsley and lemon wedges if using.",
            Categories = new List<Category> {
              new Category {CategoryName = "Dinner"}
            },
            Tag = new List<Tag> {
              new Tag {TagName = "Fish, Easy"}
            }
        },

        new Recipe
        {
            RecipeName = "EASY LIGHTLY FRIED FISH - THYME AND SPICES - MEDITERRANEAN",
            RecipeDescription = "This dish is simple and easy, and quick, and delicious version of friend fish fillets. Serve it with whatever side you would like",
            Ingredient = "Tilapia fillets, Egg, Lemon, flour, sale, pepper, chili powder, paprika, cumin, oregano",
            Instruction = "(1) thaw the fish if frozen - rinse it under water and pat dry if you wish. (2) thaw the fish if frozen - rinse it under water and pat dry if you wish. (3) cut the fillets into smaller pieces if you want. (4) crack the egg into a shallow bowl and beat - add a pinch of salt and pepper. (5) prepare the spiced fish fry coating - mix roughly 50:50 flour:spices. I suggest adding a fair amount of salt and pepper, and also chili powder if you like it hot. ANY COMBO OF SPICES WORK, be liberal. MIX UNTIL HOMOGENOUS. (6) dip the fish in egg - let the extra egg drip off (tap against the side of bowl). (7) coat both sides of the egged up fish in the frying coating. (8) carefully (hot oil is dangerous!) fry both sides of the fish in the oil until golden brown on both sides, and the inside of the fish is flaky and white. (9) dry on paper towels lined with a bed of thyme. (10) garnish with lemon wedges and thyme sprigs (optional).",
            Categories = new List<Category> {
              new Category {CategoryName = "Main Dish"}
            },
            Tag = new List<Tag> {
              new Tag {TagName = "Fish, Easy"}
            }
        },

        new Recipe
        {
            RecipeName = "GRILLED BREAKFAST BURRITO",
            RecipeDescription = "A soft flour tortilla, rolled and lightly grilled, filled with scrambled eggs, sausage, potatoes, onions, peppers, and two cheeses.",
            Ingredient = "Vegetable oil, Large potatoes, Onion, Bell pepper, Butter, Eggs, Breakfast sausage, salt, black pepper, monterey jack cheese, sharp cheddar chesse, flour tortillas.",
            Instruction = "(1) Heat 1/4 cup of vegetable oil in a large skillet over medium heat. Fry potatoes until almost cooked through, then add onions and peppers, continuing to cook until vegetables are tender. Drain, set aside. (2) In the same skillet, melt butter or margarine over medium heat. Scramble eggs, adding potatoes, vegetables, and sausage during the last few moments of cooking. Add salt and pepper to taste. (3) Top each tortilla with cheese and part of the egg mixture, roll into a burrito. Spray a hot grill (I use a family size George Foreman) with cooking spray. Grill for approximately 10 minutes or until lightly browned. (4) Serve hot with homemade Pico De Gallo, salsa, sour cream, or perhaps Spanish rice and refried beans.",
            Categories = new List<Category> {
              new Category {CategoryName = "Breakfast"}
            },
            Tag = new List<Tag> {
              new Tag {TagName = "Easy"}
            }
        },

        new Recipe
        {
            RecipeName = "EGG AND AVOCADO WRAPS",
            RecipeDescription = "Egg and avocado wrap for breakfast",
            Ingredient = "black beans, salsa, avacado, lime, egg, chili powder, tortillas.",
            Instruction = "(1) In a skillet, over medium heat, combine black beans and salsa for 5 minutes, smashing the beans while cooking. (2) Meanwhile in a small cup or bowl combine avocado and lime juice; mashing with a fork.(3) Whisk together the egg substitute and chili powder in another bowl. (4) Over medium low heat, spray skillet with Pam cooking spray; add egg substitute mixture and cook for 2 to 5 minutes, stirring frequently. (5) Spread each tortilla with 1 tablespoon avocado mixture; top with 1/4 cup egg mixture and 1/4 cup bean mixture. (6) Roll up and serve.",
            Categories = new List<Category> {
              new Category {CategoryName = "Breakfast"}
            },
            Tag = new List<Tag> {
              new Tag {TagName = "Quick and easy"}
            }
        },

        new Recipe
        {
            RecipeName = "BREAKFAST BURRITOS",
            RecipeDescription = "These burritos are not just for breakfast, they are a great anytime snack, if you desire, these could be fully prepared, and stored in the fridge....just make sure to bake them 10-15 minutes longer, or they may be frozen, just thaw them before baking.",
            Ingredient = "frozen southern style hash brown potatoes, eggs, half-half cream (salt pepper to taste), onion, green pepper, pork sausage, flour tortillas, cheddar cheese.",
            Instruction = "(1) Set oven to 350 degrees. (2) In a large skillet, fry hash browns according to package directions; remove and set aside. (3) In a large bowl beat eggs with milk; add chopped onion and green pepper, then season with salt and pepper. (4) Pour the mixture into the same skillet; cook over medium heat, stirring occasionally, until eggs are set; remove from heat. (5) Add the cooked hash browns and sausage; mix gently. (6) Place about 3/4 cup filling on each tortilla; top with 1/4 cup cheese. (7) Roll up, and place on a greased baking sheet. (8) Bake, uncovered for 15-20 minutes, or until heated through.",
            Categories = new List<Category> {
              new Category {CategoryName = "Breakfast"}
            },
            Tag = new List<Tag> {
              new Tag {TagName = "Quick and easy"}
            }
        },

        new Recipe
        {
            RecipeName = "FANTASTIC CRISPY TEMPURA BATTER",
            RecipeDescription = "Crispy tempura shrimp",
            Ingredient = "bear, rice flour, salt, pepper, garlic powder, shrimp",
            Instruction = "(1) In a bowl whisk beer with the rice flour until very smooth. (2) Add in salt and garlic powder and cayenne (if using). (3) Let sit out at room temperature for 10 minutes. (4) Heat oil to 375 degrees. (5) Dredge the fish or veggies into the batter coating completely with batter, letting any excess drip off. (6) Deep-fry turning once until golden (about 3 minutes). (7) Transfer to a piece of brown paper (a brown paper bag will do for this!).",
            Categories = new List<Category> {
              new Category {CategoryName = "Appetizer"}
            },
            Tag = new List<Tag> {
              new Tag {TagName = "Shrimp"}
            }
        },

        new Recipe
        {
            RecipeName = "SHRIMP LO MEIN",
            RecipeDescription = "This is a wonderful shrimp lo mein recipe. To cut down on prep time, I peel and devein the shrimp ahead of time, or buy the ones that are already done for you. Sprinkle with a little sesame seed and sliced scallion for a nice presentation.",
            Ingredient = "shrimp, soy sauce, cornstarch, fresh ginger, garlic, snow peas, carrots, bok choy, chicken broth, scallions, fettuccine.",
            Instruction = "(1) Combine first 5 ingredients and set aside for 10 minutes. (2) In skillet or wok, heat 1 tsp oil over high heat. (3) Drain shrimp, reserving soy mixture. (4) Cook shrimp until pink, 2-3 minutes. (5) Remove from skillet. (6) Add 1 tsp oil to skillet, then add peas and carrot, and cook 1 minute. (7) Add to shrimp. (8) Cook cabbage in skillet with remaining oil 1 minute. (9) Combine broth and reserved soy mixture and add to skillet, along with shrimp mixture. (10) Cook until thickened, 1 minute. (11) Remove from heat and mix in scallion and fettucini.",
            Categories = new List<Category> {
              new Category {CategoryName = "Dinner"}
            },
            Tag = new List<Tag> {
              new Tag {TagName = "Shrimp"}
            }
        },

        new Recipe
        {
            RecipeName = "CITRUSY GARLIC SHRIMP",
            RecipeDescription = "Easy, yummy, and garlicy. Doesn't get any better.",
            Ingredient = "shrimp, butter, garlic, salt, pepper, lemon",
            Instruction = "(1) Heat oil and butter in a large skillet. (2) Add garlic and shrimp; sprinkle with salt and pepper. (3) Saute 2-3 minutes or until shrimp turn pink. (4) Turn shrimp with spatula; cook shrimp 2 minutes longer on other side. (5) Remove shrimp to serving platter; garnish with lemon wedges. (6) Little squirt with the lemon wedge",
            Categories = new List<Category> {
              new Category {CategoryName = "Appetizer"}
            },
            Tag = new List<Tag> {
              new Tag {TagName = "Shrimp"}
            }
        },

        new Recipe
        {
            RecipeName = "SPICY GRILLED SHRIMP SKEWERS",
            RecipeDescription = "I suggest to use fresh shrimp for this as frozen thawed will create a watery marinade, do not marinade for longer than 30 minutes or the acid in the lemon juice will cook the shrimp, adjust the cayenne to suit heat level, I have left the Tabasco as optional you may add it or omit --- this shrimp is very good!",
            Ingredient = "shrimp, garlic, salt, cayenne pepper, paprika, olive oil, fresh lemon juice, tabaco sauce, lemon",
            Instruction = "(1) In a small bowl crush the garlic with coarse salt; mix in cayenne pepper and paprika. (2) Add in olive oil and lemon juice; mix until combine, then add in Tabasco if using. (3) In a large bowl toss the shrimp with the garlic oil until evenly coated. (4) Cover and refrigerate for 30 minutes. (5) Meanwhile soak the wooden skewers in cold water for 30 minutes. (6) Preheat grill to medium heat, then lightly oil the grill grate. (7) Thread the shrimp onto the wooden skewers. (8) Cook the shrimp for 2-3 minutes per side or until opaque.",
            Categories = new List<Category> {
              new Category {CategoryName = "Dinner"}
            },
            Tag = new List<Tag> {
              new Tag {TagName = "Shrimp"}
            }
        },

        new Recipe
        {
            RecipeName = "BEER AND LIME MARINATED SALMON",
            RecipeDescription = "Salmon needs to marinate overnight, so prepare the day before.",
            Ingredient = "salmon fillet, lime juice, beer, soy sauce, minced gingerroot, garlic, lime zest, green pepper.",
            Instruction = "(1) Combine lime juice, beer, soy sauce, ginger, and garlic. (2) Mix well. (3) Place salmon fillets in shallow glass dish and pour marinade over top. (4) Turn pieces several times to coat; cover and refrigerate overnight. (5) Preheat oven, broiler or grill. (6) Remove salmon from marinade; discard marinade. (7) Broil, bake or grill for about 10 minutes for 1 thick fillets or until fish flakes in center. (8) Serve hot garnished with diced bell pepper, lime zest and pepper on top.",
            Categories = new List<Category> {
              new Category {CategoryName = "Main Dish"}
            },
            Tag = new List<Tag> {
              new Tag {TagName = "Salmon"}
            }
        },

        new Recipe
        {
            RecipeName = "BAKED SEASONED SALMON",
            RecipeDescription = "This recipe came out of a local newspaper column 'Hometown Recipes' & had been submitted by Frankie Roland of Coffeyville KS. Since I'm always looking for quick & easy when it comes to salmon filets",
            Ingredient = "salmon, cider vinegar, worcestershire sauce, lemon juice, salt, prepared mustard, black pepper, butter, paprika, dried parsley.",
            Instruction = "(1) Preheat oven to 450 degrees F. (2) Arrange filets in a shallow baking dish. (3) Mix together the remaining ingredients, & pour half of this mixture over the fish. (4) Bake 20 minutes, basting with the remaining sauce. (5) When done, sprinkle with paprika & chopped parsley, if desired.",
            Categories = new List<Category> {
              new Category {CategoryName = "Main Dish"}
            },
            Tag = new List<Tag> {
              new Tag {TagName = "Salmon"}
            }
        },

        new Recipe
        {
            RecipeName = "GRILLED SALMON WITH TERIYAKI SAUCE",
            RecipeDescription = "Grilled salmon with teriyaki sauce",
            Ingredient = "salmon, dry sherry, low sodium soy sauce, brown sugar, rice wine vinegar, garlic powder, pepper, ground ginger.",
            Instruction = "(1) Combine first 7 ingredients in a shallow dish; stir well. Add fish; cover, and marinate in refrigerator 30 minutes. (2) Coat grill rack with cooking spray; place on grill over medium-hot coals (350-400 degrees). Remove fish from marinade; reserve marinade. (3) Place fish on grill rack or in a grill basket coated with cooking spray; grill, uncovered, 5 to 7 minutes on each side or until fish flakes easily when tested with a fork. (4) Transfer fish to a serving platter, and keep warm. (5) Place reserved marinade in a small saucepan; bring to a boil. Boil 5 minutes or until marinade becomes thick and syrupy. (6) Spoon over fish; serve immediately.",
            Categories = new List<Category> {
              new Category {CategoryName = "Main Dish"}
            },
            Tag = new List<Tag> {
              new Tag {TagName = "Salmon"}
            }
        },

        new Recipe
        {
            RecipeName = "SOUTHERN FRIED SALMON PATTIES",
            RecipeDescription = "Fried salmon patties",
            Ingredient = "canned salmon, onion, cornmeal, flour, egg, mayonnaise",
            Instruction = "(1) Open salmon and drain thoroughly. Place drained salmon in mixing bowl and flake evenly with a fork. (2) Add onion, corn meal, flour, mayonnaise, and egg. Stir until well blended. (3) Shape the mixture into patties about the size of an average burger or less. (4) Cook in oil in skillet over medium heat until browned on each side. Turn once while frying. (5) Note: The mayonnaise helps the patties hold their shape and keeps them from being too dry.",
            Categories = new List<Category> {
              new Category {CategoryName = "Dinner"}
            },
            Tag = new List<Tag> {
              new Tag {TagName = "Salmon"}
            }
        },

        new Recipe
        {
            RecipeName = "PAN-GRILLED SALMON",
            RecipeDescription = "pan grilled salmon",
            Ingredient = "salmon fillet, low sodium soy sauce, garlic, fresh ginger, sesame oil, honey, green onion.",
            Instruction = "(1) Whisk together soy sauce, garlic, ginger, and honey in a bowl. (2) Remove and set aside 1/4 cup of mixture. (3) Place salmon fillets in a shallow dish and pour marinade over top. (4) Cover and chill 5 minutes. (5) Heat sesame oil in large skillet over medium-high heat. (6) Remove fillets from marinade; discard remaining marinade. (7) Cook, skin side up, 5 minutes; turn and coat with reserved marinade. (8) Cook 5 to 7 minutes more or until fish flakes with a fork.",
            Categories = new List<Category> {
              new Category {CategoryName = "Dinner"}
            },
            Tag = new List<Tag> {
              new Tag {TagName = "Salmon"}
            }
        },

        new Recipe
        {
            RecipeName = "STICKY PORK CHOPS",
            RecipeDescription = "A mouth watering yummy pork chop Asian style.",
            Ingredient = "pork cutlets, chinese wine or sherry wine, soya sauce, ginger, chili sauce, honey.",
            Instruction = "(1) Heat frying pan over medium heat. (2) Cook meat for 2 minutes each side, or until meat is well browned. (3) Remove meat, set aside Keep warm. (4) Add cooking wine, soy sauce, ginger, chili sauce/flakes and honey to the same pan without washing the pan. (5) Cook for 3 minutes. (6) Return the meat to pan and cook on each side for 1 minute. (7) Simmer until the sauce thickens, and pork is cooked through. (8) Serve with rice and greens.",
            Categories = new List<Category> {
              new Category {CategoryName = "Dinner"}
            },
            Tag = new List<Tag> {
              new Tag {TagName = "Pork"}
            }
        },

        new Recipe
        {
            RecipeName = "COUNTRY FRIED PORK CHOPS WITH CREAM GRAVY",
            RecipeDescription = "Fried pork chop with cream gravy (not low-fat)",
            Ingredient = "pork chop, flour, salt, pepper, milk.",
            Instruction = "(1) Mix flour, salt and pepper in a plate or shallow dish. (2) Dredge pork chops in seasoned flour (reserve unused flour). (3) Heat 4 tablespoons of oil in a large skillet. (4) When hot, add the flour coated pork chops and brown on medium-high. (5) Turn and brown on the other side. (6) Add 1/4 cup water. (7) Reduce heat, cover pan and simmer for 30 minutes or until pork chops are done. (8) Remove cover, increase the heat and recrisp the chops. (9) Remove chops to a paper towel lined plate. (10) Stir up any flour crispies to loosen. (11) Add 3 to 4 tablespoons of the reserved seasoned flour to the hot oil, stirring constantly with a whisk until lightly browned. (12) Add 2 cups of milk all at once and continue stirring until thickened and bubbly. (13) Season with salt and pepper. (14) Serve pork chops with cream gravy.",
            Categories = new List<Category> {
              new Category {CategoryName = "Main Dish"}
            },
            Tag = new List<Tag> {
              new Tag {TagName = "Pork"}
            }
        },

        new Recipe
        {
            RecipeName = "BACON WRAPPED PORK CHOPS WITH BBQ SAUCE",
            RecipeDescription = "Absolutely delicious take on pork chops. The chops really benefit from the bacon, making them moist and flavorful. You can also do on the grill if you prefer.",
            Ingredient = "boneless pork chops, barbecue sauce, bacon, fresh rosemary, salt, pepper.",
            Instruction = "(1) Preheat oven to 400°F. (2) On work surface layer slices of bacon side by side. Place each chop on 2 pieces of bacon (picture 2 slices of bacon as the upright part of an H, and the pork chop as the across section). Season with salt and pepper. (3) Slather the chops with barbeque sauce. Flip the chops and slather the other side as well, until barbeque sauce is used up. (4) Lay a sprig of rosemary on each chop (letting the ends hang over the edge, for easy removal before serving). (5) Wrap bacon slices tightly around each chop. (6) Prepare broiler pan (or any roasting pan with a rack), by spraying surface with cooking spray. (7) Bake for 30 to 35 minutes until a meat thermometer inserted in thickest part of the meat should register about 150°F (8) Turn oven to broil and broil on each side until bacon is crisp. (9) Let chops rest for a few minutes. Remove rosemary sprigs before serving. (10) If desired, serve with additional warmed barbeque sauce.  ",
            Categories = new List<Category> {
              new Category {CategoryName = "Dinner"}
            },
            Tag = new List<Tag> {
              new Tag {TagName = "Pork"}
            }
        },

        new Recipe
        {
            RecipeName = "PARMESAN SAGE PORK CHOPS",
            RecipeDescription = "Parmesan sage pork chops",
            Ingredient = "breadcrumbs, parmesan cheese, dried rubbed sage, lemon rind, egg, flour, salt, pepper, butter, olive oil.",
            Instruction = "(1) preheat oven to 425F degrees. (2) Mix in bowl, bread crumbs, grated parmesan cheese, dried rubbed sage and grated lemon peel. (3) Then, on a plate put flour seasoned with salt and pepper; coat chops with flour. (4) Dip in egg (5) Then dip in bread crumb mixture. (6) Melt butter and olive oil in a oven-proof skillet. (7) Brown chops until golden. (8) Transfer to oven and bake until meat thermometer says 150 degrees, about 20 minutes.",
            Categories = new List<Category> {
              new Category {CategoryName = "Dinner"}
            },
            Tag = new List<Tag> {
              new Tag {TagName = "Pork"}
            }
        },

        new Recipe
        {
            RecipeName = "SZECHUAN NOODLES WITH SPICY BEEF SAUCE",
            RecipeDescription = "Tired of using ground beef the same old way? Try this spicy dish! Feel free to double the sauce if you like it really saucy!",
            Ingredient = "ground beef, onions, garlic, fresh ginger, dry crushed red pepper, sesame oil, cornstarch, beef broth, hoisin sauce, soy sauce, green onion.",
            Instruction = "(1) Brown ground beef in a large skillet, stirring until it crumbles; drain and keep warm. (2) Pour sesame oil in pan and heat till hot. Saute onion and next 4 ingredients hot sesame oil until tender. (3) Combine cornstarch and beef broth, whisking until smooth. (4) Stir broth mixture, hoisin sauce, and soy sauce into onion mixture. (5) Bring to a boil, stirring constantly; boil, stirring constantly, 1 minute. (6) Stir in ground beef. (7) Toss with hot cooked pasta, and sprinkle with sliced green onions.",
            Categories = new List<Category> {
              new Category {CategoryName = "Dinner"}
            },
            Tag = new List<Tag> {
              new Tag {TagName = "Ground beef"}
            }
        },

        new Recipe
        {
            RecipeName = "FRENCH ONION BURGERS",
            RecipeDescription = "Burger",
            Ingredient = "onions, worcestershire sauce, salt, ground beef, can mushrooms, hamburger buns",
            Instruction = "(1) In a bowl, combine the onions, Worcestershire sauce, salt and mushrooms if using. Crumble beef over mixture and mix well. Shape into 4 patties. (2) Grill, uncovered, over medium heat or broil 4 inches from the heat for 6-9 minutes on each side or until no longer pink. Serve on buns with any condiments and toppings of your choice.",
            Categories = new List<Category> {
              new Category {CategoryName = "Dinner"}
            },
            Tag = new List<Tag> {
              new Tag {TagName = "Ground beef"}
            }
        }
        );

        context.SaveChanges();
      }
    }
  }
}
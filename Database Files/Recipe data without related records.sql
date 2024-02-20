insert Ingredient(IngredientName)
select 'corn syrup'
union select 'rice krispies'
union select 'peanut butter'
union select 'pasta sauce'
union select 'angel hair pasta'



;with x as (
   select RecipeName = 'Peanut chews', Calorie = 320, LastName = 'rothschild', DateDrafted = '2024-01-08', DatePublished = '2024-02-15', DateArchived = null, CuisineType ='american'
   union select 'Easy Lasagna', 580, 'lowenthal', '2018-07-12', '2018-07-29', null, 'french'
   union select 'Chicken Lo Mein', 100, 'rothschild', '2020-01-03', '2021-03-01', '2023-06-08', 'Chinese'
  
)
insert Recipe(RecipeName, Calorie, StaffID, DateDrafted, DatePublished, DateArchived, CuisineID)
select x.recipeName, x.calorie, s.staffId, x.datedrafted, x.datePublished, x.dateArchived, c.cuisineID
from x 
join staff s 
on s.lastName = x.lastname
join cuisine c 
on c.cuisinetype = x.cuisineType

/*;with x as (
    select RecipName = 'peanut chews', IngredientName= 'sugar', MeasurementType='cups', RecipeSequence= 1, Amount = 1
    union select 'peanut chews', 'corn syrup', 'tbsp', 2, 2
    union select 'peanut chews', 'rice krispies', 'cups', 3, 5
    union select 'easy lasagna', 'lasagna', 'pkg', 1, 1
    union select 'easy lasagna', 'pasta sauce', 'jars', 2, 1
    union select 'easy lasagna', 'shredded cheese', 'cups', 3, 2 
    union select 'chicken lo mein', 'chicken cutlets', 'lb.', 1, 2
    union select 'chicken lo mein', 'garlic', 'tsp', 2, 3
    union select 'chicken lo mein', 'angel hair pasta', 'pkg', 3, 1
    union select 'chicken lo mein', 'soy sauce', 'jars', 4, 1
)
insert RecipeIngredient (RecipeID, IngredientID, MeasurementID, RecipeSequence, Amount)
select r.RecipeId, i.IngredientID, m.MeasurementID, x.RecipeSequence, x.Amount
from x 
join recipe r 
on x.RecipName=r.RecipeName
join Ingredient i 
on x.IngredientName=i.IngredientName
left join Measurement m 
on m.MeasurementType = x.MeasurementType

; with x as (
    select RecipeName ='peanut chews' , Direction ='mix sugar, corn syrup and peanut butter on a low flame' , DirectionSequence = 1
    union select 'peanut chews', 'pour over rice krispies', 2
    union select 'peanut chews', 'freeze until hardened', 3
    union select 'peanut chews', 'defrost half an hour before serving', 4
    union select 'easy lasagna', 'lay  the lasagna out in a 9x13 pan, in layers of three', 1
    union select 'easy lasagna', 'spread sauce on each layer', 2
    union select 'easy lasagna', 'sprinkle cheese on top', 3
    union select 'easy lasagna', 'bake on 350 for 1/2 hour', 4
    union select 'chicken lo mein', 'cook pasta', 1
    union select 'chicken lo mein', 'on a low flame, saute the chicken with garlic and soy sauce', 2
    union select 'chicken lo mein', 'mix the pasta into the chicken mixture', 3
)
INSERT RecipeDirection (RecipeID, Direction, DirectionSequence)
select r.RecipeId, x.Direction, x.DirectionSequence
from x
join Recipe r
on x.RecipeName = r.RecipeName*/
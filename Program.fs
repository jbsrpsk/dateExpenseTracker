type Cuisine =
    | Korean
    | Turkish
type MovieType =
    | Regular
    | IMAX
    | DBOX
    | RegularWithSnacks
    | IMAXWithSnacks
    | DBOXWithSnacks
type Genre =
    | Action
    | Comedy
    | Drama
    | SciFi

type Activity =
    | BoardGame
    | Chill
    | Movie of Genre
    | Restaurant of Cuisine
    | LongDrive of int * float


let calculateBudget (activity: Activity) =
    match activity with
    | BoardGame | Chill -> 0.0
    | Movie genre ->
        match genre with
        | Action | Comedy | Drama -> 12.0
        | SciFi -> 17.0
    | Restaurant cuisine ->
        match cuisine with
        | Korean -> 70.0
        | Turkish -> 65.0
    | LongDrive (kilometers, fuelCharge) -> float kilometers * fuelCharge

let calculateTotalBudget activities =
    activities
    |> List.sumBy calculateBudget

let printTotalBudget totalBudget =
    printfn "Budget for the day: %.2f CAD" totalBudget

let activities = [BoardGame; Movie Action; Restaurant Korean; LongDrive (100, 0.12)]
let totalBudget = calculateTotalBudget activities
printTotalBudget totalBudget
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
    | Movie of Genre * MovieType 
    | Restaurant of Cuisine
    | LongDrive of int * float

let calculateBudget (activity: Activity) =
    match activity with
    | BoardGame | Chill -> 0.0
    | Movie (genre, movieType) ->
        match genre with
        | Action | Comedy | Drama -> 12.0
        | SciFi ->
            match movieType with
            | Regular -> 12.0
            | IMAX -> 17.0
            | DBOX -> 20.0
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

let activities = [BoardGame; Movie (Comedy, IMAX); Restaurant Turkish; LongDrive (200, 0.42)]
let totalBudget = calculateTotalBudget activities
printTotalBudget totalBudget

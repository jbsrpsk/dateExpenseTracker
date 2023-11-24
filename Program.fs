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
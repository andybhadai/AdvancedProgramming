open System

// Basic function

let greet (message: string) (name: string) =
    printf "%s %s" message name

let greeting = greet "Welcome to our application, " "Andy"

let greater (a : int) (b : int) = 
    a > b

let simpleDisplayCharacter (phrase : string) =
    for p in phrase do
        Console.WriteLine(p)
    

let greaterOrSmaller = 
    if greater 4 2 then
        printf "It is greater"
    else
        printf "It is smaller"

let name = simpleDisplayCharacter "Hallo, dit is een zin"
 
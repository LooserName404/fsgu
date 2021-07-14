open System
open Classes

[<EntryPoint>]
let main argv =
    let namePrompt = ConsolePrompt("Please enter your name", 3)
    let name = namePrompt.GetValue()
    let colorPrompt = ConsolePrompt("Please enter your favorite color", 1)
    let color = colorPrompt.GetValue()
    
    let person = Person(name, color)
    printfn "%s" (person.Description()) 
    0
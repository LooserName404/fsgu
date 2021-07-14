open System

let sayHello person =
    printfn "Hello %s from my F# program!" person

let isValid person =
    String.IsNullOrWhiteSpace person |> not

[<EntryPoint>]
let main argv =
    argv
    |> Array.filter isValid
    |> Array.iter sayHello

    printfn "Nice to meet you."
    0

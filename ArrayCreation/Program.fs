open System

module MathSequence =
    let pell =
        {| N = 0; Pn2 = 0; Pn1 = 0 |}
        |> Seq.unfold
            (fun values ->
                let n = values.N
                let pn2 = values.Pn2
                let pn1 = values.Pn1

                let pn =
                    match n with
                    | 0
                    | 1 -> n
                    | _ -> 2 * pn1 + pn2

                let n' = n + 1
                Some(pn, {| N = n'; Pn2 = pn1; Pn1 = pn |}))

[<EntryPoint>]
let main argv =

    let total =
        Seq.init
            1000
            (fun i ->
                let x = i + 1
                x * x)
        |> Seq.sum

    printfn "The total is: %i" total

    MathSequence.pell
    |> Seq.truncate 10
    |> Seq.iter (fun x -> printf "%i, " x)

    0

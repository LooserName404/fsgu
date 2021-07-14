namespace StudentScores


module Summary =
    open System.IO

    let printGroupSummary (surname: string) (students: Student []) =
        printfn "%s" (surname.ToUpperInvariant())

        students
        |> Array.sortBy (fun student -> student.GivenName)
        |> Array.iter
            (fun student ->
                printfn
                    "	%20s	%s	%0.2f	%0.2f	%0.2f"
                    student.GivenName
                    student.Id
                    student.MeanScore
                    student.MinScore
                    student.MaxScore)


    let summarize schoolCodesFilePath filePath =
        let rows = File.ReadLines filePath |> Seq.cache
        let studentCount = (rows |> Seq.length) - 1
        printfn "Student count: %i" studentCount
        let schoolCodes = SchoolCodes.load schoolCodesFilePath
        rows
        |> Seq.skip 1
        |> Seq.map (Student.fromString schoolCodes)
        |> Seq.sortBy (fun student -> student.MeanScore)
        |> Seq.iter Student.printSummary

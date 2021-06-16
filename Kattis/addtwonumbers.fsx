open System

let s = Console.ReadLine()
let sum =  s.Split " "
            |> Seq.map int
            |> Seq.fold (+) 0
printfn "%d" sum


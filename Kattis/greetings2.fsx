open System

let s = Console.ReadLine()
printfn "%s" ("h" + String.replicate ((s.Length-2)*2) "e" + "y")

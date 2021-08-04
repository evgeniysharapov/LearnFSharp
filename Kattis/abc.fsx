open System

(*
    takes array of numbers and string of letters and then it spits out string of numbers
    arranged according to the order of letters 
*)
let arrange (nums : int[]) (abc: string) =
    let sorted = Map.ofSeq (Seq.zip [|'A'; 'B'; 'C'|]  (Array.sort nums))
    abc.ToCharArray() |> 
        Array.map ( fun c -> string (Map.find c sorted) ) |> 
        Seq.ofArray |> 
        (String.concat " " )

let numString = Console.ReadLine()
let letterString = Console.ReadLine()
let nums = numString.Split(" ") |> Array.map int
let result = arrange nums letterString
printfn "%s" result


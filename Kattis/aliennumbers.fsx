open System
let mutable continueLooping = true 

//
//  Converts any number N written in system LANG into a decimal one
//
//  1000 01 = 1*2^3 + 0*2^2 + 0*2 + 0*1
// 
let convToDec (n:string) (lang:string) = 
    let numbase = lang.Length
    let sz = n.Length - 1
    let tbl = Seq.toList lang |> Seq.mapi (fun i x -> x,i ) |> Map.ofSeq 
    let mutable res = 0;
    for i, c in (Seq.toList n |> Seq.indexed) do
        res <- res + (Map.find c tbl) * (pown numbase (sz - i)) 
    res

let convFromDec (n:int) (lang:string) = 
    let numbase = lang.Length
    let tbl = Seq.toList lang |> Seq.indexed |> Map.ofSeq
    let mutable res = List.empty
    let mutable left = n
    while left > 0 do
        let q,r = left / numbase, left % numbase
        res <- (Map.find r tbl) :: res
        left <- q
    res |> Seq.map string |> (String.concat "")

// while continueLooping do
//     let s = Console.ReadLine()
//     if s = "" then
//         continueLooping <- false
//     else 
//         printfn "asdf"
    
// Console.WriteLine (convToDec "a" "0123456789abcdef")
Console.WriteLine (convFromDec 2373 "01")

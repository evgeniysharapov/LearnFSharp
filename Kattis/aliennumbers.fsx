open System

let mutable continueLooping = true 

//
//    1000 01 = 1*2^3 + 0*2^2 + 0*2 + 0*1
// 
let convToDec (n:string) (lang:string) = 
    let tbl = Seq.toList lang |> Seq.mapi (fun i x -> x,i ) |> Map.ofSeq 
    let mutable res = 0;
    for i, c in (Seq.toList n |> Seq.indexed) do
        (Map.find c tbl) 


let convFromDec n lang

while continueLooping do
    let s = Console.ReadLine()
    if s = "" then
        continueLooping <- false
    else 
        printfn "asdf"
    
open System

let strIntTbl (lang:string) =
    if lang = "oF8" then
        Map.ofArray [| ("F", 1); ("8", 2); ("Fo", 3); ("FF", 4); ("F8", 5); ("8o", 6); ("8F", 7); ("88", 8); ("Foo", 9); ("FoF", 10) |]    
    else
        Seq.toList lang 
            |> Seq.map string 
            |> Seq.mapi (fun i x -> x,i ) 
            |> Map.ofSeq

let intStrTbl (lang:string) =
    let tbl = strIntTbl lang
    Map.toSeq tbl
        |> Seq.map (fun (i,s) -> s,i)
        |> Map.ofSeq
//
//  Converts any number N written in system LANG into a decimal one
//
//  1000 01 = 1*2^3 + 0*2^2 + 0*2 + 0*1
// 
let convToDec (n:string) (lang:string) = 
    let tbl = strIntTbl lang
    if lang = "oF8" then
        Map.find n tbl
    else
        let numbase = lang.Length
        let sz = n.Length - 1
        Seq.toList n 
        |> Seq.map string
        |> Seq.indexed 
        |> Seq.fold (fun res (i,s)  -> res + (Map.find s tbl) * (pown numbase (sz - i))) 0

let convFromDec (n:int) (lang:string) = 
    let tbl = intStrTbl lang
    if lang = "oF8" then 
        Map.find n tbl
    else
        let numbase = lang.Length
        let mutable res = List.empty
        let mutable left = n
        while left > 0 do
            let q,r = left / numbase, left % numbase
            res <- (Map.find r tbl) :: res
            left <- q
        res |> Seq.map string |> (String.concat "")


// Ok, let's solve the cases
[<EntryPoint>]
let main argv =
    let T = Console.ReadLine() |> int
    for i = 1 to T do
        let s = Console.ReadLine()
        if s = "" then 
            exit 0
        else 
            let arr = s.Split(" ")
            let c = convFromDec (convToDec arr.[0] arr.[1]) arr.[2]
            printfn "Case #%d: %s" i c
    0

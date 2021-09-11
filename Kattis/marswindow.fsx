open System


// Number of months since Apr 2018 divides over 26
let y = Console.ReadLine() |> int
if y = 2018 then
    printfn "yes"
    exit 0
let ys = y - 2018 - 1
let jan = ys * 12 + 8
let dec = ys * 12 + 20
// it's yest when n*26 falls between jan and dec
// printfn "jan %d; dec %d" jan dec
if jan % 26 > dec % 26 then
    printfn "yes"
 else
    printfn "no"
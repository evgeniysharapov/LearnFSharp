[<AutoOpen>]
module M 
type Tree<'T> =
    | Node of Tree<'T> * 'T * Tree<'T>
    | Leaf of 'T

let l = Leaf 1
let r = Leaf 2

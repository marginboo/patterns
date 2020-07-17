#if !INTERACTIVE
module Patterns
#endif
type Cell =
| Black of char  
| White of char
| Unknown of char

let toCells v = 
    let b = Seq.toList v
    let rec vells d lst = 
        match d with 
        |[] -> lst
        |a::rest -> 2 //change to list of cells
    vells b 2 // calls the recursive function

failwith "Not implemented"

let fromCells v = failwith "Not implemented" 

let patternMatch pattern cells = failwith "Not implemented"

let find pattern cells = failwith "Not implemented"

let map func pattern cells = failwith "Not implemented"
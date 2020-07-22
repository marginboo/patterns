#if !INTERACTIVE
module Patterns
#endif
type Cell =
| Black   
| White 
| Unknown 

type Pattern = 
| BlackP 
| WhiteP
| UnknownP
| ZeroOrMore of Pattern
| OneOrMore of  Pattern
| Exactly of (int * Pattern)
| FewerThan of (int * Pattern)
| Sequence of Pattern list  
| Either of (Pattern * Pattern)
| Anything 
| EndOfCells 

let mam a = match a with 
            | 'b' | 'B' -> Black
            | 'w' | 'W' -> White
            | _  -> Unknown

let toCells v = 
    let b = Seq.toList v  
    let rec vells d lst = 
        match d with 
        |[] -> lst
        |a::rest ->  vells rest ( lst @ [mam a]) //change to list of cells
    vells b  [] // calls the recursive function

    //failwith "Not implemented"

let fromCells v =
    let rec fells b lst = 
        match b with 
        |[] -> lst
        |a::rest -> fells rest (lst + string (match a with 
                                              | Black  -> 'b'
                                              | White -> 'w'
                                              | Unknown -> '.' ))
    fells v ""
    //failwith "Not implemented" 

let patternMatch pattern cells = 
    // tail recursion with 
    failwith "Not implemented"

let find pattern cells =
    // tail recursive function that finds the first occurence of sumting 
    failwith "Not implemented"

let map func pattern cells = 
    // 
    failwith "Not implemented"
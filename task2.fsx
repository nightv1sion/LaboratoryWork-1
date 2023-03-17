let replace list pred  = 
    list
    |> List.map(pred)

let printResult result = printfn "result is %A" result


let resultOfReplaceZero = replace [0; 2; 3; 4; 0] (fun x -> if x = 0 then x + 1 else x)

printResult resultOfReplaceZero

let resultOfReplaceOdd = replace [1;2;3;4;5;6] (fun x -> if x % 2 = 1 then x * 2 else x)

printResult resultOfReplaceOdd

let resultOfReplaceEven = replace [1;3;5;7] (fun x -> if x % 2 = 0 then x / 2 else x)

printResult resultOfReplaceEven

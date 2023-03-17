let countTargetInList target list = 
    list 
    |> List.filter(fun x -> x = target)
    |> List.length

let printResult x = printfn "result is %d" x

let resultOfTwoTargetLetters = countTargetInList 'a' ['a'; 'b'; 'c'; 'a']
printResult resultOfTwoTargetLetters

let resultOfZeroTargetLetters = countTargetInList 'b' ['a';'c'; 'd']
printResult resultOfZeroTargetLetters

let resultOfZeroTargetLettersInEmptyList = countTargetInList 'a' []
printResult resultOfZeroTargetLettersInEmptyList

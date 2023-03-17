let rec cycle item times = 
    if times = 1
    then item
    elif times < 1
    then []
    else List.append (cycle item (times - 1)) item

let printResult list = printfn "result is %A" list

let resultOfCycleThreeTimes = (cycle ["a"] 5)

printResult resultOfCycleThreeTimes

let resultOfCycleThreeLettersThreeTimes = (cycle ["a"; "b"; "c"] 3)
printResult resultOfCycleThreeLettersThreeTimes

let resultOfCycleZeroTimes =(cycle [""] 0)
printResult resultOfCycleZeroTimes
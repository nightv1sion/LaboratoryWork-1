let replicate x times = 
    if times <= 0
    then []
    else x |> List.replicate times

let printResult result = printfn "result is %A" result

let resultOfReplicationFiveTimes = replicate "a" 5

printResult resultOfReplicationFiveTimes

let resultOfReplicationThreeTimes = replicate ["a"; "b"; "c"] 3

printResult resultOfReplicationThreeTimes

let resultOfReplicationZeroTimes = replicate "" 0

printResult resultOfReplicationZeroTimes
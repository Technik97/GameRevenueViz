open Revenue
open ReadData

[<EntryPoint>]
let main argv =
    loadCSVFile ()
    |> Option.map barData
    |> Option.map createBar
    |> ignore

    0

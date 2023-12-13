open ReadData
open Revenue
open Games

[<EntryPoint>]
let main argv =
    loadCSVFile ()
    |> Option.map barData
    |> Option.map createBar
    |> ignore

    loadCSVFile ()
    |> Option.map pieData
    |> Option.map createPie
    |> ignore

    0

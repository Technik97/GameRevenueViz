open ReadData
open Revenue
open Games

let showCharts data createChart =      
    loadCSVFile ()      
    |> Option.map data     
    |> Option.map createChart     
    |> ignore

[<EntryPoint>]
let main argv =
    showCharts barData createBar
    showCharts pieData createPie

    0

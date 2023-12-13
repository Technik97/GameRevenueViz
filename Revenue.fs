module Revenue

open FSharp.Data
open XPlot.Plotly

open ReadData

let barData (rawCSV: RawCSV) = 
    // Selecting top 20 games
    let games= rawCSV.Rows
                |> Seq.toList
                |> List.take 20

    Bar(
        x = [for game in games -> game.Game],
        y = [for game in games -> game.Revenue]
    )


let createBar (data: Bar) =
    data
    |> Chart.Plot
    |> Chart.WithOptions
        (Options(title = "Game Revenues"))
    |> Chart.WithXTitle("Games")
    |> Chart.WithYTitle("Revenue (Billion $)")
    |> Chart.WithHeight 1200
    |> Chart.WithWidth 3000 
    |> Chart.Show


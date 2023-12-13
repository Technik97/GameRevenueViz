module Games

open FSharp.Data
open XPlot.Plotly

open ReadData

let pieData (rawCSV: RawCSV) = 
    let games = rawCSV.Rows |> Seq.toList

    let genres = games 
                                |> List.map(fun x -> x.``Genre(s)``)
                                |> List.distinct
                                |> List.take 10 

    let data = genres
               |> List.map(fun x -> (x, x.Length))
               |> List.toSeq

    data |> Chart.Pie

let createPie (data: PlotlyChart) = 
    data
    |> Chart.WithHeight 700
    |> Chart.WithWidth 1500
    |> Chart.WithLegend true
    |> Chart.Show


            
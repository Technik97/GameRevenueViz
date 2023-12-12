module ReadData

open FSharp.Data
open XPlot.Plotly

[<Literal>]
let filePath = __SOURCE_DIRECTORY__ + """/data/mobile-games.csv"""

type RawCSV = CsvProvider<filePath, HasHeaders = true>

let loadCSVFile () = 
    try 
        let cSVFile = RawCSV.GetSample()
        let cSVFile = Some(cSVFile)
        cSVFile
    with _ -> None

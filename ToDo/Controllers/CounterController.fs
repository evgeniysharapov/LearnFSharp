namespace ToDo.Controllers

open Amazon.DynamoDB

type private CounterEntry = {
     [<HashKey>]
     Id : Guid
     Value : int64 
}

[<ApiController>]
[<Route("[controller]")>]
type CounterController (logger : ILogger<CounterController>) =
    inherit ControllerBase()

    [<HttpPost>]
    member _.Post() =
        let table = TableContext.Create<CounterEntry>(client, tableName = "workItems", createIfNotExists = true)
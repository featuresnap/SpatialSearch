module SpatialSearch.Tests

open SpatialSearch
open NUnit.Framework

[<Test>]
let ``encloses`` () =
  let result = Library.hello 42
  printfn "%i" result
  Assert.AreEqual(42,result)



// See https://aka.ms/new-console-template for more information


using iLINQ.LinqSample;

LinqOperators linqOperators = new LinqOperators();

//LINQ Operations : --------------------------------
//linqOperators.PrintNameWithoutLinq();
//linqOperators.PrintNameWithLinqQuery();
//linqOperators.PrintNameWithLinqMethod();
//linqOperators.PrintNumbersDiferred();
//linqOperators.PrintNumbersImmediate();

//Filter : -----------------------------------------
//linqOperators.FilterStudentsQuery();
//linqOperators.FilterStudentsMethod();

//Filter by Type : ---------------------------------
//linqOperators.FilterByType();

//Sort : -------------------------------------------
//linqOperators.SortStudents();
//linqOperators.SortDescStudents();
//linqOperators.SortGradeAndNameStudents();

//Grouping : ---------------------------------------
//linqOperators.GroupStudents();

//Joins and Set Operations : -----------------------
//linqOperators.InnerJoin();
//linqOperators.GroupJoin();
//linqOperators.LeftJoin();
//linqOperators.Distinct();
//linqOperators.Union();
//linqOperators.Except();
//linqOperators.Intersect();
//linqOperators.UnionBy();
//linqOperators.DistinctBy();
//linqOperators.IntersectBy();
//linqOperators.ExceptBy();
//linqOperators.Zip();

//Pagination : -------------------------------------
//linqOperators.Pagination(0, 3);
//linqOperators.Pagination(1, 3);
//linqOperators.Pagination(2, 3);
//linqOperators.Pagination(3, 3);
//linqOperators.Pagination(4, 3);
//-----------------------------

//Chunk : ------------------------------------------
//linqOperators.Chunk();

//Aggregate Functions : ----------------------------
//linqOperators.AggregateFunctions();

//Generators : -------------------------------------
linqOperators.Generators();
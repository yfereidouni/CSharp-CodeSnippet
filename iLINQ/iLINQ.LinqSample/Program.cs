// See https://aka.ms/new-console-template for more information


using iLINQ.LinqSample;

LinqOperators linqOperators = new LinqOperators();

//linqOperators.PrintNameWithoutLinq();

//linqOperators.PrintNameWithLinqQuery();

//linqOperators.PrintNameWithLinqMethod();

//linqOperators.PrintNumbersDiferred();

//linqOperators.PrintNumbersImmediate();

//Filter : --------------------------------------

//linqOperators.FilterStudentsQuery();

//linqOperators.FilterStudentsMethod();

//Filter by Type : -----------------------------
linqOperators.FilterByType();

//Sort : ----------------------------------------
//linqOperators.SortStudents();
//linqOperators.SortDescStudents();
linqOperators.SortGradeAndNameStudents();

//Grouping : ------------------------------------



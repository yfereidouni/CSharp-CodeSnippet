using iEFCore.S24.E15.Interceptors;

InterceptorsDbContext ctx = new InterceptorsDbContext();
PersonRepository personRepository = new PersonRepository(ctx);

//personRepository.ExecuteTagedQuery();
personRepository.AddStudent("Using Interceptors");
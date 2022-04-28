using iEFCore.S24.E11.FromSQLInterpolated;

FromSQLInterpolatedDbContext ctx = new  FromSQLInterpolatedDbContext();
TeacherRepository teacherRepository = new TeacherRepository(ctx);

//Read from SQL
teacherRepository.FromSqlSample();

//Write to SQL
teacherRepository.InsertPersonRaw();

//Read-Only Query
teacherRepository.FromSqlQueryNews();

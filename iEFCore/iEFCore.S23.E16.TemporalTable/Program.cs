using iEFCore.S23.E16.TemporalTable;


TemporalTableDbContext ctx = new TemporalTableDbContext();
PersonTemporalRepository personTemporalRepository = new PersonTemporalRepository(ctx);

//personTemporalRepository.AddPerson("Yasser", "Fereidouni"); 
//personTemporalRepository.AddPerson("Alireza", "Oroumand");
//personTemporalRepository.AddPerson("Shervin", "Souri");

//personTemporalRepository.EditPerson(2, "Alireza V1", "Oroumand V2");
//personTemporalRepository.DeletePerson(3);

personTemporalRepository.PrintAllHistory();


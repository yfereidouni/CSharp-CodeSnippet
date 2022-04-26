using iEFCore.S24.E05.SettingTheEntityState;

SettingTheEntityStateDbContext ctx = new SettingTheEntityStateDbContext();

PersonRepository personRepository = new PersonRepository(ctx);

personRepository.SetEntityState(1, "Yasser", "Fereidouni");
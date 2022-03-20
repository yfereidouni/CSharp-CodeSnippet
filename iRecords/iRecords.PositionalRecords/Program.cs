// See https://aka.ms/new-console-template for more information

using iRecords.PositionalRecords;

PersonPositionalRecord01 ppr01 = new PersonPositionalRecord01()
{
    Id = 1,
    FirstName = "Yasser",
    LastName = "Fereidouni"
};

PersonPositionalRecord02 ppr02 = new PersonPositionalRecord02(1, "Yasser", "Fereidouni");

PersonPositionalRecord02 ppr02cc = ppr02 with { Id = 2 };


PersonPositionalRecord03 ppr03 = new PersonPositionalRecord03(1, "Yasser", "Fereidouni");

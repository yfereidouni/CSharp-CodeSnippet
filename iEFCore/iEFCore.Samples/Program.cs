// See https://aka.ms/new-console-template for more information

using iEFCore.Samples.Models;


PersonRepository personRepository = new PersonRepository();

/// Add Person ----------------------------------------------------
//personRepository.AddPerson("Yasser", "Fereidouni");
//personRepository.AddPerson("Majid", "Eslahi");
//personRepository.AddPerson("Farid","Taheri");
//personRepository.AddPerson("Soroush", "Sarabi");
//personRepository.AddPerson("Shervin", "Souri");

/// Update Person -------------------------------------------------
//personRepository.UpdatePerson(2, "Yousef", "Teymouri");

/// Delete Person -------------------------------------------------
personRepository.DeletePerson(id: 5);

/// Pople List ----------------------------------------------------
personRepository.PrintPeople();

using iEFCore.S24.E09.ChangeTrackerDebugView;

ChangeTrackerDebugViewDbContext ctx = new ChangeTrackerDebugViewDbContext();
TeacherRepository teacherRepository = new TeacherRepository(ctx);

//teacherRepository.UpdateTeacher(1, "Yasser v4", "Fereidouni v4");

teacherRepository.ShowChangeTrackerDebugView();
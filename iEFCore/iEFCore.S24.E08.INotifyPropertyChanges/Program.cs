using iEFCore.S24.E08.INotifyPropertyChanges;

INotifyPropertyChangesDbContext ctx = new INotifyPropertyChangesDbContext();
TeacherRepository teacherRepository = new TeacherRepository(ctx);
teacherRepository.UpdateTeacher(1, "Soroush v3", "Sarabi v3");

teacherRepository.ShowChangeTrackerDebugView();
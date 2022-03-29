// See https://aka.ms/new-console-template for more information

using iCollections.GenericStringList;

ListSample ls = new ListSample();

ls.PrintCapacity();
ls.AddMember("Yasser");
ls.PrintCapacity();
//ls.Ensure();
ls.Trim();
ls.PrintCapacity();

ls.AddMember("Shervin");
ls.AddMember("Soroush");
//ls.AddMember("Majid");
//ls.AddMember("Kazem");

ls.PrintCapacity();
ls.Trim();
ls.PrintCapacity();

ls.Ensure();
ls.PrintCapacity();

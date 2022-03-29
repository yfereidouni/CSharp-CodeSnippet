// See https://aka.ms/new-console-template for more information

using iCollections.GenericStringList;

ListSample ls = new ListSample();

ls.CountAndCapacity();
ls.AddMember("Yasser");
ls.CountAndCapacity();
//ls.Ensure();
ls.Trim();
ls.CountAndCapacity();

ls.AddMember("Shervin");
ls.AddMember("Soroush");
//ls.AddMember("Majid");
//ls.AddMember("Kazem");

ls.CountAndCapacity();
ls.Trim();
ls.CountAndCapacity();

ls.Ensure();
ls.CountAndCapacity();

//You can just read the items. Changes is not possible.
var readOnlyList = ls.GetReadOnly();

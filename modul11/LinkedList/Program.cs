using LinkedList;

User kristian = new User("Kristian", 1);
User mads = new User("Mads", 2);
User torill = new User("Torill", 3);
User kell = new User("Kell", 4);
User henrik = new User("Henrik", 5);
User klaus = new User("Klaus", 6);

UserLinkedList list = new UserLinkedList();
list.AddFirst(kristian);
list.AddFirst(mads);
list.AddFirst(torill);
list.AddFirst(henrik);
list.AddFirst(klaus);

// AddSorted metoden er implementeret i UserLinkedList.cs og bruges i forbindelse med opgave 4 SortedUserLinkedList
/*list.AddSorted(kristian);
list.AddSorted(mads);
list.AddSorted(torill);
list.AddSorted(henrik);
list.AddSorted(klaus);*/


Console.WriteLine(list.CountUsers());
Console.WriteLine(list);

list.RemoveUser(mads);
list.RemoveFirst();

Console.WriteLine(list.CountUsers());
Console.WriteLine(list);

Console.WriteLine(list.Contains(torill));
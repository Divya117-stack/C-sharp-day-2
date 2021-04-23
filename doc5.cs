using System;
public struct Person
{
    public string Name {get; set;}
    public Person(string _name)
    {
    Name = _name;
     }
}
public struct Dog
{
    public string Breed {get; set;}
    public Dog(string _breed)
    {
    Breed = _breed;
     }
}
class program
{
   public static void showvalue(object o)
   {
       if(o is Person p)
       {
           Console.WriteLine(p.Name);
       }
        else if(o is Dog d)
       {
           Console.WriteLine(d.Breed);
       }
   }
  static void Main ()
  {
    object o = new Person ("divya");
      showvalue (o);
      o = new Dog ("husky");
      showvalue(o);
      Console.ReadLine();
  }


}
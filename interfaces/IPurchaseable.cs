namespace BlockBuster.Interfaces
{
  public interface IPurchaseable
  {
    decimal Price { get; }
    void Purchase();
  }
}



//IDevelopers 

//WebDeveloper : IDeveloper
//JavascriptDeveloper : IDeveloper
//JavaDeveloper : IDeveloper
//C#Developer : IDeveloper
//KotlinDeveloper : IDeveloper


//Manager
//Go to each IDeveloper and invoke develop() method


//class Person

// class D$ : Person, ICarpenter, IDeveloper, IMechanic, ILogger, IConstruction
// class Justin: Person, IConstruction, IDeveloper
// class Jake: Person


// list of developers
// List<Ideveloper> => Justin, D$
// List<IConstruction> => 

// interface IVehicle
// void Move();

// class Car : IVehicle
// public void move()
// {
// start engine and drive on land 
// }

// class Boat : IVehicle
// public void move()
// {
// start outboard motor and propel through water 
// }


// class Plane : IVehicle
// public void move()
// {
// start dual prop engines, generate lift and pull self through air 
// }

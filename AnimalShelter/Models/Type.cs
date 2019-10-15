// using System.Collections.Generic;

// namespace AnimalShelter.Models
// {
//   public class Type
//   {
//     private static List<Type> _instances = new List<Type> { };
//     public string AnimalType { get; set; }
//     public int Id { get; }
//     public List<Animal> Animals { get; set; }

//     public Type(string animalType)
//     {
//       AnimalType = animalType;
//       _instances.Add(this);
//       Id = _instances.Count;
//       Animals = new List<Animal> { };
//     }

//     public static void ClearAll()
//     {
//       _instances.Clear();
//     }

//     public static List<Type> GetAll()
//     {
//       return _instances;
//     }

//     public static Type Find(int searchId)
//     {
//       return _instances[searchId - 1];
//     }


//     public void AddAnimal(Animal animal)
//     {
//       Animals.Add(animal);
//     }
//   }
// }
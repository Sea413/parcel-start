namespace Parcel.Objects
{
  public class ParcelVariables
  {
    public int width  { get; set; }
    public int length {get; set;}
    public int height { get; set; }
    public int weight { get; set; }
    public int distance { get; set;}


  }
  public class ParcelReturn
  {
    public int volume {get; set;}
    public int price {get; set;}
  }
}
// public class List
// {
//     public static void Main()
//     {
//         // Create a list of parts.
//         List<Car> Cars = new List<Car>();
//
//         // Add parts to the list.
//         Cars.Add(new Car() {PartName="crank arm", PartId=1234});
//         parts.Add(new Part() { PartName = "chain ring", PartId = 1334 });
//         parts.Add(new Part() { PartName = "regular seat", PartId = 1434 });
//          parts.Add(new Part() { PartName = "banana seat", PartId = 1444 });
//         parts.Add(new Part() { PartName = "cassette", PartId = 1534 });
//         parts.Add(new Part() { PartName = "shift lever", PartId = 1634 }); ;
//
//         // Write out the parts in the list. This will call the overridden ToString method
//         // in the Part class.
//         Console.WriteLine();
//         foreach (Part aPart in parts)
//         {
//             Console.WriteLine(aPart);
//         }

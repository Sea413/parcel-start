using Nancy;
using Parcel.Objects;

namespace Parcel
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
    {
    return View["parcel_form.html"];
    };
    Get["/parcel_cost"] = _ =>
    {
      ParcelVariables myParcelVariables = new ParcelVariables
      {
        width = Request.Query["width"],
        length = Request.Query["length"],
        height = Request.Query["height"],
        weight = Request.Query["weight"],
        distance = Request.Query["distance"],
    };

    int newVolume = myParcelVariables.width*myParcelVariables.height*myParcelVariables.length;
    int newPrice = newVolume*myParcelVariables.weight*myParcelVariables.distance;

    ParcelReturn myParcelReturn = new ParcelReturn
    {
      volume = newVolume,
      price = newPrice,
    };
      return View["parcel_cost.html", myParcelReturn];
    };
  }
}
}

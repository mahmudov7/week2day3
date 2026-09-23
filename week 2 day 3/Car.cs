public class Car : Product
{
  public int Maxspeed { get; set; }
  public string model { get; set; }

  public Car() { }
  public Car(string n, double pr, int mxspeed, string ml) : base(n, pr)
  {
    Maxspeed = mxspeed;
    model = ml;
  }

}
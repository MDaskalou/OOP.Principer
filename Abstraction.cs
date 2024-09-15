namespace OOPBasic
{
    public abstract class Snow
    {
      public abstract void Weather();

    }

    public class  Rain : Snow
    {
        public override void Weather()
        {
            Console.WriteLine("It is raining");
        }
    }
}

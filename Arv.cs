
namespace OOPBasic
{
  public class Summer : Season
    {
        public string Activity;

        public new void Describe()
        {
            Console.WriteLine( $"Season: {Name}, Weather: {Weather}, Temperature: {Temperature}, Activity: {Activity}");
        }

    };
    
      

       
    
}

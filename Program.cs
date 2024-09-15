namespace OOPBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var season1 = new Season();
            season1.Name = "Seasons";
            season1.Weather = "4 different seasons";
            season1.Temperature = "From -10 to 35 ";
            season1.Describe();

            var summer = new Season();
            summer.Name = "Summer";
            summer.Weather = "Hot";
            summer.Temperature = "From 20 to 35";
            summer.Activity = "Swimming";
            summer.Describe();

            var winter = new Season();
            winter.Name = "Winter";
            winter.Weather = "Cold";
            winter.Temperature = "From -10 to 10";
            winter.Activity = "Skiing";
            winter.Describe();



            var spring = new Season();
            spring.Name = "EasterTime";
            
            var rain = new Rain();
            rain.Weather();

        }
    }

    public class Season
    {
        public string Name;
        public string Weather;
        public string Temperature;
        public string Activity;

        public virtual void Describe()
        {
            Console.WriteLine($"Season: {Name}, Weather: {Weather}, Temperature: {Temperature}, Activity: {Activity}");
        }
    }
}

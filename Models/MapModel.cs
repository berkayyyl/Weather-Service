namespace WeatherApplication.Models
{
    public class Root
    {
        public List<Feature> features { get; set; }
    }

    public class Feature
    {
        public List<double> center { get; set; }
    }
}

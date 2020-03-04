namespace Weather.Models
{
    public class Weather
    {
        public int Id { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public string IconURL
        {
            get
            {
                return "http://openweathermap.org/img/wn/" + Icon + "@2x.png";
            }
        }
    }
}

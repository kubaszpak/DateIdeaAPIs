namespace JakubSzpakLab6___DateIdeaAPIs.Models
{
    public class Location
    {
        /// <summary>
        /// Identyfikator miejsca
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nazwa losowego wskazanego obiektu
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Miasto
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Opis danego miejsca
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Długość geograficzna danego miejsca
        /// </summary>
        public double Longitude { get; set; }

        /// <summary>
        /// Szerokość geograficzna danego miejsca
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// Link do strony w Google Maps przeznaczonej danemu miejscu
        /// </summary>
        public string GoogleMapsLink { get; set; }
    }
}

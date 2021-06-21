namespace JakubSzpakLab6___DateIdeaAPIs.Models
{
    public class Cartoon
    {
        /// <summary>
        /// Identyfikator bajki
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nazwa bajki
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Zmienna określająca czy bajka jest animowana
        /// </summary>
        public bool IsAnimated { get; set; }

        /// <summary>
        /// Link do piosenki otwierającej show
        /// </summary>
        public string LinkToOpeningTheme { get; set; }

        /// <summary>
        /// Liczba odcinków umożliwiająca wylosowanie jednego
        /// </summary>
        public int NumberOfEpisodes { get; set; }
    }
}

namespace SpeakingInBits.Models
{
    public class Course
    {
        /// <summary>
        /// Primary key for the course
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The title of the course displayed to the user
        /// </summary>
        public required string Title { get; set; }

        /// <summary>
        /// The description of the course displayed to the user
        /// </summary>
        public required string Description { get; set; }

        /// <summary>
        /// The lessons that belong to the course
        /// </summary>
        public ICollection<Lesson> Lessons { get; set; } = [];
    }
}

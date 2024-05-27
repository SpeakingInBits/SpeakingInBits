namespace SpeakingInBits.Models
{
    public class Lesson
    {
        /// <summary>
        /// Primary key for the lesson
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The title of the lesson displayed to the user
        /// </summary>
        public required string Title { get; set; }

        /// <summary>
        /// The description of the lesson displayed to the user
        /// </summary>
        public required string Description { get; set; }

        /// <summary>
        /// The course that the lesson belongs to
        /// </summary>
        public required Course Course { get; set; }

        /// <summary>
        /// The foreign key for the course that the lesson belongs to
        /// </summary>
        public int CourseId { get; internal set; }
    }

    public class VideoLesson : Lesson
    {
        /// <summary>
        /// The embed code of the video
        /// </summary>
        public required string VideoEmbedCode { get; set; }

        /// <summary>
        /// Duration of the video in minutes
        /// </summary>
        public int Duration { get; set; }
    }
}

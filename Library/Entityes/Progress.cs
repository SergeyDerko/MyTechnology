using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library
{
    /// <summary>
    /// Успеваемость студента
    /// </summary>
    public class Progress
    {
        [Key]
        [ForeignKey("Student")]
        public int Id { get; set; }
        public int BallSum { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace Library
{
    /// <summary>
    /// Описание студента
    /// </summary>
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public virtual Progress Progress { get; set; }
        public virtual Group Group { get; set; }
    }
}
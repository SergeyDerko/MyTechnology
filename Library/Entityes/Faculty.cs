using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library
{
    /// <summary>
    /// Факультеты для групп
    /// </summary>
    public class Faculty
    {
        [Key]
        public int Id { get; set; }
        public string  FacultyName { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
    }
}
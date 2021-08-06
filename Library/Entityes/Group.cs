using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library
{
    /// <summary>
    /// Группа студентов
    /// </summary>
    public class Group
    {
        [Key]
        public int Id { get; set; }
        public string NameGroup { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual Faculty Faculty { get; set; }


    }
}
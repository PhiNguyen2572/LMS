using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.Models
{
        [Table("Users")]
        public class Users
        {
            [Key]
            public int id { set; get; }

            [StringLength(100)]
            public string username { set; get; }

            [StringLength(100)]
            public string password { set; get; }

        }
}

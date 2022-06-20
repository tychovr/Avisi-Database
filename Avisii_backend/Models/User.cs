using System.ComponentModel.DataAnnotations;

namespace Avisi_backend.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }

    }
}

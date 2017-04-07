using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectManagementSystemDatabase.Entities
{
    public class Project
    {
        [Key]
        [MaxLength(12)]
        public string Code { get; set; }

        [MaxLength(15)]
        public string ShortName { get; set; }

        [MaxLength(120)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

    }
}

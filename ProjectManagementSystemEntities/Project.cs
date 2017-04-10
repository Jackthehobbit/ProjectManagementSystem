using System.ComponentModel.DataAnnotations;

namespace ProjectManagementSystemEntities
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

        public Project()
        {

        }

        public Project(string parCode,string parShortName,string parName,string parDescription)
        {
            Code = parCode;
            ShortName = parShortName;
            Name = parName;
            Description = parDescription;

        }

    }
}

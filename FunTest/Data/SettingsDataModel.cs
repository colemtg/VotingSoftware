using System.ComponentModel.DataAnnotations;

namespace VotingSoftware
{
    /// <summary>
    /// settings database table representational model
    /// </summary>

    public class SettingsDataModel
    {
        /// <summary>
        /// unique id
        /// </summary>
        [Key]
        public string Identifier { get; set; }
        /// <summary>
        /// settings name
        /// </summary>
        [Required]
        [MaxLength(1024)]
        public string Name { set; get; }
        /// <summary>
        /// setting value
        /// </summary>
        [Required]
        [MaxLength(512)]
        public string Value { set; get; }
    }
}

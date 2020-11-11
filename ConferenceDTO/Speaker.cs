using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConferenceDTO
{
    public class Speaker
    {
        
        public int Id { get; set; }
        /// <summary>
        /// Speaker's name
        /// </summary>
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        /// <summary>
        /// Speaker's bio
        /// </summary>
        [StringLength(4000)]
        public string Bio { get; set; }
        /// <summary>
        /// Speaker's web site
        /// </summary>
        [StringLength(1000)]
        public virtual string WebSite { get; set; }
    }
}

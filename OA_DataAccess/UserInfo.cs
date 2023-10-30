using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_DataAccess
{
    public class UserInfo
    {
        [Key]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(maximumLength: 50, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 2)]
        public string? UserId { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(maximumLength: 50, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 2)]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(maximumLength: 50, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 2)]
        public string? UserEmail { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(maximumLength: 50, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 2)]
        public string? Password { get; set; }
        [StringLength(maximumLength: 50, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 2)]
        public string? UserDetails { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(maximumLength: 10, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 2)]
        public string? UserStatus { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [StringLength(maximumLength: 200, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 1)]
        public string? PasswordHash { get; set; } 

    }
    public class UserPost 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? PostId { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public string? UserId { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(maximumLength: 200, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 2)]
        public string? PostType { get; set; }
        [StringLength(maximumLength: 200, ErrorMessage = "{0} length is between {2} and {1}", MinimumLength = 1)]
        public string? PostDetails { get; set; }
        public int ReactionCount { get; set; }
        public DateTime PostDate { get; set; }=DateTime.Now;

        //Foreign Key
        [ForeignKey("UserId")]
        public virtual UserInfo? UserInfo { get; set; }
        public virtual List<UserPostContent> UserPostContent { get; set; }

    }
    public class UserPostContent 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? PosContentId { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        public string? UserId { get; set; }
        public byte[]? FileData { get; set; }
        public string? PostId { get; set; }

        //Foreign Key
        [ForeignKey("PostId")]
        public virtual UserPost? UserPost { get; set; }

    }
    public class UserFollowers 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? Id { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public string? UserId { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        public string? FollwingUserId { get; set; }

    }
}

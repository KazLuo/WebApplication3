using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Member
    {
        [Key]
        [Display(Name = "編號")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0}必填")]
        [MaxLength(50)]
        [Display(Name = "帳號")]
        public string Account { get; set; }

        //[Display(Name = "單位")]
        //public int OrgId { get; set; }
        //[JsonIgnore]//不會產生無限迴圈
        //[ForeignKey("OrgId")]
        //[Display(Name = "所屬單位")]
        //public virtual Org MyOrg { get; set; }//virtual=虛擬資料，會跟資料庫的對應資料相對應

        //[Required]
        //[MaxLength(6)]
        //public string Salt { get; set; }

        [Required(ErrorMessage = "{0}必填")]
        [StringLength(100, ErrorMessage = "{0} 長度至少必須為 {2} 個字元。", MinimumLength = 4)]
        [DataType(DataType.Password)]
        [Display(Name = "密碼")]
        public string Password { get; set; }


        [Required(ErrorMessage = "{0}必填")]
        [MaxLength(50)]
        [Display(Name = "姓名")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0}必填")]
        [EmailAddress(ErrorMessage = "{0} 格式錯誤")]
        [MaxLength(200)]
        //[DataType(DataType.EmailAddress)]//未來版本會有衝突，建議不用寫
        [Display(Name = "E-Mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0}必填")]
        [MaxLength(50)]
        [Display(Name = "電話")]
        public string Telphone { get; set; }

        [Required(ErrorMessage = "{0}必填")]
        [MaxLength(50)]
        [Display(Name = "手機")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "{0}必填")]
        [MaxLength(100)]
        [Display(Name = "地址")]
        public string Address { get; set; }

        [MaxLength(100)]
        [Display(Name = "權限")]
        public string Permission { get; set; }

        //[Display(Name = "性別")]
        //public GenderType Gender { set; get; }//使用列舉型別

    //    [NotMapped]//不會進到資料庫儲存，是動態生成
    //    [Display(Name = "別稱")]
    //    public string GenderString
    //    {
    //        get
    //        {
    //            switch (Gender)
    //            {
    //                case GenderType.女:
    //                    return "正妹";
    //                case GenderType.男:
    //                    return "肥宅";
    //                case GenderType.其他:
    //                    return "其他人";
    //                default:
    //                    return null;
    //            }
    //        }
    //    }

    //    [Display(Name = "所屬社團")]
    //    [JsonIgnore]
    //    public virtual ICollection<Club> Clubs { get; set; }
    }
}
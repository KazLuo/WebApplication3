using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Org
    {
        [Key]//主鍵PK
        [Display(Name = "編號")]//呈現欄位的名稱
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//識別規格
        public int Id { get; set; }

        //[Required(ErrorMessage = "{0}必填")]//必填，驗證畫面呈現單位名稱必填
        [Required]//必填
        [MaxLength(100)]//=nvarchar(100)；沒寫=nvarchar(max)
        [Display(Name = "單位名稱")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0}必填")]
        [Display(Name = "發佈時間")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]//進行編輯操作時能夠看到適當格式的日期時間
        [DataType(DataType.DateTime)]//送出時驗證是不是時間格式
        public DateTime InitDate { get; set; }
    }
}
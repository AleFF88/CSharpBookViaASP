using System.ComponentModel.DataAnnotations;

namespace CSharpBookViaASP.Models {

    public class AboutModel {
        [Required (ErrorMessage = "You need input something.")]
        [Display(Name = "Input description.")]
        [StringLength(6,ErrorMessage ="Text should be more then 6 symbols.")]
        public string Description { get; set; }
    }
}

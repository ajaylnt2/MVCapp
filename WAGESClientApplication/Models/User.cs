using System.ComponentModel.DataAnnotations;

namespace WAGESClientApplication.Models
{
    public class User
    {
        #region public properties
        [Required(ErrorMessage ="User Name Required")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Password Required")]
        public string email { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string country { get; set; }
        public string Error { get; set; }
        public string Password { get; set; }
        public bool checkUser (string UserName,string email)
        {
            bool flag = false;
            return flag;
        }

        #endregion
    }
}
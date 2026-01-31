using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalManagementSystem.Pages
{
    public class LoginModel : PageModel
    {
        public string Message { get; set; } = "";

        public void OnGet()
        {
        }

        public void OnPost()
        {
            string username = Request.Form["username"];
            string password = Request.Form["password"];

            if (username == "admin" && password == "1234")
            {
                Message = "Login Successful";
            }
            else
            {
                Message = "Invalid Login";
            }
        }
    }
}

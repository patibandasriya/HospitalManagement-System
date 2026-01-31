using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalManagementSystem.Pages
{
    public class PatientModel : PageModel
    {
        public string StatusMessage { get; set; } = "";

        public void OnGet()
        {
        }

        public void OnPost()
        {
            StatusMessage = "Patient Registered Successfully!";
        }
    }
}

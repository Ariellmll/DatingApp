using Microsoft.AspNetCore.Http;

namespace DatingApp.API.Helpers
{
    public static class Extensions
    {
        public static void AddAplicationError(this HttpResponse reponse, string message)
        {
            reponse.Headers.Add("Aplication-Error", message);
            reponse.Headers.Add("Access-Control-Expose-Headers", "Aplication-Error");
            reponse.Headers.Add("Access-ControlAllow-Origin", "*");
        }
    }
}
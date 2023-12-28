using Microsoft.AspNetCore.Identity;
using ReportAPI.Interface;

namespace ReportAPI.DAL.Implementation
{
    public class AppImplementation : IAppImplementation
    {
        public AppImplementation()
        {
        }
        public string GetReports()
        {
            try
            {
                var result = "worked";
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

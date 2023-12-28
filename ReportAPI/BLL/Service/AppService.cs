using ReportAPI.Interface;

namespace ReportAPI.BLL.Service
{
    public class AppService : IAppService
    {
        private readonly IAppImplementation _appImp;

        public AppService( IAppImplementation appImp)
        {
            this._appImp = appImp;
        }

        public string GetReports()
        {
            var result = _appImp.GetReports();
            return result;
        }
    }
}

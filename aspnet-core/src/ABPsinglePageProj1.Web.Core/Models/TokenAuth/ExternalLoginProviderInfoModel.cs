using Abp.AutoMapper;
using ABPsinglePageProj1.Authentication.External;

namespace ABPsinglePageProj1.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}

using Microsoft.Extensions.Options;
using WebApplication1.Settings;

namespace WebApplication1.App.GetValueSingleton
{
    public class GetValueIOptions : IGetValueIOptions
    {
        private readonly SettingOptions _settingOptions;
        public GetValueIOptions(IOptions<SettingOptions> settingOptions)
        {
            _settingOptions = settingOptions.Value;
        }
        public object GetValue()
        {
            return _settingOptions;
        }
    }
}

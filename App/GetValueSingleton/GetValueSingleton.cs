using WebApplication1.Settings;

namespace WebApplication1.App.GetValueSingleton
{
    public class GetValueSingleton : IGetValueSingleton
    {
        private readonly SettingSingleton _settingSingleton;
        public GetValueSingleton(SettingSingleton settingSingleton)
        {
            _settingSingleton = settingSingleton;
        }
        public object GetValue()
        {
            return _settingSingleton;
        }
    }
}

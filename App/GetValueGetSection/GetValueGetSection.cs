namespace WebApplication1.App.GetValueGetSection
{
    public class GetValueGetSection : IGetValueGetSection
    {
        private readonly IConfiguration _configuration;
        public GetValueGetSection(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public object GetValue()
        {
            return new { 
                Nome = _configuration.GetSection("SettingGetSection:Nome").Value,
                Telefone = _configuration.GetSection("SettingGetSection:Telefone").Value,
                Rua = _configuration.GetSection("SettingGetSection:Rua").Value,
                Idade = _configuration.GetSection("SettingGetSection:Idade").Value
            };
        }
    }
}

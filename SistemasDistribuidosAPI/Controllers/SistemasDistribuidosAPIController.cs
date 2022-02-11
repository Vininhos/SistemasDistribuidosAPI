using Microsoft.AspNetCore.Mvc;
using SistemasDistribuidosAPI.Model;

namespace SistemasDistribuidosAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class SistemasDistribuidosAPIController : ControllerBase
    {
        private readonly ILogger<SistemasDistribuidosAPIController> _logger;

        public SistemasDistribuidosAPIController(ILogger<SistemasDistribuidosAPIController> logger)
        {
            _logger = logger;
        }

        [HttpPost("Tempo/DiasParaHorasViceVersa", Name = "DaysToHoursViceVersa")]
        public string DaysToHoursViceVersa(Weather weather)
        {
            if (weather.ReturnType == 0)
                return $"{weather.Days * 24} hora(s).";

            return $"{weather.Hours / 24} dia(s).";
        }

        [HttpPost("Tempo/HorasParaMinutosViceVersa", Name = "HoursToMinutesViceVersa")]
        public string HoursToMinutesViceVersa(Weather weather)
        {
            if (weather.ReturnType == 0)
                return $"{weather.Hours * 60} minuto(s).";

            return $"{weather.Minutes / 60} hora(s).";
        }

        [HttpPost("Área/AcresParaHectaresViceVersa", Name = "AcresToHectaresViceVersa")]
        public string AcresToHectaresViceVersa(Area area)
        {
            if (area.ReturnType == 0)
                return $"{area.Acres / 2.471} hectare(s).";

            return $"{area.Hectares * 2.471} acre(s).";
        }

        [HttpPost("Velocidade/MilhasParaKilometrosViceVersa", Name = "MilesToKilometersViceVersa")]
        public string MilesToKilometersViceVersa(Velocity velocity)
        {
            if (velocity.ReturnType == 0)
                return $"{velocity.Miles * 1.609} kilometros(s).";

            return $"{velocity.Kilometers / 1.609} milhas(s).";
        }

        [HttpPost("Massa/ToneladasParaKilogramasViceVersa", Name = "TonsToKilogramsViceVersa")]
        public string TonsToKilogramsViceVersa(Mass mass)
        {
            if (mass.ReturnType == 0)
                return $"{mass.Tons * 1000} kilograma(s).";

            return $"{mass.Kilograms / 1000} tonelada(s).";
        }

        [HttpPost("Massa/LibrasParaKilogramasViceVersa", Name = "PoundsToKilogramsViceVersa")]
        public string PoundsToKilogramsViceVersa(Mass mass)
        {
            if (mass.ReturnType == 0)
                return $"{mass.Pounds / 2.205} kilograma(s).";

            return $"{mass.Kilograms * 2.205} libras(s).";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApptTempoAgora.Models;
using MetalPerformanceShaders;

namespace MauiApptTempoAgora.Services
{
    public class DataService
    {
        public static async Task<Tempo?> GetPrevisao(string cidade)
        {
            Tempo? t = null;

            string chave = $"https://api.openweathermap.org"
        }
    }
}

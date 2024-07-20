using BusinessObject.Dto;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IWatercolorsPaintingRepository
    {
        Task<IEnumerable<WatercolorsPaintingResponseDto>> GetWatercolorsPaintings();
        Task<WatercolorsPaintingResponseDto> GetWatercolorsPaintingId(string id);
        Task<bool> AddWatercolorsPainting(WatercolorsPaintingDto watercolorsPaintingDto);
        Task<bool> UpdateWatercolorsPainting(string id, WatercolorsPaintingDto watercolorsPaintingDto);
        Task<bool> DeleteWatercolorsPainting(string id);
    }
}

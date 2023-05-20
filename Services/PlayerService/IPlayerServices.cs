
namespace Catolog.Services.PlayerService;

public interface IPlayerServices
{
    Task<ServiceResponse<GetPlayerDto>> GetPlayerById(int id);
    Task<ServiceResponse<List<GetPlayerDto>>> GetAllPlayers();

    Task<ServiceResponse<GetPlayerDto>> UpdatePlayerScore(UpdatePlayerScoreDto updatePlayer);

    Task<ServiceResponse<List<GetPlayerDto>>> CreatePlayer(CreatePlayerDto createPlayer);

    Task<ServiceResponse<List<GetPlayerDto>>> DeletePlayer(int id);
}
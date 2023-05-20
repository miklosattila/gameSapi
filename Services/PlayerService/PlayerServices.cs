global using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catolog.Data;
using Microsoft.EntityFrameworkCore;

namespace Catolog.Services.PlayerService
{
    public class PlayerServices : IPlayerServices
    {
        private static List<Player> players = new()
        {
            new Player {

                Id=1,
                Name="Player1",
                Age=0,
                CreatedDate=DateTimeOffset.UtcNow,
                ExitDate=DateTimeOffset.UtcNow,

            },
            new Player {

                Id=2,
                Name="Player2",
                Age=2,
                CreatedDate=DateTimeOffset.UtcNow,
                ExitDate=DateTimeOffset.UtcNow,

            },
            new Player {

                Id=3,
                Name="Player3",
                Age=3,
                CreatedDate=DateTimeOffset.UtcNow,
                ExitDate=DateTimeOffset.UtcNow,

            },
        };
        
        private readonly IMapper _mapper;

        public DataContext _context;
       
        public PlayerServices(IMapper mapper, DataContext context)
        {
            _context = context;
            _mapper=mapper;
        }

        public async Task<ServiceResponse<List<GetPlayerDto>>> CreatePlayer(CreatePlayerDto createPlayer)
        {
            var serviceResponse = new ServiceResponse<List<GetPlayerDto>>();
            var player = _mapper.Map<Player>(createPlayer);
            _context.Players.Add(player);
            await _context.SaveChangesAsync();

             serviceResponse.Data =
                await _context.Players
                    .Select(c => _mapper.Map<GetPlayerDto>(c))
                    .ToListAsync();
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetPlayerDto>>> DeletePlayer(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetPlayerDto>>();
            try
            {
                
               
                var player = players.FirstOrDefault(c => c.Id == id);
                if(player is null)
                    throw new Exception($"Player with Id '{id}' not found.");

                players.Remove(player);
                serviceResponse.Data=players.Select(c => _mapper.Map<GetPlayerDto>(c)).ToList();
   
            }
            catch (Exception ex){
                serviceResponse.Success=false;
                serviceResponse.Message=ex.Message;
            }
            

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetPlayerDto>>> GetAllPlayers()
        {
            var serviceResponse = new ServiceResponse<List<GetPlayerDto>>();

            var dbPlayers = await _context.Players.ToListAsync();
            serviceResponse.Data=dbPlayers.Select(c => _mapper.Map<GetPlayerDto>(c)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetPlayerDto>> GetPlayerById(int id)
        {
            var serviceResponse = new ServiceResponse<GetPlayerDto>();
            var player = players.FirstOrDefault(c => c.Id == id);
            var dbPlayer = await _context.Players.FirstOrDefaultAsync(c => c.Id == id);
            if(dbPlayer is not null){
                serviceResponse.Data = _mapper.Map<GetPlayerDto>(dbPlayer);
                return serviceResponse;
                }
            serviceResponse.Success=false;
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetPlayerDto>> UpdatePlayerScore(UpdatePlayerScoreDto updatePlayerScoreDto)
        {
            var serviceResponse = new ServiceResponse<GetPlayerDto>();
            try
            {
                
               
                var player = players.FirstOrDefault(c => c.Id == updatePlayerScoreDto.Id);
                if(player is null)
                    throw new Exception($"Player with Id '{updatePlayerScoreDto.Id}' not found.");

                // _mapper.Map(updatePlayerScoreDto,player);
                player.GameScore=updatePlayerScoreDto.GameScore;
                player.QuizScore=updatePlayerScoreDto.QuizScore;

                serviceResponse.Data= _mapper.Map<GetPlayerDto>(player);   
            }
            catch (Exception ex){
                serviceResponse.Success=false;
                serviceResponse.Message=ex.Message;
            }
            

            return serviceResponse;
        }
    }
}
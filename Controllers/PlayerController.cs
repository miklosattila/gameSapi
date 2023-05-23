using Microsoft.AspNetCore.Mvc;
using Catolog.Services.PlayerService;
using Catolog.Models;

namespace Catolog.Controllers;



    [ApiController]
    [Route("player/")]
    public class PlayerController : ControllerBase{
        private readonly IPlayerServices _playerServices;

        public PlayerController(IPlayerServices playerServices)
        {
            _playerServices= playerServices;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetPlayerDto>>>> GetAllPlayers()
        {
            
            return Ok(await _playerServices.GetAllPlayers());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetPlayerDto>>> GetPlayer(int id)
        {
           
            return Ok( await _playerServices.GetPlayerById(id));

        }
        // [HttpPut]
        // public async Task<ActionResult<ServiceResponse<List<GetPlayerDto>>>> CreatePlayer(CreatePlayerDto createPlayer){

        //     return Ok( await _playerServices.CreatePlayer(createPlayer));
        // }
        [HttpPut]
        public async Task<ActionResult> UpdatePlayerScore(UpdatePlayerScoreDto playerScoreDto){

            var response = await _playerServices.UpdatePlayerScore(playerScoreDto);
            if( response.Data is null){
                return NotFound(response);
            }
            return Ok(response);

        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePlayer(int id){

            var response = await _playerServices.DeletePlayer(id);
            if( response.Data is null){
                return NotFound(response);
            }
            return Ok(response);

        }

    }   


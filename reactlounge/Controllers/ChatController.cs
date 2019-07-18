using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autino.Lounge.Services.Interfaces;
using Autino.Lounge.Services.Models.Booking;
using AutinoConnect.Shared.Model.Chat;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace reactlounge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        public ChatController(IChatService chatService)
        {
            _chatService = chatService;
        }
        [HttpGet]
        public async  Task<ChatHistoryResponseModel> Get(string authHash)
        {
            return await  _chatService.GetChatHistory(authHash);
        }
        [HttpGet("[action]")]
        public async Task<ActionResult> ChatSend(string authHash, string message)
        {
         
                await _chatService.SendChat(authHash,  message);
            return Ok();


        }

        private readonly IChatService _chatService;
    }
}
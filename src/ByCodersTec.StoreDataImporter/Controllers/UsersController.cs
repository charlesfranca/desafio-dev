using ByCodersTec.StoreDataImporter.CQRS.Queries;
using ByCodersTec.StoreDataImporter.Domain;
using ByCodersTec.StoreDataImporter.Entities;
using ByCodersTec.StoreDataImporter.Services.Interfaces;
using ByCodersTec.StoreDataImporter.ViewModel;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ByCodersTec.StoreDataImporter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;
        readonly IUserService _userService;
        readonly IMessageService _messageService;
        private readonly IMediator _mediator;
        public UsersController(
            ILogger<UsersController> logger,
            IUserService userService,
            IMessageService messageService,
            IMediator mediator
        )
        {
            _logger = logger;
            _userService = userService;
            _messageService = messageService;
            _mediator = mediator;
        }

        [HttpGet("")]
        public async Task<ApiResponse<List<UserViewModel>>> GetUsers()
        {
            _logger.LogWarning("UsersController Get - this is a nice message to test the logs", DateTime.UtcNow);

            var response = await _mediator.Send(new GetUsersQuery());
            return ApiResponse<List<UserViewModel>>.CreateResponse(response);
        }

        [HttpGet("{id}")]
        public ApiResponse<UserViewModel> GetUser(Guid id)
        {
            var user = _userService.GetUser(new Services.Message.GetUserRequest { Id = id }).user;
            return ApiResponse<UserViewModel>.CreateResponse(user);
        }
    }
}
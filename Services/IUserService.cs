﻿using tiki_shop.Models.Common;
using tiki_shop.Models.DTO;
using tiki_shop.Models.Request;

namespace tiki_shop.Services
{
    public interface IUserService
    {
        Task<Result<bool>> AddUser(UserRequest userRequest);
        Task<ResultList<UserDTO>> GetAllUsers();
        Task<Result<string>> Login(string phoneNumber, string password);
    }
}

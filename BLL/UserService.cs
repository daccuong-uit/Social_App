using BLL;
using DAL.DataAccess;
using Models;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System;

public class UserService
{
    private readonly UserRepository _userRepository;
    private readonly ProfileRepository _profileRepository;

    // Constructor to initialize the repositories and email service
    public UserService()
    {
        _userRepository = new UserRepository();
        _profileRepository = new ProfileRepository();
    }

    public async Task RegisterUserAsync(User user, Profile profile)
    {
        // Validate input data
        if (string.IsNullOrWhiteSpace(user.EmailAddress) || string.IsNullOrWhiteSpace(user.Password))
            throw new ArgumentException("Email và mật khẩu không được để trống.");

        // Validate email format
        if (!IsValidEmail(user.EmailAddress))
            throw new ArgumentException("Email không hợp lệ.");

        // Check if the user already exists
        if (await _userRepository.ValidateUserAsync(user.EmailAddress, user.Password))
            throw new InvalidOperationException("Người dùng đã tồn tại.");

        // Add user
        string userId = await _userRepository.AddUserAsync(user);
        profile.UserId = int.Parse(userId); // Assign UserId to profile

        // Add profile for user
        await _profileRepository.AddProfileAsync(profile);
    }

    public async Task<bool> LoginUserAsync(string email, string password)
    {
        // Validate input data
        if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            throw new ArgumentException("Email và mật khẩu không được để trống.");

        // Authenticate user
        return await _userRepository.ValidateUserAsync(email, password);
    }

    private bool IsValidEmail(string email)
    {
        // Basic email format validation
        var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return Regex.IsMatch(email, emailPattern);
    }

    // Additional methods like UpdateUserAsync, GetUserProfileAsync, etc.
}
using DAL.Helpers;
using Models;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DAL.DataAccess
{
    public class UserRepository
    {
        private readonly string _connectionString;

        public UserRepository()
        {
            _connectionString = DatabaseConfig.ConnectionString;
        }

        public async Task<string> AddUserAsync(User user)
        {
            const string query = @"
                INSERT INTO Users (email_address, phone_number, first_name, last_name, password, created_datetime, updated_datetime) 
                OUTPUT INSERTED.ID 
                VALUES (@Email, @Phone, @FirstName, @LastName, @Password, @CreatedAt, @UpdatedAt)";

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Email", user.EmailAddress);
                command.Parameters.AddWithValue("@Phone", user.PhoneNumber);
                command.Parameters.AddWithValue("@FirstName", user.FirstName);
                command.Parameters.AddWithValue("@LastName", user.LastName);
                command.Parameters.AddWithValue("@Password", PasswordHelper.HashPassword(user.Password));
                command.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                command.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);

                await connection.OpenAsync();
                object result = await command.ExecuteScalarAsync();
                return result?.ToString(); // Return the ID of the newly added user
            }
        }

        public async Task<bool> ValidateUserAsync(string email, string password)
        {
            const string query = @"
                SELECT COUNT(*) 
                FROM Users 
                WHERE email_address = @Email AND password = @Password";

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", PasswordHelper.HashPassword(password));

                await connection.OpenAsync();
                int count = (int)await command.ExecuteScalarAsync();
                return count > 0; // Return true if the user exists
            }
        }

        // Additional methods like UpdateUser, DeleteUser, GetUserById...
    }
}
using Models;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DAL.DataAccess
{
    public class ProfileRepository
    {
        private readonly string _connectionString;

        public ProfileRepository()
        {
            _connectionString = DatabaseConfig.ConnectionString;
        }

        public async Task AddProfileAsync(Profile profile)
        {
            const string query = @"
                INSERT INTO Profiles (user_id, first_name, last_name, date_of_birth, gender, country, avatar_photo, cover_photo, bio) 
                VALUES (@UserId, @FirstName, @LastName, @DateOfBirth, @Gender, @Country, @AvatarPhoto, @CoverPhoto, @Bio)";

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserId", profile.UserId);
                command.Parameters.AddWithValue("@FirstName", profile.FirstName);
                command.Parameters.AddWithValue("@LastName", profile.LastName);
                command.Parameters.AddWithValue("@DateOfBirth", (object)profile.DateOfBirth ?? DBNull.Value);
                command.Parameters.AddWithValue("@Gender", profile.Gender);
                command.Parameters.AddWithValue("@Country", profile.Country);
                command.Parameters.AddWithValue("@AvatarPhoto", (object)profile.AvatarPhoto ?? DBNull.Value);
                command.Parameters.AddWithValue("@CoverPhoto", (object)profile.CoverPhoto ?? DBNull.Value);
                command.Parameters.AddWithValue("@Bio", (object)profile.Bio ?? DBNull.Value);

                await connection.OpenAsync();
                await command.ExecuteNonQueryAsync(); // Execute the insert command
            }
        }

        // Additional methods like UpdateProfileAsync, DeleteProfileAsync, GetProfileByUserIdAsync...
    }
}
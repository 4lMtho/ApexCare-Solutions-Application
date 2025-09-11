using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ApexCareApp.Control
{
    public class FileHandler
    {
        private readonly string filePath;

        public FileHandler()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            filePath = Path.Combine(baseDirectory, "Data", "users.txt");
        }

        public string GetRoleIfLoginValid(string username, string password)
        {
            try
            {
                // Check if the file exists
                if (!File.Exists(filePath))
                    throw new FileNotFoundException("User data file not found.");

                // Read all lines from the file
                var lines = File.ReadAllLines(filePath);

                // Search for a matching username, password, and role combination
                foreach (var line in lines)
                {
                    var credentials = line.Split(',');

                    // Ensure the line has username, password, and role
                    if (credentials.Length == 3)
                    {
                        var storedUsername = credentials[0].Trim();
                        var storedPassword = credentials[1].Trim();
                        var storedRole = credentials[2].Trim();

                        if (storedUsername == username && storedPassword == password)
                        {
                            return storedRole; // Return the role if login is valid
                        }
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                // Handle any potential errors (file not found, etc.)
                Console.WriteLine($"Error reading file: {ex.Message}");
                return null;
            }
        }
    }
}

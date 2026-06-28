using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        private string connectionString = "Server=DESKTOP-0HPTUPS;Database=wending;Trusted_Connection=True";
        public static string CurrentToken { get; set; }

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string surname = textBox1.Text.Trim();
            string role = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM users WHERE surname=@surname AND role=@role";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@surname", surname);
                    command.Parameters.AddWithValue("@role", role);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        string user_role = reader["role"].ToString();
                        CurrentToken = JwtManager.GenerateToken(surname, role);
                        this.Hide();

                        switch (user_role.ToLower())
                        {
                            case "mechanic":
                                Form7 form7 = new Form7();
                                form7.Show();
                                break;

                            case "operator":
                                Form8 form8 = new Form8();
                                form8.Show();
                                break;

                            case "analyst":
                                Form6 form6 = new Form6();
                                form6.Show();
                                break;

                            case "merchandiser":
                                Form2 form2 = new Form2();
                                form2.Show();
                                break;

                            default:
                                Form1 form1 = new Form1();
                                form1.Show();
                                break;
                        }

                        MessageBox.Show($"Welcome {surname}", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public static class JwtManager
    {
        private static readonly string key = "wending_app_super_secret_key_2024_123456789";
        private static readonly string Issuer = "WendingApp";
        private static readonly string Audience = "WendingAppUsers";

        public static string GenerateToken(string surname, string role)
        {
            var securitykey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(securitykey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, surname),
                new Claim(ClaimTypes.Role, role),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
            var token = new JwtSecurityToken(
                issuer: Issuer,
                audience: Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddHours(8),
                signingCredentials: credentials
                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public static bool ValidateToken(string token, out ClaimsPrincipal principal)
        {
            principal = null;
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var validationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key)),
                    ValidateIssuer = true,
                    ValidIssuer = Issuer,
                    ValidateAudience = true,
                    ValidAudience = Audience,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero
                };

                principal = tokenHandler.ValidateToken(token, validationParameters, out _);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static (string surname, string role) GetUserInformationToken(string token)
        {
            if (ValidateToken(token, out ClaimsPrincipal principal))
            {
                string surname = principal.FindFirst(ClaimTypes.Name)?.Value;
                string role = principal.FindFirst(ClaimTypes.Role)?.Value;
                return (surname, role);
            }
            return (null, null);
        }
    }

    public static class AppState
    {
        public static string CurrentToken { get; set; }
        public static string CurrentUser { get; set; }
        public static string CurrentRole { get; set; }

        public static bool IsTokenValid()
        {
            if (string.IsNullOrEmpty(CurrentToken))
            {
                return false;
            }
            return JwtManager.ValidateToken(CurrentToken, out _);
        }

        public static (string surname, string role) GetUserInfoFromToken()
        {
            return JwtManager.GetUserInformationToken(CurrentToken);
        }
    }
}
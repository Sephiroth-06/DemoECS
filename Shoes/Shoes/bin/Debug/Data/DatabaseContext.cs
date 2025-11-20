using System.Data.SQLite;
using Shoes.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace Shoes.Data
{
    public class DatabaseContext
    {
        private string connectionString;

        public DatabaseContext()
        {
            // Правильный путь к БД
            string dbPath = Path.Combine("Data", "Directory", "Shoes.sqbpro");
            connectionString = $"Data Source={dbPath};Version=3;";

            // Проверяем что файл существует
            if (!File.Exists(dbPath))
            {
                throw new FileNotFoundException($"Файл БД не найден: {dbPath}");
            }
        }

        public SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        public User AuthenticateUser(string login, string password)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = @"
                    SELECT u.*, r.Name as RoleName 
                    FROM Users u 
                    JOIN Roles r ON u.RoleId = r.Id 
                    WHERE u.Login = @login AND u.Password = @password";

                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                Id = reader.GetInt32(0),
                                FullName = reader.GetString(1),
                                Login = reader.GetString(2),
                                Password = reader.GetString(3),
                                RoleId = reader.GetInt32(4),
                                Role = new Role { Name = reader.GetString(5) }
                            };
                        }
                    }
                }
            }
            return null;
        }

        public List<Product> GetAllProducts()
        {
            var products = new List<Product>();
            using (var connection = GetConnection())
            {
                connection.Open();
                string query = @"
                    SELECT p.Article, p.Name, p.Unit, p.Price, p.Discount, p.StockQuantity, 
                           p.Description, p.ImagePath,
                           c.Name as CategoryName,
                           s.Name as SupplierName,
                           m.Name as ManufacturerName
                    FROM Products p
                    LEFT JOIN Categories c ON p.CategoryId = c.Id
                    LEFT JOIN Suppliers s ON p.SupplierId = s.Id
                    LEFT JOIN Manufacturers m ON p.ManufacturerId = m.Id";

                using (var cmd = new SQLiteCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new Product
                        {
                            Article = reader.GetString(0),
                            Name = reader.GetString(1),
                            Unit = reader.GetString(2),
                            Price = reader.GetDecimal(3),
                            Discount = reader.GetInt32(4),
                            StockQuantity = reader.GetInt32(5),
                            Description = reader.IsDBNull(6) ? "" : reader.GetString(6),
                            ImagePath = reader.IsDBNull(7) ? "" : reader.GetString(7),
                            Category = new Category { Name = reader.GetString(8) },
                            Supplier = new Supplier { Name = reader.GetString(9) },
                            Manufacturer = new Manufacturer { Name = reader.GetString(10) }
                        });
                    }
                }
            }
            return products;
        }
    }
}
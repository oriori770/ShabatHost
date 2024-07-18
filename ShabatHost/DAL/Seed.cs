using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShabatHost.DAL
{
    internal class Seed
    {
        private DBContext _dbContext;
        public Seed(DBContext dBContext)
        {
            _dbContext = dBContext;
        }
        public void EnsureTablesAndSeedData()
        {
            string sqlScript = @"USE Shabat;
        GO

        DECLARE @TableCreated INT = 0;

        BEGIN TRANSACTION;

        BEGIN TRY
			IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Guests' AND type = 'U')
            BEGIN
				CREATE TABLE Guests (
					ID INT PRIMARY KEY IDENTITY,
					Name NVARCHAR(15) NOT NULL UNIQUE,
				);

				INSERT INTO Guests (Name)
					VALUES 
					('Alice'),
					('Bob'),
					('Charlie');
                SET @TableCreated += 1; -- add 1 to indicate that the table was created				
			END
			IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Categories' AND type = 'U')
            BEGIN
                CREATE TABLE Categories (
					ID INT PRIMARY KEY IDENTITY,
					Name NVARCHAR(15) NOT NULL UNIQUE,
				);	
				INSERT INTO Categories (Name)
					VALUES 
					('Fruit'),
					('Vegetable'),
					('Dessert');
                SET @TableCreated += 1; -- add 1 to indicate that the table was created
            END
            IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Food' AND type = 'U')
            BEGIN
                CREATE TABLE Food (
					ID INT PRIMARY KEY IDENTITY,
					GuestID int FOREIGN KEY REFERENCES Guests(ID),
					CategoryID int FOREIGN KEY REFERENCES Categories(ID),
					Name NVARCHAR(15),
					CONSTRAINT UC_Food UNIQUE (GuestID,CategoryID, Name),
				);
				INSERT INTO Food (GuestID, CategoryID, Name)
					VALUES 
					(1, 1, 'Apple'),
					(2, 2, 'Carrot'),
					(3, 3, 'Cake'),
					(1, 2, 'Spinach'),
					(2, 3, 'Ice Cream'),
					(3, 1, 'Banana');
                SET @TableCreated += 1; -- add 1 to indicate that the table was created
            END
            COMMIT TRANSACTION;
        END TRY
        BEGIN CATCH

            ROLLBACK TRANSACTION;
            SET @TableCreated = 0; -- Set to 0 to indicate an error or that the table was not created
        END CATCH
        SELECT @TableCreated AS IsCreated;";
            _dbContext.ExecuteNonQuery(sqlScript, null);
            DataTable result = _dbContext.ExecuteQuery("SELECT COUNT(*) as test FROM Categories;", null);
            if (result.Rows.Count <= 0)
            {
                throw new Exception("Shabat Seed failed...");
            }
        }
    }
}

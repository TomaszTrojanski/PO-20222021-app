using Microsoft.EntityFrameworkCore;
using PO_20222021_app.Modele;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace PO_20222021_app.Data
{
    internal class DbProvider : DbContext
    {
        private string ConnectionString = "Server=myServerAddress; Database=myDataBase;User Id = myUsername; Password=myPassword;";
        private SqlConnection sqlConnection = null;

        public DbProvider(DbContextOptions<DbProvider> options) : base(options)
        {
        }

        public DbSet<Aplikacja> Aplikacje { get; set; }
        public DbSet<Pracownik> Pracownicy { get; set; }
        public DbSet<Licencja> Licencje { get; set; }
        public DbSet<Kontrahent> Konhenci { get; set; }

        public void OpenConnection()
        {
            var conn = new SqlConnection(ConnectionString);
            try
            {
                if (sqlConnection != null)
                {
                    if (sqlConnection.State == ConnectionState.Open)
                    {
                        sqlConnection.Close();
                    }
                }
                sqlConnection = conn;
                conn.Open();
            }
            catch (Exception ex)
            {
                sqlConnection?.Dispose();
                MessageBox.Show(ex.Message);
            }
        }

        //public DbProvider()
        //{
        //    Aplikacje = new DbSet<Aplikacja>();
        //    Pracownicy = new DbSet<Pracownik>();
        //    Licencje = new DbSet<Licencja>();
        //    Konhenci = new DbSet<Kontrahent>();
        //}
    }
}
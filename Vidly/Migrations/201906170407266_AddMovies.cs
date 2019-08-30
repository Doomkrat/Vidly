namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies(Name, ReleaseDate, DateAdded,NumberInStock,GenreId) VALUES ('Vally', 1980-04-25, 1980-02-02,6,1)");
            Sql("INSERT INTO Movies(Name, ReleaseDate, DateAdded,NumberInStock,GenreId) VALUES ('Hangover', 1980-04-25, 1980-02-02,6,2)");
            Sql("INSERT INTO Movies(Name, ReleaseDate, DateAdded,NumberInStock,GenreId) VALUES ('The Terminator', 1980-04-25, 1980-02-02,6,3)");
            Sql("INSERT INTO Movies(Name, ReleaseDate, DateAdded,NumberInStock,GenreId) VALUES ('Titanic', 1980-04-25, 1980-02-02,6,4)");
        }
        
        public override void Down()
        {
        }
    }
}

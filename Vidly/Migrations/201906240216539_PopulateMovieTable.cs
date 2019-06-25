namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieTable : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES (1, 'Hangover',  '2009-11-06',  '2016-05-04', 5, 0)");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES (2, 'Die Hard',  '2006-12-20',  '2017-07-16', 2, 1)");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES (3, 'The Terminator',  '2003-03-06',  '2015-05-04', 5, 1)");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES (4, 'Toy Story',  '2009-10-06',  '2015-08-04', 5, 2)");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInStock, Genre_Id) VALUES (5, 'Titanic',  '2003-04-16',  '2016-10-14', 5, 3)");
        }
        
        public override void Down()
        {
        }
    }
}

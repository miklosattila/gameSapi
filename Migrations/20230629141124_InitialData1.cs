using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catolog.Migrations
{
    /// <inheritdoc />
    public partial class InitialData1 : Migration
     {
        

       
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
        
            migrationBuilder.InsertData(
            table: "Players",
            columns: new[] { "Name", "Age", "CreatedDate", "ExitDate", "QuizScore", "GameScore" },
            values: new object[,]
            {
            { "Player 1", 7, DateTimeOffset.Now, DateTimeOffset.Now, 0, 0},
            { "Player 2", 10, DateTimeOffset.Now, DateTimeOffset.Now,0, 0 },
            
            });
            migrationBuilder.InsertData(
            table: "Maps",
            columns: new[] { "Id", "PlayerId", "Name", "Latitude", "Longitude", "CreatedDate", "CreatedAt" },
            values: new object[,]
            {
                { 1, 1, "Map 1", 40, 40, DateTimeOffset.Now, "Mackotestver" },
                { 2, 1, "Map 2", 40, 40, DateTimeOffset.Now, "Mackotestver" },
                { 3, 1, "Map 3", 40, 40, DateTimeOffset.Now, "Mackotestver" },
                { 4, 1, "Map 4", 40, 40, DateTimeOffset.Now, "Mackotestver" },
                { 5, 1, "Map 5", 40, 40, DateTimeOffset.Now, "Mackotestver" },
                { 6, 1, "Map 6", 40, 40, DateTimeOffset.Now, "Mackotestver" },
                { 7, 1, "Map 7", 40, 40, DateTimeOffset.Now, "Mackotestver" },
                { 8, 1, "Map 8", 40, 40, DateTimeOffset.Now, "Mackotestver" },
                { 9, 1, "Map 9", 40, 40, DateTimeOffset.Now, "Mackotestver" }
            });
            migrationBuilder.InsertData(
                table: "MapEntityTypes",
                columns: new[] {"Code","Name", "CreatedDate", "CreatedAT" },
                values: new object[,]
                {
                    {1,"Ut", DateTimeOffset.UtcNow, "Mackotestver" },
                    {3,"trap", DateTimeOffset.UtcNow, "Mackotestver" },
                    {4,"computer (palya vege)", DateTimeOffset.UtcNow, "Mackotestver" },
                    {5,"background (collider)", DateTimeOffset.UtcNow, "Mackotestver" },
                    {12,"NPC (2 lehetoseg, jobbra van a megoldas)", DateTimeOffset.UtcNow, "Mackotestver" },
                    {22,"NPC (2 lehetoseg, balra van a megoldas)", DateTimeOffset.UtcNow, "Mackotestver" },
                    {32,"NPC (3 lehetoseg, jobbra van a megoldas)", DateTimeOffset.UtcNow, "Mackotestver" },
                    {42,"NPC (3 lehetoseg, kozepen van a megoldas)", DateTimeOffset.UtcNow, "Mackotestver" },
                    {52,"NPC (3 lehetoseg, balra van a megoldas)", DateTimeOffset.UtcNow, "Mackotestver" },
                });

            //      migrationBuilder.InsertData(
            //      table: "MapEntitys",
            //      columns: new[] { "MapId", "EntityTypeId", "Xcoordinate", "Ycoordinate", "CreatedDate", "CreatedAT" },
            //      values: values);
            

            // migrationBuilder.InsertData(
            //     table: "PlayerMap",
            //     columns: new[] { "Id", "PlayerId", "MapId"},
            //     values: new object[,]
            //     {
            //         { 1, 1, 1},
            //         { 2, 1, 2},
            //         { 3, 1, 3},
            //         { 4, 1, 4},
            //         { 5, 1, 5},
            //         { 6, 1, 6},
            //         { 7, 1, 7},
            //         { 8, 1, 8},
            //         { 9, 1, 9},
            //     });

            

            // migrationBuilder.InsertData(
            //     table: "Quizzes",
            //     columns: new[] { "Name","Title","CurrentLife","Score","MapId", "CreatedDate", "CreatedAT" },
            //     values: new object[,]
            //     {
            //         { "Quiz 1", "This is the first quiz",3,100,1, DateTimeOffset.UtcNow, "Mackotestver" },
            //         { "Quiz 2", "This is the second quiz",3,100,1, DateTimeOffset.UtcNow, "Mackotestver" },
            //         { "Quiz 3", "This is the third quiz",3,100,1, DateTimeOffset.UtcNow, "Mackotestver" }
            //     });

            // migrationBuilder.InsertData(
            //     table: "Questions",
            //     columns: new[] { "Id", "Content", "Type", "Rank", "QuizId", "CreatedDate", "CreatedAT" },
            //     values: new object[,]
            //     {
            //         { 1, "Mi a fővárosa Magyarországnak?", "Choice", 1, 1, DateTimeOffset.Now, "Mackotestver" },
            //         { 2, "Mikor volt az első Holdra szállás?", "Choice", 2, 1, DateTimeOffset.Now,"Mackotestver" },
            //         { 3, "Ki volt Leonardo da Vinci?", "Text", 1, 2, DateTimeOffset.Now, "Mackotestver" },
            //         { 4, "Hány planéta van a Naprendszerben?", "Choice", 3, 2, DateTimeOffset.Now, "Mackotestver" },
            //     });

            // migrationBuilder.InsertData(
            //     table: "QuizAnswers",
            //     columns: new[] { "Id", "Name", "Title", "CurentLife", "Score", "QuizId", "CreatedDate", "CreatedAT" },
            //     values: new object[,]
            //     {
            //         { 1, "Answer 1", "Title 1", 3, 100, 1, DateTimeOffset.UtcNow, "Mackotestver" },
            //         { 2, "Answer 2", "Title 2", 2, 50, 1, DateTimeOffset.UtcNow, "Mackotestver" },
            //         { 3, "Answer 3", "Title 3", 1, 25, 2, DateTimeOffset.UtcNow, "Mackotestver" },
            //         { 4, "Answer 4", "Title 4", 3, 75, 2, DateTimeOffset.UtcNow, "Mackotestver" }
            //     });
            
            // migrationBuilder.InsertData(
            //     table: "QustionAnswers",
            //     columns: new[] { "Content", "Type", "Corrrect", "QuestionId", "CreatedDate", "CreatedAT" },
            //     values: new object[,]
            //     {
            //         { "Válasz 1", "Type 1", true, 1, DateTimeOffset.Now, "Mackotestver" },
            //         { "Válasz 2", "Type 2", false, 1, DateTimeOffset.Now, "Mackotestver" },
            //         { "Válasz 3", "Type 3", false, 2, DateTimeOffset.Now, "Mackotestver" },
            //         { "Válasz 4", "Type 4", true, 2, DateTimeOffset.Now, "Mackotestver" }
            //     });

            // migrationBuilder.InsertData(
            //     table: "QustionAnswersPicked",
            //     columns: new[] { "Id", "Corrrect", "QuestionId", "CreatedDate", "CreatedAT" },
            //     values: new object[,]
            //     {
            //         { 1, true, 1, DateTimeOffset.Now, "Mackotestver" },
            //         { 2, false, 1, DateTimeOffset.Now, "Mackotestver" },
            //         { 3, true, 2, DateTimeOffset.Now, "Mackotestver" },
            //         { 4, false, 2, DateTimeOffset.Now, "Mackotestver" },
            //     });
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {   
            migrationBuilder.Sql("DELETE FROM Players");
            migrationBuilder.Sql("DELETE FROM Map");
            migrationBuilder.Sql("DELETE FROM PlayerMap");
            migrationBuilder.Sql("DELETE FROM MapEntityTypes");
            // migrationBuilder.Sql("DELETE FROM Quizzes");
            // migrationBuilder.Sql("DELETE FROM Questions");
            // migrationBuilder.Sql("DELETE FROM QuizAnswers");
            // migrationBuilder.Sql("DELETE FROM QustionAnswers");
            // migrationBuilder.Sql("DELETE FROM QustionAnswersPicked");
        }
    }
}

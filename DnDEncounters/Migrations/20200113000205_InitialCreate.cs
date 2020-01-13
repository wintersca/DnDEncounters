using Microsoft.EntityFrameworkCore.Migrations;

namespace DnDEncounters.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Monster",
                columns: table => new
                {
                    MonsterID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Species = table.Column<string>(nullable: true),
                    XP = table.Column<int>(nullable: false),
                    Alignment = table.Column<string>(nullable: true),
                    AC = table.Column<int>(nullable: false),
                    HP = table.Column<int>(nullable: false),
                    WalkSpeed = table.Column<int>(nullable: false),
                    FlySpeed = table.Column<int>(nullable: false),
                    SwimSpeed = table.Column<int>(nullable: false),
                    Str = table.Column<int>(nullable: false),
                    Dex = table.Column<int>(nullable: false),
                    Con = table.Column<int>(nullable: false),
                    Int = table.Column<int>(nullable: false),
                    Wis = table.Column<int>(nullable: false),
                    Cha = table.Column<int>(nullable: false),
                    StrSave = table.Column<int>(nullable: false),
                    DexSave = table.Column<int>(nullable: false),
                    ConSave = table.Column<int>(nullable: false),
                    IntSave = table.Column<int>(nullable: false),
                    WisSave = table.Column<int>(nullable: false),
                    ChaSave = table.Column<int>(nullable: false),
                    PassivePerception = table.Column<int>(nullable: false),
                    PassiveInsight = table.Column<int>(nullable: false),
                    PassiveInvestigation = table.Column<int>(nullable: false),
                    Athletics = table.Column<int>(nullable: false),
                    Acrobatics = table.Column<int>(nullable: false),
                    SleightOfHand = table.Column<int>(nullable: false),
                    Stealth = table.Column<int>(nullable: false),
                    Arcana = table.Column<int>(nullable: false),
                    History = table.Column<int>(nullable: false),
                    Investigation = table.Column<int>(nullable: false),
                    Nature = table.Column<int>(nullable: false),
                    Religion = table.Column<int>(nullable: false),
                    AnimalHandling = table.Column<int>(nullable: false),
                    Insight = table.Column<int>(nullable: false),
                    Medicine = table.Column<int>(nullable: false),
                    Perception = table.Column<int>(nullable: false),
                    Survival = table.Column<int>(nullable: false),
                    Deception = table.Column<int>(nullable: false),
                    Intimidation = table.Column<int>(nullable: false),
                    Performance = table.Column<int>(nullable: false),
                    Persuasion = table.Column<int>(nullable: false),
                    CR = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monster", x => x.MonsterID);
                });

            migrationBuilder.CreateTable(
                name: "NPC",
                columns: table => new
                {
                    NPCID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Species = table.Column<string>(nullable: true),
                    XP = table.Column<int>(nullable: false),
                    Alignment = table.Column<string>(nullable: true),
                    AC = table.Column<int>(nullable: false),
                    HP = table.Column<int>(nullable: false),
                    WalkSpeed = table.Column<int>(nullable: false),
                    FlySpeed = table.Column<int>(nullable: false),
                    SwimSpeed = table.Column<int>(nullable: false),
                    Str = table.Column<int>(nullable: false),
                    Dex = table.Column<int>(nullable: false),
                    Con = table.Column<int>(nullable: false),
                    Int = table.Column<int>(nullable: false),
                    Wis = table.Column<int>(nullable: false),
                    Cha = table.Column<int>(nullable: false),
                    StrSave = table.Column<int>(nullable: false),
                    DexSave = table.Column<int>(nullable: false),
                    ConSave = table.Column<int>(nullable: false),
                    IntSave = table.Column<int>(nullable: false),
                    WisSave = table.Column<int>(nullable: false),
                    ChaSave = table.Column<int>(nullable: false),
                    PassivePerception = table.Column<int>(nullable: false),
                    PassiveInsight = table.Column<int>(nullable: false),
                    PassiveInvestigation = table.Column<int>(nullable: false),
                    Athletics = table.Column<int>(nullable: false),
                    Acrobatics = table.Column<int>(nullable: false),
                    SleightOfHand = table.Column<int>(nullable: false),
                    Stealth = table.Column<int>(nullable: false),
                    Arcana = table.Column<int>(nullable: false),
                    History = table.Column<int>(nullable: false),
                    Investigation = table.Column<int>(nullable: false),
                    Nature = table.Column<int>(nullable: false),
                    Religion = table.Column<int>(nullable: false),
                    AnimalHandling = table.Column<int>(nullable: false),
                    Insight = table.Column<int>(nullable: false),
                    Medicine = table.Column<int>(nullable: false),
                    Perception = table.Column<int>(nullable: false),
                    Survival = table.Column<int>(nullable: false),
                    Deception = table.Column<int>(nullable: false),
                    Intimidation = table.Column<int>(nullable: false),
                    Performance = table.Column<int>(nullable: false),
                    Persuasion = table.Column<int>(nullable: false),
                    Level = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NPC", x => x.NPCID);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    PlayerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Species = table.Column<string>(nullable: true),
                    XP = table.Column<int>(nullable: false),
                    Alignment = table.Column<string>(nullable: true),
                    AC = table.Column<int>(nullable: false),
                    HP = table.Column<int>(nullable: false),
                    WalkSpeed = table.Column<int>(nullable: false),
                    FlySpeed = table.Column<int>(nullable: false),
                    SwimSpeed = table.Column<int>(nullable: false),
                    Str = table.Column<int>(nullable: false),
                    Dex = table.Column<int>(nullable: false),
                    Con = table.Column<int>(nullable: false),
                    Int = table.Column<int>(nullable: false),
                    Wis = table.Column<int>(nullable: false),
                    Cha = table.Column<int>(nullable: false),
                    StrSave = table.Column<int>(nullable: false),
                    DexSave = table.Column<int>(nullable: false),
                    ConSave = table.Column<int>(nullable: false),
                    IntSave = table.Column<int>(nullable: false),
                    WisSave = table.Column<int>(nullable: false),
                    ChaSave = table.Column<int>(nullable: false),
                    PassivePerception = table.Column<int>(nullable: false),
                    PassiveInsight = table.Column<int>(nullable: false),
                    PassiveInvestigation = table.Column<int>(nullable: false),
                    Athletics = table.Column<int>(nullable: false),
                    Acrobatics = table.Column<int>(nullable: false),
                    SleightOfHand = table.Column<int>(nullable: false),
                    Stealth = table.Column<int>(nullable: false),
                    Arcana = table.Column<int>(nullable: false),
                    History = table.Column<int>(nullable: false),
                    Investigation = table.Column<int>(nullable: false),
                    Nature = table.Column<int>(nullable: false),
                    Religion = table.Column<int>(nullable: false),
                    AnimalHandling = table.Column<int>(nullable: false),
                    Insight = table.Column<int>(nullable: false),
                    Medicine = table.Column<int>(nullable: false),
                    Perception = table.Column<int>(nullable: false),
                    Survival = table.Column<int>(nullable: false),
                    Deception = table.Column<int>(nullable: false),
                    Intimidation = table.Column<int>(nullable: false),
                    Performance = table.Column<int>(nullable: false),
                    Persuasion = table.Column<int>(nullable: false),
                    Level = table.Column<int>(nullable: false),
                    ProficiencyBonus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.PlayerID);
                });

            migrationBuilder.CreateTable(
                name: "LegendaryAction",
                columns: table => new
                {
                    LegendaryActionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    MonsterID = table.Column<int>(nullable: true),
                    NPCID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LegendaryAction", x => x.LegendaryActionId);
                    table.ForeignKey(
                        name: "FK_LegendaryAction_Monster_MonsterID",
                        column: x => x.MonsterID,
                        principalTable: "Monster",
                        principalColumn: "MonsterID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LegendaryAction_NPC_NPCID",
                        column: x => x.NPCID,
                        principalTable: "NPC",
                        principalColumn: "NPCID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StandardAction",
                columns: table => new
                {
                    StandardActionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    MonsterID = table.Column<int>(nullable: true),
                    NPCID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StandardAction", x => x.StandardActionID);
                    table.ForeignKey(
                        name: "FK_StandardAction_Monster_MonsterID",
                        column: x => x.MonsterID,
                        principalTable: "Monster",
                        principalColumn: "MonsterID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StandardAction_NPC_NPCID",
                        column: x => x.NPCID,
                        principalTable: "NPC",
                        principalColumn: "NPCID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Feature",
                columns: table => new
                {
                    FeatureID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    MonsterID = table.Column<int>(nullable: true),
                    NPCID = table.Column<int>(nullable: true),
                    PlayerID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feature", x => x.FeatureID);
                    table.ForeignKey(
                        name: "FK_Feature_Monster_MonsterID",
                        column: x => x.MonsterID,
                        principalTable: "Monster",
                        principalColumn: "MonsterID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Feature_NPC_NPCID",
                        column: x => x.NPCID,
                        principalTable: "NPC",
                        principalColumn: "NPCID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Feature_Player_PlayerID",
                        column: x => x.PlayerID,
                        principalTable: "Player",
                        principalColumn: "PlayerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    LanguageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    MonsterID = table.Column<int>(nullable: true),
                    NPCID = table.Column<int>(nullable: true),
                    PlayerID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.LanguageID);
                    table.ForeignKey(
                        name: "FK_Language_Monster_MonsterID",
                        column: x => x.MonsterID,
                        principalTable: "Monster",
                        principalColumn: "MonsterID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Language_NPC_NPCID",
                        column: x => x.NPCID,
                        principalTable: "NPC",
                        principalColumn: "NPCID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Language_Player_PlayerID",
                        column: x => x.PlayerID,
                        principalTable: "Player",
                        principalColumn: "PlayerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Feature_MonsterID",
                table: "Feature",
                column: "MonsterID");

            migrationBuilder.CreateIndex(
                name: "IX_Feature_NPCID",
                table: "Feature",
                column: "NPCID");

            migrationBuilder.CreateIndex(
                name: "IX_Feature_PlayerID",
                table: "Feature",
                column: "PlayerID");

            migrationBuilder.CreateIndex(
                name: "IX_Language_MonsterID",
                table: "Language",
                column: "MonsterID");

            migrationBuilder.CreateIndex(
                name: "IX_Language_NPCID",
                table: "Language",
                column: "NPCID");

            migrationBuilder.CreateIndex(
                name: "IX_Language_PlayerID",
                table: "Language",
                column: "PlayerID");

            migrationBuilder.CreateIndex(
                name: "IX_LegendaryAction_MonsterID",
                table: "LegendaryAction",
                column: "MonsterID");

            migrationBuilder.CreateIndex(
                name: "IX_LegendaryAction_NPCID",
                table: "LegendaryAction",
                column: "NPCID");

            migrationBuilder.CreateIndex(
                name: "IX_StandardAction_MonsterID",
                table: "StandardAction",
                column: "MonsterID");

            migrationBuilder.CreateIndex(
                name: "IX_StandardAction_NPCID",
                table: "StandardAction",
                column: "NPCID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feature");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "LegendaryAction");

            migrationBuilder.DropTable(
                name: "StandardAction");

            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "Monster");

            migrationBuilder.DropTable(
                name: "NPC");
        }
    }
}

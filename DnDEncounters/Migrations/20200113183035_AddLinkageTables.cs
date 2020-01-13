using Microsoft.EntityFrameworkCore.Migrations;

namespace DnDEncounters.Migrations
{
    public partial class AddLinkageTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feature_Monster_MonsterID",
                table: "Feature");

            migrationBuilder.DropForeignKey(
                name: "FK_Feature_NPC_NPCID",
                table: "Feature");

            migrationBuilder.DropForeignKey(
                name: "FK_Feature_Player_PlayerID",
                table: "Feature");

            migrationBuilder.DropForeignKey(
                name: "FK_Language_Monster_MonsterID",
                table: "Language");

            migrationBuilder.DropForeignKey(
                name: "FK_Language_NPC_NPCID",
                table: "Language");

            migrationBuilder.DropForeignKey(
                name: "FK_Language_Player_PlayerID",
                table: "Language");

            migrationBuilder.DropForeignKey(
                name: "FK_LegendaryAction_Monster_MonsterID",
                table: "LegendaryAction");

            migrationBuilder.DropForeignKey(
                name: "FK_LegendaryAction_NPC_NPCID",
                table: "LegendaryAction");

            migrationBuilder.DropForeignKey(
                name: "FK_StandardAction_Monster_MonsterID",
                table: "StandardAction");

            migrationBuilder.DropForeignKey(
                name: "FK_StandardAction_NPC_NPCID",
                table: "StandardAction");

            migrationBuilder.DropIndex(
                name: "IX_StandardAction_MonsterID",
                table: "StandardAction");

            migrationBuilder.DropIndex(
                name: "IX_StandardAction_NPCID",
                table: "StandardAction");

            migrationBuilder.DropIndex(
                name: "IX_LegendaryAction_MonsterID",
                table: "LegendaryAction");

            migrationBuilder.DropIndex(
                name: "IX_LegendaryAction_NPCID",
                table: "LegendaryAction");

            migrationBuilder.DropIndex(
                name: "IX_Language_MonsterID",
                table: "Language");

            migrationBuilder.DropIndex(
                name: "IX_Language_NPCID",
                table: "Language");

            migrationBuilder.DropIndex(
                name: "IX_Language_PlayerID",
                table: "Language");

            migrationBuilder.DropIndex(
                name: "IX_Feature_MonsterID",
                table: "Feature");

            migrationBuilder.DropIndex(
                name: "IX_Feature_NPCID",
                table: "Feature");

            migrationBuilder.DropIndex(
                name: "IX_Feature_PlayerID",
                table: "Feature");

            migrationBuilder.DropColumn(
                name: "MonsterID",
                table: "StandardAction");

            migrationBuilder.DropColumn(
                name: "NPCID",
                table: "StandardAction");

            migrationBuilder.DropColumn(
                name: "MonsterID",
                table: "LegendaryAction");

            migrationBuilder.DropColumn(
                name: "NPCID",
                table: "LegendaryAction");

            migrationBuilder.DropColumn(
                name: "MonsterID",
                table: "Language");

            migrationBuilder.DropColumn(
                name: "NPCID",
                table: "Language");

            migrationBuilder.DropColumn(
                name: "PlayerID",
                table: "Language");

            migrationBuilder.DropColumn(
                name: "MonsterID",
                table: "Feature");

            migrationBuilder.DropColumn(
                name: "NPCID",
                table: "Feature");

            migrationBuilder.DropColumn(
                name: "PlayerID",
                table: "Feature");

            migrationBuilder.CreateTable(
                name: "MonsterAction",
                columns: table => new
                {
                    MonsterActionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StandardActionID = table.Column<int>(nullable: false),
                    MonsterID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterAction", x => x.MonsterActionID);
                    table.ForeignKey(
                        name: "FK_MonsterAction_Monster_MonsterID",
                        column: x => x.MonsterID,
                        principalTable: "Monster",
                        principalColumn: "MonsterID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterAction_StandardAction_StandardActionID",
                        column: x => x.StandardActionID,
                        principalTable: "StandardAction",
                        principalColumn: "StandardActionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonsterFeature",
                columns: table => new
                {
                    MonsterFeatureID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeatureID = table.Column<int>(nullable: false),
                    MonsterID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterFeature", x => x.MonsterFeatureID);
                    table.ForeignKey(
                        name: "FK_MonsterFeature_Feature_FeatureID",
                        column: x => x.FeatureID,
                        principalTable: "Feature",
                        principalColumn: "FeatureID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterFeature_Monster_MonsterID",
                        column: x => x.MonsterID,
                        principalTable: "Monster",
                        principalColumn: "MonsterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonsterLanguage",
                columns: table => new
                {
                    MonsterLanguageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageID = table.Column<int>(nullable: false),
                    MonsterID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterLanguage", x => x.MonsterLanguageID);
                    table.ForeignKey(
                        name: "FK_MonsterLanguage_Language_LanguageID",
                        column: x => x.LanguageID,
                        principalTable: "Language",
                        principalColumn: "LanguageID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterLanguage_Monster_MonsterID",
                        column: x => x.MonsterID,
                        principalTable: "Monster",
                        principalColumn: "MonsterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonsterLegendaryAction",
                columns: table => new
                {
                    MonsterLegendaryActionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LegendaryActionID = table.Column<int>(nullable: false),
                    MonsterID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterLegendaryAction", x => x.MonsterLegendaryActionID);
                    table.ForeignKey(
                        name: "FK_MonsterLegendaryAction_LegendaryAction_LegendaryActionID",
                        column: x => x.LegendaryActionID,
                        principalTable: "LegendaryAction",
                        principalColumn: "LegendaryActionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterLegendaryAction_Monster_MonsterID",
                        column: x => x.MonsterID,
                        principalTable: "Monster",
                        principalColumn: "MonsterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NPCAction",
                columns: table => new
                {
                    NPCActionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StandardActionID = table.Column<int>(nullable: false),
                    NPCID = table.Column<int>(nullable: false),
                    NPC = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NPCAction", x => x.NPCActionID);
                    table.ForeignKey(
                        name: "FK_NPCAction_NPC_NPCID",
                        column: x => x.NPCID,
                        principalTable: "NPC",
                        principalColumn: "NPCID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NPCAction_StandardAction_StandardActionID",
                        column: x => x.StandardActionID,
                        principalTable: "StandardAction",
                        principalColumn: "StandardActionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NPCFeature",
                columns: table => new
                {
                    NPCFeatureID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeatureID = table.Column<int>(nullable: false),
                    NPCID = table.Column<int>(nullable: false),
                    NPC = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NPCFeature", x => x.NPCFeatureID);
                    table.ForeignKey(
                        name: "FK_NPCFeature_Feature_FeatureID",
                        column: x => x.FeatureID,
                        principalTable: "Feature",
                        principalColumn: "FeatureID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NPCFeature_NPC_NPCID",
                        column: x => x.NPCID,
                        principalTable: "NPC",
                        principalColumn: "NPCID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NPCLanguage",
                columns: table => new
                {
                    NPCLanguageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageID = table.Column<int>(nullable: false),
                    NPCID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NPCLanguage", x => x.NPCLanguageID);
                    table.ForeignKey(
                        name: "FK_NPCLanguage_Language_LanguageID",
                        column: x => x.LanguageID,
                        principalTable: "Language",
                        principalColumn: "LanguageID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NPCLanguage_NPC_NPCID",
                        column: x => x.NPCID,
                        principalTable: "NPC",
                        principalColumn: "NPCID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NPCLegendaryAction",
                columns: table => new
                {
                    NPCLegendaryActionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LEgendaryActionID = table.Column<int>(nullable: false),
                    NPCID = table.Column<int>(nullable: false),
                    NPC = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NPCLegendaryAction", x => x.NPCLegendaryActionID);
                    table.ForeignKey(
                        name: "FK_NPCLegendaryAction_LegendaryAction_LEgendaryActionID",
                        column: x => x.LEgendaryActionID,
                        principalTable: "LegendaryAction",
                        principalColumn: "LegendaryActionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NPCLegendaryAction_NPC_NPCID",
                        column: x => x.NPCID,
                        principalTable: "NPC",
                        principalColumn: "NPCID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerLanguage",
                columns: table => new
                {
                    PlayerLanguageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageID = table.Column<int>(nullable: false),
                    PlayerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerLanguage", x => x.PlayerLanguageID);
                    table.ForeignKey(
                        name: "FK_PlayerLanguage_Player_PlayerID",
                        column: x => x.PlayerID,
                        principalTable: "Player",
                        principalColumn: "PlayerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MonsterAction_MonsterID",
                table: "MonsterAction",
                column: "MonsterID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterAction_StandardActionID",
                table: "MonsterAction",
                column: "StandardActionID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterFeature_FeatureID",
                table: "MonsterFeature",
                column: "FeatureID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterFeature_MonsterID",
                table: "MonsterFeature",
                column: "MonsterID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterLanguage_LanguageID",
                table: "MonsterLanguage",
                column: "LanguageID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterLanguage_MonsterID",
                table: "MonsterLanguage",
                column: "MonsterID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterLegendaryAction_LegendaryActionID",
                table: "MonsterLegendaryAction",
                column: "LegendaryActionID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterLegendaryAction_MonsterID",
                table: "MonsterLegendaryAction",
                column: "MonsterID");

            migrationBuilder.CreateIndex(
                name: "IX_NPCAction_NPCID",
                table: "NPCAction",
                column: "NPCID");

            migrationBuilder.CreateIndex(
                name: "IX_NPCAction_StandardActionID",
                table: "NPCAction",
                column: "StandardActionID");

            migrationBuilder.CreateIndex(
                name: "IX_NPCFeature_FeatureID",
                table: "NPCFeature",
                column: "FeatureID");

            migrationBuilder.CreateIndex(
                name: "IX_NPCFeature_NPCID",
                table: "NPCFeature",
                column: "NPCID");

            migrationBuilder.CreateIndex(
                name: "IX_NPCLanguage_LanguageID",
                table: "NPCLanguage",
                column: "LanguageID");

            migrationBuilder.CreateIndex(
                name: "IX_NPCLanguage_NPCID",
                table: "NPCLanguage",
                column: "NPCID");

            migrationBuilder.CreateIndex(
                name: "IX_NPCLegendaryAction_LEgendaryActionID",
                table: "NPCLegendaryAction",
                column: "LEgendaryActionID");

            migrationBuilder.CreateIndex(
                name: "IX_NPCLegendaryAction_NPCID",
                table: "NPCLegendaryAction",
                column: "NPCID");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerLanguage_PlayerID",
                table: "PlayerLanguage",
                column: "PlayerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MonsterAction");

            migrationBuilder.DropTable(
                name: "MonsterFeature");

            migrationBuilder.DropTable(
                name: "MonsterLanguage");

            migrationBuilder.DropTable(
                name: "MonsterLegendaryAction");

            migrationBuilder.DropTable(
                name: "NPCAction");

            migrationBuilder.DropTable(
                name: "NPCFeature");

            migrationBuilder.DropTable(
                name: "NPCLanguage");

            migrationBuilder.DropTable(
                name: "NPCLegendaryAction");

            migrationBuilder.DropTable(
                name: "PlayerLanguage");

            migrationBuilder.AddColumn<int>(
                name: "MonsterID",
                table: "StandardAction",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NPCID",
                table: "StandardAction",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MonsterID",
                table: "LegendaryAction",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NPCID",
                table: "LegendaryAction",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MonsterID",
                table: "Language",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NPCID",
                table: "Language",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlayerID",
                table: "Language",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MonsterID",
                table: "Feature",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NPCID",
                table: "Feature",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlayerID",
                table: "Feature",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StandardAction_MonsterID",
                table: "StandardAction",
                column: "MonsterID");

            migrationBuilder.CreateIndex(
                name: "IX_StandardAction_NPCID",
                table: "StandardAction",
                column: "NPCID");

            migrationBuilder.CreateIndex(
                name: "IX_LegendaryAction_MonsterID",
                table: "LegendaryAction",
                column: "MonsterID");

            migrationBuilder.CreateIndex(
                name: "IX_LegendaryAction_NPCID",
                table: "LegendaryAction",
                column: "NPCID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Feature_Monster_MonsterID",
                table: "Feature",
                column: "MonsterID",
                principalTable: "Monster",
                principalColumn: "MonsterID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Feature_NPC_NPCID",
                table: "Feature",
                column: "NPCID",
                principalTable: "NPC",
                principalColumn: "NPCID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Feature_Player_PlayerID",
                table: "Feature",
                column: "PlayerID",
                principalTable: "Player",
                principalColumn: "PlayerID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Language_Monster_MonsterID",
                table: "Language",
                column: "MonsterID",
                principalTable: "Monster",
                principalColumn: "MonsterID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Language_NPC_NPCID",
                table: "Language",
                column: "NPCID",
                principalTable: "NPC",
                principalColumn: "NPCID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Language_Player_PlayerID",
                table: "Language",
                column: "PlayerID",
                principalTable: "Player",
                principalColumn: "PlayerID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LegendaryAction_Monster_MonsterID",
                table: "LegendaryAction",
                column: "MonsterID",
                principalTable: "Monster",
                principalColumn: "MonsterID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LegendaryAction_NPC_NPCID",
                table: "LegendaryAction",
                column: "NPCID",
                principalTable: "NPC",
                principalColumn: "NPCID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StandardAction_Monster_MonsterID",
                table: "StandardAction",
                column: "MonsterID",
                principalTable: "Monster",
                principalColumn: "MonsterID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StandardAction_NPC_NPCID",
                table: "StandardAction",
                column: "NPCID",
                principalTable: "NPC",
                principalColumn: "NPCID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

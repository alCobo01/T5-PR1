using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace T5_PR1.Migrations
{
    /// <inheritdoc />
    public partial class CanviPropietats : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CostTotal",
                table: "Simulacions");

            migrationBuilder.DropColumn(
                name: "PreuTotal",
                table: "Simulacions");

            migrationBuilder.DropColumn(
                name: "CCAC_GasoilA",
                table: "IndicadorsEnergetics");

            migrationBuilder.DropColumn(
                name: "CDEEBC_ConsumAux",
                table: "IndicadorsEnergetics");

            migrationBuilder.DropColumn(
                name: "CDEEBC_ConsumBomb",
                table: "IndicadorsEnergetics");

            migrationBuilder.DropColumn(
                name: "CDEEBC_ProdBruta",
                table: "IndicadorsEnergetics");

            migrationBuilder.DropColumn(
                name: "CDEEBC_SaldoIntercanviElectr",
                table: "IndicadorsEnergetics");

            migrationBuilder.DropColumn(
                name: "CDEEBC_TotVendesXarxaCentral",
                table: "IndicadorsEnergetics");

            migrationBuilder.DropColumn(
                name: "CDEEBC_TotalEBCMercatLliure",
                table: "IndicadorsEnergetics");

            migrationBuilder.DropColumn(
                name: "CDEEBC_TotalEBCMercatRegulat",
                table: "IndicadorsEnergetics");

            migrationBuilder.DropColumn(
                name: "DGGN_ConsumGNCentrTerm",
                table: "IndicadorsEnergetics");

            migrationBuilder.DropColumn(
                name: "DGGN_DistrAlimGNL",
                table: "IndicadorsEnergetics");

            migrationBuilder.DropColumn(
                name: "DGGN_PuntFrontEnagas",
                table: "IndicadorsEnergetics");

            migrationBuilder.DropColumn(
                name: "FEEI_AlimBegudaTabac",
                table: "IndicadorsEnergetics");

            migrationBuilder.DropColumn(
                name: "FEEI_AltresIndus",
                table: "IndicadorsEnergetics");

            migrationBuilder.DropColumn(
                name: "FEEI_AltresMatConstr",
                table: "IndicadorsEnergetics");

            migrationBuilder.DropColumn(
                name: "FEEI_CimentsCalGuix",
                table: "IndicadorsEnergetics");

            migrationBuilder.DropColumn(
                name: "FEEI_ConsObrPub",
                table: "IndicadorsEnergetics");

            migrationBuilder.DropColumn(
                name: "FEEI_ConstrMedTrans",
                table: "IndicadorsEnergetics");

            migrationBuilder.DropColumn(
                name: "FEEI_IndusVidre",
                table: "IndicadorsEnergetics");

            migrationBuilder.DropColumn(
                name: "FEEI_Metalurgia",
                table: "IndicadorsEnergetics");

            migrationBuilder.DropColumn(
                name: "FEEI_PastaPaperCartro",
                table: "IndicadorsEnergetics");

            migrationBuilder.DropColumn(
                name: "FEEI_QuimPetroquim",
                table: "IndicadorsEnergetics");

            migrationBuilder.DropColumn(
                name: "FEEI_RestaTransforMetal",
                table: "IndicadorsEnergetics");

            migrationBuilder.DropColumn(
                name: "FEEI_SiderFoneria",
                table: "IndicadorsEnergetics");

            migrationBuilder.DropColumn(
                name: "FEEI_TextilConfecCuirCalçat",
                table: "IndicadorsEnergetics");

            migrationBuilder.DropColumn(
                name: "FEE_Domestic",
                table: "IndicadorsEnergetics");

            migrationBuilder.DropColumn(
                name: "FEE_Energetic",
                table: "IndicadorsEnergetics");

            migrationBuilder.DropColumn(
                name: "FEE_Industria",
                table: "IndicadorsEnergetics");

            migrationBuilder.DropColumn(
                name: "FEE_Primari",
                table: "IndicadorsEnergetics");

            migrationBuilder.DropColumn(
                name: "FEE_Terciari",
                table: "IndicadorsEnergetics");

            migrationBuilder.DropColumn(
                name: "PBEE_Carbo",
                table: "IndicadorsEnergetics");

            migrationBuilder.DropColumn(
                name: "PBEE_CiclComb",
                table: "IndicadorsEnergetics");

            migrationBuilder.DropColumn(
                name: "PBEE_Fuel_Oil",
                table: "IndicadorsEnergetics");

            migrationBuilder.DropColumn(
                name: "PBEE_GasNat",
                table: "IndicadorsEnergetics");

            migrationBuilder.DropColumn(
                name: "PBEE_Hidroelectr",
                table: "IndicadorsEnergetics");

            migrationBuilder.DropColumn(
                name: "PBEE_Nuclear",
                table: "IndicadorsEnergetics");

            migrationBuilder.DropColumn(
                name: "ActivitatsEconomiquesIFontsPropies",
                table: "ConsumsAigua");

            migrationBuilder.DropColumn(
                name: "CodiComarca",
                table: "ConsumsAigua");

            migrationBuilder.DropColumn(
                name: "DomesticXarxa",
                table: "ConsumsAigua");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "ConsumsAigua");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "CostTotal",
                table: "Simulacions",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PreuTotal",
                table: "Simulacions",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "CCAC_GasoilA",
                table: "IndicadorsEnergetics",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "CDEEBC_ConsumAux",
                table: "IndicadorsEnergetics",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "CDEEBC_ConsumBomb",
                table: "IndicadorsEnergetics",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "CDEEBC_ProdBruta",
                table: "IndicadorsEnergetics",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "CDEEBC_SaldoIntercanviElectr",
                table: "IndicadorsEnergetics",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "CDEEBC_TotVendesXarxaCentral",
                table: "IndicadorsEnergetics",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "CDEEBC_TotalEBCMercatLliure",
                table: "IndicadorsEnergetics",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CDEEBC_TotalEBCMercatRegulat",
                table: "IndicadorsEnergetics",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "DGGN_ConsumGNCentrTerm",
                table: "IndicadorsEnergetics",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "DGGN_DistrAlimGNL",
                table: "IndicadorsEnergetics",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "DGGN_PuntFrontEnagas",
                table: "IndicadorsEnergetics",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "FEEI_AlimBegudaTabac",
                table: "IndicadorsEnergetics",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "FEEI_AltresIndus",
                table: "IndicadorsEnergetics",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "FEEI_AltresMatConstr",
                table: "IndicadorsEnergetics",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "FEEI_CimentsCalGuix",
                table: "IndicadorsEnergetics",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "FEEI_ConsObrPub",
                table: "IndicadorsEnergetics",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "FEEI_ConstrMedTrans",
                table: "IndicadorsEnergetics",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "FEEI_IndusVidre",
                table: "IndicadorsEnergetics",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "FEEI_Metalurgia",
                table: "IndicadorsEnergetics",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "FEEI_PastaPaperCartro",
                table: "IndicadorsEnergetics",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "FEEI_QuimPetroquim",
                table: "IndicadorsEnergetics",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "FEEI_RestaTransforMetal",
                table: "IndicadorsEnergetics",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "FEEI_SiderFoneria",
                table: "IndicadorsEnergetics",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "FEEI_TextilConfecCuirCalçat",
                table: "IndicadorsEnergetics",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "FEE_Domestic",
                table: "IndicadorsEnergetics",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "FEE_Energetic",
                table: "IndicadorsEnergetics",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "FEE_Industria",
                table: "IndicadorsEnergetics",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "FEE_Primari",
                table: "IndicadorsEnergetics",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "FEE_Terciari",
                table: "IndicadorsEnergetics",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PBEE_Carbo",
                table: "IndicadorsEnergetics",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PBEE_CiclComb",
                table: "IndicadorsEnergetics",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PBEE_Fuel_Oil",
                table: "IndicadorsEnergetics",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PBEE_GasNat",
                table: "IndicadorsEnergetics",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PBEE_Hidroelectr",
                table: "IndicadorsEnergetics",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PBEE_Nuclear",
                table: "IndicadorsEnergetics",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ActivitatsEconomiquesIFontsPropies",
                table: "ConsumsAigua",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "CodiComarca",
                table: "ConsumsAigua",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "DomesticXarxa",
                table: "ConsumsAigua",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Total",
                table: "ConsumsAigua",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}

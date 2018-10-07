using Microsoft.EntityFrameworkCore.Migrations;

namespace Chimerical.Conversions.Db.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "BaseUnitMap",
                keyColumn: "UnitTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "m", "nm" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "m", "μm" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 1, "cm" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 1, "dm" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 1, "ft" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 1, "in" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 1, "km" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 1, "m" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 1, "mi" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 1, "mm" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 1, "nm" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 1, "nmi" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 1, "yd" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 1, "μm" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 2, "ac" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 2, "ft²" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 2, "ha" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 2, "in²" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 2, "km²" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 2, "m²" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 2, "mi²" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 2, "yd²" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                schema: "Conversions",
                table: "BaseUnitMap",
                keyColumn: "UnitTypeId",
                keyValue: 1,
                column: "BaseUnitSymbol",
                value: "km²");

            migrationBuilder.InsertData(
                schema: "Conversions",
                table: "Conversion",
                columns: new[] { "FromUnitSymbol", "ToUnitSymbol", "Multiplier" },
                values: new object[,]
                {
                    { "mm", "μm", 1000.0 },
                    { "μm", "nm", 1000.0 }
                });

            migrationBuilder.InsertData(
                schema: "Conversions",
                table: "Unit",
                columns: new[] { "Symbol", "DisplayName" },
                values: new object[,]
                {
                    { "hr", "Hour" },
                    { "min", "Minute" },
                    { "s", "Second" },
                    { "ms", "Millisecond" },
                    { "μs", "Microsecond" },
                    { "ns", "Nanosecond" },
                    { "kn", "Knot" },
                    { "km/h", "Kilometre per Hour" },
                    { "m/s", "Metre per Second" },
                    { "fps", "Foot per Second" },
                    { "mph", "Mile per Hour" },
                    { "Torr", "Torr" },
                    { "psi", "Pounds per Square Inch" },
                    { "Pa", "Pascal" },
                    { "atm", "Atmosphere" },
                    { "arcsec", "SecondOfArc" },
                    { "rad", "Radian" },
                    { "arcmin", "MinuteOfArc" },
                    { "mrad", "Milliradian" },
                    { "gon", "Gradian" },
                    { "day", "Day" },
                    { "week", "Week" },
                    { "yr", "Year" },
                    { "deg", "Degree" },
                    { "in³", "Cubic Inch" },
                    { "ft³", "Cubic Foot" },
                    { "tsp", "Imperial Teaspoon" },
                    { "tbsp", "Imperial Tablespoon" },
                    { "fluid oz", "Imperial Fluid Ounce" },
                    { "cup", "Imperial Cup" },
                    { "pt", "Imperial Pint" },
                    { "quart", "Imperial Quart" },
                    { "gal", "Imperial Gallon" },
                    { "mL", "Millilitre" },
                    { "L", "Litre" },
                    { "m³", "CubicMetre" },
                    { "US tsp", "US Teaspoon" },
                    { "US tbsp", "US Tablespoon" },
                    { "US oz", "US Fluid Ounce" },
                    { "US cup", "US Legal Cup" },
                    { "US pt", "US Liquid Pint" },
                    { "US quart", "US Liquid Quart" },
                    { "US gal", "US Liquid Gallon" },
                    { "century", "Century" },
                    { "decade", "Decade" },
                    { "month", "Month" },
                    { "oz", "Ounce" },
                    { "bar", "Bar" },
                    { "st", "Stone" },
                    { "PB", "Petabyte" },
                    { "TiB", "Tebibyte" },
                    { "TB", "Terabyte" },
                    { "GiB", "Gibibyte" },
                    { "GB", "Gigabyte" },
                    { "MiB", "Mebibyte" },
                    { "lbs", "Pound" },
                    { "KiB", "Kibibyte" },
                    { "kB", "Kilobyte" },
                    { "B", "Byte" },
                    { "Pibit", "Pebibit" },
                    { "Pbit", "Petabit" },
                    { "Tibit", "Tebibit" },
                    { "Tbit", "Terabit" },
                    { "Gibit", "Gibibit" },
                    { "Gbit", "Gigabit" },
                    { "Mibit", "Mebibit" },
                    { "Mbit", "Megabit" },
                    { "Kibit", "Kibibit" },
                    { "kbit", "Kilobit" },
                    { "bit", "Bit" },
                    { "PiB", "Pebibyte" },
                    { "J", "Joule" },
                    { "MB", "Megabyte" },
                    { "cal", "Gram Calorie" },
                    { "US ton", "US Ton" },
                    { "kJ", "Kilojoule" },
                    { "μg", "Microgram" },
                    { "mg", "Milligram" },
                    { "g", "Gram" },
                    { "kg", "Kilogram" },
                    { "t", "Tonne" },
                    { "km/L", "Kilometre per Litre" },
                    { "mpg", "Miles per Gallon (Imperial)" },
                    { "US mpg", "US Miles per Gallon" },
                    { "ton", "Imperial Ton" },
                    { "MHz", "Megahertz" },
                    { "kCal", "Kilocalorie" },
                    { "Wh", "Watt Hour" },
                    { "GHz", "Gigahertz" },
                    { "eV", "Electronvolt" },
                    { "Btu", "British Thermal Unit" },
                    { "kWh", "Kilowatt Hour" },
                    { "ft-lb", "Foot-Pound" },
                    { "Hz", "Hertz" },
                    { "kHz", "Kilohertz" },
                    { "thm", "US Therm" }
                });

            migrationBuilder.UpdateData(
                schema: "Conversions",
                table: "UnitType",
                keyColumn: "Id",
                keyValue: 1,
                column: "DisplayName",
                value: "Area");

            migrationBuilder.InsertData(
                schema: "Conversions",
                table: "UnitType",
                columns: new[] { "Id", "DisplayName" },
                values: new object[,]
                {
                    { 14, "Volume" },
                    { 13, "Time" },
                    { 11, "Speed" },
                    { 10, "Pressure" },
                    { 9, "Plane Angle" },
                    { 6, "Frequency" },
                    { 7, "Fuel Economy" },
                    { 5, "Energy" },
                    { 4, "Distance" },
                    { 3, "Digital Storage" },
                    { 8, "Mass" }
                });

            migrationBuilder.InsertData(
                schema: "Conversions",
                table: "UnitTypeMap",
                columns: new[] { "UnitTypeId", "UnitSymbol" },
                values: new object[,]
                {
                    { 1, "ha" },
                    { 1, "km²" },
                    { 1, "m²" },
                    { 1, "mi²" },
                    { 1, "yd²" },
                    { 1, "ft²" },
                    { 1, "in²" },
                    { 1, "ac" }
                });

            migrationBuilder.InsertData(
                schema: "Conversions",
                table: "BaseUnitMap",
                columns: new[] { "UnitTypeId", "BaseUnitSymbol" },
                values: new object[,]
                {
                    { 4, "m" },
                    { 8, "kg" },
                    { 9, "deg" },
                    { 7, "km/L" },
                    { 6, "Hz" },
                    { 10, "Pa" },
                    { 11, "m/s" },
                    { 5, "J" },
                    { 13, "s" },
                    { 14, "L" },
                    { 3, "B" }
                });

            migrationBuilder.InsertData(
                schema: "Conversions",
                table: "Conversion",
                columns: new[] { "FromUnitSymbol", "ToUnitSymbol", "Multiplier" },
                values: new object[,]
                {
                    { "min", "s", 60.0 },
                    { "hr", "min", 60.0 },
                    { "day", "hr", 24.0 },
                    { "kbit", "bit", 1000.0 },
                    { "yr", "month", 12.0 },
                    { "s", "ms", 1000.0 },
                    { "week", "day", 365.0 },
                    { "ms", "μs", 1000.0 },
                    { "atm", "Torr", 760.0 },
                    { "kn", "mph", 1.15078 },
                    { "mph", "km/h", 1.609344 },
                    { "m/s", "km/h", 3.6 },
                    { "fps", "m/s", 0.3048 },
                    { "yr", "day", 365.0 },
                    { "psi", "Pa", 6894.757 },
                    { "bar", "Pa", 100000.0 },
                    { "μs", "ns", 1000.0 },
                    { "decade", "yr", 10.0 },
                    { "US tbsp", "US tsp", 3.0 },
                    { "US gal", "US quart", 4.0 },
                    { "ft³", "in³", 1728.0 },
                    { "m³", "ft³", 0.028316846592000004 },
                    { "tbsp", "tsp", 3.0 },
                    { "fluid oz", "tbsp", 1.6 },
                    { "pt", "fluid oz", 20.0 },
                    { "pt", "cup", 1.75975 },
                    { "quart", "pt", 2.0 },
                    { "century", "decade", 10.0 },
                    { "gal", "quart", 4.0 },
                    { "L", "mL", 1000.0 },
                    { "US gal", "L", 3.78541 },
                    { "m³", "L", 1000.0 },
                    { "atm", "Pa", 101325.0 },
                    { "US pt", "US oz", 16.0 },
                    { "US pt", "US cup", 1.97157 },
                    { "US quart", "US pt", 2.0 },
                    { "gal", "L", 4.54609 },
                    { "rad", "arcsec", 206265.0 },
                    { "US oz", "US tbsp", 2.0 },
                    { "rad", "deg", 57.295779513082323 },
                    { "PiB", "TiB", 1024.0 },
                    { "PB", "TB", 1000.0 },
                    { "TiB", "GiB", 1024.0 },
                    { "TB", "GB", 1000.0 },
                    { "GiB", "MiB", 1024.0 },
                    { "GB", "MB", 1000.0 },
                    { "MiB", "KiB", 1024.0 },
                    { "Tibit", "Gibit", 1024.0 },
                    { "KiB", "B", 1024.0 },
                    { "KiB", "kB", 1.024 },
                    { "kJ", "J", 1000.0 },
                    { "kB", "B", 1000.0 },
                    { "Kibit", "kbit", 1.024 },
                    { "Kibit", "bit", 1024.0 },
                    { "Mbit", "kbit", 1000.0 },
                    { "arcmin", "arcsec", 60.0 },
                    { "Mibit", "Kibit", 1024.0 },
                    { "Gbit", "Mbit", 1000.0 },
                    { "Pibit", "Tibit", 1024.0 },
                    { "Gibit", "Mibit", 1024.0 },
                    { "Pbit", "Tbit", 1000.0 },
                    { "Tbit", "Gbit", 1000.0 },
                    { "B", "bit", 8.0 },
                    { "cal", "J", 4.184 },
                    { "MB", "kB", 1000.0 },
                    { "kCal", "cal", 1000.0 },
                    { "st", "lbs", 14.0 },
                    { "lbs", "oz", 16.0 },
                    { "kg", "lbs", 2.20462262185 },
                    { "ton", "US ton", 1.12 },
                    { "rad", "gon", 63.661977236758133 },
                    { "rad", "mrad", 1000.0 },
                    { "mg", "μg", 1000.0 },
                    { "g", "mg", 1000.0 },
                    { "t", "kg", 1000.0 },
                    { "km/L", "US mpg", 0.621371192237334 },
                    { "kg", "g", 1000.0 },
                    { "GHz", "MHz", 1000.0 },
                    { "Wh", "J", 3600.0 },
                    { "kWh", "Wh", 1000.0 },
                    { "J", "eV", 6.242E+18 },
                    { "Btu", "J", 1055.06 },
                    { "thm", "Btu", 99976.1 },
                    { "US mpg", "mpg", 0.621371192237334 },
                    { "US ton", "lbs", 2000.0 },
                    { "kHz", "Hz", 1000.0 },
                    { "MHz", "kHz", 1000.0 },
                    { "Btu", "ft-lb", 778.169 }
                });

            migrationBuilder.InsertData(
                schema: "Conversions",
                table: "UnitTypeMap",
                columns: new[] { "UnitTypeId", "UnitSymbol" },
                values: new object[,]
                {
                    { 11, "m/s" },
                    { 11, "mph" },
                    { 11, "km/h" },
                    { 10, "psi" },
                    { 11, "kn" },
                    { 10, "Torr" },
                    { 11, "fps" },
                    { 9, "arcmin" },
                    { 10, "bar" },
                    { 10, "atm" },
                    { 9, "arcsec" },
                    { 9, "rad" },
                    { 8, "st" },
                    { 9, "mrad" },
                    { 9, "gon" },
                    { 9, "deg" },
                    { 8, "oz" },
                    { 8, "lbs" },
                    { 10, "Pa" },
                    { 13, "ns" },
                    { 14, "US tsp" },
                    { 13, "ms" },
                    { 8, "US ton" },
                    { 14, "tsp" },
                    { 14, "tbsp" },
                    { 14, "fluid oz" },
                    { 14, "cup" },
                    { 14, "pt" },
                    { 14, "quart" },
                    { 14, "gal" },
                    { 14, "mL" },
                    { 14, "L" },
                    { 14, "m³" },
                    { 14, "US tbsp" },
                    { 13, "μs" },
                    { 14, "US oz" },
                    { 14, "US pt" },
                    { 14, "US quart" },
                    { 14, "US gal" },
                    { 13, "century" },
                    { 13, "decade" },
                    { 13, "yr" },
                    { 13, "month" },
                    { 13, "week" },
                    { 13, "day" },
                    { 13, "hr" },
                    { 13, "min" },
                    { 13, "s" },
                    { 14, "US cup" },
                    { 8, "ton" },
                    { 3, "MB" },
                    { 8, "mg" },
                    { 4, "dm" },
                    { 4, "m" },
                    { 4, "km" },
                    { 3, "PiB" },
                    { 3, "PB" },
                    { 3, "TiB" },
                    { 3, "TB" },
                    { 3, "GiB" },
                    { 3, "GB" },
                    { 3, "MiB" },
                    { 14, "ft³" },
                    { 3, "KiB" },
                    { 3, "kB" },
                    { 3, "B" },
                    { 3, "Pibit" },
                    { 3, "Pbit" },
                    { 3, "Tibit" },
                    { 3, "Tbit" },
                    { 3, "Gibit" },
                    { 3, "Gbit" },
                    { 3, "Mibit" },
                    { 3, "Mbit" },
                    { 3, "Kibit" },
                    { 3, "kbit" },
                    { 3, "bit" },
                    { 4, "cm" },
                    { 8, "μg" },
                    { 4, "mm" },
                    { 4, "nm" },
                    { 8, "g" },
                    { 8, "kg" },
                    { 8, "t" },
                    { 7, "km/L" },
                    { 7, "mpg" },
                    { 7, "US mpg" },
                    { 6, "GHz" },
                    { 6, "MHz" },
                    { 6, "kHz" },
                    { 6, "Hz" },
                    { 5, "ft-lb" },
                    { 5, "thm" },
                    { 5, "Btu" },
                    { 5, "eV" },
                    { 5, "kWh" },
                    { 5, "Wh" },
                    { 5, "kCal" },
                    { 5, "cal" },
                    { 5, "kJ" },
                    { 5, "J" },
                    { 4, "nmi" },
                    { 4, "in" },
                    { 4, "ft" },
                    { 4, "yd" },
                    { 4, "mi" },
                    { 4, "μm" },
                    { 14, "in³" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "BaseUnitMap",
                keyColumn: "UnitTypeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "BaseUnitMap",
                keyColumn: "UnitTypeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "BaseUnitMap",
                keyColumn: "UnitTypeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "BaseUnitMap",
                keyColumn: "UnitTypeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "BaseUnitMap",
                keyColumn: "UnitTypeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "BaseUnitMap",
                keyColumn: "UnitTypeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "BaseUnitMap",
                keyColumn: "UnitTypeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "BaseUnitMap",
                keyColumn: "UnitTypeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "BaseUnitMap",
                keyColumn: "UnitTypeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "BaseUnitMap",
                keyColumn: "UnitTypeId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "BaseUnitMap",
                keyColumn: "UnitTypeId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "arcmin", "arcsec" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "atm", "Pa" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "atm", "Torr" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "B", "bit" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "bar", "Pa" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "Btu", "ft-lb" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "Btu", "J" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "cal", "J" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "century", "decade" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "day", "hr" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "decade", "yr" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "fluid oz", "tbsp" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "fps", "m/s" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "ft³", "in³" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "g", "mg" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "gal", "L" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "gal", "quart" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "GB", "MB" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "Gbit", "Mbit" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "GHz", "MHz" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "GiB", "MiB" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "Gibit", "Mibit" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "hr", "min" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "J", "eV" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "kB", "B" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "kbit", "bit" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "kCal", "cal" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "kg", "g" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "kg", "lbs" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "kHz", "Hz" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "KiB", "B" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "KiB", "kB" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "Kibit", "bit" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "Kibit", "kbit" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "kJ", "J" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "km/L", "US mpg" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "kn", "mph" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "kWh", "Wh" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "L", "mL" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "lbs", "oz" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "m/s", "km/h" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "m³", "ft³" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "m³", "L" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "MB", "kB" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "Mbit", "kbit" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "mg", "μg" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "MHz", "kHz" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "MiB", "KiB" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "Mibit", "Kibit" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "min", "s" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "mm", "μm" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "mph", "km/h" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "ms", "μs" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "PB", "TB" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "Pbit", "Tbit" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "PiB", "TiB" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "Pibit", "Tibit" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "psi", "Pa" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "pt", "cup" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "pt", "fluid oz" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "quart", "pt" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "rad", "arcsec" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "rad", "deg" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "rad", "gon" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "rad", "mrad" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "s", "ms" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "st", "lbs" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "t", "kg" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "TB", "GB" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "Tbit", "Gbit" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "tbsp", "tsp" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "thm", "Btu" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "TiB", "GiB" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "Tibit", "Gibit" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "ton", "US ton" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "US gal", "L" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "US gal", "US quart" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "US mpg", "mpg" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "US oz", "US tbsp" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "US pt", "US cup" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "US pt", "US oz" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "US quart", "US pt" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "US tbsp", "US tsp" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "US ton", "lbs" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "week", "day" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "Wh", "J" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "yr", "day" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "yr", "month" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "μm", "nm" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Conversion",
                keyColumns: new[] { "FromUnitSymbol", "ToUnitSymbol" },
                keyValues: new object[] { "μs", "ns" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 1, "ac" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 1, "ft²" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 1, "ha" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 1, "in²" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 1, "km²" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 1, "m²" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 1, "mi²" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 1, "yd²" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 3, "B" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 3, "bit" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 3, "GB" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 3, "Gbit" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 3, "GiB" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 3, "Gibit" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 3, "kB" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 3, "kbit" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 3, "KiB" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 3, "Kibit" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 3, "MB" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 3, "Mbit" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 3, "MiB" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 3, "Mibit" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 3, "PB" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 3, "Pbit" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 3, "PiB" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 3, "Pibit" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 3, "TB" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 3, "Tbit" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 3, "TiB" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 3, "Tibit" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 4, "cm" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 4, "dm" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 4, "ft" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 4, "in" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 4, "km" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 4, "m" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 4, "mi" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 4, "mm" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 4, "nm" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 4, "nmi" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 4, "yd" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 4, "μm" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 5, "Btu" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 5, "cal" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 5, "eV" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 5, "ft-lb" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 5, "J" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 5, "kCal" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 5, "kJ" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 5, "kWh" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 5, "thm" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 5, "Wh" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 6, "GHz" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 6, "Hz" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 6, "kHz" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 6, "MHz" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 7, "km/L" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 7, "mpg" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 7, "US mpg" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 8, "g" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 8, "kg" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 8, "lbs" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 8, "mg" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 8, "oz" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 8, "st" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 8, "t" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 8, "ton" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 8, "US ton" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 8, "μg" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 9, "arcmin" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 9, "arcsec" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 9, "deg" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 9, "gon" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 9, "mrad" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 9, "rad" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 10, "atm" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 10, "bar" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 10, "Pa" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 10, "psi" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 10, "Torr" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 11, "fps" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 11, "km/h" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 11, "kn" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 11, "m/s" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 11, "mph" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 13, "century" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 13, "day" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 13, "decade" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 13, "hr" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 13, "min" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 13, "month" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 13, "ms" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 13, "ns" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 13, "s" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 13, "week" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 13, "yr" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 13, "μs" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 14, "cup" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 14, "fluid oz" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 14, "ft³" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 14, "gal" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 14, "in³" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 14, "L" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 14, "m³" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 14, "mL" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 14, "pt" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 14, "quart" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 14, "tbsp" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 14, "tsp" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 14, "US cup" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 14, "US gal" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 14, "US oz" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 14, "US pt" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 14, "US quart" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 14, "US tbsp" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitTypeMap",
                keyColumns: new[] { "UnitTypeId", "UnitSymbol" },
                keyValues: new object[] { 14, "US tsp" });

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "arcmin");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "arcsec");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "atm");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "B");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "bar");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "bit");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "Btu");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "cal");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "century");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "cup");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "day");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "decade");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "deg");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "eV");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "fluid oz");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "fps");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "ft³");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "ft-lb");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "g");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "gal");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "GB");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "Gbit");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "GHz");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "GiB");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "Gibit");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "gon");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "hr");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "Hz");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "in³");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "J");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "kB");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "kbit");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "kCal");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "kg");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "kHz");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "KiB");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "Kibit");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "kJ");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "km/h");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "km/L");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "kn");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "kWh");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "L");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "lbs");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "m/s");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "m³");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "MB");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "Mbit");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "mg");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "MHz");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "MiB");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "Mibit");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "min");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "mL");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "month");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "mpg");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "mph");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "mrad");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "ms");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "ns");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "oz");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "Pa");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "PB");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "Pbit");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "PiB");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "Pibit");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "psi");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "pt");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "quart");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "rad");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "s");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "st");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "t");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "TB");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "Tbit");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "tbsp");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "thm");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "TiB");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "Tibit");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "ton");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "Torr");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "tsp");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "US cup");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "US gal");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "US mpg");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "US oz");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "US pt");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "US quart");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "US tbsp");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "US ton");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "US tsp");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "week");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "Wh");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "yr");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "μg");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "Unit",
                keyColumn: "Symbol",
                keyValue: "μs");

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitType",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitType",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitType",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitType",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitType",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitType",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitType",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitType",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitType",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "Conversions",
                table: "UnitType",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.UpdateData(
                schema: "Conversions",
                table: "BaseUnitMap",
                keyColumn: "UnitTypeId",
                keyValue: 1,
                column: "BaseUnitSymbol",
                value: "m");

            migrationBuilder.InsertData(
                schema: "Conversions",
                table: "Conversion",
                columns: new[] { "FromUnitSymbol", "ToUnitSymbol", "Multiplier" },
                values: new object[,]
                {
                    { "m", "μm", 1000000.0 },
                    { "m", "nm", 1000000000.0 }
                });

            migrationBuilder.UpdateData(
                schema: "Conversions",
                table: "UnitType",
                keyColumn: "Id",
                keyValue: 1,
                column: "DisplayName",
                value: "Distance");

            migrationBuilder.InsertData(
                schema: "Conversions",
                table: "UnitType",
                columns: new[] { "Id", "DisplayName" },
                values: new object[] { 2, "Area" });

            migrationBuilder.InsertData(
                schema: "Conversions",
                table: "UnitTypeMap",
                columns: new[] { "UnitTypeId", "UnitSymbol" },
                values: new object[,]
                {
                    { 1, "ft" },
                    { 1, "yd" },
                    { 1, "mi" },
                    { 1, "nm" },
                    { 1, "μm" },
                    { 1, "cm" },
                    { 1, "in" },
                    { 1, "dm" },
                    { 1, "m" },
                    { 1, "km" },
                    { 1, "mm" },
                    { 1, "nmi" }
                });

            migrationBuilder.InsertData(
                schema: "Conversions",
                table: "BaseUnitMap",
                columns: new[] { "UnitTypeId", "BaseUnitSymbol" },
                values: new object[] { 2, "km²" });

            migrationBuilder.InsertData(
                schema: "Conversions",
                table: "UnitTypeMap",
                columns: new[] { "UnitTypeId", "UnitSymbol" },
                values: new object[,]
                {
                    { 2, "km²" },
                    { 2, "m²" },
                    { 2, "mi²" },
                    { 2, "yd²" },
                    { 2, "ft²" },
                    { 2, "in²" },
                    { 2, "ha" },
                    { 2, "ac" }
                });
        }
    }
}

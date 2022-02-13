using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnyJob.Persistence.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Software development" },
                    { 2, "Quality Assurance /Control" },
                    { 3, "UI/UX/Graphic Design" },
                    { 4, "Product/Project Management" },
                    { 5, "Sales/service management" },
                    { 6, "Marketing/Advertising" },
                    { 7, "Finance Management" },
                    { 8, "Healthcare/Pharmaceutical" },
                    { 9, "Human Resources" },
                    { 10, "Production" },
                    { 11, "Business/Management" },
                    { 12, "IT security/Networks" },
                    { 13, "Insurance" },
                    { 14, "Data Science/Data Engineering" },
                    { 15, "Foreign language" },
                    { 16, "Economics" },
                    { 17, "Hardware Design / Engineering" },
                    { 18, "System Admin/Engineer" },
                    { 19, "Content writing" },
                    { 20, "DevOps/Infrastructure" }
                });

            migrationBuilder.InsertData(
                table: "EmploymentTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Full Time" },
                    { 2, "Part Time" },
                    { 3, "Contractor" },
                    { 4, "Intern" },
                    { 5, "Seasonal / Temp" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "City", "Country", "State" },
                values: new object[,]
                {
                    { 1, "Yerevan", "Armenia", null },
                    { 2, "Baltimore", "United States", "Maryland" },
                    { 3, "Tsaghkaber", "Armenia", null },
                    { 4, "Whitwell", "United Kingdom", "England" },
                    { 5, "Dortmund", "Germany", "Nordrhein-Westfalen" },
                    { 6, "Wuppertal", "Germany", "Nordrhein-Westfalen" },
                    { 7, "San Antonio", "United States", null },
                    { 8, "Sydney Mines", "Canada", null },
                    { 9, "North Battleford", "Canada", null },
                    { 10, "Fermont", "Canada", "Quebec" },
                    { 11, "Archis", "Armenia", null },
                    { 12, "Abovyan", "Armenia", null },
                    { 13, "Bagratashen", "Armenia", null },
                    { 14, "Aurora", "United States", "Colorado" },
                    { 15, "Las Vegas", "United States", "Nevada" },
                    { 16, "San Antonio", "United States", "Texas" },
                    { 17, "Valencia", "Spain", "Comunidad Valenciana" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "City", "Country", "State" },
                values: new object[,]
                {
                    { 18, "Thessalon", "Canada", "Ontario" },
                    { 19, "Logrono", "Spain", "La Rioja" },
                    { 20, "Buffalo", "United States", "New York" },
                    { 21, "Summerland", "Canada", "British Columbia" },
                    { 22, "Zamora", "Spain", "Castilla - Leon" },
                    { 23, "Labrador City", "Canada", "Newfoundland and Labrador" },
                    { 24, "Bassano", "Canada", "Alberta" },
                    { 25, "Ceuta", "Spain", "Ceuta" },
                    { 26, "Atlanta", "United States", null },
                    { 27, "Stuttgart", "Germany", "Baden-Württemberg" },
                    { 28, "Hannover", "Germany", "Niedersachsen" },
                    { 29, "Harbour Breton", "Canada", "Newfoundland and Labrador" },
                    { 30, "Alexandria", "United States", "Virginia" },
                    { 31, "New Orleans", "United States", "Louisiana" },
                    { 32, "Akunk’", "Armenia", null },
                    { 33, "Gagarin", "Armenia", null },
                    { 34, "Windsor", "Canada", "Quebec" },
                    { 35, "Bartsrashen", "Armenia", null },
                    { 36, "Santander", "Spain", null },
                    { 37, "Perth", "Australia", "Western Australia" },
                    { 38, "Orlando", "United States", "Florida" },
                    { 39, "Munchen", "Germany", "Bayern" },
                    { 40, "Solingen", "Germany", "Nordrhein-Westfalen" }
                });

            migrationBuilder.InsertData(
                table: "JobPostings",
                columns: new[] { "Id", "CategoryId", "EmploymentTypeId", "LocationId", "Title" },
                values: new object[,]
                {
                    { 1, 14, 5, 11, "VP Product Management" },
                    { 2, 19, 1, 10, "Analog Circuit Design manager" },
                    { 3, 7, 5, 18, "GIS Technical Architect" },
                    { 4, 19, 2, 21, "Nurse Practicioner" },
                    { 5, 9, 3, 24, "Assistant Professor" },
                    { 6, 20, 4, 23, "Systems Administrator II" },
                    { 7, 11, 3, 5, "Graphic Designer" },
                    { 8, 19, 1, 13, "Web Developer IV" },
                    { 9, 9, 2, 28, "VP Accounting" },
                    { 10, 8, 2, 18, "Geological Engineer" },
                    { 11, 9, 4, 29, "Information Systems Manager" },
                    { 12, 11, 1, 13, "Software Test Engineer III" },
                    { 13, 11, 2, 11, "Technical Writer" },
                    { 14, 7, 4, 20, "Geological Engineer" },
                    { 15, 16, 1, 12, "Programmer I" },
                    { 16, 4, 5, 35, "Food Chemist" },
                    { 17, 3, 5, 38, "Systems Administrator IV" },
                    { 18, 3, 5, 34, "Business Systems Development Analyst" },
                    { 19, 19, 4, 19, "Business Systems Development Analyst" },
                    { 20, 12, 3, 32, "Junior Executive" },
                    { 21, 9, 1, 17, "Senior Sales Associate" },
                    { 22, 9, 1, 37, "Research Assistant I" },
                    { 23, 3, 3, 1, "Compensation Analyst" },
                    { 24, 18, 2, 30, "Media Manager I" },
                    { 25, 3, 2, 24, "Physical Therapy Assistant" },
                    { 26, 10, 5, 37, "Paralegal" },
                    { 27, 8, 3, 38, "Safety Technician I" },
                    { 28, 2, 1, 33, "Teacher" },
                    { 29, 2, 5, 23, "VP Sales" },
                    { 30, 13, 5, 30, "Clinical Specialist" },
                    { 31, 20, 1, 37, "Food Chemist" },
                    { 32, 17, 3, 23, "Associate Professor" },
                    { 33, 20, 1, 10, "Developer II" },
                    { 34, 13, 2, 10, "Data Coordiator" },
                    { 35, 5, 2, 25, "Health Coach IV" },
                    { 36, 4, 2, 11, "Staff Scientist" },
                    { 37, 8, 5, 10, "Social Worker" },
                    { 38, 10, 3, 28, "Financial Advisor" },
                    { 39, 5, 2, 13, "Database Administrator II" },
                    { 40, 13, 5, 13, "VP Sales" },
                    { 41, 8, 3, 2, "Software Consultant" },
                    { 42, 9, 2, 34, "Database Administrator II" }
                });

            migrationBuilder.InsertData(
                table: "JobPostings",
                columns: new[] { "Id", "CategoryId", "EmploymentTypeId", "LocationId", "Title" },
                values: new object[,]
                {
                    { 43, 19, 2, 36, "Office Assistant III" },
                    { 44, 7, 4, 16, "Paralegal" },
                    { 45, 2, 5, 32, "Database Administrator II" },
                    { 46, 10, 1, 34, "Food Chemist" },
                    { 47, 13, 5, 27, "Computer Systems Analyst III" },
                    { 48, 20, 5, 17, "Assistant Professor" },
                    { 49, 19, 3, 24, "Technical Writer" },
                    { 50, 12, 1, 33, "Help Desk Technician" },
                    { 51, 12, 1, 28, "Cost Accountant" },
                    { 52, 8, 4, 14, "Health Coach I" },
                    { 53, 6, 1, 10, "Executive Secretary" },
                    { 54, 10, 3, 2, "Analog Circuit Design manager" },
                    { 55, 17, 3, 9, "Dental Hygienist" },
                    { 56, 9, 2, 10, "Design Engineer" },
                    { 57, 7, 5, 29, "Health Coach III" },
                    { 58, 13, 5, 14, "Speech Pathologist" },
                    { 59, 1, 4, 22, "Research Associate" },
                    { 60, 18, 2, 2, "VP Quality Control" },
                    { 61, 7, 5, 11, "Executive Secretary" },
                    { 62, 2, 2, 11, "Internal Auditor" },
                    { 63, 16, 4, 32, "Biostatistician II" },
                    { 64, 5, 1, 19, "Internal Auditor" },
                    { 65, 2, 2, 37, "Senior Financial Analyst" },
                    { 66, 1, 2, 1, "Internal Auditor" },
                    { 67, 4, 1, 27, "Senior Cost Accountant" },
                    { 68, 10, 2, 37, "Geological Engineer" },
                    { 69, 9, 2, 30, "Administrative Assistant IV" },
                    { 70, 11, 2, 27, "Research Assistant III" },
                    { 71, 13, 4, 26, "Account Executive" },
                    { 72, 17, 3, 12, "Account Executive" },
                    { 73, 3, 2, 39, "Senior Quality Engineer" },
                    { 74, 11, 2, 27, "Social Worker" },
                    { 75, 18, 5, 40, "Nurse" },
                    { 76, 4, 1, 15, "Web Designer II" },
                    { 77, 8, 2, 37, "Database Administrator II" },
                    { 78, 12, 1, 26, "Electrical Engineer" },
                    { 79, 17, 5, 7, "Quality Engineer" },
                    { 80, 3, 3, 1, "Geological Engineer" },
                    { 81, 5, 5, 13, "Cost Accountant" },
                    { 82, 17, 4, 11, "Geologist I" },
                    { 83, 7, 1, 34, "Structural Analysis Engineer" },
                    { 84, 7, 5, 5, "Biostatistician I" }
                });

            migrationBuilder.InsertData(
                table: "JobPostings",
                columns: new[] { "Id", "CategoryId", "EmploymentTypeId", "LocationId", "Title" },
                values: new object[,]
                {
                    { 85, 2, 1, 3, "Physical Therapy Assistant" },
                    { 86, 13, 1, 33, "Environmental Tech" },
                    { 87, 10, 3, 6, "Assistant Professor" },
                    { 88, 19, 2, 35, "Accounting Assistant I" },
                    { 89, 17, 2, 31, "Analog Circuit Design manager" },
                    { 90, 12, 1, 16, "Nuclear Power Engineer" },
                    { 91, 3, 2, 24, "Analog Circuit Design manager" },
                    { 92, 16, 4, 12, "Community Outreach Specialist" },
                    { 93, 20, 3, 32, "Environmental Specialist" },
                    { 94, 19, 4, 12, "Desktop Support Technician" },
                    { 95, 5, 2, 37, "Financial Advisor" },
                    { 96, 12, 4, 4, "Graphic Designer" },
                    { 97, 13, 4, 7, "Occupational Therapist" },
                    { 98, 18, 2, 14, "Research Associate" },
                    { 99, 10, 5, 28, "Chief Design Engineer" },
                    { 100, 17, 1, 26, "Systems Administrator II" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "EmploymentTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EmploymentTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EmploymentTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EmploymentTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EmploymentTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 40);
        }
    }
}

using EAP.Entity.Models.Country;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EAP.Entity.Configurations
{
    public class CountriesConfiguration : IEntityTypeConfiguration<Countries>
    {
        public void Configure(EntityTypeBuilder<Countries> builder)
        {
            builder.HasData(
                new Countries { Id = 1, CountryName = "Afghanistan", Code = "AF" },
                new Countries { Id = 2, CountryName = "Åland Islands", Code = "AX" },
                new Countries { Id = 3, CountryName = "Albania", Code = "AL" },
                new Countries { Id = 4, CountryName = "Algeria", Code = "DZ" },
                new Countries { Id = 5, CountryName = "American Samoa", Code = "AS" },
                new Countries { Id = 6, CountryName = "AndorrA", Code = "AD" },
                new Countries { Id = 7, CountryName = "Angola", Code = "AO" },
                new Countries { Id = 8, CountryName = "Antarctica", Code = "AQ" },
                new Countries { Id = 9, CountryName = "Antigua and Barbuda", Code = "AG" },
                new Countries { Id = 10, CountryName = "Argentina", Code = "AR" },
                new Countries { Id = 11, CountryName = "Armenia", Code = "AM" },
                new Countries { Id = 12, CountryName = "Aruba", Code = "AW" },
                new Countries { Id = 13, CountryName = "Australia", Code = "AU" },
                new Countries { Id = 14, CountryName = "Austria", Code = "AT" },
                new Countries { Id = 15, CountryName = "Azerbaijan", Code = "AZ" },
                new Countries { Id = 16, CountryName = "Bahamas", Code = "BS" },
                new Countries { Id = 17, CountryName = "Bahrain", Code = "BH" },
                new Countries { Id = 18, CountryName = "Bangladesh", Code = "BD" },
                new Countries { Id = 19, CountryName = "Barbados", Code = "BB" },
                new Countries { Id = 20, CountryName = "Belarus", Code = "BY" },
                new Countries { Id = 21, CountryName = "Belgium", Code = "BE" },
                new Countries { Id = 22, CountryName = "Belize", Code = "BZ" },
                new Countries { Id = 23, CountryName = "Benin", Code = "BJ" },
                new Countries { Id = 24, CountryName = "Bermuda", Code = "BM" },
                new Countries { Id = 25, CountryName = "Bhutan", Code = "BT" },
                new Countries { Id = 26, CountryName = "Bolivia", Code = "BO" },
                new Countries { Id = 27, CountryName = "Bosnia and Herzegovina", Code = "BA" },
                new Countries { Id = 28, CountryName = "Botswana", Code = "BW" },
                new Countries { Id = 29, CountryName = "Bouvet Island", Code = "BV" },
                new Countries { Id = 30, CountryName = "Brazil", Code = "BR" },
                new Countries { Id = 31, CountryName = "British Indian Ocean Territory", Code = "IO" },
                new Countries { Id = 32, CountryName = "Brunei Darussalam", Code = "BN" },
                new Countries { Id = 33, CountryName = "Bulgaria", Code = "BG" },
                new Countries { Id = 34, CountryName = "Burkina Faso", Code = "BF" },
                new Countries { Id = 35, CountryName = "Burundi", Code = "BI" },
                new Countries { Id = 36, CountryName = "Cambodia", Code = "KH" },
                new Countries { Id = 37, CountryName = "Cameroon", Code = "CM" },
                new Countries { Id = 38, CountryName = "Canada", Code = "CA" },
                new Countries { Id = 39, CountryName = "Cape Verde", Code = "CV" },
                new Countries { Id = 40, CountryName = "Cayman Islands", Code = "KY" },
                new Countries { Id = 41, CountryName = "Central African Republic", Code = "CF" },
                new Countries { Id = 42, CountryName = "Chad", Code = "TD" },
                new Countries { Id = 43, CountryName = "Chile", Code = "CL" },
                new Countries { Id = 44, CountryName = "China", Code = "CN" },
                new Countries { Id = 45, CountryName = "Christmas Island", Code = "CX" },
                new Countries { Id = 46, CountryName = "Cocos (Keeling) Islands", Code = "CC" },
                new Countries { Id = 47, CountryName = "Colombia", Code = "CO" },
                new Countries { Id = 48, CountryName = "Comoros", Code = "KM" },
                new Countries { Id = 49, CountryName = "Congo", Code = "CG" },
                new Countries { Id = 50, CountryName = "Congo, The Democratic Republic of the", Code = "CD" },
                new Countries { Id = 51, CountryName = "Cook Islands", Code = "CK" },
                new Countries { Id = 52, CountryName = "Costa Rica", Code = "CR" },
                new Countries { Id = 53, CountryName = "Cote D'Ivoire", Code = "CI" },
                new Countries { Id = 54, CountryName = "Croatia", Code = "HR" },
                new Countries { Id = 55, CountryName = "Cuba", Code = "CU" },
                new Countries { Id = 56, CountryName = "Cyprus", Code = "CY" },
                new Countries { Id = 57, CountryName = "Czech Republic", Code = "CZ" },
                new Countries { Id = 58, CountryName = "Denmark", Code = "DK" },
                new Countries { Id = 59, CountryName = "Djibouti", Code = "DJ" },
                new Countries { Id = 60, CountryName = "Dominica", Code = "DM" },
                new Countries { Id = 61, CountryName = "Dominican Republic", Code = "DO" },
                new Countries { Id = 62, CountryName = "Ecuador", Code = "EC" },
                new Countries { Id = 63, CountryName = "Egypt", Code = "EG" },
                new Countries { Id = 64, CountryName = "El Salvador", Code = "SV" },
                new Countries { Id = 65, CountryName = "Equatorial Guinea", Code = "GQ" },
                new Countries { Id = 66, CountryName = "Eritrea", Code = "ER" },
                new Countries { Id = 67, CountryName = "Estonia", Code = "EE" },
                new Countries { Id = 68, CountryName = "Ethiopia", Code = "ET" },
                new Countries { Id = 69, CountryName = "Falkland Islands (Malvinas)", Code = "FK" },
                new Countries { Id = 70, CountryName = "Faroe Islands", Code = "FO" },
                new Countries { Id = 71, CountryName = "Fiji", Code = "FJ" },
                new Countries { Id = 72, CountryName = "Finland", Code = "FI" },
                new Countries { Id = 73, CountryName = "France", Code = "FR" },
                new Countries { Id = 74, CountryName = "French Guiana", Code = "GF" },
                new Countries { Id = 75, CountryName = "French Polynesia", Code = "PF" },
                new Countries { Id = 76, CountryName = "French Southern Territories", Code = "TF" },
                new Countries { Id = 77, CountryName = "Gabon", Code = "GA" },
                new Countries { Id = 78, CountryName = "Gambia", Code = "GM" },
                new Countries { Id = 79, CountryName = "Georgia", Code = "GE" },
                new Countries { Id = 80, CountryName = "Germany", Code = "DE" },
                new Countries { Id = 81, CountryName = "Ghana", Code = "GH" },
                new Countries { Id = 82, CountryName = "Gibraltar", Code = "GI" },
                new Countries { Id = 83, CountryName = "Greece", Code = "GR" },
                new Countries { Id = 84, CountryName = "Greenland", Code = "GL" },
                new Countries { Id = 85, CountryName = "Grenada", Code = "GD" },
                new Countries { Id = 86, CountryName = "Guadeloupe", Code = "GP" },
                new Countries { Id = 87, CountryName = "Guam", Code = "GU" },
                new Countries { Id = 88, CountryName = "Guatemala", Code = "GT" },
                new Countries { Id = 89, CountryName = "Guernsey", Code = "GG" },
                new Countries { Id = 90, CountryName = "Guinea", Code = "GN" },
                new Countries { Id = 91, CountryName = "Guinea-Bissau", Code = "GW" },
                new Countries { Id = 92, CountryName = "Guyana", Code = "GY" },
                new Countries { Id = 93, CountryName = "Haiti", Code = "HT" },
                new Countries { Id = 94, CountryName = "Heard Island and Mcdonald Islands", Code = "HM" },
                new Countries { Id = 95, CountryName = "Holy See (Vatican City States)", Code = "VA" },
                new Countries { Id = 96, CountryName = "Honduras", Code = "HN" },
                new Countries { Id = 97, CountryName = "Hong Kong", Code = "HK" },
                new Countries { Id = 98, CountryName = "Hungary", Code = "HU" },
                new Countries { Id = 99, CountryName = "Iceland", Code = "IS" },
                new Countries { Id = 100, CountryName = "India", Code = "IN" },
                new Countries { Id = 101, CountryName = "Indonesia", Code = "ID" },
                new Countries { Id = 102, CountryName = "Iran, Islamic Republic Of", Code = "IR" },
                new Countries { Id = 103, CountryName = "Iraq", Code = "IQ" },
                new Countries { Id = 104, CountryName = "Ireland", Code = "IE" },
                new Countries { Id = 105, CountryName = "Isle of Man", Code = "IM" },
                new Countries { Id = 106, CountryName = "Israel", Code = "IL" },
                new Countries { Id = 107, CountryName = "Italy", Code = "IT" },
                new Countries { Id = 108, CountryName = "Jamaica", Code = "JM" },
                new Countries { Id = 109, CountryName = "Japan", Code = "JP" },
                new Countries { Id = 110, CountryName = "Jersey", Code = "JE" },
                new Countries { Id = 111, CountryName = "Jordan", Code = "JO" },
                new Countries { Id = 112, CountryName = "Kazakhstan", Code = "KZ" },
                new Countries { Id = 113, CountryName = "Kenya", Code = "KE" },
                new Countries { Id = 114, CountryName = "Kiribati", Code = "KI" },
                new Countries { Id = 115, CountryName = "Korea, Democratic People's Republic of", Code = "KP" },
                new Countries { Id = 116, CountryName = "Korea, Republic of", Code = "KR" },
                new Countries { Id = 117, CountryName = "Kuwait", Code = "KW" },
                new Countries { Id = 118, CountryName = "Kyrgyzstan", Code = "KG" },
                new Countries { Id = 119, CountryName = "Lao People's Democratic Republic", Code = "LA" },
                new Countries { Id = 120, CountryName = "Latvia", Code = "LV" },
                new Countries { Id = 121, CountryName = "Lebanon", Code = "LB" },
                new Countries { Id = 122, CountryName = "Lesotho", Code = "LS" },
                new Countries { Id = 123, CountryName = "Liberia", Code = "LR" },
                new Countries { Id = 124, CountryName = "Libyan Arab Jamahiriya", Code = "LY" },
                new Countries { Id = 125, CountryName = "Liechtenstein", Code = "LI" },
                new Countries { Id = 126, CountryName = "Lithuania", Code = "LT" },
                new Countries { Id = 127, CountryName = "Luxembourg", Code = "LU" },
                new Countries { Id = 128, CountryName = "Macao", Code = "MO" },
                new Countries { Id = 129, CountryName = "Macedonia, The Former Yugoslav Republic of", Code = "MK" },
                new Countries { Id = 130, CountryName = "Madagascar", Code = "MG" },
                new Countries { Id = 131, CountryName = "Malawi", Code = "MW" },
                new Countries { Id = 132, CountryName = "Malaysia", Code = "MY" },
                new Countries { Id = 133, CountryName = "Maldives", Code = "MV" },
                new Countries { Id = 134, CountryName = "Mali", Code = "ML" },
                new Countries { Id = 135, CountryName = "Malta", Code = "MT" },
                new Countries { Id = 136, CountryName = "Marshall Islands", Code = "MH" },
                new Countries { Id = 137, CountryName = "Martinique", Code = "MQ" },
                new Countries { Id = 138, CountryName = "Mauritania", Code = "MR" },
                new Countries { Id = 139, CountryName = "Mauritius", Code = "MU" },
                new Countries { Id = 140, CountryName = "Mayotte", Code = "YT" },
                new Countries { Id = 141, CountryName = "Mexico", Code = "MX" },
                new Countries { Id = 142, CountryName = "Micronesia, Federated Statess of", Code = "FM" },
                new Countries { Id = 143, CountryName = "Moldova, Republic of", Code = "MD" },
                new Countries { Id = 144, CountryName = "Monaco", Code = "MC" },
                new Countries { Id = 145, CountryName = "Mongolia", Code = "MN" },
                new Countries { Id = 146, CountryName = "Montserrat", Code = "MS" },
                new Countries { Id = 147, CountryName = "Morocco", Code = "MA" },
                new Countries { Id = 148, CountryName = "Mozambique", Code = "MZ" },
                new Countries { Id = 149, CountryName = "Myanmar", Code = "MM" },
                new Countries { Id = 150, CountryName = "Namibia", Code = "NA" },
                new Countries { Id = 151, CountryName = "Nauru", Code = "NR" },
                new Countries { Id = 152, CountryName = "Nepal", Code = "NP" },
                new Countries { Id = 153, CountryName = "Netherlands", Code = "NL" },
                new Countries { Id = 154, CountryName = "Netherlands Antilles", Code = "AN" },
                new Countries { Id = 155, CountryName = "New Caledonia", Code = "NC" },
                new Countries { Id = 156, CountryName = "New Zealand", Code = "NZ" },
                new Countries { Id = 157, CountryName = "Nicaragua", Code = "NI" },
                new Countries { Id = 158, CountryName = "Niger", Code = "NE" },
                new Countries { Id = 159, CountryName = "Nigeria", Code = "NG" },
                new Countries { Id = 160, CountryName = "Niue", Code = "NU" },
                new Countries { Id = 161, CountryName = "Norfolk Island", Code = "NF" },
                new Countries { Id = 162, CountryName = "Northern Mariana Islands", Code = "MP" },
                new Countries { Id = 163, CountryName = "Norway", Code = "NO" },
                new Countries { Id = 164, CountryName = "Oman", Code = "OM" },
                new Countries { Id = 165, CountryName = "Pakistan", Code = "PK" },
                new Countries { Id = 166, CountryName = "Palau", Code = "PW" },
                new Countries { Id = 167, CountryName = "Palestinian Territory, Occupied", Code = "PS" },
                new Countries { Id = 168, CountryName = "Panama", Code = "PA" },
                new Countries { Id = 169, CountryName = "Papua New Guinea", Code = "PG" },
                new Countries { Id = 170, CountryName = "Paraguay", Code = "PY" },
                new Countries { Id = 171, CountryName = "Peru", Code = "PE" },
                new Countries { Id = 172, CountryName = "Philippines", Code = "PH" },
                new Countries { Id = 173, CountryName = "Pitcairn", Code = "PN" },
                new Countries { Id = 174, CountryName = "Poland", Code = "PN" },
                new Countries { Id = 175, CountryName = "Portugal", Code = "PT" },
                new Countries { Id = 176, CountryName = "Puerto Rico", Code = "PR" },
                new Countries { Id = 177, CountryName = "Qatar", Code = "QA" },
                new Countries { Id = 178, CountryName = "Reunion", Code = "RE" },
                new Countries { Id = 179, CountryName = "Romania", Code = "RO" },
                new Countries { Id = 180, CountryName = "Russian Federation", Code = "RU" },
                new Countries { Id = 181, CountryName = "RWANDA", Code = "RW" },
                new Countries { Id = 182, CountryName = "Saint Helena", Code = "SH" },
                new Countries { Id = 183, CountryName = "Saint Kitts and Nevis", Code = "KN" },
                new Countries { Id = 184, CountryName = "Saint Lucia", Code = "LC" },
                new Countries { Id = 185, CountryName = "Saint Pierre and Miquelon", Code = "PM" },
                new Countries { Id = 186, CountryName = "Saint Vincent and the Grenadines", Code = "VC" },
                new Countries { Id = 187, CountryName = "Samoa", Code = "WS" },
                new Countries { Id = 188, CountryName = "San Marino", Code = "SM" },
                new Countries { Id = 189, CountryName = "Sao Tome and Principe", Code = "ST" },
                new Countries { Id = 190, CountryName = "Saudi Arabia", Code = "SA" },
                new Countries { Id = 191, CountryName = "Senegal", Code = "SN" },
                new Countries { Id = 192, CountryName = "Serbia and Montenegro", Code = "CS" },
                new Countries { Id = 193, CountryName = "Seychelles", Code = "SC" },
                new Countries { Id = 194, CountryName = "Sierra Leone", Code = "SL" },
                new Countries { Id = 195, CountryName = "Singapore", Code = "SG" },
                new Countries { Id = 196, CountryName = "Slovakia", Code = "SK" },
                new Countries { Id = 197, CountryName = "Slovenia", Code = "SI" },
                new Countries { Id = 198, CountryName = "Solomon Islands", Code = "SB" },
                new Countries { Id = 199, CountryName = "Somalia", Code = "SO" },
                new Countries { Id = 200, CountryName = "South Africa", Code = "ZA" },
                new Countries { Id = 201, CountryName = "South Georgia and the South Sandwich Islands", Code = "GS" },
                new Countries { Id = 202, CountryName = "Spain", Code = "ES" },
                new Countries { Id = 203, CountryName = "Sri Lanka", Code = "LK" },
                new Countries { Id = 204, CountryName = "Sudan", Code = "SD" },
                new Countries { Id = 205, CountryName = "Suriname", Code = "SR" },
                new Countries { Id = 206, CountryName = "Svalbard and Jan Mayen", Code = "SJ" },
                new Countries { Id = 207, CountryName = "Swaziland", Code = "SZ" },
                new Countries { Id = 208, CountryName = "Sweden", Code = "SE" },
                new Countries { Id = 209, CountryName = "Switzerland", Code = "CH" },
                new Countries { Id = 210, CountryName = "Syrian Arab Republic", Code = "SY" },
                new Countries { Id = 211, CountryName = "Taiwan, Province of China", Code = "TW" },
                new Countries { Id = 212, CountryName = "Tajikistan", Code = "TJ" },
                new Countries { Id = 213, CountryName = "Tanzania, United Republic of", Code = "TZ" },
                new Countries { Id = 214, CountryName = "Thailand", Code = "TH" },
                new Countries { Id = 215, CountryName = "Timor-Leste", Code = "TL" },
                new Countries { Id = 216, CountryName = "Togo", Code = "TG" },
                new Countries { Id = 217, CountryName = "Tokelau", Code = "TK" },
                new Countries { Id = 218, CountryName = "Tonga", Code = "TO" },
                new Countries { Id = 219, CountryName = "Trinidad and Tobago", Code = "TT" },
                new Countries { Id = 220, CountryName = "Tunisia", Code = "TN" },
                new Countries { Id = 221, CountryName = "Turkey", Code = "TR" },
                new Countries { Id = 222, CountryName = "Turkmenistan", Code = "TM" },
                new Countries { Id = 223, CountryName = "Turks and Caicos Islands", Code = "TC" },
                new Countries { Id = 224, CountryName = "Tuvalu", Code = "TV" },
                new Countries { Id = 225, CountryName = "Uganda", Code = "UG" },
                new Countries { Id = 226, CountryName = "Ukraine", Code = "UA" },
                new Countries { Id = 227, CountryName = "United Arab Emirates", Code = "AE" },
                new Countries { Id = 228, CountryName = "United Kingdom", Code = "GB" },
                new Countries { Id = 229, CountryName = "United Statess", Code = "US" },
                new Countries { Id = 230, CountryName = "United Statess Minor Outlying Islands", Code = "UM" },
                new Countries { Id = 231, CountryName = "Uruguay", Code = "UY" },
                new Countries { Id = 232, CountryName = "Uzbekistan", Code = "UZ" },
                new Countries { Id = 233, CountryName = "Vanuatu", Code = "VU" },
                new Countries { Id = 234, CountryName = "Venezuela", Code = "VE" },
                new Countries { Id = 235, CountryName = "Viet Nam", Code = "VN" },
                new Countries { Id = 236, CountryName = "Virgin Islands, British", Code = "VG" },
                new Countries { Id = 237, CountryName = "Virgin Islands, U.S.", Code = "VI" },
                new Countries { Id = 238, CountryName = "Wallis and Futuna", Code = "WF" },
                new Countries { Id = 239, CountryName = "Western Sahara", Code = "EH" },
                new Countries { Id = 240, CountryName = "Yemen", Code = "YE" },
                new Countries { Id = 241, CountryName = "Zambia", Code = "ZM" },
                new Countries { Id = 242, CountryName = "Zimbabwe", Code = "ZW" }
                );
        }
    }
}
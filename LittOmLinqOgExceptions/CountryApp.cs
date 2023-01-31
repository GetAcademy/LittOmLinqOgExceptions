namespace LittOmLinqOgExceptions
{
    internal class CountryApp
    {
        private readonly Country[] _countries;

        public CountryApp()
        {
            _countries = CreateCountries();
        }

        public void ShowCountriesStartingWith(string prefix)
        {
            //foreach (var country in _countries)
            //{
            //    if (country.Name.StartsWith(prefix))
            //    {
            //        Console.WriteLine(country.Name);
            //    }
            //}

            //var selectedCountryNames0 = new List<string>();
            //foreach (var country in _countries)
            //{
            //    if (country.Name.StartsWith(prefix))
            //    {
            //        selectedCountryNames0.Add(country.Name);
            //    }
            //}


            //var selectedCountriesx = Enumerable.Where(_countries, c => c.Name.StartsWith(prefix));
            
            //var selectedCountries = _countries.Where(c => c.Name.StartsWith(prefix));
            //var selectedCountryNames = selectedCountries.Select(c => c.Name);
            //foreach (var country in selectedCountries)
            //{
            //    Console.WriteLine(country.Name);
            //}

            var selectedCountryNames2 = _countries
                .Where(c => c.Name.StartsWith(prefix))
                .Select(c => c.Name)
                .OrderByDescending(n=>n)
                .Skip(5)
                .Take(5)
                .ToArray();

            foreach (var name in selectedCountryNames2)
            {
                Console.WriteLine(name);
            }
        }

        private static Country[] CreateCountries()
        {
            return new[]
            {
                new Country(1, "China",1439323776,9388211),
                new Country(2, "India",1380004385,2973190),
                new Country(3, "United States",331002651,9147420),
                new Country(4, "Indonesia",273523615,1811570),
                new Country(5, "Pakistan",220892340,77088),
                new Country(6, "Brazil",212559417,8358140),
                new Country(7, "Nigeria",206139589,91077),
                new Country(8, "Bangladesh",164689383,13017),
                new Country(9, "Russia",145934462,16376870),
                new Country(10, "Mexico",128932753,1943950),
                new Country(11, "Japan",126476461,364555),
                new Country(12, "Ethiopia",114963588,1000000),
                new Country(13, "Philippines",109581078,29817),
                new Country(14, "Egypt",102334404,99545),
                new Country(15, "Vietnam",97338579,31007),
                new Country(16, "DR Congo",89561403,2267050),
                new Country(17, "Turkey",84339067,76963),
                new Country(18, "Iran",83992949,1628550),
                new Country(19, "Germany",83783942,34856),
                new Country(20, "Thailand",69799978,51089),
                new Country(21, "United Kingdom",67886011,24193),
                new Country(22, "France",65273511,547557),
                new Country(23, "Italy",60461826,29414),
                new Country(24, "Tanzania",59734218,8858),
                new Country(25, "South Africa",59308690,1213090),
                new Country(26, "Myanmar",54409800,65329),
                new Country(27, "Kenya",53771296,56914),
                new Country(28, "South Korea",51269185,9723),
                new Country(29, "Colombia",50882891,1109500),
                new Country(30, "Spain",46754778,4988),
                new Country(31, "Uganda",45741007,19981),
                new Country(32, "Argentina",45195774,2736690),
                new Country(33, "Algeria",43851044,2381740),
                new Country(34, "Sudan",43849260,1765048),
                new Country(35, "Ukraine",43733762,57932),
                new Country(36, "Iraq",40222493,43432),
                new Country(37, "Afghanistan",38928346,65286),
                new Country(38, "Poland",37846611,30623),
                new Country(39, "Canada",37742154,9093510),
                new Country(40, "Morocco",36910560,4463),
                new Country(41, "Saudi Arabia",34813871,2149690),
                new Country(42, "Uzbekistan",33469203,4254),
                new Country(43, "Peru",32971854,1280000),
                new Country(44, "Angola",32866272,1246700),
                new Country(45, "Malaysia",32365999,32855),
                new Country(46, "Mozambique",31255435,78638),
                new Country(47, "Ghana",31072940,22754),
                new Country(48, "Yemen",29825964,52797),
                new Country(49, "Nepal",29136808,14335),
                new Country(50, "Venezuela",28435940,88205),
                new Country(51, "Madagascar",27691018,581795),
                new Country(52, "Cameroon",26545863,47271),
                new Country(53, "Côte d'Ivoire",26378274,318),
                new Country(54, "North Korea",25778816,12041),
                new Country(55, "Australia",25499884,7682300),
                new Country(56, "Niger",24206644,1266700),
                new Country(57, "Taiwan",23816775,3541),
                new Country(58, "Sri Lanka",21413249,6271),
                new Country(59, "Burkina Faso",20903273,2736),
                new Country(60, "Mali",20250833,1220190),
                new Country(61, "Romania",19237691,23017),
                new Country(62, "Malawi",19129952,9428),
                new Country(63, "Chile",19116201,743532),
                new Country(64, "Kazakhstan",18776707,2699700),
                new Country(65, "Zambia",18383955,74339),
                new Country(66, "Guatemala",17915568,10716),
                new Country(67, "Ecuador",17643054,24836),
                new Country(68, "Syria",17500658,18363),
                new Country(69, "Netherlands",17134872,3372),
                new Country(70, "Senegal",16743927,19253),
                new Country(71, "Cambodia",16718965,17652),
                new Country(72, "Chad",16425864,1259200),
                new Country(73, "Somalia",15893222,62734),
                new Country(74, "Zimbabwe",14862924,38685),
                new Country(75, "Guinea",13132795,24572),
                new Country(76, "Rwanda",12952218,2467),
                new Country(77, "Benin",12123200,11276),
                new Country(78, "Burundi",11890784,2568),
                new Country(79, "Tunisia",11818619,15536),
                new Country(80, "Bolivia",11673021,1083300),
                new Country(81, "Belgium",11589623,3028),
                new Country(82, "Haiti",11402528,2756),
                new Country(83, "Cuba",11326616,10644),
                new Country(84, "South Sudan",11193725,610952),
                new Country(85, "Dominican Republic",10847910,4832),
                new Country(86, "Czech Republic (Czechia)",10708981,7724),
                new Country(87, "Greece",10423054,1289),
                new Country(88, "Jordan",10203134,8878),
                new Country(89, "Portugal",10196709,9159),
                new Country(90, "Azerbaijan",10139177,82658),
                new Country(91, "Sweden",10099265,41034),
                new Country(92, "Honduras",9904607,11189),
                new Country(93, "United Arab Emirates",9890402,836),
                new Country(94, "Hungary",9660351,9053),
                new Country(95, "Tajikistan",9537645,13996),
                new Country(96, "Belarus",9449323,20291),
                new Country(97, "Austria",9006398,82409),
                new Country(98, "Papua New Guinea",8947024,45286),
                new Country(99, "Serbia",8737371,8746),
                new Country(100, "Israel",8655535,2164),
                new Country(101, "Switzerland",8654622,39516),
                new Country(102, "Togo",8278724,5439),
                new Country(103, "Sierra Leone",7976983,7218),
                new Country(104, "Hong Kong",7496981,105),
                new Country(105, "Laos",7275560,2308),
                new Country(106, "Paraguay",7132538,3973),
                new Country(107, "Bulgaria",6948445,10856),
                new Country(108, "Libya",6871292,1759540),
                new Country(109, "Lebanon",6825445,1023),
                new Country(110, "Nicaragua",6624554,12034),
                new Country(111, "Kyrgyzstan",6524195,1918),
                new Country(112, "El Salvador",6486205,2072),
                new Country(113, "Turkmenistan",6031200,46993),
                new Country(114, "Singapore",5850342,700),
                new Country(115, "Denmark",5792202,4243),
                new Country(116, "Finland",5540720,30389),
                new Country(117, "Congo",5518087,3415),
                new Country(118, "Slovakia",5459642,48088),
                new Country(119, "Norway",5421241,365268),
                new Country(120, "Oman",5106626,3095),
                new Country(121, "State of Palestine",5101414,602),
                new Country(122, "Costa Rica",5094118,5106),
                new Country(123, "Liberia",5057681,9632),
                new Country(124, "Ireland",4937786,6889),
                new Country(125, "Central African Republic",4829767,62298),
                new Country(126, "New Zealand",4822233,26331),
                new Country(127, "Mauritania",4649658,1030700),
                new Country(128, "Panama",4314767,7434),
                new Country(129, "Kuwait",4270571,1782),
                new Country(130, "Croatia",4105267,5596),
                new Country(131, "Moldova",4033963,3285),
                new Country(132, "Georgia",3989167,6949),
                new Country(133, "Eritrea",3546421,101),
                new Country(134, "Uruguay",3473730,17502),
                new Country(135, "Bosnia and Herzegovina",3280819,51),
                new Country(136, "Mongolia",3278290,1553560),
                new Country(137, "Armenia",2963243,2847),
                new Country(138, "Jamaica",2961167,1083),
                new Country(139, "Qatar",2881053,1161),
                new Country(140, "Albania",2877797,274),
                new Country(141, "Puerto Rico",2860853,887),
                new Country(142, "Lithuania",2722289,62674),
                new Country(143, "Namibia",2540905,82329),
                new Country(144, "Gambia",2416668,1012),
                new Country(145, "Botswana",2351627,56673),
                new Country(146, "Gabon",2225734,25767),
                new Country(147, "Lesotho",2142249,3036),
                new Country(148, "North Macedonia",2083374,2522),
                new Country(149, "Slovenia",2078938,2014),
                new Country(150, "Guinea-Bissau",1968001,2812),
                new Country(151, "Latvia",1886198,622),
                new Country(152, "Bahrain",1701575,760),
                new Country(153, "Equatorial Guinea",1402985,2805),
                new Country(154, "Trinidad and Tobago",1399488,513),
                new Country(155, "Estonia",1326535,4239),
                new Country(156, "Timor-Leste",1318445,1487),
                new Country(157, "Mauritius",1271768,203),
                new Country(158, "Cyprus",1207359,924),
                new Country(159, "Eswatini",1160164,172),
                new Country(160, "Djibouti",988,2318),
                new Country(161, "Fiji",896,1827),
                new Country(162, "Réunion",895,25),
                new Country(163, "Comoros",870,1861),
                new Country(164, "Guyana",787,19685),
                new Country(165, "Bhutan",772,38117),
                new Country(166, "Solomon Islands",687,2799),
                new Country(167, "Macao",649,30),
                new Country(168, "Montenegro",628,1345),
                new Country(169, "Luxembourg",626,259),
                new Country(170, "Western Sahara",597,266),
                new Country(171, "Suriname",587,156),
                new Country(172, "Cabo Verde",556,403),
                new Country(173, "Micronesia",549,700),
                new Country(174, "Maldives",541,300),
                new Country(175, "Malta",442,320),
                new Country(176, "Brunei",437,527),
                new Country(177, "Guadeloupe",400,169),
                new Country(178, "Belize",398,2281),
                new Country(179, "Bahamas",393,1001),
                new Country(180, "Martinique",375,106),
                new Country(181, "Iceland",341,10025),
                new Country(182, "Vanuatu",307,1219),
                new Country(183, "French Guiana",299,822),
                new Country(184, "Barbados",287,430),
                new Country(185, "New Caledonia",285,1828),
                new Country(186, "French Polynesia",281,366),
                new Country(187, "Mayotte",273,375),
                new Country(188, "Sao Tome & Principe",219,960),
                new Country(189, "Samoa",198,283),
                new Country(190, "Saint Lucia",184,610),
                new Country(191, "Channel Islands",174,190),
                new Country(192, "Guam",169,540),
                new Country(193, "Curaçao",164,444),
                new Country(194, "Kiribati",119,810),
                new Country(195, "Grenada",113,340),
                new Country(196, "St. Vincent & Grenadines",111,390),
                new Country(197, "Aruba",107,180),
                new Country(198, "Tonga",106,720),
                new Country(199, "U.S. Virgin Islands",104,350),
                new Country(200, "Seychelles",98,460),
                new Country(201, "Antigua and Barbuda",98,440),
                new Country(202, "Isle of Man",85,570),
                new Country(203, "Andorra",77,470),
                new Country(204, "Dominica",72,750),
                new Country(205, "Cayman Islands",66,240),
                new Country(206, "Bermuda",62,50),
                new Country(207, "Marshall Islands",59,180),
                new Country(208, "Northern Mariana Islands",58,460),
                new Country(209, "Greenland",57,41045),
                new Country(210, "American Samoa",55,200),
                new Country(211, "Saint Kitts & Nevis",53,260),
                new Country(212, "Faeroe Islands",49,1396),
                new Country(213, "Sint Maarten",43,34),
                new Country(214, "Monaco",39,1),
                new Country(215, "Turks and Caicos",39,950),
                new Country(216, "Saint Martin",39,53),
                new Country(217, "Liechtenstein",38,160),
                new Country(218, "San Marino",34,60),
                new Country(219, "Gibraltar",34,10),
                new Country(220, "British Virgin Islands",30,150),
                new Country(221, "Caribbean Netherlands",26,328),
                new Country(222, "Palau",18,460),
                new Country(223, "Cook Islands",18,240),
                new Country(224, "Anguilla",15,90),
                new Country(225, "Tuvalu",12,30),
                new Country(226, "Wallis & Futuna",11,140),
                new Country(227, "Nauru",11,20),
                new Country(228, "Saint Barthelemy",10,21),
                new Country(229, "Saint Helena",6,390),
                new Country(230, "Saint Pierre & Miquelon",6,230),
                new Country(231, "Montserrat",5,100),
                new Country(232, "Falkland Islands",3,1217),
                new Country(233, "Niue",2,260),
                new Country(234, "Tokelau",1,10),
                new Country(235, "Holy See",801,0),
            };
        }
    }
}

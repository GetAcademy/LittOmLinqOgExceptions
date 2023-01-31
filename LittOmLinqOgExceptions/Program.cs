/*
 - litt om typiske oppgaver bedrift/codealong
 - eksempel landene i verden inkl. rank, befolkning og areal
 - med og uten linq
 - LINQ
   - likhet med SQL
   - to syntakser
   - interface
   - extension method
   - builder pattern
   - anonyme objekter
   - "cheat sheet": https://vslapp.files.wordpress.com/2011/11/linq-cheatsheet.pdf
   - WHERE (tilsvarer filter() i JavaScript)
   - SELECT (tilsvarer map() i JavaScript)
   - ev. interface og IEnumerable og IEnumerator



 - ev. exceptions 
 */

using LittOmLinqOgExceptions;

var app = new CountryApp();
app.ShowCountriesStartingWith("A");

/*
var name = "Terje Kolderup";
var startsAndEndsWithT1 = name.StartsWith("T") && name.EndsWith("T");
var startsAndEndsWithT2 = name.StartsAndEndsWith("T");
var startsAndEndsWithT3 = StringExtensions.StartsAndEndsWith(name, "T");
*/
// ==============================
// STATEMENTS
// ==============================

// Statement (sats) - fullständig instruktion.
// Kan sluta på ; alternativt vara ett block { } av flera statements.

Console.WriteLine("This line is a statement");

if (true)
{
    Console.WriteLine("Statement 1");
    Console.WriteLine("Statement 2");
}


// ==============================
// EXPRESSIONS
// ==============================

// Expression (uttryck) - utvärderas till ett (1) värde.

// 5 + 3
// x * 2
// "Hello" + " " + "World"


// ==============================
// KEYWORDS
// ==============================

// Keywords - reserverade ord i C#-språket.
// Exempel:
// if
// for
// true
// while


// ==============================
// IDENTIFIERS
// ==============================

// Identifiers - namn som man ger till variabler, metoder, klasser etc.
//
// Regler:
// - Kan innehålla bokstäver, siffror och underscore (_)
// - Kan inte innehålla mellanslag eller andra specialtecken
// - Måste börja med en bokstav eller underscore
// - Kan inte börja med en siffra
// - Kan inte använda reserverade ord (keywords)
//
// Namngivningskonventioner i C#:
// - Variabler och parametrar skrivs vanligtvis i camelCase
// - Klasser och metoder skrivs vanligtvis i PascalCase

string name = "Fredrik";


// ==============================
// NAMING CONVENTIONS
// ==============================

// UPPERCASE
// lowercase
// camelCase
// PascalCase
// snake_case

// camelCase
// förstaOrdBörjarMedLitenBokstavOchAllaFöljandeOrdMedStorBokstav

// PascalCase
// AllaOrdBörjarMedStorBokstav

// snake_case
// bara_små_bokstäver_ord_avskilda_med_underscore
// Används normalt inte för vanliga identifiers i C#.


// ==============================
// CASE SENSITIVITY
// ==============================

// C# är case-sensitive.
// Det betyder att stora och små bokstäver spelar roll.

int myVariable;
int MyVariable;

// Dessa räknas som två olika variabler.

US-17 – Lägg till personuppgifter

Individuell C#-implementation för Verktygsdepån.

 Funktioner
- Registrera förnamn, efternamn, e-post och telefonnummer.
- Validera obligatoriska fält.
- Kontrollera e-postformat.
- Visa felmeddelanden vid ogiltiga uppgifter.
- Spara kunder i ett repository i minnet.

Körinstruktioner
1. Ladda ner projektet från GitHub.
2. Öppna projektet i Visual Studio.
3. Installera rätt .NET SDK om det behövs.
4. Starta programmet med Ctrl + F5.
5. Fyll i kunduppgifterna i konsolen.

 Projektstruktur
- Domain: Kundmodell och validering.
- Services: Registreringslogik.
- Repositories: Lagring i minnet.
- Program.cs: Inmatning och felhantering.

 Tester
Huvudflödet har testats med giltiga kunduppgifter.
Alternativflödet har testats med ogiltig e-postadress.

Lagringen har verifierats genom att kontrollera
antalet sparade kunder.

Begränsningar
Kunduppgifterna sparas endast i minnet och
försvinner när programmet avslutas.
		
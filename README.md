# Prosjekt: Den Intelligente Assistenten (Kombinasjon av oppgave 1+2+3)

## Beskrivelse
Dette programmet er en kombinert verktøykasse utviklet i C#. Det demonstrerer bruk av tidsstyrt logikk, avansert metode-håndtering (overloading), og validering av input gjennom kontrollstrukturer.

### Funksjonalitet
* **Personlig Hilsen:** Tar imot brukernavn og bursdag i formatet DD.MM.YYYY, sjekker systemtiden og gir en tilpasset hilsen.
* **Bursdagskalkulator:** Beregner hvor mange dager det er til neste bursdag og hvilken alder brukeren fyller.
* **Avansert Kalkulator:** Kan utføre matematiske operasjoner på enten to spesifikke tall eller en hel rekke med tall ved hjelp av overloads.
* **Sikkerhets- og Miljøanalyse:** En modul som sjekker styrken på passord (basert på lengde) og gir tilbakemelding på temperaturverdier.

---

## Planlegging (Pseudokode / Flytskjema)

### 1. Oppstart og Hilsen
HENT bruker navn
HENT bursdag (DD.MM.YYYY)
HENT nåværende time (0-23)
HVIS time < 12: SKRIV "God morgen"
ELLER HVIS time < 18: SKRIV "God dag"
ELLERS: SKRIV "God kveld"
BEREGN antall dager til neste bursdag (Hvis Dato nå > Bursdag = I år + 1 = Neste bursdag)
BEREGN alder ved neste bursdag (Neste bursdag - Dato nå)
SKRIV "Det er X dager til du fyller Y år"

### 2. Kalkulator (Overloads)
METODE LeggTil(tall1, tall2) -> returner sum
METODE LeggTil(List med tall) -> loop gjennom og returner totalsum

### 3. Logikk/Validering
HVIS inputLengde < 8  : "Svakt passord"
HVIS inputLengde 8-12 : "Medium passord"
HVIS inputLengde > 12 : "Sterk password"

---

## Testplan (Verdier brukt til testing)

For å sikre at programflyten fungerer som forventet, har følgende verdier blitt testet:

| Modul          | Inputverdi          | Forventet resultat                  | Status |
|----------------|---------------------|-------------------------------------|--------|
| Hilsen (Tid)   | 09:00               | "God morgen, [Navn]"                | OK     |
| Hilsen (Tid)   | 20:30               | "God kveld, [Navn]"                 | OK     |
| Passordsjekk   | "123"               | "Svakt passord"                     | OK     |
| Passordsjekk   | "SuperSikkert123"   | "Sterkt passord"                    | OK     |
| Kalkulator     | 5, 10               | 15                                  | OK     |
| Kalkulator     | List{1, 2, 3, 4}    | 10                                  | OK     |
| Temperatur     | -10                 | "Det er kaldt ute"                  | OK     |
| Bursdag        | 25.12.2000          | "Det er X dager til du fyller X år" | OK     |

---

## Bruk av kontrollstrukturer
* **If/Else:** Brukt til tidsbasert hilsen, bursdagsberegning og temperaturmåling.
* **Switch-case:** Brukt i hovedmenyen for å la brukeren velge mellom kalkulator, passordsjekk, temperaturanalyse eller avslutning.
* **While-loop:** Holder programmet kjørende slik at brukeren kan utføre flere oppgaver helt til de velger avslutt.
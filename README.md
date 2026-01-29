
---

# Vesmírná Hra (Space Dodger) – Semestrální projekt

Jednoduchá arkádová hra typu "Space Dodger" vyvinutá v jazyce **C#** s využitím frameworku **Windows Forms**. Cílem hráče je ovládat raketu a vyhýbat se padajícím meteoritům. Za každý meteorit, který úspěšně opustí obrazovku, získává hráč bod.

## 🚀 Technické vlastnosti a OOP principy

Projekt demonstruje klíčové koncepty objektově orientovaného programování:

* **Abstrakce a Dědičnost**: Základní třída `ObjektHry` slouží jako společný předek pro všechny herní objekty (hráč, překážky).
* **Polymorfismus**: Metoda `Pohyb()` je definována v základní třídě a přepsána (`override`) v konkrétních třídách podle jejich chování.
* **Zapouzdření**: Využití modifikátorů přístupu (např. `private set`) pro ochranu stavu herní logiky ve třídě `Logika.cs`.
* **Double Buffering**: Implementováno pro plynulé vykreslování bez blikání obrazovky.

---

## 🛠 Návod na spuštění

Pro spuštění projektu na vašem lokálním počítači postupujte podle těchto kroků:

### Požadavky

* **Visual Studio** (verze 2019 nebo novější).
* **.NET Framework 4.7.2** (součástí instalace Visual Studia).

### Postup

1. **Klonování projektu:**
Stáhněte si repozitář nebo jej naklonujte pomocí příkazu:
```bash
git clone https://github.com/vase-jmeno/vesmirna-hra.git

```


2. **Otevření projektu:**
V kořenové složce projektu vyhledejte soubor `VesmirnaHra.csproj` a otevřete jej v aplikaci Visual Studio.
3. **Obnovení závislostí:**
Visual Studio automaticky načte potřebné knihovny (System.Windows.Forms, System.Drawing). Pokud se tak nestane, klikněte pravým tlačítkem na řešení (Solution) a zvolte **Restore NuGet Packages**.
4. **Sestavení a spuštění:**
Stiskněte klávesu **F5** nebo klikněte na tlačítko **Start** v horní liště Visual Studia.

---

## 🎮 Ovládání hry

Hra se ovládá velmi intuitivně pomocí klávesnice:

* **Šipka doleva**: Pohyb rakety vlevo.
* **Šipka doprava**: Pohyb rakety vpravo.
* **Cíl**: Vyhýbejte se červeným čtvercům (kamenům). Po kolizi hra končí a zobrazí se vaše výsledné skóre.

---

## 📂 Struktura souborů

* `Form1.cs`: Uživatelské rozhraní a zpracování vstupu.
* `Logika.cs`: Hlavní herní smyčka, správa kolizí a skóre.
* `ObjektHry.cs`: Abstraktní základ pro všechny entity.
* `Objekty.cs`: Implementace konkrétních tříd `Raketa` a `Kamen`.
* `Nastaveni.cs`: Konfigurační konstanty (rychlost, rozměry).

---

**Autor:** [Anatolii Shyrokov

**Verze:** 1.0.0

# github-pk-is-2024-sk3
na GitHubu vytvořit první issue s názvem Úkol 001 - inicializační úkoly a první program
 provést spojení mezi lokálem (PC, u kterého sedím) s repozitářem na GitHubu
vyklonovat svůj repo z GitHubu
nastavení identifikace pro commity
 na lokále změnit obsah souboru README.md a provést první inicializační commit
 a nyní opačný postup => provést změnu README.md přímo na GitHubu a na lokále provést git pull
 uvnitř vyklonované složky vytvořit složku s názvem IS-Projekty
 do této složky přidat nový README.md soubor
 pro tyto změny provést další commit a git push
 uvnitř složky IS-Projekty vytvořit další složku 001-prvni-program-vypis-rady
 tuto složku je nyní potřeba otevřít v samostatné instanci aplikace VS Code (ideálně pomocí volby Open in Integrated Terminal a příkazu code .)
alternativa: otevřeme si nové okno aplikace VS Code a v něm si otevřeme složku pomocí Open Folder...
 ověříme, zda máme nainstalován dotnet pomocí příkazu dotnet --version 
 příkaz dotnet new console - vytvoří nám soubory potřebné pro projekt v jazyce C#
 otevřeme soubor launch.json, který se nachází ve složce .vscode a změníme v něm "console": "internalConsole", na "console": "externalTerminal",

# GFPlegendy - FaceToWork


Oficiální GitHub FaceToWork projektu, na účast soutěže AzureCup 2021.
Instruktáž k použití aplikace FaceToWork od týmu GFPlegendy.

# Instalace

Instalace Zip file
export zip file 

# Packages
Projekt využívá balíčky 

* **Emgu.Cv**
* **AForge** + další odvětví (.Imaging, .Video, .VideoDirectShow)
* **Microsoft.Azure.CognitiveServices.Vision.Face**
* **Newtonsoft.Json**

Projekt běží na .NET Frameworku 4.8 (V budoucnu přesun na .NET pro rychlost a crossplatform funkce)


# FaceToWork
Demo/celá aplikace FaceToWork v0.1

Detekce a identifikace obličejů zaměstnanců pomocí kognitivních služeb Azure FaceAPI. Následný zápis do docházky v podobě SQL databáze.
Ke správnému fungování bude potřeba poslat ip adresu, abychom vás napojili do SQL serveru.

Hlavní cíl programu je usnadnění záznamu zaměstnanců při příchodu do práce, kontrola proticovidových opatření (nošení respirátoru), při neidentifikování osoby zařadit do nevítaných osob.
Zatím lze detekce a identifikace pouze v jedné Person Group(která zatím v klidu postačí).



# Použití

Na začátku si můžete nastavit Koncový bod a klíč od Azure Face API :
```csharp
 //variables for Azure Face API
        private static string subscriptionKey = "<subricption key>";
        private static string endpoint = "<endpoint>";
        
        public static IFaceClient faceClient = new FaceClient(
            new ApiKeyServiceClientCredentials(subscriptionKey),
            new System.Net.Http.DelegatingHandler[] { });
```
1. Po zapnutí vám naběhne hlavní menu, se kterým si přejdete do **Docházky** 

![Menu](https://raw.githubusercontent.com/lexa105/FaceToWork-ImageSamples/main/obrazky/Doch%C3%A1zka.png)

2. V docházce dáte tlačítko **Create Person Group** kde zadáte vámi volitelný groupID a Group Name ()

3. Výborně jste vytvořili Person Group. Teď je potřeba zvolit Person Group v ComboBox (při zmáčknutí se načtou skupiny) a můžete začít přidávat Osoby a tváře Při výběru souborů pro osoby vybírejte pouze ty kde bude osoba sama na fotce a je dobře rozeznatelná. Výbrat můžete více foutek najednou program se s tím vypořádá :)

4.Až budete hotovi stačí pouze zmáčknout tlačítko **Train**. A aplikace bude připravena identifikovat lidi.

5. Vraťte se zpátky **Domů**, zde si musíte vybrat dostupná zařízení pro Vchod a Východ (kamerové výstupy), dáte Zapnout Kamery, při spuštění se vám obrazovky zapnou a aplikace bude připravena identifikovat a určovat tváře.







## Licence a copyright

© Tuan Pham Van, Jan Kupka, Ondřej Šponer

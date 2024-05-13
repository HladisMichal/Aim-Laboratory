using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using System.Linq;

public class SkoreScript : MonoBehaviour
{
    public Text CasText;
    public Text PocetText;
    public Text ProcentaText;
    public Text KliknutiText;
    private List<int> skoreList = new List<int>();
    private List<float> casList = new List<float>();
    private List<int> kliknutiList = new List<int>();
    private List<double> procentaList = new List<double>();

    void Start()
    {
        LoadSkore();
        LoadCas();
        LoadKliknuti();
        LoadProcenta();
        UpdateTexts();

    }

    void Update()
    {
        UpdateTexts();
    }

   void UpdateTexts()
    {
        if (casList.Count > 0) // kontrola, zda je v seznamu časů nějaký čas
    {
        // Seřazení časů od nejmenšího k největšímu
        casList.Sort();

        // Vytvoření seznamu řetězců, kde každý řetězec je "pořadí. čas"
        List<string> casStrings = new List<string>();
        for (int i = 0; i < casList.Count; i++)
        {
            casStrings.Add((i + 1) + ". " + casList[i].ToString("F2"));
        }

        // Zobrazení všech časů na nových řádcích
        CasText.text = "Nejlepší časy v módu 20 kliknutí:\n" + string.Join("\n", casStrings);
    }
        else
    {
        CasText.text = "Nejlepší časy v módu 20 kliknutí:\n žádné"; // pokud v seznamu časů není žádný čas, zobrazí se tento text
    }



        if (skoreList.Count > 0) // kontrola, zda je v seznamu skóre nějaké skóre
    {
            // Seřazení skóre od největšího k nejmenšímu
            skoreList.Sort();
            skoreList.Reverse();

            // Vytvoření seznamu řetězců, kde každý řetězec je "pořadí. skóre"
            List<string> skoreStrings = new List<string>();
            for (int i = 0; i < skoreList.Count; i++)
            {
                skoreStrings.Add((i + 1) + ". " + skoreList[i]);
            }

            // Zobrazení všech skóre na nových řádcích
            PocetText.text = "Nejvíce trefení terčů v módu 1 min:\n" + string.Join("\n", skoreStrings);
    }
        else
    {
            PocetText.text = "Nejvíce trefení terčů v módu 1 min:\n žádné"; 
    }




        if (kliknutiList.Count > 0) 
    {
        
        kliknutiList.Sort();
        kliknutiList.Reverse();

       
        List<string> kliknutiStrings = new List<string>();
        for (int i = 0; i < kliknutiList.Count; i++)
        {
            kliknutiStrings.Add(kliknutiList[i].ToString());
        }

        
        KliknutiText.text = string.Join("\n", kliknutiStrings);
    }
        else
    {
        KliknutiText.text = "";
    }
    if (procentaList.Count > 0) // kontrola, zda je v seznamu procent nějaká procenta
{
    // Seřazení procent od největšího k nejmenšímu
    procentaList.Sort((x, y) => y.CompareTo(x));

    // Vytvoření seznamu řetězců, kde každý řetězec je "pořadí. procenta"
    List<string> procentaStrings = new List<string>();
    for (int i = 0; i < procentaList.Count; i++)
    {
        string procentaString;
        if (procentaList[i] % 1 == 0) // pokud je procento celé číslo
        {
            procentaString = procentaList[i].ToString("F0"); // vypíše se bez desetinného místa
        }
        else
        {
            procentaString = procentaList[i].ToString("F2"); // jinak se vypíše s dvěma desetinnými místy
        }
        // Only add the percentage to procentaStrings if it's not empty
        if (!string.IsNullOrEmpty(procentaString))
        {
            procentaStrings.Add((i + 1) + ". " + procentaString + "%");
        }
    }

    // Zobrazení všech procent na nových řádcích
    ProcentaText.text = "Nejlepší procenta úspěšnosti a počet trefených terčů:\n" + string.Join("\n", procentaStrings);
}
else
{
    ProcentaText.text = "Nejlepší procenta úspěšnosti a počet trefených terčů:\n žádné";
}


    }
    public void SaveSkore(int skore)
    {
        
        skoreList.Add(skore);

        // Kontrola, zda existuje adresář, a pokud ne, vytvoří ho
        string dir = "skoreData";
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }

        // Přidání nového skóre do souboru
        File.AppendAllText(dir + "\\skore.txt", skore + Environment.NewLine);
    }

    public void LoadSkore()
    {
        string dir = "skoreData";
        if (File.Exists(dir + "\\skore.txt"))
        {
            skoreList = new List<int>(Array.ConvertAll(File.ReadAllLines(dir + "\\skore.txt"), int.Parse));
        }
        else
        {
           Debug.Log("File not found: " + dir + "\\skore.txt");
        }
    }


    public void SaveCas(float cas)
    {
        // Přidání času do seznamu časů
        casList.Add(cas);

        // Kontrola, zda existuje adresář, a pokud ne, vytvoří ho
        string dir = "casData";
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }

        // Přidání nového času do souboru
        File.AppendAllText(dir + "\\cas.txt", cas + Environment.NewLine);
    }

    public void LoadCas()
    {
        string dir = "casData";
        if (File.Exists(dir + "\\cas.txt"))
        {
            casList = new List<float>(Array.ConvertAll(File.ReadAllLines(dir + "\\cas.txt"), float.Parse));
        }
    }

    public void SaveKliknuti(int kliknuti)
    {
        // Přidání kliknuti do seznamu
        kliknutiList.Add(kliknuti);

        // Kontrola, zda existuje adresář, a pokud ne, vytvoří ho
        string dir = "kliknutiData";
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }

        // Přidání nového počtu kliknutí do souboru
        File.AppendAllText(dir + "\\kliknuti.txt", kliknuti + Environment.NewLine);
    }

    public void SaveProcenta(double procenta)
{
    // Přidání procenta do seznamu
    procentaList.Add(procenta);

    // Kontrola, zda existuje adresář, a pokud ne, vytvoří ho
    string dir = "procentaData";
    if (!Directory.Exists(dir))
    {
        Directory.CreateDirectory(dir);
    }

    // Čtení stávajících procent z souboru
    string filePath = dir + "\\procenta.txt";
    if (File.Exists(filePath))
    {
        string[] existingProcentaStrings = File.ReadAllLines(filePath);
        foreach (string existingProcentaString in existingProcentaStrings)
        {
            // Odstranění znaku procenta a přidání do seznamu
            string trimmedString = existingProcentaString.TrimEnd('%', '\n', ' ');
            if (double.TryParse(trimmedString, out double existingProcenta))
            {
                procentaList.Add(existingProcenta);
            }
        }
    }

    // Seřazení v sestupném pořadí
    procentaList.Sort((x, y) => y.CompareTo(x));

    // Přidání nových procent do souboru
    string[] procentaStrings = new string[procentaList.Count];
    for (int i = 0; i < procentaList.Count; i++)
    {
        // Přidání znaku procenta při převodu na řetězec
        procentaStrings[i] = procentaList[i].ToString() + "%\n";
    }
    File.WriteAllLines(filePath, procentaStrings);
}

    void LoadKliknuti()
{
    string dir = "kliknutiData";
    string path = dir + "\\kliknuti.txt";

    // Kontrola, zda soubor existuje
    if (File.Exists(path))
    {
        // Načtení všech řádků ze souboru a převod na int
        kliknutiList = new List<int>(Array.ConvertAll(File.ReadAllLines(path), int.Parse));
    }
    else
    {
        Debug.Log("File not found: " + path);
    }
}

    public void LoadProcenta()
    {
        string dir = "procentaData";
        if (Directory.Exists(dir))
        {
            string[] procentaStrings = File.ReadAllLines(dir + "\\procenta.txt");
            procentaList = Array.ConvertAll(procentaStrings, s => double.Parse(s.Replace("%", ""))).ToList();
        }
    }

    public void ResetSkore()
    {
        string dir = "skoreData";
        string filePath = dir + "\\skore.txt";
        if (File.Exists(filePath))
        {
            File.WriteAllText(filePath, string.Empty);
        }
        LoadSkore();

    }

    public void ResetCas()
    {
        string dir = "casData";
        string filePath = dir + "\\cas.txt";
        if (File.Exists(filePath))
        {
            File.WriteAllText(filePath, string.Empty);
        }
        LoadCas();
    }

    public void ResetKliknuti()
    {
        string dir = "kliknutiData";
        string filePath = dir + "\\kliknuti.txt";
        if (File.Exists(filePath))
        {
            File.WriteAllText(filePath, string.Empty);
        }
        LoadKliknuti();
    }
    public void ResetProcenta()
    {
        string dir = "procentaData";
        string filePath = dir + "\\procenta.txt";
        if (File.Exists(filePath))
        {
            File.WriteAllText(filePath, string.Empty);
        }
        LoadProcenta();
    }
}
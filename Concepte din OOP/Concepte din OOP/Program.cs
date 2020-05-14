using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepte_din_OOP
{
    //    Programarea Orientată Obiect(POO) este o metodă de
    //proiectare și implementare în care programele sunt
    //reprezentate sub forma unor colecții de obiecte(clase) care
    //interacționează între ele prin intermediul mesajelor.

    //     O clasă este o colecție de obiecte cu aceiași structură
    //(caracteristici) și același comportament(metode sau operaţii)


    //    O clasa este o implementare a unui tip de date abstract.
    //Ea defineşte atributele şi metodele care implementează
    //structura de date respectiv operaţiile tipului de date
    //abstract.

    //  Un obiect este o instanţă a unei clase.El este unic
    //determinat de numele său şi are o stare reprezentată de
    //valorile atributelor sale la un anumit moment particular.


    //    Principalele concepte care stau la baza POO sunt:
    // Abstractizarea
    // Încapsularea
    // Modularizarea
    // Ierarhizarea

    //    Datele definite într-o clasă se mai numesc date-membru,
    //variabile-membru, atribute sau câmpuri, iar operaţiile se mai numesc metode sau funcţii
    //membru.

    //    Controlul accesului la membrii unei clase se realizeaza prin utilizarea
    //urmatorilor specificatori de acces:
    //- public (membrii publici pot fi accesati liber de codul din afara clasei);
    //-private (membrii privati sunt accesibili numai metodelor definite in aceeasi
    //clasa);
    //-protected (membrii protejati pot fi accesati de metodele definite in cadrul
    //aceleiasi clase sau de metodele definite in cadrul claselor care mostenesc clasa
    //data);
    //-internal (specificatorul internal este utilizat pentru a declara membrii care
    //sunt cunoscuti in toate fisierele dintr-un asamblaj, insa nu in afara asamblajului).
    //-protected internal (membrii sunt vizibili atat in clasele care mostenesc
    //clasa in care sunt definiti acesti membrii cat si in cadrul grupului de fisiere care
    //formeaza asamblajul).


    //Exemplu de o clasa este Clasa GradinaZoologica:


    class GradinaZoologica
    {
        // campurile clasei
        int numarDeAnimale;
        int numarDePersonal;


        //Constructorul este o funcție membră
        //specială a unei clase ce se apelează în mod
        //automat la crearea unui obiect
        public GradinaZoologica()
        {
            numarDeAnimale = 0;
            numarDePersonal = 0;
        }
        //metodele clasei:
        public void AdaugaUnAnimal()
        {
            numarDeAnimale++;
        }
        public void AdaugaUnAngajat()
        {
            numarDePersonal++;
        }
        public void AfiseazaInformatii()
        {
            Console.WriteLine("Gradina zoologica are {0} angajati si {1} animale",numarDePersonal,numarDeAnimale);
        }
        //Destructorul este o funcție membră specială
        //a unei clase ce apelează în mod automat la
        //distrugerea unui obiect
        ~GradinaZoologica()
        {
            Console.WriteLine("Gradina zoologica a intrat în faliment ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Cream o instanta a clasei GradinaZoologica
            GradinaZoologica gradinaZoologica = new GradinaZoologica();
            //adaugam 5 angajati apeland metoda clasei "AdaugaUnAngajat" 
            for (int i = 0; i < 5; i++)
            {
                gradinaZoologica.AdaugaUnAngajat();
            }
            //adaugam 25 animale apeland metoda clasei "AdaugaUnAnimal" 
            for (int i = 0; i < 25; i++)
            {
                gradinaZoologica.AdaugaUnAnimal();
            }
            // ca sa primim informatii despre gradina zoologica apelam functia "AfiseazaInformatii"
            gradinaZoologica.AfiseazaInformatii();

            CreareGradinaZoologica();

            // Pentru gradinaZoologica2, destructorul va fi apelat fiind ca iesim din metoda CreareGradinaZoologica
            // Folosim  GarbageCollector-ului pentru a distruge gradinaZoologica2
            GC.Collect();
            Console.ReadKey();
        }
        static void CreareGradinaZoologica()
        {
            //Cream o instanta noua a clasei GradinaZoologica
            GradinaZoologica gradinaZoologica2 = new GradinaZoologica();
            //Aceasta instanta exista numai in metoda aceasta
        }
    }
}

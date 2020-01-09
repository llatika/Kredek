using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiotrowskaPAtrycjaLab1Homework
{
/// <summary>
/// Glowna klasa zawierajaca metody i pola
/// </summary>
public partial class FormMain : Form
{
    int Lawenda = 0;
    int Nasiona = 1;        //Poczatkowa wartosc ilosci nasion rowna sie jeden,aby zapobiec konczeniu sie programu na starcie
    int Pracownicy;
    int Gotowka;
    int MagicznyPlyn;
    int NasionkaOdPracownika;
    int cenaLawenda = 15;
    int cenaNasiona = 3;
    int cenaWorkerKupno = 75;
    int cenaWorkerSprzedaz = 45;
    int cenaMagicznyPlyn = 180;
    Random random = new Random();
    /// <summary>
    /// Event FormMain dodajacy elementy do listy wybieranej combobox oraz wywolujacy metody dzialajace od startu gry
    /// </summary>
    public FormMain()
    {
        InitializeComponent();
        timerCzas.Start();
        timerZlodziej.Start();
        comboBoxRodzajSprzedawanego.Items.Add("Nasiona");
        comboBoxRodzajSprzedawanego.Items.Add("Lawenda");
        comboBoxRodzajSprzedawanego.Items.Add("Pracownicy");
        comboBoxRodzajKupowanego.Items.Add("Pracownicy");
        comboBoxRodzajKupowanego.Items.Add("Magiczny Plyn");
        comboBoxRodzajKupowanego.Items.Add("Lawenda");
        comboBoxWyborRodzajuKupna.Items.Add("Kup nasionami");
        comboBoxWyborRodzajuKupna.Items.Add("Kup gotowka");


    }
    /// <summary>
    /// Event okreslajacy warunki sprzedazy towaru, sposrod dostepnych: Pracownikow,Lawendy i Nasion
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void buttonSprzedaj_Click(object sender, EventArgs e)
    {
        if (textBoxHowMany.Text != null || textBoxHowMany.Text != "")     //Przycisk "sprzedaj"dziala tylko po okresleniu liczby sprzedawanych produktow
        {
            string selectedItem = comboBoxRodzajSprzedawanego.SelectedItem.ToString();

            switch (selectedItem)
            {
                case "Lawenda":
                    if (Lawenda >= Int32.Parse(textBoxHowMany.Text))      //Zamiana typu string na calkowity
                    {
                        Lawenda = Lawenda - Int32.Parse(textBoxHowMany.Text);    //Zmniejszenie liczby Lawendy wartosc sprzedana 
                        Gotowka = Gotowka + Int32.Parse(textBoxHowMany.Text) * cenaLawenda;  //Zwiekszenie ilosci gotowki w zaleznosci od ceny Lawendy
                    }
                    else
                        MessageBox.Show("Nie masz tyle Lawendy");  //W przypadku nie wystarczajacej ilosci zasobu,stosowny komunikat
                    break;
                case "Nasiona":
                    if (Nasiona >= Int32.Parse(textBoxHowMany.Text))
                    {
                        Nasiona = Nasiona - Int32.Parse(textBoxHowMany.Text);
                        Gotowka = Gotowka + Int32.Parse(textBoxHowMany.Text) * cenaNasiona;
                    }
                    else
                        MessageBox.Show("Nie masz tyle Nasion");
                    break;

                case "Pracownicy":
                    if (Pracownicy >= Int32.Parse(textBoxHowMany.Text))
                    {
                        Pracownicy = Pracownicy - Int32.Parse(textBoxHowMany.Text);
                        Gotowka = Gotowka + Int32.Parse(textBoxHowMany.Text) * cenaWorkerSprzedaz;
                    }
                    else
                        MessageBox.Show("Nie masz tyle Pracowników");
                    break;
            }



        }
    }
    /// <summary>
    /// Event okreslajacy warunki kupna zasobów
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void buttonKup_Click(object sender, EventArgs e)
    {

        if (textBoxHowMany.Text != null || textBoxHowMany.Text != "")
        {
            string selectedItem2 = comboBoxRodzajKupowanego.SelectedItem.ToString();

            switch (selectedItem2)

            {
                case "Pracownicy":
                    if (Gotowka >= Int32.Parse(textBoxHowMany2.Text) * cenaWorkerKupno)    //W przypadku wystarczajacej liczby gotowki mozna kupic produkt/pracownika
                    {
                        Pracownicy = Pracownicy + Int32.Parse(textBoxHowMany2.Text);    //Zwiekszanie na liczniku liczby pracownikow
                        Gotowka = Gotowka - Int32.Parse(textBoxHowMany2.Text) * cenaWorkerKupno; //Zmniejszenie na liczniku ilosci gotowki
                    }
                    else
                        MessageBox.Show("Nie masz tyle pieniedzy aby kupic pracownika");//Stosowny komunikat w sytuacji niewystarczajacej ilosci gotowki
                    break;

                case "Lawenda": //W przypadku zakupu Lawendy mamy dwie opcje zakupu: albo za pomoca gotowki albo nasion

                    if (Gotowka >= Int32.Parse(textBoxHowMany2.Text) * cenaLawenda && Nasiona < Int32.Parse(textBoxHowMany2.Text) * cenaLawenda / cenaNasiona) //warunek, jesli wystarczajaco duzo jest gotowki i niewystarczajaco nasion do zakupu
                    {
                        Lawenda = Lawenda + Int32.Parse(textBoxHowMany2.Text);
                        Gotowka = Gotowka - Int32.Parse(textBoxHowMany2.Text) * cenaLawenda;

                    }
                    else if (Nasiona >= Int32.Parse(textBoxHowMany2.Text) * cenaLawenda / cenaNasiona && Gotowka < Int32.Parse(textBoxHowMany2.Text)) //warunek,kiedy jest wystarczajaco duzo nasion i niewystarczajaco duzo gotowki
                    {
                        Lawenda = Lawenda + Int32.Parse(textBoxHowMany2.Text);
                        Nasiona = Nasiona - Int32.Parse(textBoxHowMany2.Text) * cenaLawenda / cenaNasiona;
                    }
                    else  //W przpadku wystarczajacej ilosci obu komponentow wybor za pomoca jakiego chcemy kupic 
                    {
                        string selectedItem3 = comboBoxWyborRodzajuKupna.SelectedItem.ToString();
                        switch (selectedItem3)
                        {
                            case "Kup nasionami":
                                if (Nasiona >= Int32.Parse(textBoxHowMany2.Text) * cenaLawenda / cenaNasiona)
                                {
                                    Lawenda = Lawenda + Int32.Parse(textBoxHowMany2.Text);
                                    Nasiona = Nasiona - Int32.Parse(textBoxHowMany2.Text) * cenaLawenda / cenaNasiona;
                                }
                                else MessageBox.Show("Nie masz tyle nasion, aby kupic lawende");
                                break;
                            case "Kup gotowka":
                                if (Gotowka >= Int32.Parse(textBoxHowMany2.Text) * cenaLawenda)
                                {
                                    Lawenda = Lawenda + Int32.Parse(textBoxHowMany2.Text);
                                    Gotowka = Gotowka - Int32.Parse(textBoxHowMany2.Text) * cenaLawenda;
                                }
                                else
                                    MessageBox.Show("Nie masz tyle pieniedzy aby kupic pracownika");
                                break;

                        }
                    }
                    break;

                case "Magiczny Plyn":
                    if (Lawenda >= Int32.Parse(textBoxHowMany2.Text) * cenaMagicznyPlyn / cenaLawenda)
                    {
                        MagicznyPlyn = MagicznyPlyn + Int32.Parse(textBoxHowMany2.Text);
                        Lawenda = Lawenda - Int32.Parse(textBoxHowMany2.Text) * cenaMagicznyPlyn / cenaLawenda;
                    }
                    else
                        MessageBox.Show("Nie masz tyle pieniedzy aby kupic magiczny plyn");
                    break;
            }

        }
    }
    /// <summary>
    /// Event odliczajacy czas co 1s
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void timerCzas_Tick(object sender, EventArgs e)
    {
        if (MagicznyPlyn <= 0)   //warunek posiadania choc jednego komponentu:Magiczny plyn
        {
            NasionkaOdPracownika = Pracownicy * 2;  //w czasie jednej sekundy w przypadku posiadania magicznego plynu,pracownicy pracuja dwa razy wydajniej
        }
        else
        {
            NasionkaOdPracownika = MagicznyPlyn * Pracownicy * 4; //warunek posiadania choc jednego komponentu:Magiczny plyn. Wowczas Pracownicy pracuja cztery razy wydajniej oraz dodatkowo wynik mnozony przez ilosc Magicznego Plynu
        }
        Nasiona += 1 + (NasionkaOdPracownika * Pracownicy);   //W kazdej sekundzie dostajemy jedno nasiono oraz liczbe nasion od pracownikow

        UpdateLabels();  //metoda odswiezajaca etykiety w kazdej sekundzie 
    }
    /// <summary>
    /// Funkcja odswiezajaca wartosc etykiet
    /// </summary>
    private void UpdateLabels()
    {
        labelLawendaIlosc.Text = Lawenda.ToString();
        labelWorkersQuantity.Text = Pracownicy.ToString();
        labelMoneyQuantity.Text = Gotowka.ToString();
        labelMagicznyPlynIlosc.Text = MagicznyPlyn.ToString();
        labelNasionaIlosc.Text = Nasiona.ToString();


    }
    /// <summary>
    /// Event umozliwiajacy przyspieszenie produkcji,czyli zmniejszenie interwalu z 1s do 250ms
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void buttonPrzyspieszProdukcje_Click(object sender, EventArgs e)
    {
        if (timerCzas.Interval == 1000)
        {
            timerCzas.Interval = 250;
            buttonPrzyspieszProdukcje.Text = "Zwolnij produkcje"; //zmiana napisu na przycisku
        }
        else
        {
            timerCzas.Interval = 1000;
            buttonPrzyspieszProdukcje.Text = "Przyspiesz produkcje";
        }
    }
        
    /// <summary>
    /// Pojawienie sie listy wybieranej okreslajacej w jaki sposob mamy zakupic Lawende,widoczna tylko w przypadku wyboru zakupu Lawendy 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void comboBoxRodzajKupowanego_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (comboBoxRodzajKupowanego.Text == "Lawenda")
            comboBoxWyborRodzajuKupna.Visible = true;     //widoczny combobox
        else
            comboBoxWyborRodzajuKupna.Visible = false;    //niewidoczny combobox
    }

    /// <summary>
    /// Event znikanie podpowiedzi w polu tekstowym
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void textBoxHowMany2_Click(object sender, EventArgs e)
    {
        textBoxHowMany2.Text = "";   //znikanie napisu podpowiedzi
    }
    /// <summary>
    /// Event znikanie podpowiedzi w polu tekstowym
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void textBoxHowMany_Click(object sender, EventArgs e)
    {
        textBoxHowMany.Text = " ";
    }
    /// <summary>
    /// Dodanie nowego timera o interwale 100ms w celu okreslenia przykrych wydarzen losowych w produkcji 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void timerZlodziej_Tick(object sender, EventArgs e)
    {
        if (random.Next(1, 100) < 2)  //randomowe losowanie liczby z zakresu od 1 do 100 oraz wylosowanie liczby mniejszej od 2
        {
            if (MagicznyPlyn > 0)
            {
                MagicznyPlyn = MagicznyPlyn - 1;  //Kradziez jednego Magicznego plynu
                Bitmap image = new Bitmap("3.png"); //zmiana obrazka w tle
                pictureBoxHappyLavender.Image = image;
                MessageBox.Show("Mamma Mia! Zlodziej na zapleczu ukradl Magiczny plyn!");//komunikat o wydarzeniu 
                Bitmap image1 = new Bitmap("1.png"); //ponownie zaladowanie obrazu poczatkowego

                pictureBoxHappyLavender.Image = image1;
            }
        }

        if (random.Next(1, 100) < 3)
        {
            if (Pracownicy > 0)
            {
                Pracownicy = Pracownicy - 1;
                Bitmap image = new Bitmap("5.png");
                pictureBoxHappyLavender.Image = image;
                MessageBox.Show("O psia kostka!Kolejny pracownik odszedl za lepszym groszem..");
                Bitmap image1 = new Bitmap("1.png");

                pictureBoxHappyLavender.Image = image1;
            }
        }

        if (random.Next(1, 100) < 1)
        {
            if (Nasiona > 0)
            {
                Nasiona = 0;
                Bitmap image = new Bitmap("4");
                pictureBoxHappyLavender.Image = image;
                MessageBox.Show("Ratujcie ludzie! Pozar w zagrodzie, splonely wszystkie nasiona! ");
                Bitmap image1 = new Bitmap("1.png");
                   

            }
        }

        if (Nasiona == 0 && Lawenda == 0)   //koniec gry w przypadku braku nasion i lawendy w spichlerzu
        {
            timerZlodziej.Stop();
            MessageBox.Show("Przegranko ");
            Close();
        }

        if(Nasiona!=0 && Gotowka!=0 && Pracownicy!=0 && MagicznyPlyn!=0 && Lawenda!=0 ) //Wygrana w przypadku niezerowych wartosci wszystkich komponentow
        {
            MessageBox.Show(" Wygranko bez oszukiwanka! ");  //komunikat o wygranej
                Close();
        }
    }
    /// <summary>
    /// Funkcja zamykanie okna
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void buttonZakonczGre_Click(object sender, EventArgs e)
    {
        Close();
    }
    /// <summary>
    /// Funkcja ograniczajaca widocznosc etykiety do przypadku wyboru lawendy
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void labelSposobZakupuLawendy_VisibleChanged(object sender, EventArgs e)
    {

        if (comboBoxRodzajKupowanego.Text == "Lawenda")
            labelSposobZakupuLawendy.Visible = true;
        else
            labelSposobZakupuLawendy.Visible = false;

    }
}
}
    


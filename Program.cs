int[] pishrafte1 = new int[100];
int[] tafsir = new int[100];
int[] math = new int[100];
int[] kargah = new int[100];
int[] zaban = new int[100];
int[] pishrafte2 = new int[100];
int[] sheygaraee = new int[100];
int[] tarbiatbadani = new int[100];
int[] systemamel = new int[100];
int[] algoritm = new int[100];
string number1;
string number2;
string number3;
string number4;

string[] name = new string[100];
void names()
{
    name[0] = "hossein"; name[1] = "ali"; name[2] = "mohsen"; name[3] = "bahram"; name[4] = "kazem"; name[5] = "behrooz";
    name[6] = "amir"; name[7] = "sina"; name[8] = "hasan"; name[9] = "mohammad"; name[10] = " eskandar"; name[11] = " reza";
    name[12] = "mahram"; name[13] = "bahram"; name[14] = " shahram"; name[15] = "shadmehr"; name[16] = " ebi"; name[17] = "korosh";
    name[18] = "ehsan"; name[19] = "ahmad"; name[20] = " salar"; name[21] = "sorena"; name[22] = "avesta"; name[23] = "ramin";
    name[24] = "alireza"; name[25] = "mobin"; name[26] = "saeid"; name[27] = "moein"; name[28] = "mehdi"; name[29] = "sadegh";
    name[30] = "jalal"; name[31] = "bohlol"; name[32] = "masood"; name[33] = "erfan"; name[34] = "majid"; name[35] = "omid";
    name[36] = "mehrdad"; name[37] = "hesam"; name[38] = "iliya"; name[39] = "ashkan"; name[40] = "bardiya"; name[41] = "benjamin";
    name[42] = "babak"; name[43] = "behnam"; name[44] = "pooya"; name[45] = "khosro"; name[46] = "daryoosh"; name[47] = "sirvan";
    name[48] = "sadra"; name[49] = "sobhan"; name[50] = "shahab"; name[51] = "zahra"; name[52] = "fatemeh"; name[53] = "reyhaneh";
    name[54] = "homa"; name[55] = "sara"; name[56] = "mona"; name[57] = "azita"; name[58] = "nazanin"; name[59] = "niloofar";
    name[60] = "nastaran"; name[61] = "helen"; name[62] = "asal"; name[63] = "ava"; name[64] = "ghazal"; name[65] = "hana";
    name[66] = "mersana"; name[67] = "aseman"; name[68] = "darya"; name[69] = "donya"; name[70] = "baran"; name[71] = "ayda";
    name[72] = "maedeh"; name[73] = "negar"; name[74] = "negin"; name[75] = "samira"; name[76] = "elnaz"; name[77] = "elham";
    name[78] = "narges"; name[79] = "ameneh"; name[80] = "zeynab"; name[81] = "nasrin"; name[82] = "mahnaz"; name[83] = "bahar";
    name[84] = "niki"; name[85] = "sadaf"; name[86] = "nahid"; name[87] = "akram"; name[88] = "james"; name[89] = "ben";
    name[90] = "kevin"; name[91] = "marco"; name[92] = "selena"; name[93] = "antony"; name[94] = "taylor"; name[95] = "alan";
    name[96] = "maria"; name[97] = "roze"; name[98] = "harry"; name[99] = "nicolas";
}

for (int i = 0; i < 100; i++)
{
    pishrafte1[i] = Random.Shared.Next(0, 21);

    tafsir[i] = Random.Shared.Next(0, 21);

    math[i] = Random.Shared.Next(0, 21);


    kargah[i] = Random.Shared.Next(0, 21);

    zaban[i] = Random.Shared.Next(0, 21);

    pishrafte2[i] = Random.Shared.Next(0, 21);

    sheygaraee[i] = Random.Shared.Next(0, 21);

    tarbiatbadani[i] = Random.Shared.Next(0, 21);

    systemamel[i] = Random.Shared.Next(0, 21);

    algoritm[i] = Random.Shared.Next(0, 21);
}

int pishrafte1score = pishrafte1.Length; int sheygaraeescore = sheygaraee.Length;
int tafsirscore = tafsir.Length; int tarbiatbadaniscore = tarbiatbadani.Length;
int mathscore = math.Length; int systemamelscore = systemamel.Length;
int kargahscore = kargah.Length; int algoritmscore = algoritm.Length;

int zabanscore = zaban.Length;
int pishrafte2score = pishrafte2.Length;

Moadelekol();



Moadeleamali();




Moadelteory();



Moadeldorosasli();

void Moadelekol()
{
    Console.WriteLine(((pishrafte1score * 3) + (tafsirscore * 1) + (mathscore * 2) + (kargahscore * 1) + (zabanscore * 2) + (pishrafte2score * 3) + (sheygaraeescore * 3)
        + (tarbiatbadaniscore * 1) + (systemamelscore * 3) + (algoritmscore * 3)) / 22);





}
void Moadeleamali()
{
    double moadelamali = ((pishrafte1score * 3) + (pishrafte2score * 3) + (sheygaraeescore * 3)) / 9;






}
void Moadelteory()
{
    double moadelteory = ((systemamelscore * 3) + (algoritmscore * 3)) / 6;




}
void Moadeldorosasli()
{
    double moadeldorosasli = ((pishrafte1score * 3) + (pishrafte2score * 3) + (sheygaraeescore * 3)
         + (systemamelscore * 3) + (algoritmscore * 3)) / 15;





}






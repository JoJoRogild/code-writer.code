using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace binaryRW
{
    public partial class Form1 : Form
    {

        int tipNum = 0;

        Random randN = new Random();

        int randomNum;

        string path = "";

        int binaryNum = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            path = textBox2.Text;

            if (path == "")
            {
                MessageBox.Show("please select a path");
                return;
            }

            string text2 = "";
            string text3 = "";
            string text1 = "";
            text1 = textBox1.Text;

            if (comboBox1.Text == "Morse")
            {
                foreach (char letter in text1)
                {

                    text2 += letter;

                    if (text2 == "a")
                    {
                        text3 += "._ ";
                        text2 = "";
                    }
                    else if (text2 == "b")
                    {
                        text3 += "_... ";
                        text2 = "";
                    }
                    else if (text2 == "c")
                    {
                        text3 += "_._. ";
                        text2 = "";
                    }
                    else if (text2 == "d")
                    {
                        text3 += "_.. ";
                        text2 = "";
                    }
                    else if (text2 == "e")
                    {
                        text3 += ". ";
                        text2 = "";
                    }
                    else if (text2 == "f")
                    {
                        text3 += ".._. ";
                        text2 = "";
                    }
                    else if (text2 == "g")
                    {
                        text3 += "__. ";
                        text2 = "";
                    }
                    else if (text2 == "h")
                    {
                        text3 += ".... ";
                        text2 = "";
                    }
                    else if (text2 == "i")
                    {
                        text3 += ".. ";
                        text2 = "";
                    }
                    else if (text2 == "j")
                    {
                        text3 += ".___ ";
                        text2 = "";
                    }
                    else if (text2 == "k")
                    {
                        text3 += "_._ ";
                        text2 = "";
                    }
                    else if (text2 == "l")
                    {
                        text3 += "._.. ";
                        text2 = "";
                    }
                    else if (text2 == "m")
                    {
                        text3 += "__ ";
                        text2 = "";
                    }
                    else if (text2 == "n")
                    {
                        text3 += "_. ";
                        text2 = "";
                    }
                    else if (text2 == "o")
                    {
                        text3 += "___ ";
                        text2 = "";
                    }
                    else if (text2 == "p")
                    {
                        text3 += ".__. ";
                        text2 = "";
                    }
                    else if (text2 == "q")
                    {
                        text3 += "__._ ";
                        text2 = "";
                    }
                    else if (text2 == "r")
                    {
                        text3 += "._. ";
                        text2 = "";
                    }
                    else if (text2 == "s")
                    {
                        text3 += "... ";
                        text2 = "";
                    }
                    else if (text2 == "t")
                    {
                        text3 += "_ ";
                        text2 = "";
                    }
                    else if (text2 == "u")
                    {
                        text3 += ".._ ";
                        text2 = "";
                    }
                    else if (text2 == "v")
                    {
                        text3 += "..._ ";
                        text2 = "";
                    }
                    else if (text2 == "w")
                    {
                        text3 += ".__ ";
                        text2 = "";
                    }
                    else if (text2 == "x")
                    {
                        text3 += "_.._ ";
                        text2 = "";
                    }
                    else if (text2 == "y")
                    {
                        text3 += "_.__ ";
                        text2 = "";
                    }
                    else if (text2 == "z")
                    {
                        text3 += "__.. ";
                        text2 = "";
                    }
                    else if (text2 == "0")
                    {
                        text3 += "_____ ";
                        text2 = "";
                    }
                    else if (text2 == "1")
                    {
                        text3 += ".____ ";
                        text2 = "";
                    }
                    else if (text2 == "2")
                    {
                        text3 += "..___ ";
                        text2 = "";
                    }
                    else if (text2 == "3")
                    {
                        text3 += "...__ ";
                        text2 = "";
                    }
                    else if (text2 == "4")
                    {
                        text3 += "...._ ";
                        text2 = "";
                    }
                    else if (text2 == "5")
                    {
                        text3 += "..... ";
                        text2 = "";
                    }
                    else if (text2 == "6")
                    {
                        text3 += "_.... ";
                        text2 = "";
                    }
                    else if (text2 == "7")
                    {
                        text3 += "__... ";
                        text2 = "";
                    }
                    else if (text2 == "8")
                    {
                        text3 += "___.. ";
                        text2 = "";
                    }
                    else if (text2 == "9")
                    {
                        text3 += "____. ";
                        text2 = "";
                    }
                    else if (text2 == " ")
                    {
                        text3 += "  ";
                        text2 = "";
                    }
                    else
                    {
                        MessageBox.Show("Could not find letter");
                        text2 = "";
                        text1 = "";
                        return;
                    }
                }

            }
            else if (comboBox1.Text == "Binary")
            {
                foreach (char letter in text1)
                {

                    text2 += letter;

                    if (text2 == "a")
                    {
                        text3 += "01000001 ";
                        text2 = "";
                    }
                    else if (text2 == "b")
                    {
                        text3 += "01000010 ";
                        text2 = "";
                    }
                    else if (text2 == "c")
                    {
                        text3 += "01000011 ";
                        text2 = "";
                    }
                    else if (text2 == "d")
                    {
                        text3 += "01000100 ";
                        text2 = "";
                    }
                    else if (text2 == "e")
                    {
                        text3 += "01000101 ";
                        text2 = "";
                    }
                    else if (text2 == "f")
                    {
                        text3 += "01000110 ";
                        text2 = "";
                    }
                    else if (text2 == "g")
                    {
                        text3 += "01000111 ";
                        text2 = "";
                    }
                    else if (text2 == "h")
                    {
                        text3 += "01001000 ";
                        text2 = "";
                    }
                    else if (text2 == "i")
                    {
                        text3 += "01001001 ";
                        text2 = "";
                    }
                    else if (text2 == "j")
                    {
                        text3 += "01001010 ";
                        text2 = "";
                    }
                    else if (text2 == "k")
                    {
                        text3 += "01001011 ";
                        text2 = "";
                    }
                    else if (text2 == "l")
                    {
                        text3 += "01001100 ";
                        text2 = "";
                    }
                    else if (text2 == "m")
                    {
                        text3 += "01001101 ";
                        text2 = "";
                    }
                    else if (text2 == "n")
                    {
                        text3 += "01001110 ";
                        text2 = "";
                    }
                    else if (text2 == "o")
                    {
                        text3 += "01001111 ";
                        text2 = "";
                    }
                    else if (text2 == "p")
                    {
                        text3 += "01010000 ";
                        text2 = "";
                    }
                    else if (text2 == "q")
                    {
                        text3 += "01010001 ";
                        text2 = "";
                    }
                    else if (text2 == "r")
                    {
                        text3 += "01010010 ";
                        text2 = "";
                    }
                    else if (text2 == "s")
                    {
                        text3 += "01010011 ";
                        text2 = "";
                    }
                    else if (text2 == "t")
                    {
                        text3 += "01010100 ";
                        text2 = "";
                    }
                    else if (text2 == "u")
                    {
                        text3 += "01010101 ";
                        text2 = "";
                    }
                    else if (text2 == "v")
                    {
                        text3 += "01010110 ";
                        text2 = "";
                    }
                    else if (text2 == "w")
                    {
                        text3 += "01010111 ";
                        text2 = "";
                    }
                    else if (text2 == "x")
                    {
                        text3 += "01011000 ";
                        text2 = "";
                    }
                    else if (text2 == "y")
                    {
                        text3 += "01011001 ";
                        text2 = "";
                    }
                    else if (text2 == "z")
                    {
                        text3 += "01011010 ";
                        text2 = "";
                    }
                    else if (text2 == "0")
                    {
                        text3 += "00110000 ";
                        text2 = "";
                    }
                    else if (text2 == "1")
                    {
                        text3 += "00110001 ";
                        text2 = "";
                    }
                    else if (text2 == "2")
                    {
                        text3 += "00110010 ";
                        text2 = "";
                    }
                    else if (text2 == "3")
                    {
                        text3 += "00110011 ";
                        text2 = "";
                    }
                    else if (text2 == "4")
                    {
                        text3 += "00110100 ";
                        text2 = "";
                    }
                    else if (text2 == "5")
                    {
                        text3 += "00110101 ";
                        text2 = "";
                    }
                    else if (text2 == "6")
                    {
                        text3 += "00110110 ";
                        text2 = "";
                    }
                    else if (text2 == "7")
                    {
                        text3 += "00110111 ";
                        text2 = "";
                    }
                    else if (text2 == "8")
                    {
                        text3 += "00111000 ";
                        text2 = "";
                    }
                    else if (text2 == "9")
                    {
                        text3 += "00111001 ";
                        text2 = "";
                    }
                    else if (text2 == " ")
                    {
                        text3 += "00100000 ";
                        text2 = "";
                    }
                    else
                    {
                        MessageBox.Show("Could not find letter");
                        text2 = "";
                        text1 = "";
                        return;
                    }
                }

            }
            else if (comboBox1.Text == "my own easy to crack")
            {
                foreach (char letter in text1)
                {

                    text2 += letter;

                    if (text2 == "a")
                    {
                        text3 += "i";
                        text2 = "";
                    }
                    else if (text2 == "b")
                    {
                        text3 += "u";
                        text2 = "";
                    }
                    else if (text2 == "c")
                    {
                        text3 += "j";
                        text2 = "";
                    }
                    else if (text2 == "d")
                    {
                        text3 += "h";
                        text2 = "";
                    }
                    else if (text2 == "e")
                    {
                        text3 += "a";
                        text2 = "";
                    }
                    else if (text2 == "f")
                    {
                        text3 += "o";
                        text2 = "";
                    }
                    else if (text2 == "g")
                    {
                        text3 += "p";
                        text2 = "";
                    }
                    else if (text2 == "h")
                    {
                        text3 += "d";
                        text2 = "";
                    }
                    else if (text2 == "i")
                    {
                        text3 += "b";
                        text2 = "";
                    }
                    else if (text2 == "j")
                    {
                        text3 += "z";
                        text2 = "";
                    }
                    else if (text2 == "k")
                    {
                        text3 += "y";
                        text2 = "";
                    }
                    else if (text2 == "l")
                    {
                        text3 += "x";
                        text2 = "";
                    }
                    else if (text2 == "m")
                    {
                        text3 += "w";
                        text2 = "";
                    }
                    else if (text2 == "n")
                    {
                        text3 += "v";
                        text2 = "";
                    }
                    else if (text2 == "o")
                    {
                        text3 += "c";
                        text2 = "";
                    }
                    else if (text2 == "p")
                    {
                        text3 += "g";
                        text2 = "";
                    }
                    else if (text2 == "q")
                    {
                        text3 += "t";
                        text2 = "";
                    }
                    else if (text2 == "r")
                    {
                        text3 += "f";
                        text2 = "";
                    }
                    else if (text2 == "s")
                    {
                        text3 += "n";
                        text2 = "";
                    }
                    else if (text2 == "t")
                    {
                        text3 += "k";
                        text2 = "";
                    }
                    else if (text2 == "u")
                    {
                        text3 += "e";
                        text2 = "";
                    }
                    else if (text2 == "v")
                    {
                        text3 += "m";
                        text2 = "";
                    }
                    else if (text2 == "w")
                    {
                        text3 += "r";
                        text2 = "";
                    }
                    else if (text2 == "x")
                    {
                        text3 += "s";
                        text2 = "";
                    }
                    else if (text2 == "y")
                    {
                        text3 += "q";
                        text2 = "";
                    }
                    else if (text2 == "z")
                    {
                        text3 += "l";
                        text2 = "";
                    }
                    else if (text2 == "0")
                    {
                        text3 += "159";
                        text2 = "";
                    }
                    else if (text2 == "1")
                    {
                        text3 += "238";
                        text2 = "";
                    }
                    else if (text2 == "2")
                    {
                        text3 += "905";
                        text2 = "";
                    }
                    else if (text2 == "3")
                    {
                        text3 += "836";
                        text2 = "";
                    }
                    else if (text2 == "4")
                    {
                        text3 += "643";
                        text2 = "";
                    }
                    else if (text2 == "5")
                    {
                        text3 += "501";
                        text2 = "";
                    }
                    else if (text2 == "6")
                    {
                        text3 += "012";
                        text2 = "";
                    }
                    else if (text2 == "7")
                    {
                        text3 += "494";
                        text2 = "";
                    }
                    else if (text2 == "8")
                    {
                        text3 += "792";
                        text2 = "";
                    }
                    else if (text2 == "9")
                    {
                        text3 += "371";
                        text2 = "";
                    }
                    else if (text2 == " ")
                    {
                        text3 += "999";
                        text2 = "";
                    }
                    else
                    {
                        MessageBox.Show("Could not find letter");
                        text2 = "";
                        text1 = "";
                        return;
                    }
                }

            }
            else if (comboBox1.Text == "my own medium to crack")
            {
                foreach (char letter in text1)
                {

                    text2 += letter;

                    if (text2 == "a")
                    {
                        text3 += "ljdfh";
                        text2 = "";
                    }
                    else if (text2 == "b")
                    {
                        text3 += "dhskh";
                        text2 = "";
                    }
                    else if (text2 == "c")
                    {
                        text3 += "euguc";
                        text2 = "";
                    }
                    else if (text2 == "d")
                    {
                        text3 += "sauye";
                        text2 = "";
                    }
                    else if (text2 == "e")
                    {
                        text3 += "ewvyn";
                        text2 = "";
                    }
                    else if (text2 == "f")
                    {
                        text3 += "paadk";
                        text2 = "";
                    }
                    else if (text2 == "g")
                    {
                        text3 += "sksla";
                        text2 = "";
                    }
                    else if (text2 == "h")
                    {
                        text3 += "fjjkd";
                        text2 = "";
                    }
                    else if (text2 == "i")
                    {
                        text3 += "mende";
                        text2 = "";
                    }
                    else if (text2 == "j")
                    {
                        text3 += "fhsds";
                        text2 = "";
                    }
                    else if (text2 == "k")
                    {
                        text3 += "klakj";
                        text2 = "";
                    }
                    else if (text2 == "l")
                    {
                        text3 += "lkjhg";
                        text2 = "";
                    }
                    else if (text2 == "m")
                    {
                        text3 += "poiuyt";
                        text2 = "";
                    }
                    else if (text2 == "n")
                    {
                        text3 += "qwefg";
                        text2 = "";
                    }
                    else if (text2 == "o")
                    {
                        text3 += "hfdkd";
                        text2 = "";
                    }
                    else if (text2 == "p")
                    {
                        text3 += "lksja";
                        text2 = "";
                    }
                    else if (text2 == "q")
                    {
                        text3 += "weike";
                        text2 = "";
                    }
                    else if (text2 == "r")
                    {
                        text3 += "mnbvc";
                        text2 = "";
                    }
                    else if (text2 == "s")
                    {
                        text3 += "yhbgt";
                        text2 = "";
                    }
                    else if (text2 == "t")
                    {
                        text3 += "loikm";
                        text2 = "";
                    }
                    else if (text2 == "u")
                    {
                        text3 += "asxcv";
                        text2 = "";
                    }
                    else if (text2 == "v")
                    {
                        text3 += "mvnbc";
                        text2 = "";
                    }
                    else if (text2 == "w")
                    {
                        text3 += "knjhb";
                        text2 = "";
                    }
                    else if (text2 == "x")
                    {
                        text3 += "lkjhg";
                        text2 = "";
                    }
                    else if (text2 == "y")
                    {
                        text3 += "djfjg";
                        text2 = "";
                    }
                    else if (text2 == "z")
                    {
                        text3 += "kfkda";
                        text2 = "";
                    }
                    else if (text2 == "0")
                    {
                        text3 += "1597873";
                        text2 = "";
                    }
                    else if (text2 == "1")
                    {
                        text3 += "2387548";
                        text2 = "";
                    }
                    else if (text2 == "2")
                    {
                        text3 += "9050182";
                        text2 = "";
                    }
                    else if (text2 == "3")
                    {
                        text3 += "8368264";
                        text2 = "";
                    }
                    else if (text2 == "4")
                    {
                        text3 += "6439576";
                        text2 = "";
                    }
                    else if (text2 == "5")
                    {
                        text3 += "5016410";
                        text2 = "";
                    }
                    else if (text2 == "6")
                    {
                        text3 += "0128791";
                        text2 = "";
                    }
                    else if (text2 == "7")
                    {
                        text3 += "4941684";
                        text2 = "";
                    }
                    else if (text2 == "8")
                    {
                        text3 += "7921678";
                        text2 = "";
                    }
                    else if (text2 == "9")
                    {
                        text3 += "3717615";
                        text2 = "";
                    }
                    else if (text2 == " ")
                    {
                        text3 += "6414110";
                        text2 = "";
                    }
                    else
                    {
                        MessageBox.Show("Could not find letter");
                        text2 = "";
                        text1 = "";
                        return;
                    }
                }

            }
            else if (comboBox1.Text == "my own hard to crack")
            {

                foreach (char letter in text1)
                {

                    text2 += letter;
                    randomNum = randN.Next(1, 4);

                    if (text2 == "a")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "asfkdjgfliuglsdkhdsfddv";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "uadnfsdomksldjldkjnf";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "asbfglsandsjdhhfaawdf";
                        }
                        text2 = "";
                    }
                    else if (text2 == "b")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "askunhfaljhigfoih";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "ajlhdsgjfdakghnhnjsaad";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "nakbsjddagsbnghaoeasfasc";
                        }
                        text2 = "";
                    }
                    else if (text2 == "c")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "lkyjgthfrgefwsaqvbncvd";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "hjghdfdsarfghklfghfhgjhd";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "nmadgjhmfmhrtbbnisdmrtgvb";
                        }
                        text2 = "";
                    }
                    else if (text2 == "d")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "qwertyuiopzxcvbnmlkjlkjhg";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "zxcvbnmllkjhgfdsaqwertyuio";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "asqwfdrezxcvbnghtredsfghsawqf";
                        }
                        text2 = "";
                    }
                    else if (text2 == "e")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "aqwsedrftgszawqqwasdfredcvbvcgf";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "qwertyuioplkjhgfdsazxcvbnmjfdz";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "qwertyuioplkjhgfdsaqwertyujnbv";
                        }
                        text2 = "";
                    }
                    else if (text2 == "f")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "uavkavudsfgjduterybivdsyisdvyf";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "lfugbyvtuvfuvfgdsvyhvsygusgyu";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "yivikavfydbluisdvgusjvdfgdsvdj";
                        }
                        text2 = "";
                    }
                    else if (text2 == "g")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "svkdjshkvhfdsvksjvndhjeitvdhkshvg";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "dcjmdfvhndmdfhndxmhfvndxmfvhnjdsf";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "flhsgakljfghkouritrrwweghffksfyyr";    
                        }
                        text2 = "";
                    }
                    else if (text2 == "h")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "hhsfvlasvkivalgflvgdfvsgfnvfhdf";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "jagawddbgvkgkhvfhgvfakvfgbfdgvbf";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "dsbgudvvadshnklvvhjgdhjhjdfhdifgbv";
                        }
                        text2 = "";
                    }
                    else if (text2 == "i")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "mvafyvbdvgbdyvgbbdjbgftugewbgfdsuig";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "dkjvnfsdvgbwgsydvbgvjsdkgvgbvjvjdfg";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "bagshbshbgffgfshnfgbkbgdknbdskjdgsd";
                        }
                        text2 = "";
                    }
                    else if (text2 == "j")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "hjemdedigjeghehderkajakajakajkajkaj";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "hejmaufgbvaojohansdnfgvksfgvshgdfksd";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "asdfkjhgfdssdfghjklkjhgfdsdfghjklkjg";
                        }
                        text2 = "";
                    }
                    else if (text2 == "k")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "qwertyuiopoiuytrewqwertyuiopiutrqwere";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "qwfgmmngfewqscvbnkoppouwsfghuijbvdergb";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "mnbvcxzxcvbnmnbvcxzxcvbnmmnbvcxzxcvbnmn";
                        }
                        text2 = "";
                    }
                    else if (text2 == "l")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "fvieubggvfadsjgfbvajgfvsgjdfgvhjgsjhfgv";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "hkcgbdhgbfbfdhguegveygvdvbggnsgiufygdval";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "jhvgajkgvmoeceeevtfyusatuyffvnnvfhsjwwac";
                        }
                        text2 = "";
                    }
                    else if (text2 == "m")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "vajvggahgjdgfvjhdgvjhsgvgjdgfvhjdsjvkavkv";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "savbfshhgsdghvksdvgahvnfhsvkgfshvgfhhdsgk";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "asvkbagrqwerqcacapycavcqqtcyvfcqytcacbdca";
                        }
                        text2 = "";
                    }
                    else if (text2 == "n")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "sdhgbtevgsdbvgdsjvgfdshgvsjhmmjkrvshvgdhk";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "fdjvgbfhbgvhdsghgvsahvgakhkvgfhjsagkjfvhk";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "vdbfvaudvudsakuevytuyvlkfgvgaufvguayfvfvu";
                        }
                        text2 = "";
                    }
                    else if (text2 == "o")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "dgvgbgsdgfvhjagbfshgvakjhfgvsjkgfvjgffhhk";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "ubhdgshvkhskskvfgvakughssgdjvbhjbjvbbjkbj";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "vgdfgdshdshgsdhfgvbsgvbvgfgvdfhjhvnhfdjgf";
                        }
                        text2 = "";
                    }
                    else if (text2 == "p")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "dsfhvsdhgfhsdgfdsjhfjsdfhsdhfhdgfdhsjfgfg";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "ydfhsghfgklgdhghagdfggdhsdgfjdhfdhgdfghfh";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "fdshfsfjkjhgfruiiirtyvvjdshveyvhafvhfsdhf";
                        }
                        text2 = "";
                    }
                    else if (text2 == "q")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "hqwdfgvgjfhsdjhfdsjjhgfdlkjhgfkjkjhgfd";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "dhfbhfdgvfdfgbvhgbfhgvhfgfgvhgfv";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "asdfghjlkjhgfdghjkkfdsdfghjjfdfg";
                        }
                        text2 = "";
                    }
                    else if (text2 == "r")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "djgvbvjsgvhfgbsfsvgsgfvbjfgvfvgf";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "dfdhgvfscfhscgvfbgfvgbfvgfgvbgbf";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "qwqteertrrtyvyuvuyvbvbfgbvgfjhfg";
                        }
                        text2 = "";
                    }
                    else if (text2 == "s")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "hdgdsfsfdgmjkldhgfsdafhdsafghdsf";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "dvfvvfhnfvnhvhnfvhnhnfhndshdfjhs";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "kmjnhbgvfcdxszaasdfghjklpsdkgvkj";
                        }
                        text2 = "";
                    }
                    else if (text2 == "t")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "azsxdcfvgbhnjkmloiutrewqertgggfg";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "lmknjbhvgfcdxszaqwergbnmsswdcvbd";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "azsxdcfvgbhnjlmkjnbvfcdxsasdfghn";
                        }
                        text2 = "";
                    }
                    else if (text2 == "u")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "qsdfvbgrertyhnmjhhyujmjhgdfghjum";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "syvsdfgvgshjfgshvgfjfgwsjhgfshgf";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "lsjdfhgbvfbfuvvebfvshgfjsgfshsgs";
                        }
                        text2 = "";
                    }
                    else if (text2 == "v")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "ahoiuoiuoiuutrytfvcddfcddvdcfvfc";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "qdcevbgfnfhvecfcdscfdscscgbmjmjm";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "wsedrtghyujikolkijuhygtfdvbnmnbv";
                        }
                        text2 = "";
                    }
                    else if (text2 == "w")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "dfsgsgfvsuhgvsdhgvasvgfgvhsjgfhs";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "hsvgfbvgffgvfdghjdghgfkskshgukgs";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "dwasadwsawdygjhjkjkknfnhgnffdjvn";
                        }
                        text2 = "";
                    }
                    else if (text2 == "x")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "ljlkhhkjgfdfcgvgsdgbfhhghdjghdss";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "sfhkdnvvdshfsshfbshfgbhsvbbvsskf";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "skjdfhskjdhagfuyetytayeytrytmnbv";
                        }
                        text2 = "";
                    }
                    else if (text2 == "y")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "dsfkdsfhfgjrgygajhghjfghsjaafjhv";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "hgvfhdgshfgvfsgvfdgfdhfddgfjfhdf";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "kjdbkvjdgkjghdvghdbjdvghkdhgkhgj";
                        }
                        text2 = "";
                    }
                    else if (text2 == "z")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "dvhjgdkjhvgvweaqfrdegghtedfghytr";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "jmfhnvyheslopkuttmbjjvjgbhhgj";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "fmgjfvhjdgsfhgfshgfsgfjsfjsfgfvn";
                        }
                        text2 = "";
                    }
                    else if (text2 == "0")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "gfvbhskbjgbjgfgbfjhvffvhndhcfhfm";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "hcfjjkdghjksjcdhdcjjfhfmcfjkbsdf";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "djfhvjhsdfkdjfhkhsdkjhvhvfjjvjfj";
                        }
                        text2 = "";
                    }
                    else if (text2 == "1")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "khdfckewuechuehfehueuskhafhjsfsf";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "lmnhgbfvdcsxazzawertyuiopofgnvcm";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "bggsdhdsfsdghfnvsbdhvfhvbhfhvfhb";
                        }
                        text2 = "";
                    }
                    else if (text2 == "2")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "aawdfgfgthyuuiopoiuhgfdcklxnbvfg";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "jnhfskhjhsvksjfhvkjsvjfvhnskvhsj";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "skvhfnkfshhvsvhbvskfhvsjfhggfyuy";
                        }
                        text2 = "";
                    }
                    else if (text2 == "3")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "jdfhhsfdhshshsdhdslkdkjghkhgnfvh";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "dsfhksnfvhsdjkvhfkjsfkekyksjkskf";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "dhfvadfhhkdkjhskjvhsfgsgfvfdhdhg";
                        }
                        text2 = "";
                    }
                    else if (text2 == "4")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "hdkvsdvfhvsgbbksfjshjhfggvjhvgfv";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "asdfghjkjvcxzsdfgjkjfxstbsergcdh";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "aqwsxedccrfvvtgbyhnjkmmjggfderfg";
                        }
                        text2 = "";
                    }
                    else if (text2 == "5")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "aqssdcxvbzhtfhgdgdhdfhgfhgdrgdht";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "aqsedthgfgdthtuftydrgfdgfdgfddds";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "qawsedrfgvbvcxsjhgfsdfghjhtrttfy";
                        }
                        text2 = "";
                    }
                    else if (text2 == "6")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "qswdefgvbsxddyugytfrdgfgjgfhgdfg";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "qazsxdcfvtghbfvgtyhfvgvhbgtyhtgr";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "azsdxfcvwsaqwertghfghmnbvcxdfghn";
                        }
                        text2 = "";
                    }
                    else if (text2 == "7")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "asjrfgdjesytrfyjgvsygvfgshfvsjey";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "ahjfvnsdgfvajgfgvbgbjhhjhkbhbhbh";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "jhbgfsjfgvshfgjsjfghsvfbjgvfgffg";
                        }
                        text2 = "";
                    }
                    else if (text2 == "8")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "dhvhdsvnhsdkjfvdskgfjshgfvhsdvds";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "jfvbhsdhgfvbsgfsjgvsgjfgvsgvsfgv";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "qefdgdsfdhjgtjnjgbhfbhvcdhfhfggj";
                        }
                        text2 = "";
                    }
                    else if (text2 == "9")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "kmjhgfdsaxcvbniuygbhgddfgbhgfdsw";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "qaaswsdfvrrftghyjujkiloijhgfdscv";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "qwdsadftrrgfvgtyuyjhgfd";
                        }
                        text2 = "";
                    }
                    else if (text2 == " ")
                    {
                        if (randomNum == 1)
                        {
                            text3 += "aqswedrfgthbvcddwsakdjsgvfsgvdyv";
                        }
                        else if (randomNum == 2)
                        {
                            text3 += "astfdajfsgsjgfvbhsjgfvjhgfjsgfvh";
                        }
                        else if (randomNum == 3)
                        {
                            text3 += "shdgfghgjafsgchgsfgfasfyfteeyfgb";
                        }
                        text2 = "";
                    }
                    else
                    {
                        MessageBox.Show("Could not find letter");
                        text2 = "";
                        text1 = "";
                        return;
                    }
                }
            }

            StreamWriter textFile = new StreamWriter(path);

            textFile.Write(text3);
            textFile.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            path = textBox2.Text;

            if (path == "")
            {
                MessageBox.Show("please select a path");
                return;
            }

            string text3 = "";
            string text2 = "";
            string text1 = "";

            StreamReader textFileR = new StreamReader(path);
            text1 = textFileR.ReadToEnd();

            if (comboBox2.Text == "some it is")
            {
                foreach (char letter in text1)
                {
                    text2 += letter;
                }
                textBox3.Text = text2;
            }
            else
            {

                if (comboBox1.Text == "Binary")
                {
                    foreach (char letter in text1)
                    {
                        text2 += letter;
                        binaryNum++;

                        if (binaryNum == 9)
                        {
                            if (text2 == "01000001 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "a";
                            }//a
                            else if (text2 == "01000010 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "b";
                            }//b
                            else if (text2 == "01000011 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "c";
                            }//c
                            else if (text2 == "01000100 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "d";
                            }//d
                            else if (text2 == "01000101 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "e";
                            }//e
                            else if (text2 == "01000110 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "f";
                            }//f
                            else if (text2 == "01000111 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "g";
                            }//g
                            else if (text2 == "01001000 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "h";
                            }//h
                            else if (text2 == "01001001 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "i";
                            }//i
                            else if (text2 == "01001010 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "j";
                            }//j
                            else if (text2 == "01001011 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "k";
                            }//k
                            else if (text2 == "01001100 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "l";
                            }//l
                            else if (text2 == "01001101 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "m";
                            }//m
                            else if (text2 == "01001110 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "n";
                            }//n
                            else if (text2 == "01001111 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "o";
                            }//o
                            else if (text2 == "01010000 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "p";
                            }//p
                            else if (text2 == "01010001 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "q";
                            }//q
                            else if (text2 == "01010010 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "r";
                            }//r
                            else if (text2 == "01010011 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "s";
                            }//s
                            else if (text2 == "01010100 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "t";
                            }//t
                            else if (text2 == "01010101 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "u";
                            }//u
                            else if (text2 == "01010110 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "v";
                            }//v
                            else if (text2 == "01010111 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "w";
                            }//w
                            else if (text2 == "01011000 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "x";
                            }//x
                            else if (text2 == "01011001 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "y";
                            }//y
                            else if (text2 == "01011010 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "z";
                            }//z
                            else if (text2 == "00110000 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "0";
                            }//0
                            else if (text2 == "00110001 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "1";
                            }//1
                            else if (text2 == "00110010 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "2";
                            }//2
                            else if (text2 == "00110011 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "3";
                            }//3
                            else if (text2 == "00110100 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "4";
                            }//4
                            else if (text2 == "00110101 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "5";
                            }//5
                            else if (text2 == "00110110 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "6";
                            }//6
                            else if (text2 == "00110111 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "7";
                            }//7
                            else if (text2 == "00111000 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "8";
                            }//8
                            else if (text2 == "00111001 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += "9";
                            }//9
                            else if (text2 == "00100000 ")
                            {
                                text2 = "";
                                binaryNum = 0;
                                text3 += " ";
                            }//Space
                        }
                    }
                    if (text2 != "")
                    {
                        MessageBox.Show("Could not find letter");
                        text2 = "";
                        text1 = "";
                        return;
                    }

                }
                else if (comboBox1.Text == "Morse")
                {
                    foreach (char letter in text1)
                    {
                        text2 += letter;

                        if (text2 == "._ ")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "a";
                        }//a
                        else if (text2 == "_... ")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "b";
                        }//b
                        else if (text2 == "_._. ")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "c";
                        }//c
                        else if (text2 == "_.. ")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "d";
                        }//d
                        else if (text2 == ". ")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "e";
                        }//e
                        else if (text2 == ".._. ")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "f";
                        }//f
                        else if (text2 == "__. ")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "g";
                        }//g
                        else if (text2 == ".... ")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "h";
                        }//h
                        else if (text2 == ".. ")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "i";
                        }//i
                        else if (text2 == ".___ ")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "j";
                        }//j
                        else if (text2 == "_._ ")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "k";
                        }//k
                        else if (text2 == "._.. ")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "l";
                        }//l
                        else if (text2 == "__ ")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "m";
                        }//m
                        else if (text2 == "_. ")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "n";
                        }//n
                        else if (text2 == "___ ")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "o";
                        }//o
                        else if (text2 == ".__. ")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "p";
                        }//p
                        else if (text2 == "__._ ")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "q";
                        }//q
                        else if (text2 == "._. ")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "r";
                        }//r
                        else if (text2 == "... ")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "s";
                        }//s
                        else if (text2 == "_ ")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "t";
                        }//t
                        else if (text2 == ".._ ")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "u";
                        }//u
                        else if (text2 == "..._ ")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "v";
                        }//v
                        else if (text2 == ".__ ")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "w";
                        }//w
                        else if (text2 == "_.._ ")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "x";
                        }//x
                        else if (text2 == "_.__ ")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "y";
                        }//y
                        else if (text2 == "__.. ")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "z";
                        }//z
                        else if (text2 == "_____ ")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "0";
                        }//0
                        else if (text2 == ".____ ")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "1";
                        }//1
                        else if (text2 == "..___ ")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "2";
                        }//2
                        else if (text2 == "...__ ")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "3";
                        }//3
                        else if (text2 == "...._ ")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "4";
                        }//4
                        else if (text2 == "..... ")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "5";
                        }//5
                        else if (text2 == "_.... ")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "6";
                        }//6
                        else if (text2 == "__... ")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "7";
                        }//7
                        else if (text2 == "___..")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "8";
                        }//8
                        else if (text2 == "____.")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "9";
                        }//9
                        else if (text2 == " ")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += " ";
                        }//Space

                    }
                    if (text2 != "")
                    {
                        MessageBox.Show("Could not find letter");
                        text2 = "";
                        text1 = "";
                        return;
                    }
                }
                else if (comboBox1.Text == "my own easy to crack")
                {
                    foreach (char letter in text1)
                    {
                        text2 += letter;

                        if (text2 == "i")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "a";
                        }//a
                        else if (text2 == "u")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "b";
                        }//b
                        else if (text2 == "j")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "c";
                        }//c
                        else if (text2 == "h")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "d";
                        }//d
                        else if (text2 == "a")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "e";
                        }//e
                        else if (text2 == "o")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "f";
                        }//f
                        else if (text2 == "p")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "g";
                        }//g
                        else if (text2 == "d")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "h";
                        }//h
                        else if (text2 == "b")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "i";
                        }//i
                        else if (text2 == "z")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "j";
                        }//j
                        else if (text2 == "y")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "k";
                        }//k
                        else if (text2 == "x")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "l";
                        }//l
                        else if (text2 == "w")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "m";
                        }//m
                        else if (text2 == "v")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "n";
                        }//n
                        else if (text2 == "c")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "o";
                        }//o
                        else if (text2 == "g")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "p";
                        }//p
                        else if (text2 == "t")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "q";
                        }//q
                        else if (text2 == "f")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "r";
                        }//r
                        else if (text2 == "n")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "s";
                        }//s
                        else if (text2 == "k")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "t";
                        }//t
                        else if (text2 == "e")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "u";
                        }//u
                        else if (text2 == "m")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "v";
                        }//v
                        else if (text2 == "r")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "w";
                        }//w
                        else if (text2 == "s")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "x";
                        }//x
                        else if (text2 == "q")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "y";
                        }//y
                        else if (text2 == "l")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "z";
                        }//z
                        else if (text2 == "159")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "0";
                        }//0
                        else if (text2 == "238")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "1";
                        }//1
                        else if (text2 == "905")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "2";
                        }//2
                        else if (text2 == "836")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "3";
                        }//3
                        else if (text2 == "643")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "4";
                        }//4
                        else if (text2 == "501")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "5";
                        }//5
                        else if (text2 == "012")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "6";
                        }//6
                        else if (text2 == "494")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "7";
                        }//7
                        else if (text2 == "792")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "8";
                        }//8
                        else if (text2 == "371")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "9";
                        }//9
                        else if (text2 == "999")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += " ";
                        }//Space

                    }
                    if (text2 != "")
                    {
                        MessageBox.Show("Could not find letter");
                        text2 = "";
                        text1 = "";
                        return;
                    }
                }
                else if (comboBox1.Text == "my own medium to crack")
                {
                    foreach (char letter in text1)
                    {
                        text2 += letter;

                        if (text2 == "ljdfh")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "a";
                        }//a
                        else if (text2 == "dhskh")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "b";
                        }//b
                        else if (text2 == "euguc")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "c";
                        }//c
                        else if (text2 == "sauye")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "d";
                        }//d
                        else if (text2 == "ewvyn")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "e";
                        }//e
                        else if (text2 == "paadk")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "f";
                        }//f
                        else if (text2 == "sksla")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "g";
                        }//g
                        else if (text2 == "fjjkd")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "h";
                        }//h
                        else if (text2 == "mende")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "i";
                        }//i
                        else if (text2 == "fhsds")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "j";
                        }//j
                        else if (text2 == "klakj")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "k";
                        }//k
                        else if (text2 == "lkjhg")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "l";
                        }//l
                        else if (text2 == "poiuyt")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "m";
                        }//m
                        else if (text2 == "qwefg")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "n";
                        }//n
                        else if (text2 == "hfdkd")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "o";
                        }//o
                        else if (text2 == "lksja")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "p";
                        }//p
                        else if (text2 == "weike")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "q";
                        }//q
                        else if (text2 == "mnbvc")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "r";
                        }//r
                        else if (text2 == "yhbgt")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "s";
                        }//s
                        else if (text2 == "loikm")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "t";
                        }//t
                        else if (text2 == "asxcv")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "u";
                        }//u
                        else if (text2 == "mvnbc")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "v";
                        }//v
                        else if (text2 == "knjhb")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "w";
                        }//w
                        else if (text2 == "lkjhg")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "x";
                        }//x
                        else if (text2 == "djfjg")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "y";
                        }//y
                        else if (text2 == "kfkda")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "z";
                        }//z
                        else if (text2 == "1597873")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "0";
                        }//0
                        else if (text2 == "2387548")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "1";
                        }//1
                        else if (text2 == "9050182")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "2";
                        }//2
                        else if (text2 == "8368264")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "3";
                        }//3
                        else if (text2 == "6439576")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "4";
                        }//4
                        else if (text2 == "5016410")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "5";
                        }//5
                        else if (text2 == "0128791")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "6";
                        }//6
                        else if (text2 == "4941684")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "7";
                        }//7
                        else if (text2 == "7921678")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "8";
                        }//8
                        else if (text2 == "3717615")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += "9";
                        }//9
                        else if (text2 == "6414110")
                        {
                            text2 = "";
                            binaryNum = 0;
                            text3 += " ";
                        }//Space

                    }
                    if (text2 != "")
                    {
                        MessageBox.Show("Could not find letter");
                        text2 = "";
                        text1 = "";
                        return;
                    }
                }
                else if (comboBox1.Text == "my own hard to crack")
                {
                    foreach (char letter in text1)
                    {
                        text2 += letter;

                        if (text2 == "asfkdjgfliuglsdkhdsfddv" || text2 == "uadnfsdomksldjldkjnf" || text2 == "asbfglsandsjdhhfaawdf")
                        {
                            text2 = "";
                            text3 += "a";
                        }//a
                        else if (text2 == "askunhfaljhigfoih" || text2 == "ajlhdsgjfdakghnhnjsaad" || text2 == "nakbsjddagsbnghaoeasfasc")
                        {
                            text2 = "";
                            text3 += "b";
                        }//b
                        else if (text2 == "lkyjgthfrgefwsaqvbncvd" || text2 == "hjghdfdsarfghklfghfhgjhd" || text2 == "nmadgjhmfmhrtbbnisdmrtgvb")
                        {
                            text2 = "";
                            text3 += "c";
                        }//c
                        else if (text2 == "qwertyuiopzxcvbnmlkjlkjhg" || text2 == "zxcvbnmllkjhgfdsaqwertyuio" || text2 == "asqwfdrezxcvbnghtredsfghsawqf")
                        {
                            text2 = "";
                            text3 += "d";
                        }//d
                        else if (text2 == "aqwsedrftgszawqqwasdfredcvbvcgf" || text2 == "qwertyuioplkjhgfdsazxcvbnmjfdz" || text2 == "qwertyuioplkjhgfdsaqwertyujnbv")
                        {
                            text2 = "";
                            text3 += "e";
                        }//e
                        else if (text2 == "uavkavudsfgjduterybivdsyisdvyf" || text2 == "lfugbyvtuvfuvfgdsvyhvsygusgyu" || text2 == "yivikavfydbluisdvgusjvdfgdsvdj")
                        {
                            text2 = "";
                            text3 += "f";
                        }//f
                        else if (text2 == "svkdjshkvhfdsvksjvndhjeitvdhkshvg" || text2 == "dcjmdfvhndmdfhndxmhfvndxmfvhnjdsf" || text2 == "flhsgakljfghkouritrrwweghffksfyyr")
                        {
                            text2 = "";
                            text3 += "g";
                        }//g
                        else if (text2 == "hhsfvlasvkivalgflvgdfvsgfnvfhdf" || text2 == "jagawddbgvkgkhvfhgvfakvfgbfdgvbf" || text2 == "dsbgudvvadshnklvvhjgdhjhjdfhdifgbv")
                        {
                            text2 = "";
                            text3 += "h";
                        }//h
                        else if (text2 == "mvafyvbdvgbdyvgbbdjbgftugewbgfdsuig" || text2 == "dkjvnfsdvgbwgsydvbgvjsdkgvgbvjvjdfg" || text2 == "bagshbshbgffgfshnfgbkbgdknbdskjdgsd")
                        {
                            text2 = "";
                            text3 += "i";
                        }//i
                        else if (text2 == "hjemdedigjeghehderkajakajakajkajkaj" || text2 == "hejmaufgbvaojohansdnfgvksfgvshgdfksd" || text2 == "asdfkjhgfdssdfghjklkjhgfdsdfghjklkjg")
                        {
                            text2 = "";
                            text3 += "j";
                        }//j
                        else if (text2 == "qwertyuiopoiuytrewqwertyuiopiutrqwere" || text2 == "qwfgmmngfewqscvbnkoppouwsfghuijbvdergb" || text2 == "mnbvcxzxcvbnmnbvcxzxcvbnmmnbvcxzxcvbnmn")
                        {
                            text2 = "";
                            text3 += "k";
                        }//k
                        else if (text2 == "fvieubggvfadsjgfbvajgfvsgjdfgvhjgsjhfgv" || text2 == "hkcgbdhgbfbfdhguegveygvdvbggnsgiufygdval" || text2 == "jhvgajkgvmoeceeevtfyusatuyffvnnvfhsjwwac")
                        {
                            text2 = "";
                            text3 += "l";
                        }//l
                        else if (text2 == "vajvggahgjdgfvjhdgvjhsgvgjdgfvhjdsjvkavkv" || text2 == "savbfshhgsdghvksdvgahvnfhsvkgfshvgfhhdsgk" || text2 == "asvkbagrqwerqcacapycavcqqtcyvfcqytcacbdca")
                        {
                            text2 = "";
                            text3 += "m";
                        }//m
                        else if (text2 == "sdhgbtevgsdbvgdsjvgfdshgvsjhmmjkrvshvgdhk" || text2 == "fdjvgbfhbgvhdsghgvsahvgakhkvgfhjsagkjfvhk" || text2 == "vdbfvaudvudsakuevytuyvlkfgvgaufvguayfvfvu")
                        {
                            text2 = "";
                            text3 += "n";
                        }//n
                        else if (text2 == "dgvgbgsdgfvhjagbfshgvakjhfgvsjkgfvjgffhhk" || text2 == "ubhdgshvkhskskvfgvakughssgdjvbhjbjvbbjkbj" || text2 == "vgdfgdshdshgsdhfgvbsgvbvgfgvdfhjhvnhfdjgf")
                        {
                            text2 = "";
                            text3 += "o";
                        }//o
                        else if (text2 == "dsfhvsdhgfhsdgfdsjhfjsdfhsdhfhdgfdhsjfgfg" || text2 == "ydfhsghfgklgdhghagdfggdhsdgfjdhfdhgdfghfh" || text2 == "fdshfsfjkjhgfruiiirtyvvjdshveyvhafvhfsdhf")
                        {
                            text2 = "";
                            text3 += "p";
                        }//p
                        else if (text2 == "hqwdfgvgjfhsdjhfdsjjhgfdlkjhgfkjkjhgfd" || text2 == "dhfbhfdgvfdfgbvhgbfhgvhfgfgvhgfv" || text2 == "asdfghjlkjhgfdghjkkfdsdfghjjfdfg")
                        {
                            text2 = "";
                            text3 += "q";
                        }//q
                        else if (text2 == "djgvbvjsgvhfgbsfsvgsgfvbjfgvfvgf" || text2 == "dfdhgvfscfhscgvfbgfvgbfvgfgvbgbf" || text2 == "qwqteertrrtyvyuvuyvbvbfgbvgfjhfg")
                        {
                            text2 = "";
                            text3 += "r";
                        }//r
                        else if (text2 == "hdgdsfsfdgmjkldhgfsdafhdsafghdsf" || text2 == "dvfvvfhnfvnhvhnfvhnhnfhndshdfjhs" || text2 == "kmjnhbgvfcdxszaasdfghjklpsdkgvkj")
                        {
                            text2 = "";
                            text3 += "s";
                        }//s
                        else if (text2 == "azsxdcfvgbhnjkmloiutrewqertgggfg" || text2 == "lmknjbhvgfcdxszaqwergbnmsswdcvbd" || text2 == "azsxdcfvgbhnjlmkjnbvfcdxsasdfghn")
                        {
                            text2 = "";
                            text3 += "t";
                        }//t
                        else if (text2 == "qsdfvbgrertyhnmjhhyujmjhgdfghjum" || text2 == "syvsdfgvgshjfgshvgfjfgwsjhgfshgf" || text2 == "lsjdfhgbvfbfuvvebfvshgfjsgfshsgs")
                        {
                            text2 = "";
                            text3 += "u";
                        }//u
                        else if (text2 == "ahoiuoiuoiuutrytfvcddfcddvdcfvfc" || text2 == "qdcevbgfnfhvecfcdscfdscscgbmjmjm" || text2 == "wsedrtghyujikolkijuhygtfdvbnmnbv")
                        {
                            text2 = ""; 
                            text3 += "v";
                        }//v
                        else if (text2 == "dfsgsgfvsuhgvsdhgvasvgfgvhsjgfhs" || text2 == "hsvgfbvgffgvfdghjdghgfkskshgukgs" || text2 == "dwasadwsawdygjhjkjkknfnhgnffdjvn")
                        {
                            text2 = "";
                            text3 += "w";
                        }//w
                        else if (text2 == "ljlkhhkjgfdfcgvgsdgbfhhghdjghdss" || text2 == "sfhkdnvvdshfsshfbshfgbhsvbbvsskf" || text2 == "skjdfhskjdhagfuyetytayeytrytmnbv")
                        {
                            text2 = "";
                            text3 += "x";
                        }//x
                        else if (text2 == "dsfkdsfhfgjrgygajhghjfghsjaafjhv" || text2 == "hgvfhdgshfgvfsgvfdgfdhfddgfjfhdf" || text2 == "kjdbkvjdgkjghdvghdbjdvghkdhgkhgj")
                        {
                            text2 = "";
                            text3 += "y";
                        }//y
                        else if (text2 == "dvhjgdkjhvgvweaqfrdegghtedfghytr" || text2 == "jmfhnvyheslopkuttmbjjvjgbhhgj" || text2 == "fmgjfvhjdgsfhgfshgfsgfjsfjsfgfvn")
                        {
                            text2 = "";
                            text3 += "z";
                        }//z
                        else if (text2 == "gfvbhskbjgbjgfgbfjhvffvhndhcfhfm" || text2 == "hcfjjkdghjksjcdhdcjjfhfmcfjkbsdf" || text2 == "djfhvjhsdfkdjfhkhsdkjhvhvfjjvjfj")
                        {
                            text2 = "";
                            text3 += "0";
                        }//0
                        else if (text2 == "khdfckewuechuehfehueuskhafhjsfsf" || text2 == "lmnhgbfvdcsxazzawertyuiopofgnvcm" || text2 == "bggsdhdsfsdghfnvsbdhvfhvbhfhvfhb")
                        {
                            text2 = "";
                            text3 += "1";
                        }//1
                        else if (text2 == "aawdfgfgthyuuiopoiuhgfdcklxnbvfg" || text2 == "jnhfskhjhsvksjfhvkjsvjfvhnskvhsj" || text2 == "skvhfnkfshhvsvhbvskfhvsjfhggfyuy")
                        {
                            text2 = "";
                            text3 += "2";
                        }//2
                        else if (text2 == "jdfhhsfdhshshsdhdslkdkjghkhgnfvh" || text2 == "dsfhksnfvhsdjkvhfkjsfkekyksjkskf" || text2 == "dhfvadfhhkdkjhskjvhsfgsgfvfdhdhg")
                        {
                            text2 = "";
                            text3 += "3";
                        }//3
                        else if (text2 == "hdkvsdvfhvsgbbksfjshjhfggvjhvgfv" || text2 == "asdfghjkjvcxzsdfgjkjfxstbsergcdh" || text2 == "aqwsxedccrfvvtgbyhnjkmmjggfderfg")
                        {
                            text2 = "";
                            text3 += "4";
                        }//4
                        else if (text2 == "aqssdcxvbzhtfhgdgdhdfhgfhgdrgdht" || text2 == "aqsedthgfgdthtuftydrgfdgfdgfddds" || text2 == "qawsedrfgvbvcxsjhgfsdfghjhtrttfy")
                        {
                            text2 = "";
                            text3 += "5";
                        }//5
                        else if (text2 == "qswdefgvbsxddyugytfrdgfgjgfhgdfg" || text2 == "qazsxdcfvtghbfvgtyhfvgvhbgtyhtgr" || text2 == "azsdxfcvwsaqwertghfghmnbvcxdfghn")
                        {
                            text2 = "";
                            text3 += "6";
                        }//6
                        else if (text2 == "asjrfgdjesytrfyjgvsygvfgshfvsjey" || text2 == "ahjfvnsdgfvajgfgvbgbjhhjhkbhbhbh" || text2 == "jhbgfsjfgvshfgjsjfghsvfbjgvfgffg")
                        {
                            text2 = "";
                            text3 += "7";
                        }//7
                        else if (text2 == "dhvhdsvnhsdkjfvdskgfjshgfvhsdvds" || text2 == "jfvbhsdhgfvbsgfsjgvsgjfgvsgvsfgv" || text2 == "qefdgdsfdhjgtjnjgbhfbhvcdhfhfggj")
                        {
                            text2 = "";
                            text3 += "8";
                        }//8
                        else if (text2 == "kmjhgfdsaxcvbniuygbhgddfgbhgfdsw" || text2 == "qaaswsdfvrrftghyjujkiloijhgfdscv" || text2 == "qwdsadftrrgfvgtyuyjhgfd")
                        {
                            text2 = "";
                            text3 += "9";
                        }//9
                        else if (text2 == "aqswedrfgthbvcddwsakdjsgvfsgvdyv" || text2 == "astfdajfsgsjgfvbhsjgfvjhgfjsgfvh" || text2 == "shdgfghgjafsgchgsfgfasfyfteeyfgb")
                        {
                            text2 = "";
                            text3 += " ";
                        }//Space

                    }
                    if (text2 != "")
                    {
                        MessageBox.Show("Could not find letter");
                        text2 = "";
                        text1 = "";
                        return;
                    }
                }

                textBox3.Text = text3;

            }

            textFileR.Close();

        }

        private void Tip_Click(object sender, EventArgs e)
        {
            if (tipNum == 0)
            {
                MessageBox.Show("in the path you need to make a back slash and a name after and then a .file type for the proram to work you can create you own file type if you want");
                tipNum++;
            }
            else if (tipNum == 1)
            {
                MessageBox.Show("remember that the first thing you should do when you start this program is to make the path and select a thing to write and how to read it");
                tipNum++;
            }
            else if (tipNum == 2)
            {
                MessageBox.Show("you can hide it in a image but it will delete the image and you have to save the image like `name.png´");
                tipNum++;
            }
            else if (tipNum == 3)
            {
                MessageBox.Show("if you want to read or write a file that this program has not made you need to know if the file is saved with `.anything´");
                tipNum++;
            }
            else if (tipNum == 4)
            {
                MessageBox.Show("you do not need to make a file type in the path just a name");
                tipNum++;
            }
            else if (tipNum == 5)
            {
                MessageBox.Show("you can make a image file you just need to be prepared that you cant open the file");
                tipNum++;
            }
            else if (tipNum == 6)
            {
                MessageBox.Show("you have been thrugh evry tip in this list now");
                tipNum = 0;
            }
        }
    }
}
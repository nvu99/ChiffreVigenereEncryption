using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChiffreVigenereEncryption
{
    public partial class Encryption : Form
    {

        string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456789 \\/~`!@#$%^&*(),._+{}[]\"-=;'\n<>|";
        int indexInLoop = 1;
        string inputInLoop;
        string outputInLoop;
        string output;
        int shiftrate;
        int keyLength;
        int keyIndex;
        string keyInLoop;

        public Encryption()
        {
            InitializeComponent();
            inputBox.Enabled = false;
            outputBox.ReadOnly = true;
            
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            keyLength = keyBox.Text.Length;
            int numberOfCharacters = inputBox.Text.Length;
            indexInLoop = 1;
            int i1 = 0;
            output = "";
            string key = keyBox.Text;
            keyIndex = 0;

            while (indexInLoop <= numberOfCharacters) 
            {
                keyIndex++;
                if (keyIndex > keyLength)
                {
                    keyIndex = 1;
                    keyInLoop = keyBox.Text.Substring(keyIndex - 1, 1);
                    shiftrate = alphabet.IndexOf(keyInLoop);
                }

                if (keyLength == 0)
                {
                    shiftrate = 0;
                }

                else
                {
                    keyInLoop = keyBox.Text.Substring(keyIndex - 1, 1);
                    shiftrate = alphabet.IndexOf(keyInLoop);
                }

                inputInLoop = inputBox.Text.Substring(indexInLoop - 1, 1);
                int pos = alphabet.IndexOf(inputInLoop);
                if (pos + shiftrate <= 92)
                {
                    outputInLoop = alphabet.Substring(pos + shiftrate, 1);
                    output += outputInLoop;
                    indexInLoop++;
                    outputInLoop = "";
                    outputBox.Text = output;
                }
                else
                {
                    i1 = pos - 92 + shiftrate - 1;
                    outputInLoop = alphabet.Substring(i1, 1);
                    output += outputInLoop;
                    indexInLoop++;
                    outputInLoop = "";
                    outputBox.Text = output;
                }

                }
                if (inputBox.Text.Length == 0)
                {
                    outputBox.Text = "";
                }
            
        }

        private void keyBox_TextChanged(object sender, EventArgs e)
        {
            keyLength = keyBox.Text.Length;
            int numberOfCharacters = inputBox.Text.Length;
            indexInLoop = 1;
            int i1 = 0;
            output = "";
            string key = keyBox.Text;
            keyIndex = 0;

            if (keyLength == 0)
            {
                inputBox.Enabled = false;
                inputBox.Text = "";
            }
            else
            {
                inputBox.Enabled = true;
            }

            while (indexInLoop <= numberOfCharacters)
            {
                keyIndex++;
                if (keyIndex > keyLength)
                {
                    keyIndex = 1;
                    keyInLoop = keyBox.Text.Substring(keyIndex - 1, 1);
                    shiftrate = alphabet.IndexOf(keyInLoop);
                }

                if (keyLength == 0)
                {
                    shiftrate = 0;
                }

                else
                {
                    keyInLoop = keyBox.Text.Substring(keyIndex - 1, 1);
                    shiftrate = alphabet.IndexOf(keyInLoop);
                }

                inputInLoop = inputBox.Text.Substring(indexInLoop - 1, 1);
                int pos = alphabet.IndexOf(inputInLoop);
                if (pos + shiftrate <= 92)
                {
                    outputInLoop = alphabet.Substring(pos + shiftrate, 1);
                    output += outputInLoop;
                    indexInLoop++;
                    outputInLoop = "";
                    outputBox.Text = output;
                }
                else
                {
                    i1 = pos - 92 + shiftrate - 1;
                    outputInLoop = alphabet.Substring(i1, 1);
                    output += outputInLoop;
                    indexInLoop++;
                    outputInLoop = "";
                    outputBox.Text = output;
                }

            }
            if (inputBox.Text.Length == 0)
            {
                outputBox.Text = "";
            }
        }

        private void Encryption_Load(object sender, EventArgs e)
        {

        }

        
    }
}

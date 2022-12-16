using System;
using System.Collections.Generic;

public static class PesoLettere
{

    public static int Pesa(string input)
    {
        int contatore = 0;
        input = input.ToLower();
            for (int j = 0; j < input.Length;j++){
                if(input[j] == 'a'||input[j] =='e'||input[j] =='i'||input[j] =='o'||input[j] =='u'||input[j] =='l'||input[j] =='n'||input[j] =='r'||input[j] =='s'||input[j] =='t'){
                 contatore = contatore+ 1;
                }
                else if (input[j] == 'd' || input[j] == 'g')
                {
                 contatore = contatore + 2;
                }
                else if(input[j]=='b'||input[j] == 'c'||input[j]=='m'||input[j]=='p'){
                 contatore= contatore+ 3;
                }
                else if(input[j] == 'f'||input[j]=='h'||input[j]=='v'||input[j]=='w'||input[j]=='y'){
                 contatore = contatore + 4;
                }
                else if(input[j] == 'k'){
                 contatore = contatore + 5;
                }
                else if(input[j] == 'j'||input[j] == 'x'){
                 contatore = contatore + 8;
                }
                else if(input[j] == 'q'||input[j]=='z'){
                 contatore = contatore + 10;
                }

            }
        


            return contatore;
    }
}
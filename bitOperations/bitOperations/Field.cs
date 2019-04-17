using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitOperations
{
    class Field
    {
        public long[] fieldLines = new long[8];

        
        public void AddColumn(Character ch, int colmNo) {

            byte[] colmns = ch.GetColumn(colmNo);

            
            for (int i = 0; i < 8; i++)
            {
                fieldLines[i] <<= 1;
                fieldLines[i] |= colmns[i];
            }
        }
        public void Сlean() {
            fieldLines = new long[8];
        }
    }
    class Character
    {
        byte[] chPix = new byte[8];
        public Character(char chToPixel)
        {
            chPix = СreatePix(chToPixel);
        }
        byte[] СreatePix(char chToPixel)
        {
            byte[] createdPix = new byte[8];
            switch(chToPixel){
                case 'A':
                    createdPix[0] = 0b00011000;
                    createdPix[1] = 0b00100100;
                    createdPix[2] = 0b01000010;
                    createdPix[3] = 0b01000010;
                    createdPix[4] = 0b01111110;
                    createdPix[5] = 0b01000010;
                    createdPix[6] = 0b01000010;
                    createdPix[7] = 0b01100110;
                    break;
                case 'B':
                    createdPix[0] = 0b01111100;
                    createdPix[1] = 0b01000010;
                    createdPix[2] = 0b01000100;
                    createdPix[3] = 0b01111110;
                    createdPix[4] = 0b01000001;
                    createdPix[5] = 0b01000001;
                    createdPix[6] = 0b01000001;
                    createdPix[7] = 0b01111110;
                    break;
                case 'C':
                    createdPix[0] = 0b00111100;
                    createdPix[1] = 0b01000011;
                    createdPix[2] = 0b10000001;
                    createdPix[3] = 0b10000000;
                    createdPix[4] = 0b10000000;
                    createdPix[5] = 0b10000001;
                    createdPix[6] = 0b01000011;
                    createdPix[7] = 0b00111100;
                    break;
                case 'D':
                    createdPix[0] = 0b01111100;
                    createdPix[1] = 0b01000010;
                    createdPix[2] = 0b01000001;
                    createdPix[3] = 0b01000001;
                    createdPix[4] = 0b01000001;
                    createdPix[5] = 0b01000001;
                    createdPix[6] = 0b01000010;
                    createdPix[7] = 0b01111100;
                    break;
                case 'E':
                    createdPix[0] = 0b01111111;
                    createdPix[1] = 0b01000001;
                    createdPix[2] = 0b01000000;
                    createdPix[3] = 0b01111000;
                    createdPix[4] = 0b01000000;
                    createdPix[5] = 0b01000000;
                    createdPix[6] = 0b01000001;
                    createdPix[7] = 0b01111111;
                    break;
                case 'F':
                    createdPix[0] = 0b01111110;
                    createdPix[1] = 0b01000010;
                    createdPix[2] = 0b01000000;
                    createdPix[3] = 0b01001000;
                    createdPix[4] = 0b01111000;
                    createdPix[5] = 0b01001000;
                    createdPix[6] = 0b01000000;
                    createdPix[7] = 0b01100000;
                    break;
                case 'G':
                    createdPix[0] = 0b00111111;
                    createdPix[1] = 0b01000001;
                    createdPix[2] = 0b10000000;
                    createdPix[3] = 0b10001111;
                    createdPix[4] = 0b10001001;
                    createdPix[5] = 0b10000001;
                    createdPix[6] = 0b01000001;
                    createdPix[7] = 0b00111110;
                    break;
                case 'H':
                    createdPix[0] = 0b01100110;
                    createdPix[1] = 0b01000010;
                    createdPix[2] = 0b01000010;
                    createdPix[3] = 0b01111110;
                    createdPix[4] = 0b01000010;
                    createdPix[5] = 0b01000010;
                    createdPix[6] = 0b01000010;
                    createdPix[7] = 0b01100110;
                    break;
                case 'I':
                    createdPix[0] = 0b01111110;
                    createdPix[1] = 0b00010000;
                    createdPix[2] = 0b00010000;
                    createdPix[3] = 0b00010000;
                    createdPix[4] = 0b00010000;
                    createdPix[5] = 0b00010000;
                    createdPix[6] = 0b00010000;
                    createdPix[7] = 0b01111110;
                    break;
                case 'J':
                    createdPix[0] = 0b01111110;
                    createdPix[1] = 0b00000100;
                    createdPix[2] = 0b00000100;
                    createdPix[3] = 0b00000100;
                    createdPix[4] = 0b11100100;
                    createdPix[5] = 0b10000100;
                    createdPix[6] = 0b10000100;
                    createdPix[7] = 0b01111000;
                    break;
                case 'K':
                    createdPix[0] = 0b01101110;
                    createdPix[1] = 0b01000100;
                    createdPix[2] = 0b01001000;
                    createdPix[3] = 0b01110000;
                    createdPix[4] = 0b01001000;
                    createdPix[5] = 0b01000100;
                    createdPix[6] = 0b01000010;
                    createdPix[7] = 0b01100110;
                    break;
                case 'L':
                    createdPix[0] = 0b01100000;
                    createdPix[1] = 0b01000000;
                    createdPix[2] = 0b01000000;
                    createdPix[3] = 0b01000000;
                    createdPix[4] = 0b01000000;
                    createdPix[5] = 0b01000000;
                    createdPix[6] = 0b01000010;
                    createdPix[7] = 0b01111110;
                    break;
                case 'M':
                    createdPix[0] = 0b01000110;
                    createdPix[1] = 0b01101010;
                    createdPix[2] = 0b01010010;
                    createdPix[3] = 0b01010010;
                    createdPix[4] = 0b01000010;
                    createdPix[5] = 0b01000010;
                    createdPix[6] = 0b01000010;
                    createdPix[7] = 0b01100110;
                    break;
                case 'N':
                    createdPix[0] = 0b01000110;
                    createdPix[1] = 0b01100010;
                    createdPix[2] = 0b01010010;
                    createdPix[3] = 0b01001010;
                    createdPix[4] = 0b01000110;
                    createdPix[5] = 0b01000010;
                    createdPix[6] = 0b01000010;
                    createdPix[7] = 0b01100110;
                    break;
                case 'O':
                    createdPix[0] = 0b00111100;
                    createdPix[1] = 0b01000010;
                    createdPix[2] = 0b10000001;
                    createdPix[3] = 0b10000001;
                    createdPix[4] = 0b10000001;
                    createdPix[5] = 0b10000001;
                    createdPix[6] = 0b01000010;
                    createdPix[7] = 0b00111100;
                    break;
                case 'P':
                    createdPix[0] = 0b01111110;
                    createdPix[1] = 0b01000001;
                    createdPix[2] = 0b01000001;
                    createdPix[3] = 0b01111110;
                    createdPix[4] = 0b01000000;
                    createdPix[5] = 0b01000000;
                    createdPix[6] = 0b01000000;
                    createdPix[7] = 0b01100000;
                    break;
                case 'Q':
                    createdPix[0] = 0b00111100;
                    createdPix[1] = 0b10000001;
                    createdPix[2] = 0b10000001;
                    createdPix[3] = 0b10000001;
                    createdPix[4] = 0b10000001;
                    createdPix[5] = 0b10100001;
                    createdPix[6] = 0b01111110;
                    createdPix[7] = 0b00100000;
                    break;
                case 'R':
                    createdPix[0] = 0b01111110;
                    createdPix[1] = 0b01000001;
                    createdPix[2] = 0b01000001;
                    createdPix[3] = 0b01111110;
                    createdPix[4] = 0b01001000;
                    createdPix[5] = 0b01000100;
                    createdPix[6] = 0b01000010;
                    createdPix[7] = 0b01100111;
                    break;
                case 'S':
                    createdPix[0] = 0b01111100;
                    createdPix[1] = 0b10000011;
                    createdPix[2] = 0b10000001;
                    createdPix[3] = 0b01111100;
                    createdPix[4] = 0b00000010;
                    createdPix[5] = 0b10000001;
                    createdPix[6] = 0b11000001;
                    createdPix[7] = 0b00111110;
                    break;
                case 'T':
                    createdPix[0] = 0b01111110;
                    createdPix[1] = 0b01001010;
                    createdPix[2] = 0b00001000;
                    createdPix[3] = 0b00001000;
                    createdPix[4] = 0b00001000;
                    createdPix[5] = 0b00001000;
                    createdPix[6] = 0b00001000;
                    createdPix[7] = 0b00011100;
                    break;
                case 'U':
                    createdPix[0] = 0b01100110;
                    createdPix[1] = 0b01000010;
                    createdPix[2] = 0b01000010;
                    createdPix[3] = 0b01000010;
                    createdPix[4] = 0b01000010;
                    createdPix[5] = 0b01000010;
                    createdPix[6] = 0b01000010;
                    createdPix[7] = 0b00111100;
                    break;
                case 'V':
                    createdPix[0] = 0b01100110;
                    createdPix[1] = 0b01000010;
                    createdPix[2] = 0b01000010;
                    createdPix[3] = 0b01000010;
                    createdPix[4] = 0b00100010;
                    createdPix[5] = 0b00100100;
                    createdPix[6] = 0b00010100;
                    createdPix[7] = 0b00001000;
                    break;
                case 'W':
                    createdPix[0] = 0b01100110;
                    createdPix[1] = 0b01000010;
                    createdPix[2] = 0b01000010;
                    createdPix[3] = 0b01000010;
                    createdPix[4] = 0b01010010;
                    createdPix[5] = 0b01010010;
                    createdPix[6] = 0b01010010;
                    createdPix[7] = 0b00101100;
                    break;
                case 'X':
                    createdPix[0] = 0b01100110;
                    createdPix[1] = 0b01000010;
                    createdPix[2] = 0b00100100;
                    createdPix[3] = 0b00011000;
                    createdPix[4] = 0b00100100;
                    createdPix[5] = 0b00100100;
                    createdPix[6] = 0b01000010;
                    createdPix[7] = 0b01100110;
                    break;
                case 'Y':
                    createdPix[0] = 0b01100110;
                    createdPix[1] = 0b01000010;
                    createdPix[2] = 0b00100100;
                    createdPix[3] = 0b00010100;
                    createdPix[4] = 0b00001000;
                    createdPix[5] = 0b00001000;
                    createdPix[6] = 0b00001000;
                    createdPix[7] = 0b00011100;
                    break;
                case 'Z':
                    createdPix[0] = 0b11111111;
                    createdPix[1] = 0b10000010;
                    createdPix[2] = 0b10000100;
                    createdPix[3] = 0b00001000;
                    createdPix[4] = 0b00010000;
                    createdPix[5] = 0b00100001;
                    createdPix[6] = 0b01000001;
                    createdPix[7] = 0b11111111;
                    break;

                case ' ':
                    break;
            }
            return createdPix;
        }
        public byte[] GetColumn(int colunmIndex)
        {
            byte[] result = new byte[8];
            for (int i = 0; i < 8; i++) {
                result[i] = 128;
            }

            if (colunmIndex < 0)
                colunmIndex = 0;
            else if (colunmIndex > 7)
                colunmIndex = 7;
            
            for (int i = 0; i < 8; i++)
            {
                result[i] >>= colunmIndex;
                result[i] &=  chPix[i];
                result[i] <<= colunmIndex;
                result[i] >>= 7;
            }
            return result;
        }
    } 
}

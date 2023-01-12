using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Dice_Roller
{
    public class Roller
    {
        Random rnd = new Random();
        private static Roller _instance;
        public static Roller Instance => _instance ?? (_instance = new Roller());

        public string SingleDiceRoll(int diceside, int modifier=0)
        {
            int roll = rnd.Next(1, diceside);
            int result = roll + modifier;
            if( modifier == 0)return $"d{diceside} => {roll}";

            return $"d{diceside} => {roll} + {modifier} ={result}";
        }

        public StringBuilder MultipleDiceRoll(int dicecount, int diceside, int modifier = 0, bool avg =false)
        {
            int totalresult = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < dicecount; i++)
            {
                int roll = rnd.Next(1, diceside);
                int result = roll + modifier;
            if (modifier == 0)
                {
                    sb.Append($"{i+1}.  d{diceside} => {roll}\n");
                   
                }
                else
                {
                    sb.Append($"{i + 1}. d{diceside} => {roll} + {modifier} ={result}\n");
                }

                totalresult = totalresult + result;
            }
                sb.Append($"TOTAL RESULT : {totalresult}");
            if (avg)
            {
                int average = totalresult / dicecount;
                sb.Append($"\nAVARAGE : {average}");
            }
            return sb;
        }

    }
}


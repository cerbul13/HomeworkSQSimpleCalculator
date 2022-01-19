using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkSQSimpleCalculator
{
    public class SimpleCalc
    {
        private string text;
        public string Text
        {
            get
            {
                return this.text;
            }
            set 
            {
                this.text = value;
            }
        }
        public SimpleCalc()
        {
            Console.Write("Please insert the text: ");
            this.Text=Console.ReadLine();
        }
        public int Calculation
        {
            get
            {                
                StringBuilder sb = new StringBuilder();
                Stack<char> signs = new Stack<char>();
                Stack<String> numbers = new Stack<String>();
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i]=='+' || text[i]=='-')
                    {
                        signs.Push(text[i]);
                        if (sb.Length!=0) 
                        { 
                            numbers.Push(sb.ToString());
                            sb.Clear();
                        }                        
                    }
                    if (text[i]!='+' && text[i]!='-')
                    {
                        sb.Append(text[i]);
                        if (i == text.Length - 1) 
                        { 
                            numbers.Push(sb.ToString()); 
                        }
                        if (i==0)
                        {
                            signs.Push('+');
                        }
                    }
                }
                int sum = 0;
                while(numbers.Count>0)
                {
                    char sign = signs.Pop();
                    string number = numbers.Pop();
                    Console.WriteLine(sign+number);
                    if (sign=='+') { sum += int.Parse(number); }
                    if (sign=='-') { sum -= int.Parse(number); }
                }
                return sum;
            }
        }
    }
}

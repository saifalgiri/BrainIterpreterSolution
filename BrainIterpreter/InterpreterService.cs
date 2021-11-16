namespace BrainIterpreter
{
    public class InterpreterService
    {
        public int pointer { get; set; }
        public string ProcessInstructions(string input)
        {
            string result = string.Empty;

            byte[] data = new byte[input.Length];
            char[] userInput = input.ToCharArray();
            int bracket = 0;

            for (int i = 0; i < userInput.Length; i++)
            {
                switch (userInput[i])
                {
                    case '>':
                        pointer++;
                        break;
                    case '<':
                        pointer--;
                        break;
                    case '+':
                        data[pointer]++;
                        break;
                    case '-':
                        data[pointer]--;
                        break;
                    case '.':
                        result += ((char)data[pointer]);
                        if (result.Length > 30000)
                            return result = "overflow";
                        break;
                    case ',':
                        break;
                    case '[':
                        if (data[pointer] == 0)
                        {
                            bracket++;
                            while (input[i] != ']' || bracket != 0)
                            {
                                i++;

                                if (input[i] == '[')
                                {
                                    bracket++;
                                }
                                else if (input[i] == ']')
                                {
                                    bracket--;
                                }
                            }
                        }
                        break;
                    case ']':
                        if (data[pointer] != 0)
                        {
                            bracket++;
                            while (input[i] != '[' || bracket != 0)
                            {
                                i--;

                                if (input[i] == ']')
                                {
                                    bracket++;
                                }
                                else if (input[i] == '[')
                                {
                                    bracket--;
                                }
                            }
                        }
                        break;
                }
              }
                return result;
        }
    }
}

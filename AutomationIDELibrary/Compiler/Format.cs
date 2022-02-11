using System;
namespace AutomationIDELibrary.Compiler
{
    public class Format
    {
        private static string _msg;
        public static string AdvancedMessage;
        public static string Output;
        public static string AdvancedOutputOne;
        public static string AdvancedOutputTwo;

        public static int AdvancedTimes;
        public static int IntMin;
        public static int IntMax;

        public void FormatString(int commandLength, string input)
        {
            var msg = input.Substring(input.IndexOf(@":", StringComparison.Ordinal));
            msg = msg.Remove(0, commandLength);

            _msg = msg;
            Output = msg;
        }

        public void FormatStringAdvanced(int commandLength, string input)
        {
            FormatString(commandLength, input);

            var msg = _msg;
            var message = msg.Remove(msg.IndexOf(",", StringComparison.Ordinal), input.Substring(input.IndexOf(",", StringComparison.Ordinal)).Length);

            msg = input.Substring(input.IndexOf(",", StringComparison.Ordinal));
            var times = int.Parse(msg.Remove(0, 2));

            AdvancedMessage = message;
            AdvancedTimes = times;
        }

        public void FormatStringInt(int commandLength, string input)
        {
            FormatString(commandLength, input);

            var msg = _msg;
            var min = int.Parse(msg.Remove(msg.IndexOf(",", StringComparison.Ordinal), input.Substring(input.IndexOf(",", StringComparison.Ordinal)).Length));

            msg = input.Substring(input.IndexOf(",", StringComparison.Ordinal));
            var max = int.Parse(msg.Remove(0, 2));

            IntMin = min;
            IntMax = max;
        }

        public void FormatStringAdvanced(string input)
        {
            // inputOne:inputTwo
            var outputOneInput = input;
            var outputOne = outputOneInput.Remove(outputOneInput.IndexOf(":", StringComparison.Ordinal),
                outputOneInput.Substring(outputOneInput.IndexOf(":", StringComparison.Ordinal)).Length);

            var outputTwoInput = input;
            var outputTwo = outputTwoInput.Substring(outputTwoInput.IndexOf(":", StringComparison.Ordinal));
            outputTwo = outputTwo.Remove(0, 1);

            AdvancedOutputOne = outputOne;
            AdvancedOutputTwo = outputTwo;
        }
    }
}

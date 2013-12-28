using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CommandLineTools
{
    public class ParametersValidator
    {
        public string ValidationInformation;

        public bool Validate(string[] arguments)
        {
            ValidationInformation = String.Empty;
            if (!arguments.Any())
            {
                ValidationInformation = "Параметры отсутствуют.";
                return false;
            }

            var errorInformation = new StringBuilder("Неверно переданы параметры:");
            var parameterRegex = new Regex(@"--[a-z]+=(\S)+");
            var thereAreErrors = false;

            foreach (var t in arguments.Where(t => t != parameterRegex.Match(t).ToString()))
            {
                thereAreErrors = true;
                errorInformation.Append(" ");
                errorInformation.Append(t);
            }

            ValidationInformation = thereAreErrors ? errorInformation.ToString() : "Валидация прошла успешно.";

            return !thereAreErrors;
        }
    }
}

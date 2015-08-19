namespace Telerik.ILS.Common
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// StringExtensions Class
    /// </summary>
    public static class StringExtensions
    {
        static void Main()
        {
        
        }

        /// <summary>
        /// Converts each byte of the hashed data of the string to a hexadecimal string.
        /// </summary>
        /// <param name="input">String value.</param>
        /// <returns>A return value is a hexadecimal string.</returns>
        /// <exception cref="System.ArgumentNullException">Initializes a new instance of the ArgumentNullException class.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">Initializes a new instance of the ArgumentOutOfRangeException class.</exception>
        /// <exception cref="System.OverflowException">Initializes a new instance of the OverflowException class.</exception>
        /// <exception cref="System.ObjectDisposedException">Initializes a new instance of the ObjectDisposedException class with a string containing the name of the disposed object.</exception>
        /// <exception cref="System.Reflection.TargetInvocationException">Initializes a new instance of the TargetInvocationException class with a reference to the inner exception that is the cause of this exception.</exception>
        /// <exception cref="System.Text.EncoderFallbackException">Initializes a new instance of the EncoderFallbackException class.</exception>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // StringBuilder to collect the bytes and create a string.
            var builder = new StringBuilder();

            //Format each byte of the hashed data one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            return builder.ToString();
        }

        /// <summary>
        /// Determines whether a sequence contains a specified string by using the default comparer.
        /// </summary>
        /// <param name="input">String value.</param>
        /// <returns>A return value indicates whether the string is contained or not.</returns>
        /// <exception cref="System.ArgumentNullException">Initializes a new instance of the ArgumentNullException class.</exception>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// Converts the string representation of a number to it's 16-bit signed integer equivalent.
        /// </summary>
        /// <param name="input">String representation of a number.</param>
        /// <returns>A return value indicates whether the conversion succeeded or failed.</returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// Converts the string representation of a number to its 32-bit signed integer equivalent.
        /// </summary>
        /// <param name="input">String representation of a number.</param>
        /// <returns>A return value indicates whether the conversion succeeded or failed.</returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// Converts the string representation of a number to its 64-bit signed integer equivalent.
        /// </summary>
        /// <param name="input">String representation of a number.</param>
        /// <returns>A return value indicates whether the conversion succeeded or failed.</returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// Converts the specified string representation of a date and time to its Sysytem.DateTime equivalent.
        /// </summary>
        /// <param name="input">String representation of a date and time.</param>
        /// <returns>A return value indicates whether the conversion succeeded or failed.</returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// Converts the string to a string with capitalized first letter.
        /// </summary>
        /// <param name="input">String value.</param>
        /// <returns>A return value is a copy of the string with capitalized first letter.</returns>
        /// <exception cref="System.ArgumentNullException">Initializes a new instance of the ArgumentNullException class.</exception>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// Retrieves a substring from this instance.
        /// </summary>
        /// <returns>A return value is a substring between startString and endString or empty string if its not succeeded.</returns>
        /// <exception cref="System.ArgumentException">Initializes a new instance of the ArgumentException class.</exception>
        /// <exception cref="System.ArgumentNullException">Initializes a new instance of the ArgumentNullException class.</exception>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// Converts the cyrillic letters string to a latin letters string.
        /// </summary>
        /// <param name="input">Cyrillic letters string.</param>
        /// <returns>A return value is latin letters string.</returns>
        /// <exception cref="System.ArgumentException">Initializes a new instance of the ArgumentException class.</exception>
        /// <exception cref="System.ArgumentNullException">Initializes a new instance of the ArgumentNullException class.</exception>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// Converts the latin letters string to a cyrillic letters string.
        /// </summary>
        /// <param name="input">Latin letters string.</param>
        /// <returns>A return value is cyrillic letters string.</returns>
        /// 
        /// <exception cref="System.ArgumentException">Initializes a new instance of the ArgumentException class.</exception>
        /// <exception cref="System.ArgumentNullException">Initializes a new instance of the ArgumentNullException class.</exception>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// Removes all invalid characters of the entered string to receive a valid username.
        /// </summary>
        /// <param name="input">String value.</param>
        /// <returns>A return value is a valid username.</returns>
        /// <exception cref="System.ArgumentException">Initializes a new instance of the ArgumentException class.</exception>
        /// <exception cref="System.ArgumentNullException">Initializes a new instance of the ArgumentNullException class.</exception>
        /// <exception cref="System.Text.RegularExpressions.RegexMatchTimeoutException">Initializes a new instance of the RegexMatchTimeoutException class with a system-supplied message.</exception>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// Removes all invalid characters of the entered string to receive a valid latin file name.
        /// </summary>
        /// <param name="input">String value.</param>
        /// <returns>A return value is a valid latin file name.</returns>
        /// <exception cref="System.ArgumentException">Initializes a new instance of the ArgumentException class.</exception>
        /// <exception cref="System.ArgumentNullException">Initializes a new instance of the ArgumentNullException class.</exception>
        /// <exception cref="System.Text.RegularExpressions.RegexMatchTimeoutException">Initializes a new instance of the RegexMatchTimeoutException class with a system-supplied message.</exception>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// Retrieves the first few characters from a string.
        /// </summary>
        /// <param name="input">String value.</param>
        /// <param name="charsCount">Characters count.</param>
        /// <returns>A return value is a string with first few characters from the instance.</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">Initializes a new instance of the ArgumentOutOfRangeException class.</exception>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// Retrieves the file extension.
        /// </summary>
        /// <param name="fileName">File name.</param>
        /// <returns>A return value is the file extension of the file.</returns>
        /// <exception cref="System.ArgumentException">Initializes a new instance of the ArgumentException class.</exception>
        /// <exception cref="System.ArgumentNullException">Initializes a new instance of the ArgumentNullException class.</exception>
        /// <exception cref="System.OverflowException">Initializes a new instance of the OverflowException class.</exception>
        /// <exception cref="System.InvalidOperationException">Initializes a new instance of the InvalidOperationException class.</exception>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// Retrieves the content type of specified file extension.
        /// </summary>
        /// <param name="fileExtension">File extension.</param>
        /// <returns>A return value is the content type of the file extension.</returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// Converts the string to its 8-bit unsigned integer equivalent. 
        /// </summary>
        /// <param name="input">String value.</param>
        /// <returns>A return value is a 8-bit unsigned integer.</returns>
        /// <exception cref="System.ArgumentException">Initializes a new instance of the ArgumentException class.</exception>
        /// <exception cref="System.ArgumentNullException">Initializes a new instance of the ArgumentNullException class.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">Initializes a new instance of the ArgumentOutOfRangeException class.</exception>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}

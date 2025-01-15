using System;

class myProgram {

    public static string generatePassword(int length, string chars) {
        string password = "";
        Random randomChar = new Random();

        for (int i = 0; i < length; i++) {
            password += chars[randomChar.Next(0,chars.Length)];
        }

        return password;
    }

    public static void passwordPrompt() {
        string digits = "0123456789";
        string lowercaseLetters = "abcdefghijklmnopqrstuvwxyz";
        string uppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string punctuation = "!#$%&*+-=?@^_";
        string exception = "il1Lo0O";

        string char1 = "";
        string charsOne = "";

        Console.WriteLine("Сколько паролей создать?");
        string passNum = Console.ReadLine();
        int passwordNumber = int.Parse(passNum);
        Console.WriteLine("Укажите длину пароля:");
        string passLen = Console.ReadLine();
        Console.WriteLine("Включать ли цифры 0123456789? (y/n)");
        int passwordLength = int.Parse(passLen);
        string? digitNecessary = Console.ReadLine();
        Console.WriteLine("Включать ли прописные буквы ABC... Z? (y/n)");
        string? upperCaseNecessary = Console.ReadLine();
        Console.WriteLine("Включать ли строчные буквы abc... z? (y/n)");
        string? lowerCaseNecessary = Console.ReadLine();
        Console.WriteLine("Включать ли символы !#$%&*+-=?@^_? (y/n)");
        string? punctuationNecessary = Console.ReadLine();
        Console.WriteLine("Исключать ли неоднозначные символы il1Lo0O? (y/n)");
        string? exceptionNecessary = Console.ReadLine();

        if (digitNecessary.ToLower() == "y") {
            char1 += digits;
        }

        if (upperCaseNecessary.ToLower() == "y") {
            char1 += uppercaseLetters;
        }

        if (lowerCaseNecessary.ToLower() == "y") {
            char1 += lowercaseLetters;
        }

        if (punctuationNecessary.ToLower() == "y") {
            char1 += punctuation;
        }

        if (exceptionNecessary.ToLower() == "y") {
            for (int i = 0; i < char1.Length; i++) {
                for (int j = 0; j < exception.Length; j++) {
                    if (char1[i] == exception[j]) {
                        continue;
                    } else {
                        charsOne += char1[i];
                    }
                }
            }
        } else {
            charsOne = char1;
        }

        Console.WriteLine("Ваши пароли: ");
        for (int k = 0; k < passwordNumber; k++) {
            Console.WriteLine(generatePassword(passwordLength, charsOne));
        }
    }

    static void Main(string[] args) {
        passwordPrompt();
    }
}
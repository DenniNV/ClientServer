using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class CheckerIputData
{
    public bool CheckUserName(string name)
    {
        var hasMinimum4Chars = new Regex(@".{4,}");
        var isValidated = hasMinimum4Chars.IsMatch(name);
        return isValidated; 
        
    }

    public bool CheckUserPassword(string password)
    {
        var hasNumber = new Regex(@"[0-9]+");
        var hasUpperChar = new Regex(@"[A-Z]+");
        var hasMinimum8Chars = new Regex(@".{8,}");
        var isValidated = hasNumber.IsMatch(password) && hasUpperChar.IsMatch(password) && hasMinimum8Chars.IsMatch(password);
        return isValidated;
    }

    public bool CheckUserEmail(string email)
    {
        var pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
        Match isMatch = Regex.Match(email, pattern, RegexOptions.IgnoreCase);
        return isMatch.Success;
    }

    public string ErrorInputData(string name , string password, string email)
    {
        if (CheckUserName(name) == false)
        {
            return " Логин длинной не менее 4 символов";
        }
        else if (CheckUserPassword(password) == false)
        {
            return "Пароль должен содержать хотя бы 1 цифруб 1 букву в вверхнем регистре, длинной не менее 8 символов ";
        }
        else if (CheckUserEmail(email) == false)
        {
            return "Bad email";
        }
        else return " ";

    }




}

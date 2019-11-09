using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckerIputData
{
    

    public bool CheckUserName(string data)
    {
        // В данном кусочке кода надо сделать проверку на соотвецтвие правилам ввода 

        return false;

        
    }
     

    public bool CheckUserPassword(string password)
    {


        return false;
    }

    public bool CheckUserEmail(string email)
    {
        return false;

    }

    public string ErrorInputData(string name , string password, string email)
    {
        if (CheckUserName(name) == false)
        {
            return "You input bad name)";
        }
        else if (CheckUserPassword(password) == false)
        {
            return "You input bad pass";
        }
        else if (CheckUserEmail(email) == false)
        {
            return "Bad email ";
        }

        else return null;



       


    }




}

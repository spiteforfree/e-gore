using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour 
{

public InputField textField1;
public InputField textField2;
public Text textResult;

public void printNumber (int number)
{
 textResult.text += number; 
}

public void eraser ()
{
 textResult.text = "";
 
}


public void pi () 
{
    
    textResult.text = "3,1415926535";
}
public void Sum () 
    {
    string enteredNumber1 = textField1.text;
    string enteredNumber2 = textField2.text;
    

        if (string.IsNullOrEmpty(enteredNumber1) || string.IsNullOrEmpty(enteredNumber2))
        {
        textResult.fontSize = 20;
        string resultError = "Заполни оба поля, долбоёб!";
        
        textResult.text = resultError;
        }
        else 
        {
        textResult.fontSize = 40;            
        int number1 = int.Parse(enteredNumber1);
        int number2 = int.Parse(enteredNumber2);
        int resultSum = (number1+number2);
        textResult.text = resultSum.ToString();


        }


    }

public void Difference () 
{
     string enteredNumber1 = textField1.text;
    string enteredNumber2 = textField2.text;
    

        if (string.IsNullOrEmpty(enteredNumber1) || string.IsNullOrEmpty(enteredNumber2))
        {
        textResult.fontSize = 20;
        string resultError = "Заполни оба поля, долбоёб!";
        
        textResult.text = resultError;
        }
        else 
        {
        textResult.fontSize = 40;            
        int number1 = int.Parse(enteredNumber1);
        int number2 = int.Parse(enteredNumber2);
        int resultSum = (number1-number2);
        
        
        textResult.text = resultSum.ToString();


        }

}
 
 public void Multiply () 
{
     string enteredNumber1 = textField1.text;
    string enteredNumber2 = textField2.text;
    

        if (string.IsNullOrEmpty(enteredNumber1) || string.IsNullOrEmpty(enteredNumber2))
        {
        textResult.fontSize = 20;
        string resultError = "Заполни оба поля, долбоёб!";
        
        textResult.text = resultError;
        }
        else 
        {
        textResult.fontSize = 40;            
        int number1 = int.Parse(enteredNumber1);
        int number2 = int.Parse(enteredNumber2);
        int resultSum = (number1*number2);
        
        
        textResult.text = resultSum.ToString();


        }

}
 
 public void Divide () 
{
    string enteredNumber1 = textField1.text;
    string enteredNumber2 = textField2.text;
    

        if (string.IsNullOrEmpty(enteredNumber1) || string.IsNullOrEmpty(enteredNumber2))
        {
        textResult.fontSize = 20;
        string resultError = "Заполни оба поля, долбоёб!";
        textResult.text = resultError;
        }
        else 
        {
        double number1 = int.Parse(enteredNumber1);
        double number2 = int.Parse(enteredNumber2);
        if (number2 == 0) {
        textResult.fontSize = 20;
        string resultError = "Себя на ноль подели!";
        textResult.text = resultError;
        }
        else {
        textResult.fontSize = 40;            
        double resultSum = (number1/number2);
        textResult.text = resultSum.ToString();
        }

        }

}
 
public void Exponentiation1 () 
    {
    string enteredNumber1 = textField1.text;
    string enteredNumber2 = textField2.text;
    

        if (string.IsNullOrEmpty(enteredNumber1) || string.IsNullOrEmpty(enteredNumber2))
        {
        textResult.fontSize = 20;
        string resultError = "Заполни оба поля, долбоёб!";
        
        textResult.text = resultError;
        }
        else 
        {
        int number1 = int.Parse(enteredNumber1);
        int number2 = int.Parse(enteredNumber2);
        
        if (number1 == 0) 
        {
        textResult.fontSize = 40;            
        textResult.text = "0";

        }
         if (number2 == 0) 
        {
        textResult.fontSize = 40;            
        textResult.text = "1";

        }
        int Multiplicator  = number1;
        for (int i = 1; i<number2; i++) 
        {
            number1 *= Multiplicator;
        }
        textResult.fontSize = 40;            
        textResult.text = number1.ToString();
        }


    }




/* public void Exponentiation2 () 
    {
    string enteredNumber1 = textField1.text;
    string enteredNumber2 = textField2.text;
    

        if (string.IsNullOrEmpty(enteredNumber1) || string.IsNullOrEmpty(enteredNumber2))
        {
        textResult.fontSize = 20;
        string resultError = "Заполни оба поля, долбоёб!";
        
        textResult.text = resultError;
        }
        else 
        {
        float number1 = int.Parse(enteredNumber1);
        float number2 = int.Parse(enteredNumber2);
        
        if (number1 == 0) 
        {
        textResult.fontSize = 40;            
        textResult.text = "0";

        }
         if (number2 == 0) 
        {
        textResult.fontSize = 40;            
        textResult.text = "1";

        }
        
        else {

        textResult.fontSize = 40;            
        float res = mathF.Pow(number1, number2);
        Debug.Log(res);
        
        }


    }

} */


public void Minimum () 
    {
    string enteredNumber1 = textField1.text;
    string enteredNumber2 = textField2.text;
    

        if (string.IsNullOrEmpty(enteredNumber1) || string.IsNullOrEmpty(enteredNumber2))
        {
        textResult.fontSize = 20;
        string resultError = "Заполни оба поля, долбоёб!";
        
        textResult.text = resultError;
        }
        
        
        else 
        {
        string textMinimum = "Вычисляем...";
        int number1 = int.Parse(enteredNumber1);
        int number2 = int.Parse(enteredNumber2);
        if (number1 == number2) 
        {
            textMinimum = "Одинаковое";
        }

        if (number1<number2) 
        {
            textMinimum = $"число {number1} поменьше";

        } 
        if (number1>number2) 
        {
            textMinimum = $"число {number2} поменьше";
            textResult.text = textMinimum;
        }

        
        }


    }

}
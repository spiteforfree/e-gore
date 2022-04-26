using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumericButtons : MonoBehaviour
{
    public enum NumericType
    {
        One = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Zero = 0
    }

    public NumericType Numeric;
    public Calculator Calculator;

    public void Click() 
    {
        Calculator.printNumber((int)Numeric);
    }
}

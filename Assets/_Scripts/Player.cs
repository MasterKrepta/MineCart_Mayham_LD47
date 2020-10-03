using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int currency = 0;

    public void GiveCurrency(int value)
    {
        currency += value;
    }

    
}

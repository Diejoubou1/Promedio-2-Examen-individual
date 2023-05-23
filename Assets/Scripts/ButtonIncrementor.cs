using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonIncrementor : MonoBehaviour
{
    public int incrementAmount;

    public void IncrementScore()
    {
        GameManager.Instance.IncrementScore(incrementAmount);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceRoller : MonoBehaviour
{
    public Text wynik;

    public void RollDiceK4 ()
    {
        int number = Random.Range(1, 5);
        wynik.text = number.ToString();
    }
    public void RollDiceK6()
    {
        int number = Random.Range(1, 7);
        wynik.text = number.ToString();
    }
    public void RollDiceK8()
    {
        int number = Random.Range(1, 9);
        wynik.text = number.ToString();
    }
    public void RollDiceK10()
    {
        int number = Random.Range(1, 11);
        wynik.text = number.ToString();
    }
    public void RollDiceK12()
    {
        int number = Random.Range(1, 13);
        wynik.text = number.ToString();
    }
    public void RollDiceK20()
    {
        int number = Random.Range(1, 21);
        wynik.text = number.ToString();
    }
    public void RollDiceK100()
    {
        int number = Random.Range(1, 101);
        wynik.text = number.ToString();
    }
}

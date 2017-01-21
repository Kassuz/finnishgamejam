using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int points;
    [SerializeField] private Text pointsText;

    public void AddPoints(int pointsToAdd)
    {
        points += pointsToAdd;
        pointsText.text = "Points: " + points;
    }

}

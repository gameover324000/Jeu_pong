using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int joueur1 = 0;
    public static int joueur2 = 0;

    public Text texteJoueur1;
    public Text texteJoueur2;
    public Text texteVictoire;

    void Start()
    {
        texteVictoire.gameObject.SetActive(false);
    }

    void Update()
    {
        texteJoueur1.text = joueur1.ToString();
        texteJoueur2.text = joueur2.ToString();

        if (joueur1 >= 7)
        {
            FinJeu("Le joueur 1 a gagné !");
        }
        else if (joueur2 >= 7)
        {
            FinJeu("Le joueur 2 a gagné !");
        }
    }

    void FinJeu(string message)
    {
        texteVictoire.gameObject.SetActive(true);
        texteVictoire.text = message;
        Time.timeScale = 0;
    }
}
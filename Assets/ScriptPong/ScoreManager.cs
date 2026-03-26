using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int joueur1 = 0;
    public static int joueur2 = 0;

    public Text texteJoueur1;
    public Text texteJoueur2;
    public Text texteVictoire;
    public GameObject balle;

    bool jeuTermine = false;

    void Start()
    {
        joueur1 = 0;
        joueur2 = 0;
        jeuTermine = false;
        texteVictoire.gameObject.SetActive(false);
    }

    void Update()
    {
        texteJoueur1.text = joueur1.ToString();
        texteJoueur2.text = joueur2.ToString();
        if (!jeuTermine)
        {
            if (joueur1 >= 7)
                FinJeu("Le joueur 1 a gagné !");
        
        else if (joueur2 >= 7)
        
            FinJeu("Le joueur 2 a gagné !");
        
        }
        if (Input.GetKeyDown(KeyCode.R) && jeuTermine)
        {
            joueur1 = 0;
            joueur2 = 0;
            jeuTermine = false;
            Time.timeScale = 1;
            balle.SetActive(true);
            texteVictoire.gameObject.SetActive(false);
        }
    }

    void FinJeu(string message)
    {
        jeuTermine=true;
        texteVictoire.gameObject.SetActive(true);
        texteVictoire.text = message;
        balle.SetActive(false);
        Time.timeScale = 0;
    }
}
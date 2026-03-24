using UnityEngine;
 
public class LigneMilieu : MonoBehaviour
{
    public Color couleur = new Color(0f, 1f, 0.255f);
    public int nombrePoints = 10;
    public float largeurPoint = 0.1f;
    public float hauteurPoint = 0.3f;
 
    void Start()
    {
        float espacement = 9f / nombrePoints;
        float startY = 4.5f;
 
        for (int i = 0; i < nombrePoints; i++)
        {
            GameObject point = new GameObject("Point" + i);
            point.transform.parent = transform;
            point.transform.position = new Vector2(0, startY - i * espacement - espacement / 2);
 
            SpriteRenderer sr = point.AddComponent<SpriteRenderer>();
            sr.sprite = CreateSquareSprite();
            sr.color = couleur;
            point.transform.localScale = new Vector2(largeurPoint, hauteurPoint);
        }
    }
 
    Sprite CreateSquareSprite()
    {
        Texture2D texture = new Texture2D(1, 1);
        texture.SetPixel(0, 0, Color.white);
        texture.Apply();
        return Sprite.Create(texture, new Rect(0, 0, 1, 1), new Vector2(0.5f, 0.5f), 1);
    }
}
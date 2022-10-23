using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class Nyawa : MonoBehaviour
{
    public GameObject winTextObject;
    public TextMeshProUGUI countText;
    public int count;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }
    // Start is called before the first frame update
    void Start()
    {
        count = 3;
        SetCountText();

        winTextObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(SetCountText());
        

    }

    IEnumerator SetCountText()
    {
        countText.text = "Nyawa: " + count.ToString();
        if (count <= 0)
        {
            winTextObject.SetActive(true);
            yield return new WaitForSeconds(7);
            PlayGame();

        }

    }


    private void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.CompareTag("Hijau") && this.gameObject.CompareTag("BatasMerah")) || (other.gameObject.CompareTag("Biru") && this.gameObject.CompareTag("BatasMerah")) || (other.gameObject.CompareTag("Merah") && this.gameObject.CompareTag("BatasMerah")) || (other.gameObject.CompareTag("Kuning") && this.gameObject.CompareTag("BatasMerah")) || (other.gameObject.CompareTag("Abu") && this.gameObject.CompareTag("BatasMerah")));
        {
            count = count - 1;

        }
        SetCountText();
    }
}

using UnityEngine;
using UnityEngine.UI;

public class ExitMenuController : MonoBehaviour
{
    public GameObject scrollView; // Referência ao ScrollView do menu
    public Button quitButton;     // Referência ao botão de sair

    private bool isPaused = false;

    void Start()
    {
        // Esconde o menu ao iniciar
        scrollView.SetActive(false);

        // Adiciona uma função ao clicar no botão de sair
        quitButton.onClick.AddListener(QuitGame);
    }

    void Update()
    {
        // Verifica se a tecla Esc foi pressionada
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePauseMenu();
        }
    }

    void TogglePauseMenu()
    {
        isPaused = !isPaused;
        scrollView.SetActive(isPaused);

        // Pausa ou continua o jogo
        Time.timeScale = isPaused ? 0 : 1;
    }

    void QuitGame()
    {
        // Sai do jogo
        Debug.Log("Quit Game");
        Application.Quit();

        // Se estiver no editor, parar o jogo
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}

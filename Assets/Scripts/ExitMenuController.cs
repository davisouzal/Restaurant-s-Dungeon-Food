using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ExitMenuController : MonoBehaviour
{
    public GameObject scrollView; // Referência ao ScrollView do menu
    public Button quitButton;     // Referência ao botão de sair
    public Button closeButton;    // Referência ao botão de fechar o menu
    public Button startButton;    // Referência ao botão de iniciar (voltar ao início)

    private bool isPaused = false;

    void Start()
    {
        // Esconde o menu ao iniciar
        scrollView.SetActive(false);

        // Adiciona funções aos botões
        quitButton.onClick.AddListener(QuitGame);
        closeButton.onClick.AddListener(CloseMenu);
        startButton.onClick.AddListener(GoToStartScene);
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

    void CloseMenu()
    {
        // Desativa o menu e continua o jogo
        scrollView.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
    }

    void GoToStartScene()
    {
        // Retorna à cena de início
        Debug.Log("Loading Start Scene");
        Time.timeScale = 1; // Garante que o jogo não permaneça pausado na cena de início
        SceneManager.LoadScene("Play");
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

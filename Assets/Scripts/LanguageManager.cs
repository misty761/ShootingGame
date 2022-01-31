using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageManager : MonoBehaviour
{
    public static LanguageManager instance;
    public Text textTitle;
    public Text textStartGame;
    public Text textSelectPlane;
    public GameObject flagEnglish;
    public GameObject flagKorean;
    public GameObject flagChinese;
    public GameObject flagJapanese;
    public GameObject flagGerman;
    public GameObject flagRussian;
    public GameObject flagFrench;
    public GameObject flagSpanish;
    public GameObject flagPortugal;
    public GameObject flagItalian;

    string startGameEnglish = "start game";
    string startGameKorean = "게임 시작";
    string startGameChinese = "开始游戏";
    string startGameFrench = "démarrer jeu";
    string startGameGerman = "Spiel beginnen";
    string startGameJapanese = "ゲームを始める";
    string startGamePortugal = "Começar o jogo";
    string startGameRussian = "начать игру";
    string startGameSpanish = "empezar juego";
    string startGameItalian = "inizia il gioco";

    string goldEnglish = "Gold";
    string goldKorean = "골드";
    string goldChinese = "金子";
    string goldFrench = "or";
    string goldGerman = "Gold";
    string goldJapanese = "ゴールド";
    string goldPortugal = "ouro";
    string goldRussian = "золото";
    string goldSpanish = "oro";
    string goldItalian = "oro";


    string language;   

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.Log("LanguageManager : 씬에 두개 이상의매니저가 존재합니다!");
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        SelectLanguage();
    }

    public void SelectLanguage()
    {
        language = PlayerPrefs.GetString("Language", "English");
        if (language == "Korean")
        {
            textTitle.fontSize = 80;
            textTitle.text = "로켓\n스트라이크";
            textStartGame.text = startGameKorean;
            textSelectPlane.text = "비행기 선택";

            flagKorean.SetActive(true);
            flagEnglish.SetActive(false);
            flagChinese.SetActive(false);
            flagFrench.SetActive(false);
            flagGerman.SetActive(false);
            flagJapanese.SetActive(false);
            flagPortugal.SetActive(false);
            flagRussian.SetActive(false);
            flagSpanish.SetActive(false);
            flagItalian.SetActive(false);
        }
        else if (language == "Chinese")
        {
            textTitle.fontSize = 80;
            textTitle.text = "火箭弹";
            textStartGame.text = startGameChinese;
            textSelectPlane.text = "选择飞机";

            flagKorean.SetActive(false);
            flagEnglish.SetActive(false);
            flagChinese.SetActive(true);
            flagFrench.SetActive(false);
            flagGerman.SetActive(false);
            flagJapanese.SetActive(false);
            flagPortugal.SetActive(false);
            flagRussian.SetActive(false);
            flagSpanish.SetActive(false);
            flagItalian.SetActive(false);
        }
        else if (language == "French")
        {
            textTitle.fontSize = 80;
            textTitle.text = "Frappe\nde roquette";
            textStartGame.text = startGameFrench;
            textSelectPlane.text = "Sélectionnez un avion";

            flagKorean.SetActive(false);
            flagEnglish.SetActive(false);
            flagChinese.SetActive(false);
            flagFrench.SetActive(true);
            flagGerman.SetActive(false);
            flagJapanese.SetActive(false);
            flagPortugal.SetActive(false);
            flagRussian.SetActive(false);
            flagSpanish.SetActive(false);
            flagItalian.SetActive(false);
        }
        else if (language == "German")
        {
            textTitle.fontSize = 60;
            textTitle.text = "Raketenangriff";
            textStartGame.text = startGameGerman;
            textSelectPlane.text = "Ebene\nauswählen";

            flagKorean.SetActive(false);
            flagEnglish.SetActive(false);
            flagChinese.SetActive(false);
            flagFrench.SetActive(false);
            flagGerman.SetActive(true);
            flagJapanese.SetActive(false);
            flagPortugal.SetActive(false);
            flagRussian.SetActive(false);
            flagSpanish.SetActive(false);
            flagItalian.SetActive(false);
        }
        else if (language == "Japanese")
        {
            textTitle.fontSize = 80;
            textTitle.text = "ロケット\nストライク";
            textStartGame.text = startGameJapanese;
            textSelectPlane.text = "平面を選択";

            flagKorean.SetActive(false);
            flagEnglish.SetActive(false);
            flagChinese.SetActive(false);
            flagFrench.SetActive(false);
            flagGerman.SetActive(false);
            flagJapanese.SetActive(true);
            flagPortugal.SetActive(false);
            flagRussian.SetActive(false);
            flagSpanish.SetActive(false);
            flagItalian.SetActive(false);
        }
        else if (language == "Portugal")
        {
            textTitle.fontSize = 80;
            textTitle.text = "Ataque\nde foguete";
            textStartGame.text = startGamePortugal;
            textSelectPlane.text = "selecione o avião";

            flagKorean.SetActive(false);
            flagEnglish.SetActive(false);
            flagChinese.SetActive(false);
            flagFrench.SetActive(false);
            flagGerman.SetActive(false);
            flagJapanese.SetActive(false);
            flagPortugal.SetActive(true);
            flagRussian.SetActive(false);
            flagSpanish.SetActive(false);
            flagItalian.SetActive(false);
        }
        else if (language == "Russian")
        {
            textTitle.fontSize = 80;
            textTitle.text = "ракетный\nудар";
            textStartGame.text = startGameRussian;
            textSelectPlane.text = "выбрать самолет";

            flagKorean.SetActive(false);
            flagEnglish.SetActive(false);
            flagChinese.SetActive(false);
            flagFrench.SetActive(false);
            flagGerman.SetActive(false);
            flagJapanese.SetActive(false);
            flagPortugal.SetActive(false);
            flagRussian.SetActive(true);
            flagSpanish.SetActive(false);
            flagItalian.SetActive(false);
        }
        else if (language == "Spanish")
        {
            textTitle.fontSize = 80;
            textTitle.text = "huelga\nde cohetes";
            textStartGame.text = startGameSpanish;
            textSelectPlane.text = "seleccionar avión";

            flagKorean.SetActive(false);
            flagEnglish.SetActive(false);
            flagChinese.SetActive(false);
            flagFrench.SetActive(false);
            flagGerman.SetActive(false);
            flagJapanese.SetActive(false);
            flagPortugal.SetActive(false);
            flagRussian.SetActive(false);
            flagSpanish.SetActive(true);
            flagItalian.SetActive(false);
        }
        else if (language == "Italian")
        {
            textTitle.fontSize = 80;
            textTitle.text = "colpo\ndi razzo";
            textStartGame.text = startGameItalian;
            textSelectPlane.text = "selezionare l'aereo";

            flagKorean.SetActive(false);
            flagEnglish.SetActive(false);
            flagChinese.SetActive(false);
            flagFrench.SetActive(false);
            flagGerman.SetActive(false);
            flagJapanese.SetActive(false);
            flagPortugal.SetActive(false);
            flagRussian.SetActive(false);
            flagSpanish.SetActive(false);
            flagItalian.SetActive(true);
        }
        // 영어
        else
        {
            textTitle.fontSize = 100;
            textTitle.text = "Rocket\nStrike";
            textStartGame.text = startGameEnglish;
            textSelectPlane.text = "Select Plane";

            flagKorean.SetActive(false);
            flagEnglish.SetActive(true);
            flagChinese.SetActive(false);
            flagFrench.SetActive(false);
            flagGerman.SetActive(false);
            flagJapanese.SetActive(false);
            flagPortugal.SetActive(false);
            flagRussian.SetActive(false);
            flagSpanish.SetActive(false);
            flagItalian.SetActive(false);
        }
    }

    public void SetTextBuyPlane(Text button, int number)
    {
        language = PlayerPrefs.GetString("Language", "English");
        int size = 30;
        button.fontSize = size;
        if (language == "Korean")
        {
            button.text = "구입(" + number + " " + goldKorean + ")";
        }
        else if (language == "Chinese")
        {
            button.text = "买(" + number + " " + goldChinese + ")";
        }
        else if (language == "French")
        {
            button.text = "acheter(" + number + " " + goldFrench + ")";
        }
        else if (language == "German")
        {
            button.text = "Kaufen(" + number + " " + goldGerman + ")";
        }
        else if (language == "Japanese")
        {
            button.fontSize = 20;
            button.text = "購入(" + number + " " + goldJapanese + ")"; 
        }
        else if (language == "Portugal")
        {
            button.text = "Comprar(" + number + " " + goldPortugal + ")";
        }
        else if (language == "Russian")
        {
            button.text = "купить(" + number + " " + goldRussian + ")";
        }
        else if (language == "Spanish")
        {
            button.text = "comprar(" + number + " " + goldSpanish + ")";
        }
        else if (language == "Italian")
        {
            button.text = "acquistare(" + number + " " + goldItalian + ")";
        }
        else
        {
            button.fontSize = 35;
            button.text = "Buy(" + number + " " + goldEnglish + ")";
        }
    }

    public void SetTextStartGame(Text button)
    {
        language = PlayerPrefs.GetString("Language", "English");
        int size = 30;
        button.fontSize = size;
        if (language == "Korean")
        {
            button.text = startGameKorean;
        }
        else if (language == "Chinese")
        {
            button.text = startGameChinese;
        }
        else if (language == "French")
        {
            button.text = startGameFrench;
        }
        else if (language == "German")
        {
            button.text = startGameGerman;
        }
        else if (language == "Japanese")
        {
            button.text = startGameJapanese;
        }
        else if (language == "Portugal")
        {
            button.text = startGamePortugal; 
        }
        else if (language == "Russian")
        {
            button.text = startGameRussian;
        }
        else if (language == "Spanish")
        {
            button.text = startGameSpanish;
        }
        else if (language == "Italian")
        {
            button.text = startGameItalian; 
        }
        else
        {
            button.fontSize = 40;
            button.text = startGameEnglish;
        }
        
    }

    public void SetTextNewRecord(Text message)
    {
        language = PlayerPrefs.GetString("Language", "English");
        int size = 40;
        message.fontSize = size;
        if (language == "Korean")
        {
            message.text = "최고 기록";
        }
        else if (language == "Chinese")
        {
            message.text = "新纪录";
        }
        else if (language == "French")
        {
            message.text = "nouvel enregistrement";
        }
        else if (language == "German")
        {
            message.text = "Neuer Eintrag";
        }
        else if (language == "Japanese")
        {
            message.text = "新記録";
        }
        else if (language == "Portugal")
        {
            message.text = "novo recorde";
        }
        else if (language == "Russian")
        {
            message.text = "новый рекорд";
        }
        else if (language == "Spanish")
        {
            message.text = "nuevo record";
        }
        else if (language == "Italian")
        {
            message.text = "nuovo record";
        }
        else
        {
            message.fontSize = 70;
            message.text = "new record";
        }
    }

    public void SetTextGameOver(Text message)
    {
        language = PlayerPrefs.GetString("Language", "English");
        int size = 40;
        message.fontSize = size;
        if (language == "Korean")
        {
            message.text = "게임\n오버";
        }
        else if (language == "Chinese")
        {
            message.text = "游戏\n结束";
        }
        else if (language == "French")
        {
            message.text = "jeu\nterminé";
        }
        else if (language == "German")
        {
            message.text = "Spiel\nist aus";
        }
        else if (language == "Japanese")
        {
            message.text = "ゲーム\nオーバー";
        }
        else if (language == "Portugal")
        {
            message.text = "game\nOver";
        }
        else if (language == "Russian")
        {
            message.text = "игра\nокончена";
        }
        else if (language == "Spanish")
        {
            message.text = "juego\nterminado";
        }
        else if (language == "Italian")
        {
            message.text = "gioco\nfinito";
        }
        else
        {
            message.fontSize = 70;
            message.text = "game\nover";
        }
    }

    public void SetTextRetry(Text message)
    {
        language = PlayerPrefs.GetString("Language", "English");
        int size = 40;
        message.fontSize = size;
        if (language == "Korean")
        {
            message.text = "다시 시작?";
        }
        else if (language == "Chinese")
        {
            message.text = "重试?";
        }
        else if (language == "French")
        {
            message.text = "recommencez?";
        }
        else if (language == "German")
        {
            message.text = "wiederholen?";
        }
        else if (language == "Japanese")
        {
            message.text = "リトライ?";
        }
        else if (language == "Portugal")
        {
            message.text = "tentar novamente?";
        }
        else if (language == "Russian")
        {
            message.fontSize = 30;
            message.text = "повторить попытку?";
        }
        else if (language == "Spanish")
        {
            message.text = "rever?";
        }
        else if (language == "Italian")
        {
            message.text = "riprova?";
        }
        else
        {
            message.fontSize = 70;
            message.text = "retry?";
        }
    }

    public void SetTextYes(Text message)
    {
        language = PlayerPrefs.GetString("Language", "English");
        int size = 40;
        message.fontSize = size;
        if (language == "Korean")
        {
            message.text = "예";
        }
        else if (language == "Chinese")
        {
            message.text = "是的";
        }
        else if (language == "French")
        {
            message.text = "Oui";
        }
        else if (language == "German")
        {
            message.text = "Ja";
        }
        else if (language == "Japanese")
        {
            message.text = "はい";
        }
        else if (language == "Portugal")
        {
            message.text = "sim";
        }
        else if (language == "Russian")
        {
            message.text = "да";
        }
        else if (language == "Spanish")
        {
            message.text = "sí";
        }
        else if (language == "Italian")
        {
            message.text = "sì";
        }
        else
        {
            message.fontSize = 60;
            message.text = "yes";
        }
    }

    public void SetTextNo(Text message)
    {
        language = PlayerPrefs.GetString("Language", "English");
        int size = 40;
        message.fontSize = size;
        if (language == "Korean")
        {
            message.text = "아니요";
        }
        else if (language == "Chinese")
        {
            message.text = "不";
        }
        else if (language == "French")
        {
            message.text = "non";
        }
        else if (language == "German")
        {
            message.text = "Nein";
        }
        else if (language == "Japanese")
        {
            message.text = "番号";
        }
        else if (language == "Portugal")
        {
            message.text = "não";
        }
        else if (language == "Russian")
        {
            message.text = "нет";
        }
        else if (language == "Spanish")
        {
            message.text = "No";
        }
        else if (language == "Italian")
        {
            message.text = "no";
        }
        else
        {
            message.fontSize = 60;
            message.text = "no";
        }
    }

    public void SetTextRetryPayGold(Text message, int price)
    {
        language = PlayerPrefs.GetString("Language", "English");
        int size = 40;
        message.fontSize = size;
        if (language == "Korean")
        {
            message.text = price + " " + goldKorean;
        }
        else if (language == "Chinese")
        {
            message.text = price + " " + goldChinese;
        }
        else if (language == "French")
        {
            message.text = price + " " + goldFrench;
        }
        else if (language == "German")
        {
            message.text = price + " " + goldGerman;
        }
        else if (language == "Japanese")
        {
            message.text = price + " " + goldJapanese;
        }
        else if (language == "Portugal")
        {
            message.text = price + " " + goldPortugal;
        }
        else if (language == "Russian")
        {
            message.text = price + " " + goldRussian;
        }
        else if (language == "Spanish")
        {
            message.text = price + " " + goldSpanish;
        }
        else if (language == "Italian")
        {
            message.text = price + " " + goldItalian;
        }
        else
        {
            message.text = price + " " + goldEnglish;
        }
    }

    public void SetTextSeeAD(Text message)
    {
        language = PlayerPrefs.GetString("Language", "English");
        int size = 40;
        message.fontSize = size;
        if (language == "Korean")
        {
            message.text = "광고 시청";
        }
        else if (language == "Chinese")
        {
            message.text = "观看广告";
        }
        else if (language == "French")
        {
            message.fontSize = 30;
            message.text = "Regarder\nla publicité";
        }
        else if (language == "German")
        {
            message.fontSize = 30;
            message.text = "Werbung\ngucken";
        }
        else if (language == "Japanese")
        {
            message.text = "広告視聴";
        }
        else if (language == "Portugal")
        {
            message.fontSize = 30;
            message.text = "Assistindo\nanúncio";
        }
        else if (language == "Russian")
        {
            message.fontSize = 30;
            message.text = "Смотрю\nрекламу";
        }
        else if (language == "Spanish")
        {
            message.fontSize = 30;
            message.text = "Viendo\npublicidad";
        }
        else if (language == "Italian")
        {
            message.fontSize = 30;
            message.text = "Guardare\nla pubblicità";
        }
        else
        {
            message.text = "See AD";
        }
    }

    public void SetTextGoTitle(Text message)
    {
        language = PlayerPrefs.GetString("Language", "English");
        int size = 40;
        message.fontSize = size;
        if (language == "Korean")
        {
            message.text = "타이틀 화면으로\n돌아가시겠습니까?";
        }
        else if (language == "Chinese")
        {
            message.text = "前往\n标题?";
        }
        else if (language == "French")
        {
            message.text = "aller\nau titre?";
        }
        else if (language == "German")
        {
            message.text = "gehe zum\nTitel?";
        }
        else if (language == "Japanese")
        {
            message.text = "タイトルに\n移動?";
        }
        else if (language == "Portugal")
        {
            message.text = "vá para\no título?";
        }
        else if (language == "Russian")
        {
            message.text = "перейти к\nзаголовку?";
        }
        else if (language == "Spanish")
        {
            message.text = "ir al\ntitulo?";
        }
        else if (language == "Italian")
        {
            message.text = "vai al\ntitolo?";
        }
        else
        {
            message.fontSize = 70;
            message.text = "Go to\ntitle?";
        }
    }

    public void SetTextBestScore(Text message, int score)
    {
        language = PlayerPrefs.GetString("Language", "English");
        int size = 50;
        message.fontSize = size;
        if (language == "Korean")
        {
            message.text = "최고점수 : " + score;
        }
        else if (language == "Chinese")
        {
            message.text = "最好 : " + score;
        }
        else if (language == "French")
        {
            message.text = "meilleur/meilleure : " + score;
            message.fontSize = 30;
        }
        else if (language == "German")
        {
            message.text = "Beste : " + score;
        }
        else if (language == "Japanese")
        {
            message.text = "ベスト : " + score;
        }
        else if (language == "Portugal")
        {
            message.text = "melhor : " + score;
        }
        else if (language == "Russian")
        {
            message.text = "Лучший : " + score;
        }
        else if (language == "Spanish")
        {
            message.text = "El/La mejor : " + score;
        }
        else if (language == "Italian")
        {
            message.text = "migliore : " + score;
        }
        else
        {
            message.text = "best : " + score;
        }
    }

    public string SetText(string word)
    {
        language = PlayerPrefs.GetString("Language", "English");

        if (word == "Gold")
        {
            if (language == "French")
            {
                return goldFrench;
            }
            else if (language == "German")
            {
                return goldGerman;
            }
            else if (language == "Portugal")
            {
                return goldPortugal;
            }
            else if (language == "Spanish")
            {
                return goldSpanish;
            }
            else if (language == "Italian")
            {
                return goldItalian;
            }
            else
            {
                return goldEnglish;
            }

        }
        else if (word == "Bonus")
        {
            if (language == "French")
            {
                return "prime";
            }
            else if (language == "German")
            {
                return "Bonus";
            }
            else if (language == "Portugal")
            {
                return "bônus";
            }
            else if (language == "Spanish")
            {
                return "primo/prima";
            }
            else if (language == "Italian")
            {
                return "bonus";
            }
            else
            {
                return "Bonus";
            }
        }
        else if (word == "Power")
        {
            if (language == "French")
            {
                return "Puissance";
            }
            else if (language == "German")
            {
                return "Leistung";
            }
            else if (language == "Portugal")
            {
                return "potência";
            }
            else if (language == "Spanish")
            {
                return "poder";
            }
            else if (language == "Italian")
            {
                return "energia";
            }
            else
            {
                return "Power";
            }
        }
        else if (word == "Fire speed")
        {
            if (language == "French")
            {
                return "Cadence de tir";
            }
            else if (language == "German")
            {
                return "Feuerrate";
            }
            else if (language == "Portugal")
            {
                return "Cadência de tiro";
            }
            else if (language == "Spanish")
            {
                return "Cadencia de fuego";
            }
            else if (language == "Italian")
            {
                return "Velocità di fuocoa";
            }
            else
            {
                return "Fire speed";
            }
        }
        else if (word == "Life")
        {
            if (language == "French")
            {
                return "la vie";
            }
            else if (language == "German")
            {
                return "Leben";
            }
            else if (language == "Portugal")
            {
                return "vida";
            }
            else if (language == "Spanish")
            {
                return "vida";
            }
            else if (language == "Italian")
            {
                return "vita";
            }
            else
            {
                return "Life";
            }
        }
        else if (word == "Slow")
        {
            if (language == "French")
            {
                return "lent/lente";
            }
            else if (language == "German")
            {
                return "schleppend";
            }
            else if (language == "Portugal")
            {
                return "lento/lenta";
            }
            else if (language == "Spanish")
            {
                return "lento/lenta";
            }
            else if (language == "Italian")
            {
                return "lento/lenta";
            }
            else
            {
                return "Slow";
            }
        }
        else if (word == "Freeze")
        {
            if (language == "French")
            {
                return "Geler";
            }
            else if (language == "German")
            {
                return "einfrieren";
            }
            else if (language == "Portugal")
            {
                return "congelar";
            }
            else if (language == "Spanish")
            {
                return "congelar";
            }
            else if (language == "Italian")
            {
                return "congelare";
            }
            else
            {
                return "Freeze";
            }
        }
        else if (word == "Destroy all enemies")
        {
            if (language == "French")
            {
                return "détruire tous les ennemis";
            }
            else if (language == "German")
            {
                return "zerstöre alle Feinde";
            }
            else if (language == "Portugal")
            {
                return "destrua todos os inimigos";
            }
            else if (language == "Spanish")
            {
                return "destruir a todos los enemigos";
            }
            else if (language == "Italian")
            {
                return "distruggi tutti i nemici";
            }
            else
            {
                return "Destroy all enemies";
            }
        }
        else
        {
            return null;
        }

    }
}

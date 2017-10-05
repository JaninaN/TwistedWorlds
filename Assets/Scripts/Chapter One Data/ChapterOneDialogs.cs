using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChapterOneDialogs : MonoBehaviour {

    //Dialogs of Fox Mum
    public static List<Dialog> FOX_MUM_1;
    public static List<Dialog> FOX_MUM_2;
    public static List<Dialog> FOX_MUM_3;
    //Dialogs of Deer Mum
    public static List<Dialog> DEER_MUM_1;
    public static List<Dialog> DEER_MUM_2;
    //Dialogs of Owl
    public static List<Dialog> OWL_1;
    public static List<Dialog> OWL_2;
    public static List<Dialog> OWL_3;
    public static List<Dialog> OWL_4;
    //Dialogs of Chipmunk
    public static List<Dialog> CHIPMUNK_1;
    //Dialogs of Stork
    public static List<Dialog> STORK_1;
    //Dialogs of Fox Son
    public static List<Dialog> FOX_SON_1;
    public static List<Dialog> FOX_SON_2;


    //Storyline Dialogs
    public static List<string> FIRST_RIDDLE_BEGINNING;
    public static List<string> FIRST_RIDDLE_DESTROY_BOX;
    public static List<string> FIRST_RIDDLE_AMULET_COLLECTED;

    //Possible Answers
    public static string RIDDLE_ONE_YES = "Ich versuche mal das Rätsel zu lösen...";
    public static string RIDDLE_ONE_NO = "Komisches Teil. Was solls, ich mache es kaputt! Das geht schneller.";

    private void Start()
    {
        FOX_MUM_1 = new List<Dialog>() { new Dialog(ChapterOneSprites.FOX_DAUGHTER_HEAD, "Da bist du ja mein Sohn. Hast du alles vom Markt besorgt?"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Nein noch nicht. Die Äpfel fehlen noch."),
                                        new Dialog(ChapterOneSprites.FOX_DAUGHTER_HEAD, "Dann geh bitte nochmal zurück und hole welche."),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Ok, bis später.")
                                        };
        FOX_MUM_2 = new List<Dialog>() { new Dialog(ChapterOneSprites.FOX_DAUGHTER_HEAD, "Da bist du ja mein Sohn. Hast du alles vom Markt besorgt?"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Ja, hier schau."),
                                        new Dialog(ChapterOneSprites.FOX_DAUGHTER_HEAD, "Das hast du gut gemacht. Ich hätte nur noch eine Bitte an dich."),
                                        new Dialog(ChapterOneSprites.FOX_DAUGHTER_HEAD, "Sei so lieb und bringe die Äpfel zur alten Eule im Wald. Sie freut sich sicher über Besuch."),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Aber Mama, die ist unheimlich... manchmal redet sie wirres Zeug."),
                                        new Dialog(ChapterOneSprites.FOX_DAUGHTER_HEAD, "Sei nicht so hart mit Ihr, Sie ist schließlich schon sehr alt und meist alleine."),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Ok ich gehe zu Ihr..."),
                                        };
        FOX_MUM_3 = new List<Dialog>() { new Dialog(ChapterOneSprites.FOX_DAUGHTER_HEAD, "Warst du schon bei der alten Eule?"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Nein, noch nicht."),
                                        new Dialog(ChapterOneSprites.FOX_DAUGHTER_HEAD, "Dann geh jetzt besser, bevor es dunkel wird.")
                                        };
        DEER_MUM_1 = new List<Dialog>() { new Dialog(ChapterOneSprites.DEER_MUM_HEAD, "Hallo Füchschen, wie läuft es in der Schule?"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Ganz gut. Wir nehmen gerade das große Märchen von den Menschen durch."),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Ich habe es auch in mein Notizbuch geschrieben, dann klappt das auswendig lernen gleich viel besser!"),
                                        new Dialog(ChapterOneSprites.DEER_MUM_HEAD, "Das ist eine gute Idee. Was kann ich dir denn gutes tun?"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Meine Mum schickt mich, ich soll Äpfel kaufen."),
                                        new Dialog(ChapterOneSprites.DEER_MUM_HEAD, "In Ordnung, nimm dir ruhig von den Äpfeln. Ich verrechne sie dann mit deiner Mum."),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Vielen Dank.")
                                        };
        DEER_MUM_2 = new List<Dialog>() { new Dialog(ChapterOneSprites.DEER_MUM_HEAD, "Ich hoffe ihr seid mit meiner Ware zufrieden.")
                                        };
        OWL_1 = new List<Dialog>() { new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Guten Tag Frau Eule meine Mutter schickt mich. Ich bringe Ihnen Äpfel."),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "Oh! Guten Tag Füchschen. Das ist aber lieb von …"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "Füchschen woher hast du dieses Amulett?"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Es ist eben erschienen, ich hab keine Ahnung was das für ein Ding ist…"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "… Du bist der Auserwählte!"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "WAS?"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "Du wurdest auserwählt um unsere Welt vor dem Untergang zu bewahren"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Wovon reden Sie?"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "Die Prophezeiung!!!"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Na toll… Auserwählter, Weltuntergang, Prophezeiung? In was für nem Spiel bin ich hier gelandet?"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "Die Welt steht kurz vor dem Untergang und die Person, die von dem Amulett auserwählt wird, ist die einzige, die diese Welt vor dem Untergang noch retten kann."),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "Du bist der Einzige der in der Lage ist das Amulett zu benutzen. Es ist deine Aufgabe Füchschen!"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "…"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "Wenn du es nicht tust wird die Welt, wie wir sie kennen, enden"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "…"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "Du bist der Auserwählte! Nur du allein – Sag mal hörst du mir eigentlich zu?"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Ehm, ja… sagen Sie mir einfach was ich tun soll, damit ich das gleich hinter mich bringen kann. Auf mich wartet zu Hause noch ein neues Spiel… Also was soll ich machen?"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "…"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "Die Kinder von Heute…"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "Dieses Amulett hat die Kraft Türen in eine andere Welt zu öffnen. Du musst diese Welt bereisen und herausfinden was für den bevorstehenden Untergang verantwortlich ist und es aufhalten!"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "ah okay... dann mach ich mich mal auf den Weg."),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "…"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "Gut wenn du noch Fragen hast weist du ja wo du mich findest")
                                        };
        OWL_2 = new List<Dialog>() { new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Guten Tag Frau Eule meine Mutter schickt mich. Ich bringe Ihnen Äpfel."),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "Oh! Guten Tag Füchschen. Das ist aber lieb von…"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "Füchschen woher hast du dieses Amulett und warum ist es kaputt?"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Es ist eben in so einer Schatulle erschienen und ich hab die Schatulle kaputt getreten. Bestimmt war das Amulett schon vorher kaputt…"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "Weißt du überhaupt was du angerichtet hast?"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Nee… ich weiß nur, dass es Konsequenzen haben wird…"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "…"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "Du bist der Auserwählte der die Welt vor dem Untergang retten sollte und das Einzige was dir dabei helfen konnte war dieses Amulett!"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "Die Welt ist nun endgültig verloren! Nichts und Niemand kann uns jetzt noch helfen!"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Okay. Ich geh dann mal nach Hause… da wartet noch ein Spiel auf mich…"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "…"),
                                        new Dialog(ChapterOneSprites.OWL_HEAD, "Alles ist verloren…")
                                        };
        OWL_3 = new List<Dialog>() { new Dialog(ChapterOneSprites.OWL_HEAD, "Du hast Fragen? Tut mir leid… die Demo endet hier… aber es wird noch weiter gehen…")
                                        };
        OWL_4 = new List<Dialog>() { new Dialog(ChapterOneSprites.OWL_HEAD, "Es ist vorbei … die Demo auch…")};

        CHIPMUNK_1 = new List<Dialog>() { new Dialog(ChapterOneSprites.CHIPMUNK_HEAD, "Neue tollle Stoffe!"),
                                          new Dialog(ChapterOneSprites.CHIPMUNK_HEAD, "Hättest du Interesse?"),
                                          new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Momentan brauche ich keinen, danke."),
                                          new Dialog(ChapterOneSprites.CHIPMUNK_HEAD, "Okay. Falls du es dir überlegst, ich bin jeden Dienstag auf dem Markt. ")};

        FOX_SON_1 = new List<Dialog>() { new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Noch schnell die Einkäufe für Mum erledigen, dann kann ich weiter GameStation spielen.") };

        FOX_SON_2 = new List<Dialog>() { new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Jetzt schnell nach Hause.") };

        STORK_1 = new List<Dialog>() { new Dialog(ChapterOneSprites.STORK_HEAD, "Wir liefern schneller als die Schneckenpost") };


        FIRST_RIDDLE_BEGINNING = new List<string>() {"In einiger Entfernung ist ein Funkeln zu sehen.",
                                                    "Das Licht wird stärker und blendet nun sogar.",
                                                    "Langsam legt sich das Licht und Konturen werden sichtbar...",
                                                    "Deine Hände haben sich von alleine angehoben und du hälst nun eine Schatulle in den Händen.",
                                                    "Nach vorsichtiger Begutachtung erkennst du ein Schloss mit einem 4-Stelligen Zahlencode, jedoch lässt sich die Schatulle ohne Code icht öffnen.",
                                                    "Was willst du mit der Schatulle anstellen?"
                                                    };
        FIRST_RIDDLE_DESTROY_BOX = new List<string>() {"Du legst die Schatulle auf den Boden und trittst beherzt darauf.",
                                                    "KRACK KRACH",
                                                    "Die Schatulle ist völlig zerstört und ein heller Schimmer entweicht ihr.",
                                                    "Jemand oder etwas flüstert: Dein Handeln wird folgen haben, Auserwählter...",
                                                    "Du schaust dich um aber niemand ist hier.",
                                                    "Als du die Reste der Schatulle begutachtest fällt dir ein Amulett ins Auge. Der Stein in der Mitte ist zerbrochen.",
                                                    "Schließlich setzt du deinen Weg zur Eule fort.",
                                                    };
        FIRST_RIDDLE_AMULET_COLLECTED = new List<string>() {"Geschafft! In der Schatulle findest du ein Amulett und nimmst es an dich.",
                                                            "Gut gelaunt setzt du deinen Weg zur Eule fort.",
                                                            };
    }
}


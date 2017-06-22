using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChapterOneDialogs : MonoBehaviour {

    //Dialogs of Fox Mum
    public static List<Dialog> FOX_MUM_1;
    public static List<Dialog> FOX_MUM_2;
    //Dialogs of Deer Mum
    public static List<Dialog> DEER_MUM_1;
    public static List<Dialog> DEER_MUM_2;
    //Dialogs of Owl
    public static List<Dialog> OWL_1;

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
        OWL_1 = new List<Dialog>() { new Dialog(ChapterOneSprites.DEER_MUM_HEAD, "Hallo Füchschen, wie läuft es in der Schule?"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Ganz gut. Wir nehmen gerade das große Märchen von den Menschen durch."),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Ich habe es auch in mein Notizbuch geschrieben, dann klappt das auswendig lernen gleich viel besser!"),
                                        new Dialog(ChapterOneSprites.DEER_MUM_HEAD, "Das ist eine gute Idee. Was kann ich dir denn gutes tun?"),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Meine Mum schickt mich, ich soll Äpfel kaufen."),
                                        new Dialog(ChapterOneSprites.DEER_MUM_HEAD, "In Ordnung, nimm dir ruhig von den Äpfeln. Ich verrechne sie dann mit deiner Mum."),
                                        new Dialog(ChapterOneSprites.FOX_SON_HEAD, "Vielen Dank.")
                                        };

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


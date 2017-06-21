using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChapterOneDialogs : MonoBehaviour {

    //Dialogs of Fox Mum
    public static List<Dialog> FOX_MUM_1;

    //Storyline Dialogs
    public static List<string> FIRST_RIDDLE_BEGINNING;
    public static List<string> FIRST_RIDDLE_DESTROY_BOX;
    public static List<string> FIRST_RIDDLE_AMULET_COLLECTED;

    private void Start()
    {
        FOX_MUM_1 = new List<Dialog>() { new Dialog(ChapterOneSprites.DEER_MUM_HEAD, "Ist heute nicht ein schöner Tag?"),
                                        new Dialog(ChapterOneSprites.DEER_SON_HEAD, "Es ist noch zu früh um solche Vermutungen aufzustellen..."),
                                        new Dialog(ChapterOneSprites.DEER_SON_HEAD, "Ich gehe jetzt zur Schule. Machs gut Mum."),
                                        new Dialog(ChapterOneSprites.DEER_MUM_HEAD, "Mein Sohn, bevor du zur Schule gehst nimm bitte diesen Einkaufszettel mit und besorge später diese Sachen."),
                                        new Dialog(ChapterOneSprites.DEER_SON_HEAD, "Nagut... Ich bringe die Sachen mit."),
                                        new Dialog(ChapterOneSprites.DEER_MUM_HEAD, "Ich will später Kirschsouffle mit Zwetschgentampf machen."),
                                        new Dialog(ChapterOneSprites.DEER_SON_HEAD, "Oh jaaaa, lecker!!")
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

